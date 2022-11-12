using System;
using System.Numerics;

namespace OOP_Stratu.Model.Entities
{
    /// <summary>
    /// The Ship Entities that roam around the map and fire Bullets at others
    /// </summary>
    public interface IShip : IEntity
    {
        ///<summary>
        ///Shoots a Bullet in the direction of the Ship
        ///</summary>
        public IBullet Shot();

        ///<summary>
        ///What Gun the Ship uses
        ///</summary>
        public IGun Gun { set; }

        ///<summary>
        ///How much damage a Ship takes when being hit by a Bullet
        ///</summary>
        public void Hit(int damage);

        ///<summary>
        ///Current direction of the Ship
        ///</summary>
        public Vector2 Direction { get; set; }
    }
}