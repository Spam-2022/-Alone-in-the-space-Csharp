using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.Model
{
    /// <summary>
    /// HUD powerUp implementation.
    /// </summary>
    public class HUDPowerUpImpl : HUDPowerUp
    {
        /// <summary>
        /// Variables.
        /// </summary>
        private bool statusMonitor;
        private string powerUp;

        public HUDPowerUpImpl()
        {
            this.powerUp = "WeaponDamage";
        }

        public string GetPowerUp()
        {
            return this.powerUp;
        }

        public bool GetStatus()
        {
            return this.statusMonitor;
        }

        public void HidePowerUp()
        {
            if (this.GetStatus() != false)
            {
                this.statusMonitor = false;
            }
        }

        public void ShowPowerUp()
        {
            if (this.GetStatus() != true)
            {
                this.statusMonitor = true;
            }
        }
    }
}
