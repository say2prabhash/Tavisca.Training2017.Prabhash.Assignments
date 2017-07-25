using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MarsRover.Tests
{
    [TestClass()]
    public class MarsRoverTestTests
    {
        [TestMethod]
        public void Rover_is_moving_backward_Test()
        {
            RoverMovement rover = new RoverMovement();
            Assert.AreEqual(true, rover.Rover_is_moving_backward(0, 0,5,5));
        }
        [TestMethod]
        public void Rover_is_moving_forward_Test()
        {
            RoverMovement rover = new RoverMovement();
            Assert.AreEqual(true, rover.Rover_is_moving_forward(0, 4, 5, 5));
        }
        [TestMethod]
        public void Rover_is_moving_left_Test()
        {
            RoverMovement rover = new RoverMovement();
            Assert.AreEqual(true, rover.Rover_is_moving_left(0, 2, 5, 5));
        }
        [TestMethod]
        public void Rover_is_moving_right_Test()
        {
            RoverMovement rover = new RoverMovement();
            Assert.AreEqual(true, rover.Rover_is_moving_right(4, 0, 5, 5));
        }
        [TestMethod]
        public void Rover_moved_backward_Test()
        {
            RoverMoved rover = new RoverMoved();
            Assert.AreEqual(true, rover.Rover_moved_backward(1));
        }
        [TestMethod]
        public void Rover_moved_forward_Test()
        {
            RoverMoved rover = new RoverMoved();
            Assert.AreEqual(true, rover.Rover_moved_forward(1));
        }
        [TestMethod]
        public void Rover_moved_left_Test()
        {
            RoverMoved rover = new RoverMoved();
            Assert.AreEqual(true, rover.Rover_moved_left(1));
        }
        [TestMethod]
        public void Rover_moved_right_Test()
        {
            RoverMoved rover = new RoverMoved();
            Assert.AreEqual(true, rover.Rover_moved_right(1));
        }
    }
}