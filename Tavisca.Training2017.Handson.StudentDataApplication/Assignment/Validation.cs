using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Validation
    {
        public bool ValidatePhoneNumber(string mobilenumber)
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
