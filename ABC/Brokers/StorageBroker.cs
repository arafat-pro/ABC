namespace ABC.Brokers
{
    public class StorageBroker : IStorageBroker
    {
        public List<string> GetAllData()
        {
            return new List<string>{
                "Dhaka",
                "Chittagong",
                "Sylhet",
                "Rajshahi",
                "Khulna",
                "Barishal",
                "Rangpur"
            };
        }
    }
}
