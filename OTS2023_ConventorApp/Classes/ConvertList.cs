using OTS2023_ConventorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    public class ConvertList
    {
        public static double ConvertFromList(string list)
        {
            string[] values = list.Split(',');
            double number = 0;
            for (int i = 0; i < values.Length; i++)
            {
                number += Double.Parse(values[i]);
            }
            return Convert.ToDouble(number);
        }
    }
}
