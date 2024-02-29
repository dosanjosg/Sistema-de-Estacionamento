using System.Globalization;
using ParkingSystem.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to ParkPro");

        Console.Write("Enter the initial price value: ");
        double currentPrice = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        
        Console.Write("Enter the price per hour: ");
        double pricePerHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Parking parking = new(currentPrice, pricePerHour);

        parking.ServiceTable();
    }
    
}