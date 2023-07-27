namespace BusinessLayer
{
    public class BLLFactory
    {
        public IBLL GetBLL()
        {
            IBLL  bLL_Obj = new BLL();
            return bLL_Obj;
        }
    }
}
