using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreedKata.Models;

namespace RollTest
{
    [TestClass]
    public class RollTests
    {
        [TestMethod]
        public void testRollDiceRandom()
        {
            Roll roll = new Roll();
            roll.rollDiceRandom();
        }
    }
}
