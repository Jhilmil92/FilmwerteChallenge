using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FilmwerteChallenge.StorageSystem.Classes
{
    public interface IDataSourceStrategy
    {
        T ReadFromSource<T>(Stream stream) where T : struct;
        void WriteToSource<T>(Stream stream) where T : struct ;
    }
}
