using DAL;

namespace BLL
{
    public partial class UserInfoBLL
    {
        //服务层，主要负责逻辑处理
        public bool Getlogin(string account, string password)
        {
            return new UserInfoDAL().Getlogin(account, password);
        }

        public bool Getregister(string account, string password)
        {
            return new UserInfoDAL().Getregister(account, password);
        }

    }
}
