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
    public partial class Form_report : Form
    {
        MainForm mainForm;
        public Form_report(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            string sqlcmd = "select re.id, re.create_time, ml.name, re.note from report re, memberlist ml where re.member_id = ml.id;";
            DataTable? dt = MySqlManage.execute(sqlcmd);
            if (dt != null && dt.Rows.Count > 0)
            {
                dt.Columns["id"].ReadOnly = true;
                dt.Columns["create_time"].ReadOnly = true;
                dt.Columns["name"].ReadOnly = true;
            }
            dgv_data.DataSource = dt;
        }


        bool add_new_row = false;
        private void dgv_data_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            add_new_row = true;
        }

        private void dgv_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_data.CurrentCell.OwningColumn.Name;
            if (!add_new_row)
            {
                //edit data
                if (col_name.Equals("note"))
                {
                    int columnIndex = dgv_data.CurrentCell.ColumnIndex;
                    int rowIndex = dgv_data.CurrentCell.RowIndex;

                    //将单元格的内容显示为下拉列表的当前项
                    string id = dgv_data.Rows[rowIndex].Cells["id"].Value.ToString();
                    string new_value = dgv_data.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                    string sqlcmd = string.Format("update report set note=\"{0}\" where id={1}",new_value,id);
                    DataTable? dt = MySqlManage.execute(sqlcmd);
                    if (dt != null)
                    {
                        sqlcmd = "select re.id, re.create_time, ml.name, re.note from report re, memberlist ml where re.member_id = ml.id;";
                        dt = MySqlManage.execute(sqlcmd);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            dt.Columns["id"].ReadOnly = true;
                            dt.Columns["create_time"].ReadOnly = true;
                            dt.Columns["name"].ReadOnly = true;
                        }
                        dgv_data.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show(this, "修改失败！");
                    }
                }
                return;
            }

            
            //edit data
            if (col_name.Equals("note"))
            {
                int columnIndex = dgv_data.CurrentCell.ColumnIndex;
                int rowIndex = dgv_data.CurrentCell.RowIndex;

                //将单元格的内容显示为下拉列表的当前项
                string id = mainForm.member_id.ToString();
                string new_value = dgv_data.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                string sqlcmd = string.Format("insert into report(create_time, member_id, note) values(\"{0}\",{1},\"{2}\")", "2023-6-9 10:00:00", id, new_value);
                DataTable? dt = MySqlManage.execute(sqlcmd);
                if (dt != null)
                {
                    sqlcmd = "select re.id, re.create_time, ml.name, re.note from report re, memberlist ml where re.member_id = ml.id;";
                    dt = MySqlManage.execute(sqlcmd);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dt.Columns["id"].ReadOnly = true;
                        dt.Columns["create_time"].ReadOnly = true;
                        dt.Columns["name"].ReadOnly = true;
                    }
                    dgv_data.DataSource = dt;
                }
                else
                {
                    MessageBox.Show(this, "添加失败！");
                }
            }
            add_new_row = false;
        }
    }
}
