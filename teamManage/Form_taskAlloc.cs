using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teamManage
{
    public partial class Form_taskAlloc : Form
    {
        MainForm mainForm;


        System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();

        bool isShow_yourtasks = false;
        public Form_taskAlloc(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            comboBox.Items.AddRange(new string[] { "未完成", "正在进行中", "已完成" });
            comboBox.SelectedIndexChanged += this.comboBox_SelectedIndexChanged;
            comboBox.Visible = false;
            dgv_data.Controls.Add(comboBox);

            string sqlcmd0 = string.Format("select department from memberlist where id = {0};", mainForm.member_id);
            string sqlcmd1 = string.Format("select count(*) from tasklist where member_id = {0};", mainForm.member_id);
            DataTable? dt0 = MySqlManage.execute(sqlcmd0);
            string department = dt0.Rows[0][0].ToString();

            DataTable? dt1 = MySqlManage.execute(sqlcmd1);
            string taskcount;
            if (dt1.Rows.Count > 0)
            {
                taskcount = dt1.Rows[0][0].ToString();
            }
            else
            {
                taskcount = "0";
            }

            label_memberStatus.Text = string.Format("部门：{0}，你的任务数量：{1}", department, taskcount);

            isShow_yourtasks = false;
        }

        private void btn_search_name_Click(object sender, EventArgs e)
        {
            // search by member name
            string val = textBox_val.Text;
            string sqlcmd = string.Format("select tl.id,pl.project_name,tl.description,ml.name as member_name " +
                "from tasklist tl,projectlist pl, memberlist ml " +
                "where tl.member_id = ml.id and tl.project_id=pl.id and ml.name like \"%{0}%\" ", val);

            DataTable? dt = MySqlManage.execute(sqlcmd);
            dgv_data.ReadOnly = true;
            if (dt != null && dt.Rows.Count > 0)
            {
                dgv_data.DataSource = dt;
            }
            else
            {
                dgv_data.DataSource = null;
            }

            isShow_yourtasks = false;
        }

        // search by task name
        private void btn_search_task_Click(object sender, EventArgs e)
        {
            string val = textBox_val.Text;
            string sqlcmd = string.Format("select tl.id,pl.project_name,tl.description,ml.name as member_name " +
                "from tasklist tl,projectlist pl, memberlist ml " +
                "where tl.member_id = ml.id and tl.project_id=pl.id and tl.description like \"%{0}%\" ", val);

            DataTable? dt = MySqlManage.execute(sqlcmd);
            dgv_data.ReadOnly = true;
            if (dt != null && dt.Rows.Count > 0)
            {
                dgv_data.DataSource = dt;
            }
            else
            {
                dgv_data.DataSource = null;
            }

            isShow_yourtasks = false;
        }
        private void btn_searchByProject_Click(object sender, EventArgs e)
        {
            string val = textBox_val.Text;
            string sqlcmd = string.Format("select tl.id,pl.project_name,tl.description,ml.name as member_name " +
                "from tasklist tl,projectlist pl, memberlist ml " +
                "where tl.member_id = ml.id and tl.project_id=pl.id and pl.project_name like \"%{0}%\" ", val);

            DataTable? dt = MySqlManage.execute(sqlcmd);
            dgv_data.ReadOnly = true;
            if (dt != null && dt.Rows.Count > 0)
            {
                dgv_data.DataSource = dt;
            }
            else
            {
                dgv_data.DataSource = null;
            }

            isShow_yourtasks = false;
        }
        private void btn_yourtasks_Click(object sender, EventArgs e)
        {
            string val = mainForm.member_id.ToString();
            string sqlcmd = string.Format("select id,description,note,status,start_time,end_time from tasklist where member_id={0};", val);

            DataTable? dt = MySqlManage.execute(sqlcmd);
            dgv_data.ReadOnly = false;
            if (dt != null && dt.Rows.Count > 0)
            {
                dgv_data.DataSource = dt;
                isShow_yourtasks = true;
            }
            else
            {
                dgv_data.DataSource = null;
            }
        }

        private void dgv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn column = dgv_data.CurrentCell.OwningColumn;
            //如果是要显示下拉列表的列的话
            if (column.Name.Equals("status") && isShow_yourtasks)
            {
                int columnIndex = dgv_data.CurrentCell.ColumnIndex;
                int rowIndex = dgv_data.CurrentCell.RowIndex;
                Rectangle rect = dgv_data.GetCellDisplayRectangle(columnIndex, rowIndex, false);
                comboBox.Left = rect.Left;
                comboBox.Top = rect.Top;
                comboBox.Width = rect.Width;
                comboBox.Height = rect.Height;
                //将单元格的内容显示为下拉列表的当前项
                string consultingRoom = dgv_data.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                int index = comboBox.Items.IndexOf(consultingRoom);

                index = index < 0 ? 0 : index;

                comboBox.SelectedIndex = index;
                comboBox.Visible = true;
            }
            else
            {
                comboBox.Visible = false;
            }
        }

        // update status of task
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgv_data.CurrentCell != null)
            {
                int columnIndex = 0;
                int rowIndex = dgv_data.CurrentCell.RowIndex;
                string id = dgv_data.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                dgv_data.CurrentCell.Value = comboBox.Items[comboBox.SelectedIndex];

                string sqlcmd = string.Format("update tasklist set status=\"{0}\" where id={1};", dgv_data.CurrentCell.Value.ToString(), id);

                DataTable? dt = MySqlManage.execute(sqlcmd);
                if (dt == null)
                {
                    MessageBox.Show(this, "修改失败！");
                }


            }
        }

        private void btn_addNewTask_Click(object sender, EventArgs e)
        {
            if (dgv_data.CurrentCell != null && dgv_data.CurrentCell.OwningColumn.Name.Equals("project_name"))
            {

                int columnIndex = dgv_data.CurrentCell.ColumnIndex;
                int rowIndex = dgv_data.CurrentCell.RowIndex;
                string project_name = dgv_data.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                string sqlcmd0 = string.Format("select id from projectlist where project_name=\"{0}\"", project_name);
                DataTable? dt = MySqlManage.execute(sqlcmd0);


                string sqlcmd1 = string.Format("insert into tasklist(member_id,description,status,project_id,start_time) values ({0},\"{1}\",\"{2}\",{3},\"{4}\");",
                    mainForm.member_id,
                    textBox_description.Text,
                    "未开始",
                    dt.Rows[0][0].ToString(),
                    "2023-6-9 10:00:00"
                    );

                dt = MySqlManage.execute(sqlcmd1);

                if (dt == null)
                {
                    MessageBox.Show(this, "添加失败！");
                }
                else
                {
                    // search by project name
                    string val = textBox_val.Text;
                    string sqlcmd = string.Format("select tl.id,pl.project_name,tl.description,ml.name as member_name " +
                        "from tasklist tl,projectlist pl, memberlist ml " +
                        "where tl.member_id = ml.id and tl.project_id=pl.id and pl.project_name like \"%{0}%\";", project_name);
                    dt = MySqlManage.execute(sqlcmd);
                    dgv_data.ReadOnly = true;
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgv_data.DataSource = dt;
                    }
                    else
                    {
                        dgv_data.DataSource = null;
                    }

                    isShow_yourtasks = false;
                }
            }
            else
            {
                MessageBox.Show(this, "请选择一个项目！");
            }
        }

        private void btn_showproject_Click(object sender, EventArgs e)
        {
            string sqlcmd = "select * from projectlist;";
            DataTable dt = MySqlManage.execute(sqlcmd);
            dgv_data.ReadOnly = true;
            if (dt != null && dt.Rows.Count > 0)
            {
                dgv_data.DataSource = dt;
            }
            else
            {
                dgv_data.DataSource = null;
            }

            isShow_yourtasks = false;
        }
    }
}
