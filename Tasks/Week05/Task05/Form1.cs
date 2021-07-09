using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string phoneNum = maskedTxtPhone.Text;
            string birthDate = dateTimePicker.Text;

            dateTimePicker.Value = DateTime.Now;

            ListViewItem worker = new ListViewItem();
            worker.Text = name;
            worker.SubItems.Add(surname);
            worker.SubItems.Add(phoneNum);
            worker.SubItems.Add(birthDate);

            listView1.Items.Add(worker);




            txtName.Clear();
            txtSurname.Clear();
            maskedTxtPhone.Clear();

        }
    }
}
