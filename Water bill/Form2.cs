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
    public partial class Form2 : Form
    {
        private double total, usageCharge;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            double usage;
            usage = Convert.ToDouble(Form1.usage);

            if (usage <= 5)
            {
                usageCharge = usage * 12;
                total = usageCharge + 50;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge + ".00";
                label5.Text = "Total : " + total + ".00";
            }
            else if (6<= usage & usage <= 10)
            {
                usageCharge = usage * 16;
                total = usageCharge + 65;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge + ".00";
                label5.Text = "Total : " + total + ".00";
            }
            else if (11 <= usage & usage <= 15)
            {
                usageCharge = usage * 20;
                total = usageCharge + 70;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge+".00";
                label5.Text = "Total : " + total+".00";
            }
            else if (16 <= usage & usage <= 20)
            {
                usageCharge = usage * 40;
                total = usageCharge + 80;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge + ".00";
                label5.Text = "Total : " + total + ".00";
            }
            else if (21 <= usage & usage <= 25)
            {
                usageCharge = usage * 58;
                total = usageCharge + 100;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge + ".00";
                label5.Text = "Total : " + total + ".00";
            }
            else if (26 <= usage & usage <= 30)
            {
                usageCharge = usage * 88;
                total = usageCharge + 200;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge + ".00";
                label5.Text = "Total : " + total + ".00";
            }
            else if (31 <= usage & usage <= 40)
            {
                usageCharge = usage * 105;
                total = usageCharge + 400;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge + ".00";
                label5.Text = "Total : " + total + ".00";
            }
            else if (41 <= usage & usage <= 50)
            {
                usageCharge = usage * 120;
                total = usageCharge + 650;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge + ".00";
                label5.Text = "Total : " + total + ".00";
            }
            else if (51 <= usage & usage <= 75)
            {
                usageCharge = usage * 130;
                total = usageCharge + 1000;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge + ".00";
                label5.Text = "Total : " + total + ".00";
            }
            else
            {
                usageCharge = usage * 140;
                total = usageCharge + 1600;

                label1.Text = "Month : " + Form1.month;
                label2.Text = "Name : " + Form1.name;
                label3.Text = "Your Usage : " + usage;
                label4.Text = "Usage Charge : " + usageCharge + ".00";
                label5.Text = "Total : " + total + ".00";
            }
        }
    }
}
