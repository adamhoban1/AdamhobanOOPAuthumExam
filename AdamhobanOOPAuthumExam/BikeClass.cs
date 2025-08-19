using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamhobanOOPAuthumExam
{
    public enum BikeType
    {
        Petrol,
        Diesel,
        Electric,
        Human
    }
    internal class Engine
    {
        public BikeType Fuel { get; set; }
        public int HorsePower { get; set; }
    }
}
