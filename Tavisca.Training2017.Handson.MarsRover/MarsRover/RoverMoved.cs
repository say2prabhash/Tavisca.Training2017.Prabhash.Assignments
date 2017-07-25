using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public  class RoverMoved:IRoverMoved
    {
        public bool Rover_moved_backward(int y)
        {
            
            y--;
            return true;
        }
        public bool Rover_moved_forward(int y)
        {
           
            y++;
            return true;
        }
        public bool Rover_moved_left(int x)
        {
            x--;

            return true;
        }
        public bool Rover_moved_right(int x)
        {
            x++;
            return true;
        }
    }
}
