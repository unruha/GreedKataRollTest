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

    }
}
