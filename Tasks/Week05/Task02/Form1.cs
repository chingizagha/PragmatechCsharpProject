using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtAdd.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(name))
            {
                listBoxName.Items.Add(name);
                txtAdd.Clear();
                txtAdd.Focus();
            }
        }
    }
}
