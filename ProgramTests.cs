using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetSquareMinusOne()
        {
            //arrange
            var a = 0;
            var b = 1;
            var c = 2;
            //act
            double result = Program.GetSquare(a,b,c);
            double expected = -1;
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetSquareSixDouble()
        {
            //arrange
            var a = 3.0;
            var b = 4.0;
            var c = 5.0;
            //act
            double result = Program.GetSquare(a, b, c);
            double expected = 6;
            //assert
            Assert.AreEqual(expected, result); 
        }

        [TestMethod()]
        public void GetSquareSixFloat()
        {
            //arrange
            var a = 3.0f;
            var b = 4.0f;
            var c = 5.0f;
            //act
            double result = Program.GetSquare(a, b, c);
            double expected = 6;
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetSquareSixInt()
        {
            //arrange
            var a = 3;
            var b = 4;
            var c = 5;
            //act
            double result = Program.GetSquare(a, b, c);
            double expected = 6;
            //assert
            Assert.AreEqual(expected, result);
        }

    }
}