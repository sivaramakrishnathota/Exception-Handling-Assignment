using DataLayer;
using BusinessModel;
namespace BusinessLayer
{
    public class BLL:IBLL
    {
        public bool UserLogin(string email, string password)
        {
            DALFactory factory = new DALFactory();
            IDAL dALObj = factory.GetDAL();

            Users userObj = new Users();
            userObj.email = email;
            userObj.password = password;
            if(dALObj.isValidLogin(userObj)==false)
            {
                return false;
            }
            return true;
        }

        public bool UserRegistration(string email, string password,string userName,string mobileNumber)
        {
            DALFactory factory = new DALFactory();
            IDAL dALObj = factory.GetDAL();

            Users userObj = new Users();
            userObj.email = email;
            userObj.password = password;
            userObj.userName = userName;
            userObj.mobileNumber = mobileNumber;   
            
            if(dALObj.isValidRegister(email,password,userName,mobileNumber)==false)
            {
                if(dALObj.InsertUser(userObj)==false)
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
            //DAL dALObj=new DAL();
            DALFactory factory = new DALFactory();
            IDAL dALObj = factory.GetDAL();
            if(dALObj.toChangePassword(email,username,newpassword)==true)
            {
                return true;
            }
            return false;
        }
    }
}
