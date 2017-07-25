using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    interface ILeftMovement
    {
        bool Rover_is_moving_left(int x, int y,int n,int m);
    }
}
