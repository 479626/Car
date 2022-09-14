using ConsoleApp1;
using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.InitialiseCar();
        Console.WriteLine(car.GetCarData());
    }
}