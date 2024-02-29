namespace ParkingSystem.Entities 
{
    public class Parking (double currentPrice, double pricePerHour) 
    {
        private double CurrentPrice { get; set; } = currentPrice;
        private double PricePerHour { get; set; } = pricePerHour;
        readonly List <string> vehicles = [];
        public double hours;

        public void ServiceTable() 
        {
            Console.Clear();

            Console.WriteLine("-----------------");
            Console.WriteLine("Services ParkPro");
            Console.WriteLine("-----------------");
            Console.WriteLine("1 - Register vehicle");
            Console.WriteLine("2 - Remove vehicle");
            Console.WriteLine("3 - List vehicles");
            Console.WriteLine("4 - Close");

            Console.Write("Enter an option: ");
            int option = int.Parse(Console.ReadLine()!);

            switch (option) 
            {
                case 1: Register(); break;
                case 2: Remove(); break;
                case 3: ListVehicles(); break;
                case 4: Environment.Exit(0); break;
                default: ServiceTable(); break;
            }
        }

        public void Register() 
        {   
            Console.Clear();
            Console.Write("Enter the vehicle licence plate: ");
            string plate = Console.ReadLine()!;
            vehicles.Add(plate);
            Console.WriteLine("Vehicle added! Press enter to continue");
            Console.ReadKey();
            ServiceTable();
            
        }

        public void Remove() 
        {
            Console.Clear();
            Console.Write("Enter the vehicle licence plater to remove: ");
            string plateForRemove = Console.ReadLine()!;
            vehicles.Remove(plateForRemove);
            Console.Write("How many hours was the vehicle parked? ");
            hours = double.Parse(Console.ReadLine()!);
            double finalPrice = FinalPrice(CurrentPrice, PricePerHour, hours);
            Console.WriteLine($"The vehicle {plateForRemove} was removed!");
            Console.WriteLine($"Service charge: R$ {finalPrice}");
        }

        public void ListVehicles() 
        {
            Console.Clear();
            Console.WriteLine("Parked vehicles are: ");
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadKey();
            ServiceTable();
        }

        public double FinalPrice(double currentPrice, double pricePerHour, double hour) 
        {
            return currentPrice + (pricePerHour * hour);
        }
    }
}