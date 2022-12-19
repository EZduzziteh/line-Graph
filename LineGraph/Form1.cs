using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 Draw a line chart that can display multiple lines. The chart should be scaled appropriately for the numbers 
 entered by the user, and a y-axis should be drawn to show the scale. Each line is given by a sequence of numbers, and should be draw with 
 a different color, shading, or other easy way of identifying it.

 

Bonus: Display a legend identifying each line with a label.

 
     
     
     */

namespace LineGraph
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();



           


            /*
            Console.WriteLine(
            "Location"+pictureBox1.Location.X +", "+
            pictureBox1.Location.Y+" size: "+ pictureBox1.Size.Width+", "+pictureBox1.Size.Height);
            */
        }


      

       

        

        //#TODO sort points by X so they are in the right order
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
