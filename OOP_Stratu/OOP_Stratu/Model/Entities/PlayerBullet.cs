using System;
using System.Numerics;
using System.Reflection.Metadata;

namespace OOP_Stratu.Model.Entities
{
    public class PlayerBullet : IBullet
    {
        public PlayerBullet(int damage,
                            int acceleration,
                            float maxSpeed,
                            Vector2 position,
                            Vector2 direction)
        {
            this.damage = damage;
            this.acceleration = acceleration;
            this.maxSpeed = maxSpeed;
            this.position = position;
            this.direction = direction;
        }

        private int damage;
        private int acceleration;
        private const float DirectionMul = 1.01f;
        private float maxSpeed;
        private float speed;
        private Vector2 position;
        private Vector2 direction;
        private double rotation;
        private bool isAlive = true;

        public int Damage { get => this.damage; set => this.damage = value; }
        public Vector2 Position { get => this.position; set => this.position = value; }
        public Vector2 Direction { get => this.direction; private set => direction = value; }

        public double Rotation => rotation;

        public bool IsAlive => isAlive;

        public void Destroy()
        {
            this.isAlive = false;   
        }

        public void Hit(IShip ship)
        {
            ship.Hit(this.Damage);
            this.Destroy();
        }

        public void Move(long deltaTime)
        {
            float accelerationAmount = 0.01f;
            long delta = 1_000_000L;
            float newSpeed = this.speed + this.acceleration * accelerationAmount * ((float)deltaTime) / delta;
            this.ChangeSpeed(newSpeed);
            try
            {
                float newX = (float)(speed * Math.Cos((Math.PI / 180) * this.rotation));
                float newY = (float)(speed * Math.Sin((Math.PI / 180) * this.rotation));

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
    }
}