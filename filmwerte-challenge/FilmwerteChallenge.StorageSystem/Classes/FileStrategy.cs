using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FilmwerteChallenge.StorageSystem.Classes
{
    public class FileStrategy : IDataSourceStrategy
    {
        public FileStrategy()
        {

        }
        public T ReadFromSource<T>(Stream stream) where T : struct
        {
            throw new NotImplementedException();
        }

        public void WriteToSource<T>(Stream stream) where T : struct
        {
            throw new NotImplementedException();
        }
    }
}
