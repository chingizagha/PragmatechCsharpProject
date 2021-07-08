using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxOperator.Items.Add("+");
            comboBoxOperator.Items.Add("-");
            comboBoxOperator.Items.Add("*");
            comboBoxOperator.Items.Add("/");
            comboBoxOperator.SelectedIndex = 0;
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            string operators = comboBoxOperator.SelectedItem.ToString();
            int first = Convert.ToInt32(firstValue.Value);
            int second = Convert.ToInt32(secondValue.Value);

            switch (operators)
            {
                case "+":
                    resultLabel.Text = (first + second).ToString();
                    break;
                case "-":
                    resultLabel.Text = (first - second).ToString();
                    break;
                case "*":
                    resultLabel.Text = (first * second).ToString();
                    break;
                case "/":
                    resultLabel.Text = (Convert.ToDouble(first) / second).ToString();
                    break;
            }
        }
    }
        
    }
