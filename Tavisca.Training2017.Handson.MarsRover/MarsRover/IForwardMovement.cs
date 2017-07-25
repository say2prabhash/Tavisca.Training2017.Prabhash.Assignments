using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    interface IForwardMovement
    {
        bool Rover_is_moving_forward(int x,int y);
    }
}
