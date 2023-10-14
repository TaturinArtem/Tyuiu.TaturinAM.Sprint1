using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TaturinAM.Sprint1.Task7.V20.Lib
{
    public class DataService : ISprint1Task7V20

    {
        public double Calculate(double x, double y)
        {
            double z = (1 + Math.Sin(Math.Sqrt(Math.Pow(x, 2) + 1))) / (Math.Cos(12 * y - 4));
            double res = Math.Round(z, 3, MidpointRounding.AwayFromZero);
            return res;
        }
    }
}
