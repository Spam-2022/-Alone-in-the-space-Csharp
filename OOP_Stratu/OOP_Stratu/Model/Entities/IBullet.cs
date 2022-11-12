using System;

namespace OOP_Stratu.Model.Entities
{
    /// <summary>
    /// The Bullet Entity which travels and hits other Ships
    /// </summary>
    public interface IBullet : IEntity
    {
        /// <summary>
        /// How much Damage the Bullet should do
        /// </summary>
        public int Damage { get; set; }

        /// <summary>
        /// Hits a Ship and deals its damage
        /// </summary>
        /// <param name="ship">The Ship that it collides with</param>
        void Hit(IShip ship);
        
    }
}