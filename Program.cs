using ConsoleApp1;

class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car(); // Create new Car
        car.InitialiseCar(); // Intialise the Car's variables

        EditCar(car);
    }

    private static void EditCar(Car car)
    {
        Console.WriteLine(car.GetCarData());
        Console.Write("Would you like to edit your car (y/n)? ");
        string option = Console.ReadLine();

        switch (option)
        {
            case "y":
                UpdateCar(car);
                break;
            case "n":
                Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Invalid option!");
                EditCar(car);
                break;
        }
    }

    private static void UpdateCar(Car car)
    {
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("What would you like to change?\na - Direction\nb - Zero to Sixty\nc - Speed\nd - Manufacturer");
        string editOption = Console.ReadLine();

        Console.WriteLine("What would you like to make the value? ");
        var value = Console.ReadLine();

        switch (editOption)
        {
            case "a":
                int newDirection;
                if (int.TryParse(value, out newDirection))
                {
                    car.SteerCar(newDirection);
                }
                break;
            case "b":
                float newZeroToSixty;
                if (float.TryParse(value, out newZeroToSixty))
                {
                    car.Set0to60(newZeroToSixty);
                }
                break;
            case "c":
                int newSpeed;
                if (int.TryParse(value, out newSpeed))
                {
                    car.MoveCar(newSpeed);
                }
                break;
            case "d":
                if (value is string)
                {
                    car.SetManufacturer(value);
                }
                break;
            default:
                Console.WriteLine("Invalid option!");
                EditCar(car);
                break;
        }
        Console.WriteLine("Car edited!");
        EditCar(car);
    }
}
