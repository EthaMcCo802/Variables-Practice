using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Variables_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Hockey_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            string name = "Wayne Gretsky";
            label2.Text = name;
            int jersey = 9;
            label2.Text = $"{name} is number {jersey}.";
        }

        private void Area_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false; 
            double radius = 15;
            double pi = 3.14;
            double area = radius * pi;
            label3.Text = $"The area of a circle with the radius of {radius}cm is {area}cm^2.";

        }

        private void Carpet_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = false;
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = costPerMeter * area;
            label4.Text = $"The area of a room with dimensions {length}m X {width}m is {area}m^2. \n\nThe cost to carpet this area at {costPerMeter} per square meter is ${totalCost}.";
            
                
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            double shirt = 12.49;
            double tendered = 20.00;
            double taxPercent = 0.13;
            double tax = shirt * taxPercent;
            double total = shirt + tax;
            double change = tendered - total;
            label5.Text = $"Bill of Sale \n\nShirt: ${shirt} \n\nTendered: ${tendered} \n\nTax: ${tax} \n\nTotal: ${total} \n\nChange: ${change}";
             
        }
    }
}
