using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExPattern
{
    public class Patterns
    {

        public void ValidatePinCode(string pincode)
        {
            var regex = new Regex("^[1-9][0-9]{5}$");
            bool matchRes = regex.IsMatch(pincode);
            if (matchRes == true)
            {
                Console.WriteLine($"\n{pincode} Matches");
            }
            else
            {
                Console.WriteLine($"\n{pincode} does not match");
            }
        }
    }
}
