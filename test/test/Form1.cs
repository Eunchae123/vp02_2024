using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        
        ComboBox[] grades;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                   }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string result = "";

            
            if (rb1.Checked)
                result += "의료IT공학과\n";
            else if (rb2.Checked)
                result += "의공학과\n";
            else if (rb3.Checked)
                result += "의료신소재학과\n";
            else if (rb4.Checked)
                result += "제약생명공학과\n";
            else if (rb5.Checked)
                result += "의료공간디자인학과\n";
            string userInput = textBox1.Text;
                result += "이름:\n" + userInput;
            string numbers = textBox2.Text;
                result += "학번:\n" + numbers;


        CheckBox[] checkBoxes = { cbPython, cbC, cbCpp, cbCs, cbJ };


            MessageBox.Show(result, "학생정보");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grades = new ComboBox[] { cb };
            int[] arr = { 1, 2, 3, 4 };
            CheckBox[] checkBoxes = { cbPython, cbC, cbCpp, cbCs, cbJ };


            foreach (var cb in grades)
            {
                foreach (var i in arr)
                    cb.Items.Add(i);
                cb.SelectedItem = 4;
            }
            
            }
        }
    }
