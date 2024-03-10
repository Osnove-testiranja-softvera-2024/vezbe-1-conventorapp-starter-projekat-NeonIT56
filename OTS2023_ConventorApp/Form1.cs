using OTS2023_ConventorApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            if (radioMass.Checked) { 
                groupSegmentType.Visible = true;
                label1.Text = "Pounds";
                label2.Text = "Kilograms";
                radioSingle.Checked = true;
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (radioMass.Checked)
            {
                MassConverter mass = new MassConverter();
                if (radioSingle.Checked && IsValidSingleInput(textBox1.Text))
                    textBox2.Text = mass.Convert(textBox1.Text);
                else if (radioArray.Checked)
                    textBox2.Text = mass.Convert(ConvertList.ConvertFromList(textBox1.Text).ToString());
                else
                    radioSingleWithMultipleValues_Error();
            }
            else if (radioLength.Checked)
            {
                LengthConverter length = new LengthConverter();
                if (radioSingle.Checked && IsValidSingleInput(textBox1.Text))
                    textBox2.Text = length.Convert(textBox1.Text);
                else if (radioArray.Checked)
                    textBox2.Text = length.Convert(ConvertList.ConvertFromList(textBox1.Text).ToString());
                else
                    radioSingleWithMultipleValues_Error();
            }
            else if (radioMoney.Checked && IsValidSingleInput(textBox1.Text))
            {
                MoneyConverter money = new MoneyConverter();
                if (radioSingle.Checked)
                    textBox2.Text = money.Convert(textBox1.Text);
                else if (radioArray.Checked)
                    textBox2.Text = money.Convert(ConvertList.ConvertFromList(textBox1.Text).ToString());
                else
                    radioSingleWithMultipleValues_Error();
            }
            else if (radioTime.Checked)
            {
                TimeConverter time = new TimeConverter();
                if (IsValidSingleInput(textBox1.Text))
                {
                    double value = double.Parse(textBox1.Text);
                    if (radioHours.Checked)
                        textBox2.Text = time.ConvertHours(value).ToString();
                    else if (radioMinutes.Checked)
                        textBox2.Text = time.ConvertMinutes(value).ToString();
                    else if (radioSeconds.Checked)
                        textBox2.Text = time.ConvertSeconds(value).ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please provide a valid numerical value.");
                }
            }
            else if (radioCustom.Checked)
            {
                CustomMoneyConverter customMoney = new CustomMoneyConverter();
                textBox2.Text = customMoney.ConvertCustomMoney(textBox1.Text);
            }

        }
        private void radioMass_CheckedChanged(object sender, EventArgs e)
        {
            groupSegmentType.Visible = true;
            groupTimeOutput.Visible = false;
            label1.Text = "Pounds";
            label2.Text = "Kilograms";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioLength_CheckedChanged(object sender, EventArgs e)
        {
            groupSegmentType.Visible = true;
            groupTimeOutput.Visible = false;
            label1.Text = "Feet";
            label2.Text = "Meters";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioTime_CheckedChanged(object sender, EventArgs e)
        {
            groupSegmentType.Visible = false;
            groupTimeOutput.Visible = true;
            radioHours.Checked = true;
            label1.Text = "Days";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioHours_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioHours.Text;
        }

        private void radioMinutes_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioMinutes.Text;
        }

        private void radioSeconds_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioSeconds.Text;
        }

        private void radioMoney_CheckedChanged(object sender, EventArgs e)
        {
            groupSegmentType.Visible = true;
            groupTimeOutput.Visible = false;
            label1.Text = "Euro";
            label2.Text = "Rsd";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {
            groupSegmentType.Visible = false;
            label1.Text = "Custom expression";
            label2.Text = "Result";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private bool IsValidSingleInput(string input)
        {
            double value;
            return double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out value);
        }

        private void radioSingleWithMultipleValues_Error()
        {
            MessageBox.Show("Invalid input format. Please enter a single number (e.g., 'n' or 'n.n') or turn on the 'Array of values' option.");
        }
    }
}
