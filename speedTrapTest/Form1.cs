using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace speedTrapTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {   // variable declaration
            double car1, car2, car3, car4, speedLimit, average;
            speedLimit = Convert.ToDouble(txtSpeedLimit.Text);
            car1 = Convert.ToDouble(txtCar1.Text);
            car2 = Convert.ToDouble(txtCar2.Text);
            car3 = Convert.ToDouble(txtCar3.Text);
            car4 = Convert.ToDouble(txtCar4.Text);

            // Calculate the average speed of the cars
            average = (car1 + car2 + car3 + car4) / 4;
            string averageSpeed = Convert.ToString(average);

            // Display the average speed in the label
            lblAverageSpeed.Text = averageSpeed;

            // Compare the first car's speed to the speed limit
            if(car1 == speedLimit)
            {
                lblCar1.Text = "Safe Driver";
            }
            if (car1 < speedLimit)
            {
                lblCar1.Text = "Slow Driver";
            }
            if (car1 > speedLimit)
            {
                lblCar1.Text = "Speeder";
            }

            // Compare the second car's speed to the speed limit
            if (car2 == speedLimit)
            {
                lblCar2.Text = "Safe Driver";
            }
            if (car2 < speedLimit)
            {
                lblCar2.Text = "Slow Driver";
            }
            if (car2 > speedLimit)
            {
                lblCar2.Text = "Speeder";
            }

            // Compare the third car's speed to the speed limit
            if (car3 == speedLimit)
            {
                lblCar3.Text = "Safe Driver";
            }
            if (car3 < speedLimit)
            {
                lblCar3.Text = "Slow Driver";
            }
            if (car3 > speedLimit)
            {
                lblCar3.Text = "Speeder";
            }

            // Compare the fourth car's speed to the speed limit
            
            if (car4 == speedLimit)
            {
                lblCar4.Text = "Safe Driver";
            }
            if (car4 < speedLimit)
            {
                lblCar4.Text = "Slow Driver";
            }
            if (car4 > speedLimit)
            {
                lblCar4.Text = "Speeder";
            }
    
            // Compare the average speed to the speed limit
            if (average == speedLimit)
            {
                lblAverage.Text = "Safe Community";
            }
            if (average < speedLimit)
            {
                lblAverage.Text = "Slow Community";
            }
            if (average > speedLimit)
            {
                lblAverage.Text = "Dangerous Community";
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtCar1.Clear();
            txtCar2.Clear();
            txtCar3.Clear();
            txtCar4.Clear();
            txtSpeedLimit.Clear();
            

        }
    }
}
