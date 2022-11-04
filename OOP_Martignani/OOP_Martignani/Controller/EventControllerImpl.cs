using OOP_Martignani.Model;
using OOP_Martignani.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.Controller
{
    public class EventControllerImpl : EventController
    {
        private HUDImpl hudBuilder;

        public EventControllerImpl()
        {
            this.hudBuilder = new HUDImpl();
        }

        public bool CheckGameStatus()
        {
            return this.hudBuilder.CheckGameStatus();
        }

        public int CheckLifePoints()
        {
            return this.hudBuilder.CheckLifePoints();
        }

        public int CheckPoints()
        {
            return this.hudBuilder.CheckPoints();
        }

        public void EndGame()
        {
            Console.WriteLine("Game ends...");
        }

        public HUDInterface GetHUDImpl()
        {
            return this.hudBuilder;
        }

        public HUDPowerUp GetPowerUp()
        {
            return this.hudBuilder.GetPowerUpImpl();
        }
    }
}
