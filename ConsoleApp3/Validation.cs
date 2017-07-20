using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    class Validation
    {
        private int []zipdata={411027,422214,411033,411115};
        public bool ValidateZipCode(int zipcode)
        {
            string check = zipcode.ToString();
            bool flag = false;
            if(check.Length==6)
            {
                flag = true;
            }
            if (flag == true)
            {
                for (int i = 0; i < zipdata.Length; i++)
                {
                    if (zipcode ==zipdata[i])
                    {
                        return true;
                        
                    }
            }
            }
            return false;
        }
    }
}
