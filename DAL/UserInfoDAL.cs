using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public partial class UserInfoDAL
    {
        public static readonly string ConnStr = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;

        #region  执行SQL语句，返回布尔值
        /// <summary>
        /// 执行SQL语句，返回布尔值
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public bool Getlogin(string account, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnStr))
                {
                    conn.Open();
                    string SQL = string.Format("SELECT * FROM UserInfo WHERE Account= '{0}' and password='{1}' ", account, password);
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    if (sdr.HasRows)
                    {//登录成功
                        return true;
                    }
                    else
                    {//用户名或密码错误
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion


        #region 注册
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Getregister(string account, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnStr))
                {
                    conn.Open();
                    string SQL = string.Format("INSERT INTO UserInfo (Account, password) VALUES ('{0}', '{1}')", account, password);
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

    }
}
