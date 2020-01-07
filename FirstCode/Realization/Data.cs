using DataUserModel.Users.DataAccessLayer;

namespace FirstCode.Realization
{
    public class Data : IData
    {
        public IWorker[] Workers { get; set; }
        public IProduct Products { get; set; }
        public decimal RentalPrice { get; set; }
        public Data()
        {
            Workers = new IWorker[4];
        }
    }
}
