using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teamManage
{
    public partial class Form_memberAlloc : Form
    {
        MainForm mainForm;
        public Form_memberAlloc(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();


            string sqlcmd = "select * from memberlist";
            DataTable? dt = MySqlManage.execute(sqlcmd);

            dgv_data.DataSource = dt;
        }

        private void dgv_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_data.CurrentCell.OwningColumn.Name;
            //edit data
            if (col_name.Equals("permission") || col_name.Equals("account"))
            {
                int columnIndex = dgv_data.CurrentCell.ColumnIndex;
                int rowIndex = dgv_data.CurrentCell.RowIndex;

                //将单元格的内容显示为下拉列表的当前项
                string id = dgv_data.Rows[rowIndex].Cells[0].Value.ToString();
                string new_value = dgv_data.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                string sqlcmd = string.Format("update memberlist set {0}={1} where id={2}", col_name, new_value, id);
                DataTable? dt = MySqlManage.execute(sqlcmd);
                if (dt != null)
                {
                    sqlcmd = "select * from memberlist";
                    dt = MySqlManage.execute(sqlcmd);
                    dgv_data.DataSource = dt;
                }
                else
                {
                    MessageBox.Show(this, "修改失败！");
                }
            }
            else if (col_name.Equals("department"))
            {
                int columnIndex = dgv_data.CurrentCell.ColumnIndex;
                int rowIndex = dgv_data.CurrentCell.RowIndex;

                //将单元格的内容显示为下拉列表的当前项
                string id = dgv_data.Rows[rowIndex].Cells[0].Value.ToString();
                string new_value = dgv_data.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                string sqlcmd = string.Format("update memberlist set {0}=\"{1}\" where id={2}", col_name, new_value, id);
                DataTable? dt = MySqlManage.execute(sqlcmd);
                if (dt != null)
                {
                    sqlcmd = "select * from memberlist";
                    dt = MySqlManage.execute(sqlcmd);
                    dgv_data.DataSource = dt;
                }
                else
                {
                    MessageBox.Show(this, "修改失败！");
                }
            }

        }
    }
}
