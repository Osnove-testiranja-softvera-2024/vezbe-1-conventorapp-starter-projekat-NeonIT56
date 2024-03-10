using OTS2023_ConventorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp.Classes
{
    public class CustomMoneyConverter : ICustomMoneyConvert
    {
        private Dictionary<string, Dictionary<string, double>> conversionRates = new Dictionary<string, Dictionary<string, double>>()
        {
            { "$", new Dictionary<string, double>() { { "€", 0.91 } } }, // USD -> EUR
            { "€", new Dictionary<string, double>() { { "$", 1.09 }, { "£", 0.85 } } }, // EUR -> USD, EUR -> GBP
            { "£", new Dictionary<string, double>() { { "€", 1.17 } } } // GBP -> EUR
        };

        public string ConvertCustomMoney(string value)
        {
            string[] parts = value.Split(new string[] { " to " }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2)
            {
                MessageBox.Show("Invalid input format. Please provide input in the format: '<amount><currency1> to <currency2>'");
                return null;
            }

            string amountAndCurrency = parts[0].Trim();
            string currencyTo = parts[1].Trim();

            string currencyFrom = "";
            double amount = 0;

            foreach (char c in amountAndCurrency)
            {
                if (char.IsDigit(c) || c == '.' || c == ',')
                {
                    continue;
                }
                else
                {
                    currencyFrom += c;
                }
            }

            if (string.IsNullOrWhiteSpace(currencyFrom) || !double.TryParse(amountAndCurrency.Replace(currencyFrom, "").Replace("$", "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out amount))
            {
                MessageBox.Show("Invalid amount or currency symbol. Please provide a valid input.");
                return null;
            }

            if (conversionRates.ContainsKey(currencyFrom) && conversionRates[currencyFrom].ContainsKey(currencyTo))
            {
                double result = amount * conversionRates[currencyFrom][currencyTo];
                return $"{result.ToString("0.##", CultureInfo.InvariantCulture)}{currencyTo}";
            }
            else
            {
                MessageBox.Show("Unsupported conversion.");
                return null;
            }
        }


    }
}
