using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CarManagementApp
{
    public partial class CarManagementForm : Form
    {
        public static List<Car> listOfCars = new List<Car>();
        public CarManagementForm()
        {
            InitializeComponent();
            if (File.Exists(@"c:\temp\carlist.txt"))
            { 
                CarDM.load();
            }
                
        }


        private void addCarButton_Click(object sender, EventArgs e)
        {
            AddAnewCarForm cmf = new AddAnewCarForm();
            cmf.Show();
        }

        private void viewCarsButton_Click(object sender, EventArgs e)
        {
            ViewCarsForm vcf = new ViewCarsForm();
            vcf.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CarDM.save(listOfCars);
        }
    }
}
