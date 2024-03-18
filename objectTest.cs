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
  public string license;
  public Vehicle(VehicleSize size, string license)
  {
    this.size = size;
    this.license = license;
  }
}

public class Car:Vehicle
{
    public Car(string license): base(VehicleSize.Compact, license){}
}

class Program
{
  static void Main(string[] args)
  {
      Car gaysex = new Car("SEGZ420");
      Console.WriteLine(gaysex.license);
  }
}
