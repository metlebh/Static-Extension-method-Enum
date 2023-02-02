using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_02._02._2023
{
    public static class extension
    {
        public static bool PinCheck(this string pin)
        {
            if (pin.Length==7 && pin==pin.ToUpper())
            {
                return true;
            }
            return false; 

        }
    }
}
