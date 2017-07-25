using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    interface IRoverMoved
    {
        bool Rover_moved_backward(int y);
        bool Rover_moved_forward(int y);
        bool Rover_moved_left(int x);
        bool Rover_moved_right(int x);
    }
}
