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
        }

        private void dgv_data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
