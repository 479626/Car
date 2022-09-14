using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        private int direction;
        private string manufacturer;
        private float zeroToSixty;
        private int speed;

        public void InitialiseCar()
        {
            SteerCar(-1);
            MoveCar(10);
            SetManufacturer("Ariel");
            Set0to60(2.3F);
        }

        public void SteerCar(int newDirection)
        {
            direction = newDirection;
        }

        public void MoveCar(int newSpeed)
        {
            speed = newSpeed;
        }

        public void Set0to60(float newZeroToSixty)
        {
            zeroToSixty = newZeroToSixty;
        }

        public void SetManufacturer(string newManufacturer)
        {
            manufacturer = newManufacturer;
        }

        public string GetManufacturer()
        {
            return manufacturer;
        }

        public string GetCarData()
        {
            String car =
                "--------------------\n"
                + "Your car\n"
                + "\nManufacturer: " + manufacturer
                + "\nSpeed: " + speed.ToString()
                + "\nZero to Sixty: " + zeroToSixty.ToString()
                + "\nDirection: " + direction.ToString()
                + "\n--------------------";

            return car;
        }
    }
}
