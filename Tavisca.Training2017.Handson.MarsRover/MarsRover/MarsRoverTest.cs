using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MarsRover
{
   
    class MarsRoverTest
    {

        [Fact]
        public void Rover_is_moving_backward_test()
        {
            RoverMovement rover = new RoverMovement();
            Assert.Equal(true, rover.Rover_is_moving_backward(0, 0));
        }
    }
}
