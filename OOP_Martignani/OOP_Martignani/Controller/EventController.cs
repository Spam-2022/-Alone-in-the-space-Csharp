using OOP_Martignani.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.Controller
{
    public interface EventController
    {
        void EndGame();

        int CheckPoints();

        int CheckLifePoints();

        HUDInterface GetHUDImpl();

        bool CheckGameStatus();
    }
}
