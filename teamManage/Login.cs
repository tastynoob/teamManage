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
                //�����ݿ����ӵ���Ϣ
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                //�û���
                builder.UserID = "root";
                //����
                builder.Password = "root";
                //��������ַ
                builder.Server = "10.148.13.3";
                //����ʱ�����ݿ�
                builder.Database = "teammanage";
                builder.ConnectionTimeout = 1000;

                if (!MySqlManage.connect(builder.ConnectionString))
                {
                    MessageBox.Show(this, "����������ʧ��");
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
                    MessageBox.Show(this, "��Ч�˺ţ�");
                }
                else
                {
                    MessageBox.Show(this, "���ݿ���ִ��������ԣ�");
                }
            }
        }
    }
}