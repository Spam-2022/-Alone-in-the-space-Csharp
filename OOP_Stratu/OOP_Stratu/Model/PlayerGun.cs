using OOP_Stratu.Model.Entities;
using System;

namespace OOP_Stratu.Model
{
    public class PlayerGun : IGun
    {
        public PlayerGun(int damage, int acceleration, float maxSpeed, IShip ship)
        {
            this.damage = damage;
            this.acceleration = acceleration;   
            this.maxSpeed = maxSpeed;   
            this.ship = ship;
        }

        private int damage;
        private int acceleration;
        private float maxSpeed;
        private IShip ship;

        public int Damage { get => this.damage; set => damage = value; }


        public IBullet Shot()
        {
            return new PlayerBullet(this.damage, this.acceleration, this.maxSpeed, ship.Position, ship.Direction);
        }
    }
}