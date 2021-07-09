using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using (colorDialog1 = new ColorDialog())
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnColor.BackColor = colorDialog1.Color;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string brand = comboBoxBrand.Text;
            string model = comboBoxModel.Text;
            string fuel = comboBoxFuel.Text;
            string kuza = comboBoxKuza.Text;
            string speed = comboBoxSpeed.Text;
            string year = dateTimePicker.Text;
            string color = colorDialog1.Color.ToString();

            ListViewItem item = new ListViewItem();

            item.Text = brand;
            item.SubItems.Add(model);
            item.SubItems.Add(fuel);
            item.SubItems.Add(kuza);
            item.SubItems.Add(speed);
            item.SubItems.Add(year);
            item.SubItems.Add(color);

            listViewCar.Items.Add(item);

        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = comboBoxBrand.SelectedItem.ToString();


            switch (brand)
            {
                case "BMW":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("X4");
                    comboBoxModel.Items.Add("X5");
                    comboBoxModel.Items.Add("X6");
                    break;

                case "Mercedes":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("AA");
                    comboBoxModel.Items.Add("BB");
                    comboBoxModel.Items.Add("CC");
                    break;

                case "Audi":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Q3");
                    comboBoxModel.Items.Add("Q4");
                    comboBoxModel.Items.Add("Q5");
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxBrand.SelectedIndex = 0;
            comboBoxModel.SelectedIndex = 0;
            comboBoxFuel.SelectedIndex = 0;
            comboBoxKuza.SelectedIndex = 0;
            comboBoxSpeed.SelectedIndex = 0;
            comboBoxMotor.SelectedIndex = 0;
        }
    }
}
