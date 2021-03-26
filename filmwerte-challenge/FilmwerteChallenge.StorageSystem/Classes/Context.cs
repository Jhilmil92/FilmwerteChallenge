using System.IO;

namespace FilmwerteChallenge.StorageSystem.Classes
{
    public class Context<T> where T : struct
    {
        private IDataSourceStrategy _dataSourceStrategy;

        public Context()
        {

        }

        public Context(IDataSourceStrategy dataSourceStrategy)
        {
            _dataSourceStrategy = dataSourceStrategy;
        }

        public void SetStrategy(IDataSourceStrategy strategy)
        {
            _dataSourceStrategy = strategy;
        }
        
        public T PerformRead(Stream stream)
        {
            var returnedData = _dataSourceStrategy.ReadFromSource<T>(stream);
            return returnedData;
        }

        public void PerformWrite(Stream stream)
        {
            _dataSourceStrategy.WriteToSource<T>(stream);
        }

    }
}
