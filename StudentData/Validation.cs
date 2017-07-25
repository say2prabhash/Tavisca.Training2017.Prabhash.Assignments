using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class Validation
    {
        private int[] rollnumberdata = {1234,4567,6789,7890};
        public bool ValidateRollNumber(int rollnumber)
        {
            string check = rollnumber.ToString();
            bool flag = false;
            if (check.Length == 4)
            {
                flag = true;
            }
            if (flag == true)
            {
                for (int i = 0; i < rollnumberdata.Length; i++)
                {
                    if (rollnumber == rollnumberdata[i])
                    {
                        return true;

                    }
                }
            }
            return false;
        }
    }
}
