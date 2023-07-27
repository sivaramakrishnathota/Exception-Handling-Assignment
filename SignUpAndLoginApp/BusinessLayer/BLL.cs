using DataLayer;
using BusinessModel;
namespace BusinessLayer
{
    public class BLL:IBLL
    {
        public bool UserLogin(string email, string password)
        {
            DAL DALObj = new DAL();
            Users userObj = new Users();
            userObj.email = email;
            userObj.password = password;
            if(DALObj.isValidLogin(userObj)==false)
            {
                return false;
            }
            return true;
        }

        public bool UserRegistration(string email, string password,string userName,string mobileNumber)
        {
            DAL obj = new DAL();
            Users userObj = new Users();
            userObj.email = email;
            userObj.password = password;
            userObj.userName = userName;
            userObj.mobileNumber = mobileNumber;   
            
            if(obj.isValidRegister(email,password,userName,mobileNumber)==false)
            {
                if(obj.InsertUser(userObj)==false)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool ChangePassword(string email, string newpassword,string username)
        {
            DAL dALObj=new DAL();
            if(dALObj.toChangePassword(email,username,newpassword)==true)
            {
                return true;
            }
            return false;
        }
    }
}
