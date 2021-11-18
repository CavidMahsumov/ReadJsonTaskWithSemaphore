using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJsonTaskWithSemaphore.Models
{
    public class Car
    {
        public string Model { get; set; }
        public string Vendor { get; set; }
        public int Year { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return $"Model : {Model}    -    Vendor : {Vendor}   -   Year : {Year}   -   ImagePath : {ImagePath}";
        }
    }
}
