using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            InputDimensions inputdimensions = new InputDimensions(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
            AreaofRectangle areaofrectangle = new AreaofRectangle();
            areaofrectangle.RectangleArea(inputdimensions);
            PerimeterOfRectangle perimeterofrectangle = new PerimeterOfRectangle();
            perimeterofrectangle.RectanglePerimeter(inputdimensions);
        }
    }
}
