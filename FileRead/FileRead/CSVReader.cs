using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    public class FileEventArgs:EventArgs
    public class CSVReader
    {
        private string fileName;

        public delegate void FileReadCompletedDelegate(int linecount,string manufactured);
        public event FileReadCompletedDelegate OnFileCompleted;

        public CSVReader() { }
        public CSVReader(string fileName)
        {
            this.fileName = fileName;
        }
        public List<Car> ReadFile(string fileName)
        {
            int linecount = 0;
            List<Car> cars = new List<Car>();
            StreamReader reader = new StreamReader(fileName);
            string headerLine = reader.ReadLine();
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] columns = line.Split(',');
                Car car = new Car()
                {
                    Year = int.Parse(columns[0]),
                    Manufacturer = columns[1],
                    Name = columns[2],
                    Displacement = double.Parse(columns[3]),
                    Cylinders = int.Parse(columns[4]),
                    City = int.Parse(columns[5]),
                    Highway = int.Parse(columns[6]),
                    Combined = int.Parse(columns[7])
                };
                linecount++;
                cars.Add(car);
                if(car.Manufacturer == "BMW" && this.OnFileCompleted != null)
                {
                    this.OnFileCompleted(linecount,);
                }
            }
            //if (this.OnFileCompleted != null)
            //{
            //    this.OnFileCompleted();
            //}
            return cars;
        }
    }
}
