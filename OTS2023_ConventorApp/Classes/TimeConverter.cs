using OTS2023_ConventorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    internal class TimeConverter : ITimeConvert
    {
        public double ConvertHours(double days)
        {
            return days * 24;
        }

        public double ConvertMinutes(double days)
        {
            return days * 24 * 60;
        }

        public double ConvertSeconds(double days)
        {
            const int secondsInMinute = 60;
            const int minutesInHour = 60;
            const int hoursInDay = 24;

            return days * hoursInDay * minutesInHour * secondsInMinute;
        }
    }
}
