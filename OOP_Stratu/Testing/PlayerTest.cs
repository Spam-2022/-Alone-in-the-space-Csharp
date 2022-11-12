using System;
using System.Numerics;
using OOP_Stratu.Controller;
using OOP_Stratu.Model;


namespace Testing
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void TestPlayer()
        {
            Vector2 initialPos = new Vector2(100,100);
            IPlayerShipController playerShipController = new PlayerShipController(initialPos);
            Assert.IsTrue(playerShipController.PlayerShip.Position == initialPos);

        }
    }
}