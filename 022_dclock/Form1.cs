using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_dclock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void DrawHands(double radHr, double radMin, double radSec)
        {
            DrawLine(0,0,
                (int)(hourHand * Math.Sin(radHr)),
                (int)(hourHand * Math.Cos(radHr)),
                Brushes.RoyalBlue,8);
        }
    }
}
