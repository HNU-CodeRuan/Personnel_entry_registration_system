using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonMS
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //MDI窗体的设置：将窗体的属性IsMdiContainer设置为True
            this.IsMdiContainer = true;

        }
        

        private void 人员信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 
            AddPerson addform = new AddPerson();
            OpenChildForm(addform);
        }

        private void 人员信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            QueryPerson queryform = new QueryPerson();
            OpenChildForm(queryform);
        }


        private void OpenChildForm(Form formChild)//formChild只是是实例化的但既没有设置为父窗体的子窗体也没有显示
        {
            bool isOpened = false;
            foreach (Form form in this.MdiChildren)
            {
           //如果要显示的子窗体已经在父窗体的子窗体数组数组中，我们就把新建的多余的formChild销毁

                if (formChild.Name == form.Name)
                {
                    form.Activate();//既然我们想新建但已经有了，那就把之前存在的激活并调到最前边来
                    form.WindowState = FormWindowState.Normal;//窗口大小  为窗口模式
                    formChild.Dispose();
                    isOpened = true;//表示窗口已经打开

                    break;
                }
            }

            if (!isOpened)//如果没打开
            {
                formChild.MdiParent = this;//设置为子窗体
                formChild.Show();

            }
        }

        private void 人员批量导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BulkImport importform = new BulkImport();
            OpenChildForm(importform);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
