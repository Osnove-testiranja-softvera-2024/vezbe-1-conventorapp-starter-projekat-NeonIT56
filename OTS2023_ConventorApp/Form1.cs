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
            radioButton1.Checked = true;
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked )
                {
                    Mass mass = new Mass();
                    if (textBox1.Text == "")
                    {
                       textBox1.Text = Convert.ToString(mass.ConvertMass(textBox1.Text, textBox2.Text)); //Convert kg to pounds
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = Convert.ToString(mass.ConvertMass(textBox1.Text, textBox2.Text)); //Convert pounds to kg
                    }
                }
                else if (radioButton2.Checked )
                {
                    Length length = new Length();
                    length.ConvertLength(textBox1.Text, textBox2.Text);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Pounds";
            label2.Text = "Kilograms";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Feet";
            label2.Text = "Meters";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }

    public class Mass
    {
        public Mass()
        {

        }

        internal double ConvertMass(string text1, string text2)
        {
            try
            {
                if(text1 == "")
                {
                    return Convert.ToDouble(text2) * 2.205; //Convert kg to pounds
                }
                else if (text2 == "")
                {
                    return Convert.ToDouble(text1) / 2.205; //Convert pounds to kg
                }
                return 0;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class Length
    {
        public Length()
        {

        }

        internal void ConvertLength(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }
}
