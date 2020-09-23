using BLL;
using Model;
using System.Text;
using System.Web;

namespace MyFirstProject.logins
{
    /// <summary>
    /// login 的摘要说明
    /// </summary>
    public class login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string username = context.Request.QueryString["Account"];
            string password = context.Request.QueryString["Password"];
            if (username != "" && password != "")
            {
                UserInfo u = new UserInfo();
                u.Account = username.Trim();
                u.Password = password.Trim();
                StringBuilder sb = new StringBuilder();
                context.Response.ContentType = "text/html";
                sb.Append(string.Format(@"<div><h1>Hello</h1></di>"));
                if (new UserInfoBLL().Getlogin(u.Account, u.Password))
                {
                    context.Response.Write("<script>location.href='../Pagejumps/Pagejump.html';</script>");
                }
                else
                {
                    context.Response.Write("<script>alert('账号或密码错误！');location.href='login.html';</script>");
                }
            }
            return;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}