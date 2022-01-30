using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarManagementApp;

namespace CarManagementApp
{
    public partial class AddAnewCarForm : Form
    {
        
        public AddAnewCarForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CarManagementForm.listOfCars.Add(new Car(ModelTB.Text, int.Parse(YearTB.Text), ColorTB.Text, double.Parse(MileageTB.Text)));
            Close();
        }
    }
}
