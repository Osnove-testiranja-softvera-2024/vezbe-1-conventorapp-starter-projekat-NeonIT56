using OTS2023_ConventorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    internal class MoneyConverter : IConvert
    {
        public string Convert(string value)
        {
            return (Double.Parse(value) * 117.18).ToString();
        }
    }
}
