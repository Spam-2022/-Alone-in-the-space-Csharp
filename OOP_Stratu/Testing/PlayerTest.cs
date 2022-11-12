using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Stratu.Controller;
using OOP_Stratu.Model;
using OOP_Stratu.Model.Entities;
using OOP_Stratu.Utilities;


namespace Testing
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void TestPlayerMovement()
        {
            //Test initialise
            Vector2 initialPos = new Vector2(100,100);
            IPlayerShipController playerShipController = new PlayerShipController(initialPos);
            IPlayerShipController playerShipController1 = new PlayerShipController(initialPos);
            Assert.IsTrue(playerShipController.PlayerShip.Position == initialPos);
            Assert.IsTrue(playerShipController1.PlayerShip.Position == initialPos);

            //Test movement
            playerShipController.Move(100_000_000L, Input.UP);
            Assert.IsFalse(playerShipController.PlayerShip.Position == initialPos);

            //Test initialise with two PlayerShips
            playerShipController = new PlayerShipController(initialPos);
            playerShipController1= new PlayerShipController(initialPos);
            Assert.IsTrue(playerShipController.PlayerShip.Position == playerShipController1.PlayerShip.Position);

            //Test normal movement accuracy
            playerShipController.Move(100_000_000L, Input.UP);
            playerShipController1.Move(100_000_000L, Input.UP);
            Assert.IsTrue(playerShipController.PlayerShip.Position == playerShipController1.PlayerShip.Position);

            //Test rotation and movement vs no rotation
            playerShipController.Move(100_000_000L, Input.LEFT);
            playerShipController.Move(1_000_000L, Input.UP);
            playerShipController1.Move(1_000_000L, Input.UP);
            Assert.IsFalse(playerShipController.PlayerShip.Position == playerShipController1.PlayerShip.Position);

            //Test Bullet firing
            IBullet bullet = playerShipController.Shot();
            Assert.IsNotNull(bullet);

            //Test Bullet movement
            Vector2 currentBulletPos = bullet.Position;
            bullet.Move(100_000_000L);
            Assert.IsFalse(currentBulletPos == bullet.Position);

            //Test Bullet hitting another Ship and HP loss
            int currentHP = playerShipController1.PlayerShip.Health;
            bullet.Hit(playerShipController1.PlayerShip);
            Assert.IsFalse(bullet.IsAlive);
            Assert.IsFalse(currentHP == playerShipController1.PlayerShip.Health);

            //Test Ship destroying
            for (int i = 0; i < 9; i++)
            {
                bullet = playerShipController.Shot();
                bullet.Hit(playerShipController1.PlayerShip);
            }

            Assert.IsFalse(playerShipController1.PlayerShip.IsAlive);


        }

        [TestMethod]
        public void TestEXP()
        {
            //Test EXP
            Vector2 initialPos = new Vector2(100, 100);
            IPlayerShipController playerShipController = new PlayerShipController(initialPos);
            int currentExp = playerShipController.Exp;
            int currentLevel = playerShipController.CurrentLevel;

            playerShipController.AddExp(5);

            Assert.IsFalse(currentExp == playerShipController.Exp);
            Assert.IsTrue(currentLevel == playerShipController.CurrentLevel);

            //Test Level Up
            int currentMaxHealth = playerShipController.PlayerShip.MaxHealth;
            playerShipController.Exp = PlayerValues.NextLevelUp(currentLevel);
            Assert.IsFalse(currentLevel == playerShipController.CurrentLevel);
            Assert.IsFalse(currentMaxHealth == playerShipController.PlayerShip.MaxHealth);

            //Test Gun Damage change
            int damage = playerShipController.PlayerShip.Gun.Damage;
            for (int i = 0; i < 5; i++)
            {
                playerShipController.Exp = PlayerValues.NextLevelUp(playerShipController.CurrentLevel);
            }
            Console.WriteLine(playerShipController.CurrentLevel.ToString());
            Assert.IsFalse(playerShipController.PlayerShip.Gun.Damage == damage);    
        }
    }
}