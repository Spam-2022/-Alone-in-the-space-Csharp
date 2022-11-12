using System;
using System.Numerics;
using OOP_Stratu.Model;
using OOP_Stratu.Model.Entities;
using OOP_Stratu.Utilities;

namespace OOP_Stratu.Controller
{
    public class PlayerShipController : IPlayerShipController
    {
        private int exp;
        private int currentLevel;
        private PlayerGun playerGun;
        private PlayerShip playerShip;

        public PlayerShipController() 
        {
            this.exp = 0;
            this.currentLevel = 1;

            this.playerGun = new PlayerGun(
            PlayerValues.BulletDamage,
            PlayerValues.BulletAcceleration,
            PlayerValues.BulletMaxSpeed);

            this.playerShip = new PlayerShip(
                new Vector2(100, 100),
                PlayerValues.MaxHealth,
                PlayerValues.MaxSpeed,
                PlayerValues.RotationSpeed,
                this.playerGun);
        }
        public PlayerShipController(Vector2 initialPos) : this()
        {
            this.exp = 0;
            this.currentLevel = 1;

            this.playerGun = new PlayerGun(
            PlayerValues.BulletDamage,
            PlayerValues.BulletAcceleration,
            PlayerValues.BulletMaxSpeed);

            this.playerShip = new PlayerShip(
                initialPos,
                PlayerValues.MaxHealth,
                PlayerValues.MaxSpeed,
                PlayerValues.RotationSpeed,
                this.playerGun);
        }

        /// <summary>
        /// Rotates the PlayerShip based on Input
        /// </summary>
        /// <param name="input">User input</param>
        private void Rotate(Input input)
        {
            this.playerShip.Rotate(input);
        }
        /// <summary>
        /// Moves the PlayerShip based on Input
        /// </summary>
        /// <param name="input">User input</param>
        private void Thrust(Input input)
        {
            this.playerShip.Thrust(input);
        }


        public void Move(long deltaTime, Input input)
        {
            if (input != Input.UP || input != Input.DOWN)
                this.PlayerShip.ThrustReleased();
            else
                this.Thrust(input);
            this.Rotate(input);
            this.PlayerShip.Move(deltaTime);
        }

        public int Exp
        { 
            get => exp; 
            set
            {
                if (this.CheckLevelUp(value))
                {
                    this.LevelUp();
                    exp = value - PlayerValues.NextLevelUp(this.currentLevel);
                }
            } 
        }
        public int CurrentLevel { get => currentLevel; set => currentLevel = value; }
        public PlayerShip PlayerShip { get => playerShip; }

        public void AddExp(int expValue)
        {
            this.Exp += expValue;
        }

        /// <summary>
        /// Levels up the Player and changes the stats of PlayerShip based on the new Level
        /// </summary>
        private void LevelUp()
        {
            this.CurrentLevel++;

            this.playerShip.MaxHealth += this.playerShip.MaxHealth * 5 / 100;
            this.playerShip.Health = this.playerShip.MaxHealth;

            if (this.currentLevel % 5 == 0)
            {
                this.playerGun.Damage += this.playerGun.Damage * 5 / 100;
                this.playerShip.Gun = this.playerGun;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expValue"></param>
        /// <returns></returns>
        private bool CheckLevelUp(int expValue)
        {
            return expValue > PlayerValues.NextLevelUp(this.currentLevel);
        }

        public IBullet Shot()
        {
            return this.PlayerShip.Shot();
        }
    }
}