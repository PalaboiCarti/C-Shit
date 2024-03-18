using System;
class Car
{
  private string size; // field
  public string Size   // property
  {
    get { return size; }
    set { size = value; }
  }
}

class Program
{
  static void Main(string[] args)
  {
    Car bugati = new Car();
    bugati.Size = "regular";
    Console.WriteLine(bugati.Size);
  }
}
