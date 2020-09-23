using BLL;
using System.Web;

namespace MyFirstProject.registers
{
    /// <summary>
    /// register 的摘要说明
    /// </summary>
    public class register : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string account = context.Request.QueryString["register-email"];
            string password = context.Request.QueryString["register-password-affirm"];
            if (new UserInfoBLL().Getregister(account, password))
            {
                context.Response.Write("Hello World");
            }
            else
            {
                context.Response.Write("<script>alert('注册失败');</script>");
            }
           
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