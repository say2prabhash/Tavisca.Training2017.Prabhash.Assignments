using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using MarsRover;

namespace MarsRoverTest
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void Rover_is_at_the_left_corner()
        {
            RoverMovement rover = new RoverMovement();
                Xunit.Assert.Equal(true,rover.Rover_is_moving_backward(0,0));
           
        }
    }
}
