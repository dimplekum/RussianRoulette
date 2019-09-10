using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_Game_Won()
        {
            // Arrange
            var log = new Logic();

            // Act
            var actual = log.GetIfPlayerWon();

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Check_Score()
        {
            // Arrange
            var log = new Logic();

            // Act
            var actual = log.GetTheScore();

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Check_Game_Over()
        {
            // Arrange
            var log = new Logic();

            // Act
            var actual = log.GetIsGameOver();

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Check_Available_Bullets()
        {
            // Arrange
            var log = new Logic();

            // Act
            var actual = log.GetTheAvailableBullets();

            // Assert
            Assert.AreEqual(0, actual);
        }


    }
}
