namespace BusinessLayer
{
    public interface IBLL
    {
        bool UserLogin(string email, string password);
        bool UserRegistration(string email, string password, string userName, string mobileNumber);
        bool ChangePassword(string email, string newpassword, string username);
    }
}
