using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public Engine(BikeType fuel, int horsePower)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }
    }
    public abstract class Bike
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public Engine Engine { get; set; }

        public int TankCapacity { get; set; }
        public int MaxSpeed { get; set; }

        public int ChargeTime { get; set; }
        public int CurrentCharge { get; set; }

        public bool HasCarrier { get; set; }
        public bool HasBell { get; set; }


        public override string ToString()
        {
            return $"{Make} {Model} ({GetBikeType()})";
        }

        public string GetBikeType()
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

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {DateOfManufacture.ToShortDateString()}");
            Console.WriteLine($"fuel: {Engine.Fuel}");
            Console.WriteLine($"HorsePower: {Engine.HorsePower}");
        }

    }
    public class MotorBike : Bike
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
    public class ElectricBike : Bike
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
    public class TraditionalBike : Bike
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
