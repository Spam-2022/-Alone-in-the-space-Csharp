using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Martignani.Model;
using System;

namespace Tests
{
    [TestClass]
    public class HUDTest
    {
        /// <summary>
        /// Readonly variables.
        /// </summary>
        private readonly int ZERO = 0;
        private readonly int ONE = 1;
        private readonly int TEN = 10;
        private readonly int ONEHUNDRED = 100;

        /// <summary>
        /// Variables.
        /// </summary>
        private HUDPowerUp powerUpHUD;
        private HUDLife lifeHUD;
        private HUDPoints pointsHUD;

        [TestMethod]
        public void TestLifePointsBehaviour()
        {
            this.lifeHUD = lifeHUD = new HUDLifeImpl();

            Assert.IsTrue(this.lifeHUD.GetLifePoints() == ONEHUNDRED);
            Assert.IsTrue(this.lifeHUD.GetGameStatus());

            // Multiple hits taken, Life points goes to 1. Game status is still true.
            this.lifeHUD.update(ONE);
            Assert.IsTrue(this.lifeHUD.GetLifePoints() == ONE);
            Assert.IsTrue(this.lifeHUD.GetGameStatus());

            // The ship was repaired, the life points went up. Game status is still true.
            this.lifeHUD.update(TEN);
            Assert.IsTrue(this.lifeHUD.GetLifePoints() == TEN);
            Assert.IsTrue(this.lifeHUD.GetGameStatus());

            // The ship was destroyed, the life points are 0 and the gameStatus is now false.
            this.lifeHUD.update(ZERO);
            Assert.IsTrue(this.lifeHUD.GetLifePoints() == ZERO);
            Assert.IsFalse(this.lifeHUD.GetGameStatus());

            // End of the game.
        }

        [TestMethod]
        public void testPowerUpBehaviour()
        {
            this.powerUpHUD = new HUDPowerUpImpl();

            Assert.IsFalse(this.powerUpHUD.GetStatus());

            this.powerUpHUD.ShowPowerUp();
            Assert.IsTrue(this.powerUpHUD.GetStatus());

            this.powerUpHUD.HidePowerUp();
            Assert.IsFalse(this.powerUpHUD.GetStatus());
        }

        [TestMethod]
        public void testPointsBehaviour()
        {
            this.pointsHUD = new HUDPointsImpl();
            // At the beginning of the game, points are set to 0.
            Assert.IsTrue(this.pointsHUD.GetPoints() == ZERO);

            // Points increments after killing enemies. Your points are now: 10.
            this.pointsHUD.update(TEN);
            Assert.IsTrue(this.pointsHUD.GetPoints() == TEN);
        }
    }
}