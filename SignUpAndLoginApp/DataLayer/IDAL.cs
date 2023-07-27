using BusinessModel;

namespace DataLayer
{
    public interface IDAL
    {
        bool isValidRegister(string email, string password, string username, string mobileNumber);
        bool isValidLogin(Users userObj);
        bool toChangePassword(string email, string newpassword, string username);
        bool InsertUser(Users userObj);

    }
}
