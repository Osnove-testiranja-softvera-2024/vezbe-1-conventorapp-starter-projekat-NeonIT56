using OTS2023_ConventorApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if(radioMass.Checked)
                groupBox3.Visible = true;
                label1.Text = "Pounds";
                label2.Text = "Kilograms";
                radioSingle.Checked = true;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (radioMass.Checked )
            {
                MassConverter mass = new MassConverter();
                if (radioSingle.Checked) 
                    textBox2.Text = mass.Convert(textBox1.Text);
                else if (radioArray.Checked)
                    textBox2.Text = mass.Convert(ConvertList.ConvertFromList(textBox1.Text).ToString());
            }
            else if (radioLength.Checked )
            {
                LengthConverter length = new LengthConverter();
                if (radioSingle.Checked)
                    textBox2.Text = length.Convert(textBox1.Text);
                else if (radioArray.Checked)
                    textBox2.Text = length.Convert(ConvertList.ConvertFromList(textBox1.Text).ToString());
            }

        }
        private void radioMass_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            label1.Text = "Pounds";
            label2.Text = "Kilograms";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioLength_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            label1.Text = "Feet";
            label2.Text = "Meters";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioTime_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            label1.Text = "Days";
            label2.Text = "Meters";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioMoney_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            label1.Text = "Euro";
            label2.Text = "Rsd";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
