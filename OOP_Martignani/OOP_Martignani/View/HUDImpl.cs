using OOP_Martignani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.View
{
    /// <summary>
    /// Implementation of HUDInterface.
    /// </summary>
    public class HUDImpl : HUDInterface
    {
        private HUDPoints pointsHUD;
        private HUDLife livesHUD;
        private HUDPowerUp powerUpHUD;
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public HUDImpl()
        {
            this.CreateHUD();
        }

        /// <summary>
        /// Create all HUD model pieces.
        /// </summary>
        private void CreateHUD()
        {
            this.pointsHUD = new HUDPointsImpl();
            this.livesHUD = new HUDLifeImpl();
            this.powerUpHUD = new HUDPowerUpImpl();
        }

        public bool CheckGameStatus()
        {
            return this.livesHUD.GetGameStatus();
        }

        public int CheckLifePoints()
        {
            return this.livesHUD.GetLifePoints();
        }

        public int CheckPoints()
        {
            return this.pointsHUD.GetPoints();
        }

        public HUDLife GetLifeImpl()
        {
            return this.livesHUD;
        }

        public HUDPoints GetPointsImpl()
        {
            return this.pointsHUD;
        }

        public HUDPowerUp GetPowerUpImpl()
        {
            return this.powerUpHUD;
        }
    }
}
