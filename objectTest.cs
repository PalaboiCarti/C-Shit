using System;
public enum VehicleSize
{
    Motorcycle,
    Compact,
    Large
}
    
public class Vehicle
{
  VehicleSize size;
  string license;
  public Vehicle(VehicleSize size, string license)
  {
    this.size = size;
    this.license = license;
  }
}

public class Car:Vehicle
{
    public Car(string license): base(VehicleSize.Compact, license)
}

class Program
{
  static void Main(string[] args)
  {
    Vehicle trike = new Vehicle("Regular", "SEX420");
    Console.WriteLine(trike.size);
    Console.WriteLine(trike.license);
  }
}
