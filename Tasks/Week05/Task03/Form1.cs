using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtAdd.Text.Trim();

            if (!string.IsNullOrEmpty(name))
            {
                listBoxName.Items.Insert(0, name);
                txtAdd.Clear();
                txtAdd.Focus();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for(int i=listBoxName.SelectedItems.Count-1; i>=0; i--)
            {
                listBoxName.Items.Remove(listBoxName.SelectedItems[i]);
            }
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            for (int i=0; i<listBoxName.Items.Count; i++)
            {
                int num = random.Next(listBoxName.Items.Count);
                var names = listBoxName.Items[i];
                listBoxName.Items[i] = listBoxName.Items[num];
                listBoxName.Items[num] = names;
            }
        }
    }
}
