using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PersonMS
{
    public partial class AddPerson : Form
    {
        String id = "";
        String name = "";
        String phone = "";
        String sex = "";
        String in_time = "";
        String tempreture = "";
        Access acess = new Access();

        public AddPerson()
        {
            InitializeComponent();
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            ActiveControl = textBox_id;

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            id = textBox_id.Text;
            name = textBox_name.Text;
            phone = textBox_phone.Text;
            in_time = dateTimePicker1.Value.ToString();
            tempreture = textBox_tempreture.Text;


            //String in_time = 
            if (male.Checked)
            {
                sex = male.Text;
            }
            else {
                sex = female.Text;
            }

            if (id != "" && name != "" && phone != "" && in_time != "" && tempreture != "")
            {
                bool flag = acess.Add(id, name, phone, sex, in_time, tempreture);
                if (flag)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            else {
                MessageBox.Show("有未填项！");
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            //使用自定义格式

            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;

            //时间控件的启用

            this.dateTimePicker1.ShowUpDown = true; 
        }

        
    }
}
