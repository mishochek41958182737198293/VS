using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EatIsHouseLibTests
{
    [TestClass]
    public class FindPriceTest
    {
        [TestMethod]
        public void FindPriceInLineTest()
        {
            // arrange
            string findLine = "Пицца Пепперони 500г / 450₽";
            double expected = 450;

            //act
            double actual = EatIsHouseLib.FindPrice.FindPriceInLine(findLine);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
