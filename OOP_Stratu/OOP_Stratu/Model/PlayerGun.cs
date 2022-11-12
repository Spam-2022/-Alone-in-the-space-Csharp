using OOP_Stratu.Model.Entities;
using System;

namespace OOP_Stratu.Model
{
    public class PlayerGun : IGun
    {
        public PlayerGun()
        {

        }

        public int damage;

        public int Damage { get => this.damage; set => damage = value; }


        public IBullet Shot()
        {
            return new PlayerBullet();
        }
    }
}