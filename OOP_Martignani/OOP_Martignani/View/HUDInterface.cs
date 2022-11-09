using OOP_Martignani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.View
{
    /// <summary>
    /// HUD view interface linked to the controller.
    /// </summary>
    public interface HUDInterface
    {
        /// <summary>
        /// Check the value of the points.
        /// </summary>
        /// <returns> points value </returns>
        int CheckPoints();

        /// <summary>
        /// Checks the value of the life points.
        /// </summary>
        /// <returns> value of the life points </returns>
        int CheckLifePoints();

        /// <summary>
        /// Checks if game status is true.
        /// </summary>
        /// <returns> gameStatus value </returns>
        bool CheckGameStatus();

        /// <summary>
        /// PowerUp HUD reference.
        /// </summary>
        /// <returns> powerUp hud reference </returns>
        HUDPowerUp GetPowerUpImpl();

        /// <summary>
        /// Life HUD reference.
        /// </summary>
        /// <returns> life hud reference </returns>
        HUDLife GetLifeImpl();

        /// <summary>
        /// Points HUD reference.
        /// </summary>
        /// <returns> points hud reference </returns>
        HUDPoints GetPointsImpl();
    }
}
