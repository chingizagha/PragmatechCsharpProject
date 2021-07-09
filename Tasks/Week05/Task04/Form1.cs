using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtBox.Text.Trim().ToUpper();
            if (!string.IsNullOrEmpty(name))
            {
                listBoxName.Items.Add(name);
                txtBox.Clear();
                txtBox.Focus();
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBoxName.Items.Count.ToString(), "Count");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtBox.Text.Trim().ToUpper();

            if (listBoxName.Items.Contains(search))
            {
                MessageBox.Show("This name is on the list", "Message");
            }
            else
            {
                MessageBox.Show("This name is not on the list", "Message");
            }
        }
    }
}
