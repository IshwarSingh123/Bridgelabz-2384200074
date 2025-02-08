
using System;

class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Model: {Model}, Max Speed: {MaxSpeed} km/h");
    }
}

interface Refuelable
{
    void Refuel();
}

class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; }

    public ElectricVehicle(int maxSpeed, string model, int batteryCapacity)
        : base(maxSpeed, model)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void Charge()
    {
        Console.WriteLine("Charging the electric vehicle.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Electric Vehicle Model: {Model}, Max Speed: {MaxSpeed} km/h, Battery Capacity: {BatteryCapacity} kWh");
    }
}

class PetrolVehicle : Vehicle, Refuelable
{
    public int FuelCapacity { get; set; }

    public PetrolVehicle(int maxSpeed, string model, int fuelCapacity)
        : base(maxSpeed, model)
    {
        FuelCapacity = fuelCapacity;
    }

    public void Refuel()
    {
        Console.WriteLine("Refueling the petrol vehicle.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Petrol Vehicle Model: {Model}, Max Speed: {MaxSpeed} km/h, Fuel Capacity: {FuelCapacity} liters");
    }
}

class Program
{
    static void Main()
    {
        Vehicle ev = new ElectricVehicle(150, "Tesla Model S", 100);
        ev.DisplayInfo();
        ((ElectricVehicle)ev).Charge();

        Vehicle pv = new PetrolVehicle(200, "Ford Mustang", 50);
        pv.DisplayInfo();
        ((PetrolVehicle)pv).Refuel();
    }
}