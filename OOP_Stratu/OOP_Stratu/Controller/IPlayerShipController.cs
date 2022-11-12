using OOP_Stratu.Model.Entities;
using OOP_Stratu.Utilities;
using System;

namespace OOP_Stratu.Controller
{
    /// <summary>
    /// It controls the PlayerShip movement and its Levels
    /// </summary>
    public interface IPlayerShipController
    {
        /// <summary>
        /// Data for Player experience
        /// </summary>
        int Exp { get; set; }
        
        /// <summary>
        /// Data for Player current level
        /// </summary>
        int CurrentLevel { get; set; }

        /// <summary>
        /// The PlayerShip itself
        /// </summary>
        PlayerShip PlayerShip { get; }

        /// <summary>
        /// Tells the PlayerShip to fire its Gun
        /// </summary>
        /// <returns>The Bullet shot</returns>
        IBullet Shot();

        /// <summary>
        /// Move the PlayerShip based on the input given and the time passed since the last tic update
        /// </summary>
        /// <param name="deltaTime">Tic update time</param>
        /// <param name="input">User input</param>
        void Move(long deltaTime, Input input);


    }
}