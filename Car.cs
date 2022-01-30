using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementApp
{
    public class Car
    {
        private string model { get; set; }
        private int year { get; set; }
        private string color { get; set; }
        private double mileage { get; set; }

        public string GetModel() { return model; }
        public void SetModel(string newModel) { model = newModel; }
        public int GetYear() { return year; }
        public void SetYear(int newYear) { year = newYear; }
        public string GetColor() { return color; }
        public void SetColor(string newColor) { color = newColor; }
        public double GetMileage() { return mileage; }
        public void SetMileage(double newMileage) { mileage = newMileage; }



        public Car(string modelParam, int yearParam, string colorParam, double mileageParam)
        {
            this.model = modelParam;
            this.year = yearParam;
            this.color = colorParam;
            this.mileage = mileageParam;

        }

        public string GetInfo()
        {
            return String.Format("Model: {0}, Year: {1}, Color: {2}, Mileage: {3}",
                model,year,color,mileage);
        }
    }
}
