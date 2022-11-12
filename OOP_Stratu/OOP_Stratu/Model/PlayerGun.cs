using OOP_Stratu.Model.Entities;
using System;

namespace OOP_Stratu.Model
{
    public class PlayerGun : IGun
    {
        public PlayerGun(int damage,
                         int acceleration,
                         float maxSpeed)
        {
            this.damage = damage;
            this.acceleration = acceleration;   
            this.maxSpeed = maxSpeed;   
        }

        private int damage;
        private int acceleration;
        private float maxSpeed;

        public int Damage { get => this.damage; set => damage = value; }


        public IBullet Shot(IShip ship)
        {
            return new PlayerBullet(this.damage, this.acceleration, this.maxSpeed, ship.Position, ship.Direction);
        }
    }
}