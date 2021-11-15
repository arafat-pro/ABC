using ABC.Brokers;

namespace ABC.Services
{
    public class DataProcessorService : IDataProcessorService
    {
        private readonly IStorageBroker storageBroker;
        
        public DataProcessorService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public List<string> ProcessData()
        {
            throw new NotImplementedException();
        }
    }
}