using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TaturinAM.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string numberString = k.ToString();
            int length = numberString.Length;

            if (length < 3)
            {
                throw new ArgumentException("Число должно быть не меньше трехзначного");
            }

            return int.Parse(numberString[length - 3].ToString());
        }
    }
}
