using System;
using System.IO;
using System.Collections.Generic;
using CsvHelper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGO_Farming_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/mieci/Documents/Servant.csv";

        }
        private List<T> ReadFile<T>(string path) where T : class
        {
            List<T> result = new List<T>();
            using (StreamReader tr = new StreamReader(path, Encoding.GetEncoding(1252)))
            {
                var csv = new CsvReader(tr);

            }
        }
    }
}
