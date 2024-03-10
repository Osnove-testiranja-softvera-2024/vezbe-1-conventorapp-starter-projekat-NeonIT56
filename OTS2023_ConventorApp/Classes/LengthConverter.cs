using OTS2023_ConventorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    public class LengthConverter : IConvert
    {
        public string Convert(string value)
        {
            return Math.Round(Double.Parse(value) / 3.281, 3).ToString();   
        }
    }
}
