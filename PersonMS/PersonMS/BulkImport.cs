using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonMS
{
    public partial class BulkImport : Form
    {
        public BulkImport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "excel文件(*.xlsx)|*.xlsx";;//设置文件后缀
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                //Console.WriteLine(DataTableToDB(file));
                int count = DataTableToDB(file);
                if (count > 0)
                {
                    MessageBox.Show("成功导入" + count + "条数据！");
                }
                else {
                    MessageBox.Show("导入失败！");
                
                }
                
            }
        }


        public DataTable ExcelToDataTable(string strExcelFileName, string strSheetName)
        {
            string strConn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=NO;IMEX=1;'", strExcelFileName);
            string strExcel = string.Format("select * from [{0}$]", strSheetName);
            DataSet ds = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(strExcel, strConn);
                adapter.Fill(ds, strSheetName);
                conn.Close();
            }

            return ds.Tables[strSheetName];
        }

        public int DataTableToDB(String file)
        {
            
            int count = 0;
            string _strExcelFileName = file;
            

            DataTable dtExcel = ExcelToDataTable(_strExcelFileName, "Sheet1");
            for (int j = 0; j < dtExcel.Rows.Count; j++)
            {
                if ((ReturnSqlResultCount("select * from person where pid='" + dtExcel.Rows[j][0].ToString() + "'")) > 0)
                {
                    continue;
                }
                else
                {
                    InsertDataToAccess(dtExcel.Rows[j][0].ToString(), dtExcel.Rows[j][1].ToString(), dtExcel.Rows[j][2].ToString(), dtExcel.Rows[j][3].ToString(), dtExcel.Rows[j][4].ToString(), dtExcel.Rows[j][5].ToString());

                    count++;
                }
            }

            return count;
        }

         
        OleDbConnection Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\23998\Desktop\PersonMS\Person.accdb");  

        public int ReturnSqlResultCount(string strSQL)
        {
            int sqlResultCount = 0;

            try
            {
                Connection.Open();
                OleDbCommand command = new OleDbCommand(strSQL, Connection);
                OleDbDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sqlResultCount++;
                }
                dataReader.Close();
            }
            catch
            {
                sqlResultCount = 0;
            }
            finally
            {
                Connection.Close();
            }
            return sqlResultCount;
        }


        public bool InsertDataToAccess(string col1, string col2, string col3, string col4, string col5, string col6)
        {
            bool resultState = false;

            Connection.Open();
            string strSQL = "insert into person (pid,username,phone,sex,enter_time,temperature) values('" + col1 + "','" + col2 + "','" + col3 + "','" + col4 + "','" + col5 + "','" + col6 + "')";
            OleDbTransaction myTrans = Connection.BeginTransaction();
            OleDbCommand command = new OleDbCommand(strSQL, Connection, myTrans);

            try
            {
                command.ExecuteNonQuery();
                myTrans.Commit();
                resultState = true;
            }
            catch
            {
                myTrans.Rollback();
                resultState = false;
            }
            finally
            {
                Connection.Close();
            }
            return resultState;
        }

    }
}
