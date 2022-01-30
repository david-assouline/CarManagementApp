using System;
using System.Windows.Forms;

namespace CarManagementApp
{
    public partial class ViewCarsForm : Form
    {
        
       
        public ViewCarsForm()
        {
            InitializeComponent();
            foreach (Car car in CarManagementForm.listOfCars)
            {
                ViewCarsTB.AppendText(car.GetInfo() + "\r\n");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
