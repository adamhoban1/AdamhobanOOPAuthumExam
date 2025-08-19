using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdamhobanOOPAuthumExam
{
    public enum BikeType//the enum for the different types of bikes
    {
        Petrol,
        Diesel,
        Electric,
        Human
    }
    public class Engine//the class for the engine of the bike
    {
        public BikeType Fuel { get; set; }
        public int HorsePower { get; set; }

        public Engine(BikeType fuel, int horsePower)//constructor for the engine class to make it easier to create an engine object
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }
    }
    public abstract class Bike//the abstract class for the bike
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public Engine Engine { get; set; }

        public int TankCapacity { get; set; }// tthe properties for the Motorbike
        public int MaxSpeed { get; set; }

        public int ChargeTime { get; set; }// the properties for the ElectricBike
        public int CurrentCharge { get; set; }

        public bool HasCarrier { get; set; }// the properties for the TraditionalBike
        public bool HasBell { get; set; }


        public override string ToString()// override the ToString method to return a string representation of the bike for the ListBox
        {
            return $"{Make} {Model} ({GetBikeType()})";
        }

        public string GetBikeType()// method to determine the type of bike based on the engine fuel type
        {
            if (Engine != null)
            {
                if (Engine.Fuel == BikeType.Petrol || Engine.Fuel == BikeType.Diesel)
                {
                    return "MotorBike";
                }
                else if (Engine.Fuel == BikeType.Electric)
                {
                    return "ElectricBike";
                }
            }
            return "TraditionalBike";
        }

        public void DisplayInfo()//could not get this to work
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {DateOfManufacture.ToShortDateString()}");
            Console.WriteLine($"fuel: {Engine.Fuel}");
            Console.WriteLine($"HorsePower: {Engine.HorsePower}");
        }

    }
    public class MotorBike : Bike// the class for the Motorbike which inherits from the Bike class
    {
        public MotorBike(string make, string model, DateTime dateOfManufacture, Engine engine, int tankCapacity, int maxSpeed)
        {
                Make = make;
                Model = model;
                DateOfManufacture = dateOfManufacture;
                Engine = engine;
                TankCapacity = tankCapacity;
                MaxSpeed = maxSpeed;
        }
    }
    public class ElectricBike : Bike// the class for the ElectricBike which inherits from the Bike class
    {
        public ElectricBike(string make, string model, DateTime dateOfManufacture, Engine engine, int chargeTime, int currentCharge)
        {
            Make = make;
            Model = model;
            DateOfManufacture = dateOfManufacture;
            Engine = engine;
            ChargeTime = chargeTime;
            CurrentCharge = currentCharge;
        }
    }
    public class TraditionalBike : Bike// the class for the TraditionalBike which inherits from the Bike class
    {
        public TraditionalBike(string make, string model, DateTime dateOfManufacture, bool hasCarrier, bool hasBell)
        {
            Make = make;
            Model = model;
            DateOfManufacture = dateOfManufacture;
            //Engine = engine;
            HasCarrier = hasCarrier;
            HasBell = hasBell;
        }
    }

}
