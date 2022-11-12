using System;
using System.Numerics;
using OOP_Stratu.Utilities;

namespace OOP_Stratu.Model.Entities
{
    public class PlayerShip : IShip
    {
        public PlayerShip(Vector2 initialPos,
                          int maxHealth,
                          float maxSpeed,
                          int rotationSpeed,
                          IGun gun)
        {
            this.Position = initialPos;
            this.Direction = initialPos;
            this.maxHealth = maxHealth;
            this.health = this.maxHealth;
            this.maxSpeed = maxSpeed;
            this.rotationSpeed = rotationSpeed;
            this.playerGun = gun;
        }

        private const float DirectionMul = 1.01f;
        private int maxHealth;
        private int health;
        private IGun playerGun;
        private Vector2 position;
        private double rotation;
        private float speed = 0;
        private int rotationSpeed;
        private int angle = 1;
        private float maxSpeed;
        private int acceleration;
        private bool isAlive = true;
        private Vector2 direction;

        public IGun Gun { set => playerGun = value; }
        public Vector2 Position
        {
            get => position; 
            set
            {
                position = value;
                float newX = (float)(speed * Math.Cos((Math.PI / 180) * this.angle));
                float newY = (float)(speed * Math.Sin((Math.PI / 180) * this.angle));

                this.direction = Vector2.Add(this.position, new Vector2(newX * DirectionMul, newY * DirectionMul));
            }
        }
        public Vector2 Direction { get => direction; set => direction = value; }

        public double Rotation => rotation;

        public bool IsAlive => isAlive;

        /// <summary>
        /// Current Health of the Player
        /// </summary>
        public int Health { get => health; set => health = value; }
        
        /// <summary>
        /// Current Max Health of the Player
        /// </summary>
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }

        public void Destroy()
        {
            isAlive = false;
        }

        public void Hit(int damage)
        {
            this.health -= damage;
            if(this.health <= 0)
            {
                this.Destroy();
            }
        }

        public void Move(long deltaTime)
        {
            float accelerationAmount = 0.01f;
            long delta = 1_000_000L;
            float newSpeed = this.speed + this.acceleration * accelerationAmount * ((float)deltaTime) / delta;
            if(this.acceleration == 0)
            {
                newSpeed *= 0.95f;
            }
            this.ChangeSpeed(newSpeed);
            try
            {
                float newX = (float)(speed * Math.Cos((Math.PI / 180) * this.angle));
                float newY = (float)(speed * Math.Sin((Math.PI / 180) * this.angle));

                this.direction = Vector2.Add(this.direction, new Vector2(newX * DirectionMul, newY * DirectionMul));
                this.position = Vector2.Add(this.position, new Vector2(newX, newY));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        /// <summary>
        /// Change the current speed of the Ship up to its Max Speed
        /// </summary>
        /// <param name="newSpeed">New speed value to change to</param>
        private void ChangeSpeed(float newSpeed)
        {
            if (newSpeed >= maxSpeed)
                this.speed = maxSpeed;
            else if (newSpeed <= -maxSpeed)
                this.speed = -maxSpeed;
            else
                this.speed = newSpeed;
        }

        /// <summary>
        /// Direction of the movement (Forward or Backwards)
        /// </summary>
        /// <param name="input">User input</param>
        public void Thrust(Input input)
        {
            switch (input)
            {
                case Input.UP:
                    acceleration = 1;
                    break;
                case Input.DOWN:
                    acceleration = -1;
                    break;
            }
        }

        /// <summary>
        /// Direction in which to rotate the Ship (Left or Right)
        /// </summary>
        /// <param name="input">User input</param>
        public void Rotate(Input input)
        {
            int rotationDirection = 0;
            switch (input) 
            {
                case Input.LEFT:
                    rotationDirection = -1;
                    break;

                case Input.RIGHT:
                    rotationDirection = 1; 
                    break;
            }
            this.rotation = (this.Rotation + this.rotationSpeed * rotationDirection) % 360;

            float newX = (float)(speed * Math.Cos((Math.PI / 180) * this.angle));
            float newY = (float)(speed * Math.Sin((Math.PI / 180) * this.angle));

            this.direction = Vector2.Add(this.position, new Vector2(newX * DirectionMul, newY * DirectionMul));
        }

        /// <summary>
        /// If the Player lets go of UP or DOWN it will stop accelerating and slow down
        /// </summary>
        public void ThrustReleased()
        {
            this.acceleration = 0;
        }

        public IBullet Shot()
        {
            return this.playerGun.Shot(this);
        }
    }
}