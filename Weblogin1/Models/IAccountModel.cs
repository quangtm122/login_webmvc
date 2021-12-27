namespace Weblogin1.Models
{
    public interface IAccountModel
    {
        Login CheckLogin(string userName, string passWord);
    }
}