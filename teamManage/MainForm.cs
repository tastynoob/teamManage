using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teamManage
{
    public partial class MainForm : Form
    {
        // this acount
        public int member_id = 0;
        public int member_permission = 2;
        // this form
        string dgv_name = Form_type.projectlist;

        // sql connect
        MySqlConnection sqlConnection;

        Form_Login loginForm;
        public MainForm()
        {
            loginForm = new Form_Login();
            loginForm.ShowDialog();
            if (MySqlManage.lastData == null)
            {
                this.Close();
                Application.Exit();
                return;
            }
            InitializeComponent();


            member_id = (int)MySqlManage.lastData.Rows[0]["id"];
            member_permission = (int)MySqlManage.lastData.Rows[0]["permission"];

            label_permission.Text = "当前身份： " +
                (member_permission == 0 ? "主管" :
                member_permission == 1 ? "组长" :
                member_permission == 2 ? "员工" :
                "访客");
        }

        // edit data
        private void dgv_main_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string table_name = dgv_name;
            string col_name = dgv_main.Columns[e.ColumnIndex].HeaderText.ToString();
            string value_id = dgv_main.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string value_new = dgv_main[e.ColumnIndex, e.RowIndex].Value.ToString();

            string mysql_string = string.Format("update {0} set {1}=\"{2}\" where id={3}", table_name, col_name, value_new, value_id);

            label1.Text = mysql_string;

            DataTable? dt = MySqlManage.execute(mysql_string);

            if (dt != null)
            {
                MessageBox.Show(this, "修改成功！");
            }
            else
            {
                MessageBox.Show(this, "修改失败！");
            }
        }

        private void btn_allproject_Click(object sender, EventArgs e)
        {
            // main form default show all projects

            DataTable? dt = MySqlManage.execute("select * from projectlist;");
            if (dt != null)
            {
                dgv_name = Form_type.projectlist;
                dgv_main.DataSource = dt;
                permissionCheck();
            }
            else
            {
                MessageBox.Show(this, "服务器连接失败，请重试");
            }
        }

        private void btn_allmember_Click(object sender, EventArgs e)
        {
            // main form default show all projects

            DataTable? dt = MySqlManage.execute("select * from memberlist;");
            if (dt != null)
            {
                dgv_name = Form_type.memberlist;
                dgv_main.DataSource = dt;
                permissionCheck();
            }
            else
            {
                MessageBox.Show(this, "服务器连接失败，请重试");
            }
        }
        private void btn_memberAlloc_Click(object sender, EventArgs e)
        {
            Form_memberAlloc form_memberAlloc = new Form_memberAlloc(this);
            form_memberAlloc.ShowDialog();
        }

        private void btn_alltask_Click(object sender, EventArgs e)
        {
            DataTable? dt = MySqlManage.execute("select tl.id,\r\n    pl.project_name,\r\n    tl.description,\r\n    tl.note,\r\n    tl.status\r\nfrom\r\n    tasklist tl,\r\n    projectlist pl\r\nwhere tl.project_id = pl.id;");
            if (dt != null)
            {
                dgv_name = Form_type.tasklist;
                dt.Columns["project_name"].ReadOnly = true;
                dgv_main.DataSource = dt;
                permissionCheck();
            }
            else
            {
                MessageBox.Show(this, "服务器连接失败，请重试");
            }
        }

        void permissionCheck()
        {
            if (string.Equals(dgv_name, Form_type.projectlist))
            {
                if (member_permission >= 1)
                {
                    dgv_main.ReadOnly = true;
                }
                else
                {
                    dgv_main.ReadOnly = false;
                }
            }
            else if (string.Equals(dgv_main, Form_type.memberlist))
            {
                if (member_permission <= 1)
                {
                    dgv_main.ReadOnly = false;
                }
                else
                {
                    dgv_main.ReadOnly = true;
                }
            }
            else if (!string.Equals(dgv_main, Form_type.tasklist))
            {
                if (member_permission <= 1)
                {
                    dgv_main.ReadOnly = false;
                }
                else
                {
                    dgv_main.ReadOnly = true;
                }
            }
        }

        private void btn_readdoc_Click(object sender, EventArgs e)
        {
            Form_allDoc form_AllDoc = new Form_allDoc(this);
            form_AllDoc.ShowDialog();
        }
    }
}
