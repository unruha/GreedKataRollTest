using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreedKata.Models;
using System;

namespace RollTest
{
    [TestClass]
    public class RollTests
    {
        // output a random role and its score
        [TestMethod]
        public void testRandomAndScoreCalc()
        {
            Roll roll = new Roll();

            roll.rollDiceRandom();
            roll.outputDiceValues();

            Console.WriteLine();

            roll.calculateScore();
            roll.displayScore();
        }

        // tests for different roll number combinations
        [TestMethod]
        public void testNums1()
        { 
            Roll roll = new Roll();

            int[] rollNums = new int[] { 1, 1, 1, 5, 1 };
            roll.setDiceNumbers(rollNums);
            roll.calculateScore();

            int expected = 1150;
            int actual = roll.getScore();

            Assert.AreEqual(expected, actual, "test 1 score calculation incorrect");
        }

        [TestMethod]
        public void testNums2()
        {
            Roll roll = new Roll();

            int[] rollNums = new int[] { 2, 3, 4, 6, 2 };
            roll.setDiceNumbers(rollNums);
            roll.calculateScore();

            int expected = 0;
            int actual = roll.getScore();

            Assert.AreEqual(expected, actual, "test 1 score calculation incorrect");
        }

        [TestMethod]
        public void testNums3()
        {
            Roll roll = new Roll();

            int[] rollNums = new int[] { 3, 4, 5, 3, 3 };
            roll.setDiceNumbers(rollNums);
            roll.calculateScore();

            int expected = 350;
            int actual = roll.getScore();

            Assert.AreEqual(expected, actual, "test 1 score calculation incorrect");
        }

        [TestMethod]
        public void testNums4()
        {
            Roll roll = new Roll();

            int[] rollNums = new int[] { 1, 5, 1, 2, 4 };
            roll.setDiceNumbers(rollNums);
            roll.calculateScore();

            int expected = 250;
            int actual = roll.getScore();

            Assert.AreEqual(expected, actual, "test 1 score calculation incorrect");
        }

        [TestMethod]
        public void testNums5()
        {
            Roll roll = new Roll();

            int[] rollNums = new int[] { 5, 5, 5, 5, 5 };
            roll.setDiceNumbers(rollNums);
            roll.calculateScore();

            int expected = 600;
            int actual = roll.getScore();

            Assert.AreEqual(expected, actual, "test 1 score calculation incorrect");
        }
    }
}
