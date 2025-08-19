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
    public class Engine
    {
        public BikeType Fuel { get; set; }
        public int HorsePower { get; set; }
    }
    public abstract class Bike
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public Engine Engine { get; set; }

        public override string ToString()
        {
            return $"{Make} {Model} ({DateOfManufacture.Year}) - {Engine.Fuel} with {Engine.HorsePower} HP";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {DateOfManufacture.ToShortDateString()}");
            Console.WriteLine($"fuel: {Engine.Fuel}");
            Console.WriteLine($"HorsePower: {Engine.HorsePower}");
        }

    }
}
