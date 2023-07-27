namespace DataLayer
{
    public class DALFactory
    {
        public IDAL GetDAL()
        {
            IDAL dALObj= new DAL();
            return dALObj;
        }
    }
}
