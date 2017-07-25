using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public  class RoverMovement:IBackwardMovement,IForwardMovement,ILeftMovement,IRightMovement
    {
        public bool Rover_is_moving_backward(int x,int y,int n,int m)
        {
            if (y ==0)
            {
                return true;
            }
            else
            {
                RoverMoved rover = new RoverMoved();
                return (rover.Rover_moved_backward(y));
            }
            
        }
        public bool Rover_is_moving_forward(int x,int y,int n,int m)
        {
            if (y == m - 1)
            {
                return true;
            }
            else
            {
                RoverMoved rover = new RoverMoved();
                return (rover.Rover_moved_forward(x));
            }
        }
        public bool Rover_is_moving_left(int x,int y,int n,int m)
        {
            if(x==0)
            {
                return true;
            }
            else
            {
                RoverMoved rover = new RoverMoved();
                return (rover.Rover_moved_left(x));
            }
        }
        public bool Rover_is_moving_right(int x,int y,int n,int m)
        {
            if (x == n - 1)
            {
                return true;
            }
            else
            {
                RoverMoved rover = new RoverMoved();
                return (rover.Rover_moved_right(x));
            }
        }
    }
}
