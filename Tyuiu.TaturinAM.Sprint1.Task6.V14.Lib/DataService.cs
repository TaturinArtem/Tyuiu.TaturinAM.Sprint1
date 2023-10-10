using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TaturinAM.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLower(c) || !IsRussianLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsRussianLetter(char c)
        {
            return c >= 'а' && c <= 'я';
        }
    }
}

        
    

