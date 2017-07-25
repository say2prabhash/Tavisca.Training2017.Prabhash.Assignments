using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    class AreaofRectangle
    {
        public void RectangleArea(InputDimensions inputdimensions)
        {
            int[] dimensions = inputdimensions.GetDimensions();
            int area = (dimensions[0] * dimensions[1]);
            DisplayMessage displayresult = new DisplayMessage();
            displayresult.DisplayAreaOfRectangle(area);
        }
    }
}
