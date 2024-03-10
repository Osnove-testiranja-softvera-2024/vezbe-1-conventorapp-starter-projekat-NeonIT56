using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Interfaces
{
    public interface ITimeConvert
    {
        double ConvertHours(double days);
        double ConvertMinutes(double days);
        double ConvertSeconds(double days);
    }
}
