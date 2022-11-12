using OOP_Stratu.Model.Entities;
using System;

namespace OOP_Stratu.Model
{
    /// <summary>
    /// The Gun of the Ship that fires Bullets
    /// </summary>
    public interface IGun
    {
        /// <summary>
        /// Shoots a Bullet out of the Gun using the Ship position and direction
        /// </summary>
        /// <param name="ship">The Ship it's being fired from</param>
        /// <returns>The Bullet Shot</returns>
        IBullet Shot(IShip ship);

        /// <summary>
        /// How much Damage should the Bullet do
        /// </summary>
        int Damage { get; set; }    
    }
}