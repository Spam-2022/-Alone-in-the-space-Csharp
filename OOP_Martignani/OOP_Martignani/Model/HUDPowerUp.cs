using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.Model
{
    /// <summary>
    /// PowerUp HUD interface.
    /// </summary>
    public interface HUDPowerUp
    {
        /// <summary>
        /// powerUp.
        /// </summary>
        /// <returns> powerUp </returns>
        string GetPowerUp();

        /// <summary>
        /// Show the powerUp.
        /// </summary>
        void ShowPowerUp();

        /// <summary>
        /// Hide the powerUp.
        /// </summary>
        void HidePowerUp();

        /// <summary>
        /// Show if the powerUp is active or not.
        /// </summary>
        /// <returns> true if powerUp is active </returns>
        bool GetStatus();
    }
}
