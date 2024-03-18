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

public class Motor:Vehicle
{
    public Motor(string license):base(VehicleSize.Motorcycle, license){}
}

public class Truck:Vehicle
{
    public Truck(string license):base(VehicleSize.Large, license){}
}

class Program
{
  static void Main(string[] args)
  {
      Car bugatti = new Car("SEGZ069");
      Console.WriteLine("Bugatti License: " + bugatti.license);
      Truck volvo = new Truck("ZAZA420");
      Console.WriteLine("Volvo License: " + volvo.license);
      Motor ducati = new Motor("LUCK333");
      Console.WriteLine("Ducati License: " + ducati.license);
  }
}
