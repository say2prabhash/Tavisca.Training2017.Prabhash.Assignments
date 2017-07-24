using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Validation
    {
        public static bool ValidatePhoneNumber(string mobilenumber) //This method validates the mobile number entered by the user and returns a boolean value.
        {
            if(mobilenumber.Length==10)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
