using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    class PerimeterOfRectangle
    {
        public void RectanglePerimeter(InputDimensions inputdimensions)
        {
            int[] dimensions = inputdimensions.GetDimensions();
            int perimeter = 2*(dimensions[0] + dimensions[1]);
            DisplayMessage displayresult = new DisplayMessage();
            displayresult.DisplayPerimeterOfRectangle(perimeter);
        }
    }
}
