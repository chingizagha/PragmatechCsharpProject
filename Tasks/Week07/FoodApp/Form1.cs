using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pizza pizza = new Pizza();
            listBoxPizzaName.Items.Add(pizza.Klassik);
            listBoxPizzaName.Items.Add(pizza.Qarishiq);
            listBoxPizzaName.Items.Add(pizza.Pendirli);
            listBoxPizzaName.Items.Add(pizza.Kolbasali);
            listBoxPizzaName.Items.Add(pizza.Italiano);
            listBoxPizzaName.Items.Add(pizza.Mexicano);

            PizzaSize pizzasize = new PizzaSize();
            comboBoxPizzaSize.Items.Add(pizzasize.Kicik);
            comboBoxPizzaSize.Items.Add(pizzasize.Orta);
            comboBoxPizzaSize.Items.Add(pizzasize.Boyuk);
            comboBoxPizzaSize.Items.Add(pizzasize.Maxi);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHesab_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza();
            PizzaSize pizzasize = new PizzaSize();

            double sum=0;

            string pizzaSizeComboBox = comboBoxPizzaSize.SelectedItem.ToString();

            if (radioButtonQalin.Checked == true)
            {
                if (comboBoxPizzaSize.SelectedItem.ToString() == pizzasize.Kicik)
                {
                    if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Klassik)
                    {
                        sum = (pizza.KlassikPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Qarishiq)
                    {
                        sum = (pizza.QaroshiqPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Pendirli)
                    {
                        sum = (pizza.PendirliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Kolbasali)
                    {
                        sum = (pizza.KolbasaliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Italiano)
                    {
                        sum = (pizza.ItalianoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Mexicano)
                    {
                        sum = (pizza.MexicanoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    textBoxMiqdar.Text = Convert.ToString(sum);
                }
                else if (comboBoxPizzaSize.SelectedItem.ToString() == pizzasize.Orta)
                {
                    if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Klassik)
                    {
                        sum = (pizza.KlassikPrice * pizzasize.OrtaIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Qarishiq)
                    {
                        sum = (pizza.QaroshiqPrice * pizzasize.OrtaIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Pendirli)
                    {
                        sum = (pizza.PendirliPrice * pizzasize.OrtaIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Kolbasali)
                    {
                        sum = (pizza.KolbasaliPrice * pizzasize.OrtaIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Italiano)
                    {
                        sum = (pizza.ItalianoPrice * pizzasize.OrtaIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Mexicano)
                    {
                        sum = (pizza.MexicanoPrice * pizzasize.OrtaIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    textBoxMiqdar.Text = Convert.ToString(sum);
                }
                else if (comboBoxPizzaSize.SelectedItem.ToString() == pizzasize.Boyuk)
                {
                    if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Klassik)
                    {
                        sum = (pizza.KlassikPrice * pizzasize.BoyukIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Qarishiq)
                    {
                        sum = (pizza.QaroshiqPrice * pizzasize.BoyukIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Pendirli)
                    {
                        sum = (pizza.PendirliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Kolbasali)
                    {
                        sum = (pizza.KolbasaliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Italiano)
                    {
                        sum = (pizza.ItalianoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Mexicano)
                    {
                        sum = (pizza.MexicanoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    textBoxMiqdar.Text = Convert.ToString(sum);

                }
                else if (comboBoxPizzaSize.SelectedItem.ToString() == pizzasize.Maxi)
                {
                    if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Klassik)
                    {
                        sum = (pizza.KlassikPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Qarishiq)
                    {
                        sum = (pizza.QaroshiqPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Pendirli)
                    {
                        sum = (pizza.PendirliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Kolbasali)
                    {
                        sum = (pizza.KolbasaliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Italiano)
                    {
                        sum = (pizza.ItalianoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Mexicano)
                    {
                        sum = (pizza.MexicanoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    textBoxMiqdar.Text = Convert.ToString(sum);

                }
            }
            else if (radioButtonQalin.Checked == false)
            {
                if (comboBoxPizzaSize.SelectedItem.ToString() == pizzasize.Kicik)
                {
                    if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Klassik)
                    {
                        sum = (pizza.KlassikPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Qarishiq)
                    {
                        sum = (pizza.QaroshiqPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Pendirli)
                    {
                        sum = (pizza.PendirliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Kolbasali)
                    {
                        sum = (pizza.KolbasaliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Italiano)
                    {
                        sum = (pizza.ItalianoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Mexicano)
                    {
                        sum = (pizza.MexicanoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    textBoxMiqdar.Text = Convert.ToString(sum);
                }
                else if (comboBoxPizzaSize.SelectedItem.ToString() == pizzasize.Orta)
                {
                    if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Klassik)
                    {
                        sum = (pizza.KlassikPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Qarishiq)
                    {
                        sum = (pizza.QaroshiqPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Pendirli)
                    {
                        sum = (pizza.PendirliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Kolbasali)
                    {
                        sum = (pizza.KolbasaliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Italiano)
                    {
                        sum = (pizza.ItalianoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Mexicano)
                    {
                        sum = (pizza.MexicanoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    textBoxMiqdar.Text = Convert.ToString(sum);
                }
                else if (comboBoxPizzaSize.SelectedItem.ToString() == pizzasize.Boyuk)
                {
                    if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Klassik)
                    {
                        sum = (pizza.KlassikPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Qarishiq)
                    {
                        sum = (pizza.QaroshiqPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Pendirli)
                    {
                        sum = (pizza.PendirliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Kolbasali)
                    {
                        sum = (pizza.KolbasaliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Italiano)
                    {
                        sum = (pizza.ItalianoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Mexicano)
                    {
                        sum = (pizza.MexicanoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    textBoxMiqdar.Text = Convert.ToString(sum);

                }
                else if (comboBoxPizzaSize.SelectedItem.ToString() == pizzasize.Maxi)
                {
                    if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Klassik)
                    {
                        sum = (pizza.KlassikPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Qarishiq)
                    {
                        sum = (pizza.QaroshiqPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Pendirli)
                    {
                        sum = (pizza.PendirliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Kolbasali)
                    {
                        sum = (pizza.KolbasaliPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Italiano)
                    {
                        sum = (pizza.ItalianoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    else if (listBoxPizzaName.SelectedIndex.ToString() == pizza.Mexicano)
                    {
                        sum = (pizza.MexicanoPrice * pizzasize.KicikIndex) * Convert.ToDouble(numericUpDownEded.Value);
                    }
                    textBoxMiqdar.Text = Convert.ToString(sum);

                }

            }


        }
    }
}
