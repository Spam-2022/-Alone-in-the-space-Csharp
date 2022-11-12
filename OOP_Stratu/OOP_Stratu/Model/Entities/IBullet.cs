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
        
    }
}