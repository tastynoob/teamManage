using MySql.Data.MySqlClient;
using System.Data;

namespace teamManage
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_showpassword_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = !textBox_password.UseSystemPasswordChar;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string account = textBox_account.Text;
            string password = textBox_password.Text;
            if (!string.IsNullOrEmpty(account))
            {
                //与数据库连接的信息
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                //用户名
                builder.UserID = "root";
                //密码
                builder.Password = "root";
                //服务器地址
                builder.Server = "10.148.13.3";
                //连接时的数据库
                builder.Database = "teammanage";
                builder.ConnectionTimeout = 1000;

                if (!MySqlManage.connect(builder.ConnectionString))
                {
                    MessageBox.Show(this, "服务器连接失败");
                    return;
                }

                string sqlcmd = string.Format("select * from memberlist where account = {0};", account);
                DataTable? dataTable = MySqlManage.execute(sqlcmd);
                if (dataTable.Rows.Count == 1)
                {
                    this.Close();
                }
                else if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show(this, "无效账号！");
                }
                else
                {
                    MessageBox.Show(this, "数据库出现错误，请重试！");
                }
            }
        }
    }
}