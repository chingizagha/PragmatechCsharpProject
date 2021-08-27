using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AddOrder()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCategory.SelectedIndex = 0;
            comboBoxItem.SelectedIndex = 0;
            comboBoxDelivery.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (numericUpDownWeight.Value == 0 || numericUpDownPrice.Value == 0)
            {
                MessageBox.Show("Please fill in all the required fields correctly");
            }
            else
            {
                Item prdct = new Item();

                prdct.Category = comboBoxCategory.Text;
                prdct.Product = comboBoxItem.Text;
                prdct.Weight = Convert.ToInt32(numericUpDownWeight.Value);
                prdct.Delivery = comboBoxDelivery.Text;
                prdct.Price = Convert.ToInt32(numericUpDownPrice.Value);
                prdct.OrderTime = dateTimePicker.Value;

                ListViewItem item = new ListViewItem();

                item.Text = prdct.Product;
                item.SubItems.Add(prdct.Category);
                item.SubItems.Add(prdct.Weight.ToString());
                item.SubItems.Add(prdct.Delivery);
                item.SubItems.Add(prdct.Price.ToString());
                item.SubItems.Add(prdct.OrderTime.ToString());

                listViewData.Items.Add(item);
            }

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboBoxCategory.SelectedItem.ToString();

            switch (category)
            {
                case "Category 1":
                    comboBoxItem.Items.Clear();
                    comboBoxItem.Items.Add("Item 11");
                    comboBoxItem.Items.Add("Item 12");
                    comboBoxItem.Items.Add("Item 13");
                    break;

                case "Category 2":
                    comboBoxItem.Items.Clear();
                    comboBoxItem.Items.Add("Item 21");
                    comboBoxItem.Items.Add("Item 22");
                    comboBoxItem.Items.Add("Item 23");
                    break;

                case "Category 3":
                    comboBoxItem.Items.Clear();
                    comboBoxItem.Items.Add("Item 31");
                    comboBoxItem.Items.Add("Item 32");
                    comboBoxItem.Items.Add("Item 33");
                    break;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                for (int i = listViewData.Items.Count - 1; i >= 0; i--)
                {
                    var item = listViewData.Items[i];
                    if (item.Text.ToLower().Trim().Contains(txtSearch.Text.ToLower().Trim()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                        //MessageBox.Show($"This {txtSearch.Text} is in stock");
                    }
                    else
                    {
                        //MessageBox.Show($"This {txtSearch.Text} is not in stock");
                        item.BackColor = SystemColors.WindowFrame;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = listViewData.SelectedItems.Count - 1; i >= 0; i--)
            {
                listViewData.Items.Remove(listViewData.SelectedItems[i]);
            }
        }
    }
}
