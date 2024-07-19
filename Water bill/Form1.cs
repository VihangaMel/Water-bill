using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_bill
{
    public partial class Form1 : Form
    {
        public static string month="";
        public static string name="";
        public static string usage="";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtBoxUsage.Text) && !String.IsNullOrWhiteSpace(txtBoxName.Text))
                {
                    month = comboBoxMonth.SelectedItem.ToString();
                    name = txtBoxName.Text;
                    usage = txtBoxUsage.Text;

                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Please fill all the text fields!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
