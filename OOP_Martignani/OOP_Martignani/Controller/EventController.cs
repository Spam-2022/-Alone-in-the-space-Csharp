using OOP_Martignani.Model;
using OOP_Martignani.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.Controller
{
    /// <summary>
    /// I implemented the behaviour of this class partially.
    /// </summary>
    public interface EventController
    {
        /// <summary>
        /// Ends the game.
        /// </summary>
        void EndGame();

        /// <summary>
        /// Check the value of the points.
        /// </summary>
        /// <returns> points value </returns>
        int CheckPoints();

        /// <summary>
        /// Check the remaining life points
        /// </summary>
        /// <returns> life points value </returns>
        int CheckLifePoints();

        /// <summary>
        /// HUDImpl reference
        /// </summary>
        /// <returns> hudimpl reference </returns>
        HUDInterface GetHUDImpl();

        /// <summary>
        /// Check if game status is true
        /// </summary>
        /// <returns> gameStatus value </returns>
        bool CheckGameStatus();

        /// <summary>
        /// HUDPowerUp reference
        /// </summary>
        /// <returns> powerUp hud reference </returns>
        HUDPowerUp GetPowerUp();
    }
}
