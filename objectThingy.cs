using System;
public class Vehicle
{
  public string size;
  public string license;
  public Vehicle(string size, string license)
  {
    this.size = size;
    this.license = license;
  }
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
