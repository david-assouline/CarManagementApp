using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementApp
{
    class CarDM
    {
        public static void save(List<Car> listOfCars)
        {
            string fileName = "carlist.txt";

            StreamWriter writer = File.CreateText(@"c:\temp\" + fileName);
            writer.AutoFlush = true;

                foreach (Car car in listOfCars)
                {
                    writer.WriteLine(car.GetModel());
                    writer.WriteLine(car.GetColor());
                    writer.WriteLine(car.GetMileage());
                    writer.WriteLine(car.GetYear());
                } 
        }
        public static void load()
        {
            string[] lines = System.IO.File.ReadAllLines(@"c:\temp\carlist.txt");
            if (lines.Length >= 4)
            {
                for (int i = 0; i < (lines.Length); i += 4)
                {
                    CarManagementForm.listOfCars.Add(new Car(lines[i], int.Parse(lines[i + 3]), lines[i + 1], double.Parse(lines[i + 2])));
                }
            }
        }
    }
}
