using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName;
            int playerNumber = 99;
            playerName = "Wayne Gretzky";

            outputLabel.Text = $"\n{playerName} is number {playerNumber}";
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
           

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double hours = 25;
            double pay = 18.75;
            double earned = hours * pay;

            outputLabel.Text = $"\n{hours} hours at ${pay} per hour equals ${earned}";
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = radius * radius * pi;

            outputLabel.Text = $"\nThe area of a circle with a radius of {radius}cm is {area}cm^2";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = costPerMeter * area;

            outputLabel.Text = $"\nThe area of a room with dimensions {length}m x {width}m is {area}m^2";
            outputLabel.Text += $"\nThe cost to carpet this area at {costPerMeter} per square meter is ${totalCost}";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double shirt = 12.49;
            double tendered = 20;
            double tax = 0.13 * shirt;
            double total = shirt + tax; 
            double change = tendered - total;

            outputLabel.Text = $"Bill of Sale";
            outputLabel.Text += $"\n\nShirt: {shirt}";
            outputLabel.Text += $"\n\nTax: {tax}";
            outputLabel.Text += $"\n\nTotal: {total}";
            outputLabel.Text += $"\n\n\nTendered: {tendered}";
            outputLabel.Text += $"\n\n\nChange: {change}";
        }
    }
}
