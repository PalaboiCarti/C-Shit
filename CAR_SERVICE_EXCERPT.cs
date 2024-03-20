using System;

public class KissMyAss
{
    public static void Main(string[] args)
    {
        Car car1 = new Car
        (
            "abc123",
            "Toyota",
            "Inova",
            2017,
            3500,
            true
        );
        
        Car car2 = new Car
        (
            "def456",
            "Mitsubishi",
            "Mirage",
            "2021",
            "2000",
            true
        );
        
        Customer jaiden = new Customer("Jaiden", 0909123);
        Customer jack = new Customer("Jack", 56789);
        rs.AddCar(car1);
        rs.AddCar(car2);
        rs.DisplayAvailableCars();
        rs.RentCar(yourCar, jaiden);
        rs.DisplayRentedCars();
    }
}
