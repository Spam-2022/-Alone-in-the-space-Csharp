using System;
using System.Numerics;

namespace OOP_Stratu.Model.Entities
{
    public class PlayerBullet : IBullet
    {
        public PlayerBullet(int damage, int acceleration, int maxSpeed, Vector2 position, Vector2 direction)
        {
            this.damage = damage;
            this.acceleration = acceleration;
            this.Position = position;
            this.Direction = direction;
        }

        private int damage;
        private int acceleration;
        private Vector2 position;
        private Vector2 direction;

        public int Damage { get => this.damage; set => this.damage = value; }
        public Vector2 Position { get => this.position; set => this.position = value; }
        public Vector2 Direction { get => this.direction; private set => direction = value; }

        public double Rotation => throw new NotImplementedException();

        public bool IsAlive => throw new NotImplementedException();

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Move(long deltaTime)
        {
            throw new NotImplementedException();
        }
    }
}