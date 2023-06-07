using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace teamManage
{
    struct DataFrame_project {
        public int id;
        public string name;
        public string description;
        public string status;
    }


    static public class Form_type
    {
        public const string projectlist = "projectlist";
        public const string memberlist = "memberlist";
        public const string tasklist = "tasklist";
    }


    public static class MySqlManage
    {
        public static DataTable? lastData = null;
        static MySqlConnection conn;


        static public bool connect(string connectionString)
        {
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                return true;
            }
            catch {
                return false;
            }

            return false;
        }

        static public DataTable? execute(string exec_str)
        {
            try
            {
                MySqlCommand mysqlcmd = new MySqlCommand(exec_str,conn);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mysqlcmd;
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);
                if(dt.Columns["id"] != null)
                {
                    dt.Columns["id"].ReadOnly = true;
                }
                lastData = dt;
                return dt;

            }
            catch
            {
                lastData = null;
                return null;
            }
            lastData = null;
            return null;
        }
    }


}
