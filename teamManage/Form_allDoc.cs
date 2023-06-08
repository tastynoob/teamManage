using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamManage
{
    public partial class Form_allDoc : Form
    {
        MainForm mainForm;

        public Form_allDoc(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            string sqlcmd = "select * from alldoc";
            DataTable? dt = MySqlManage.execute(sqlcmd);
            dgv_data.DataSource = dt;

        }

        private void dgv_data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgv_data.CurrentCell.RowIndex;
            string? value = dgv_data.Rows[rowIndex].Cells["doc_filepath"].Value.ToString();
            if (value != null)
            {
                MessageBox.Show(this, "查看文档：" + value);
            }
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                label_filename.Text = openFileDialog.FileName;
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string member_id = mainForm.member_id.ToString();
            string doc_name = label_filename.Text.Split("\\").Last();
            string description = textBox_description.Text;
            string file_path = label_filename.Text;
            string creatTime = "2023-6-9 10:00:00";

            string sqlcmd = string.Format("insert into alldoc(member_id,doc_name,doc_description,doc_filepath,create_time) values ({0},\"{1}\",\"{2}\",\"{3}\",\"{4}\");",
            member_id,
            doc_name,
            description,
            file_path,
            creatTime
            );
            DataTable? dt = MySqlManage.execute(sqlcmd);

            if (dt != null)
            {
                sqlcmd = "select * from alldoc";
                dt = MySqlManage.execute(sqlcmd);
                dgv_data.DataSource = dt;
            }
            else
            {
                MessageBox.Show(this, "上传失败");
            }

        }
    }
}
