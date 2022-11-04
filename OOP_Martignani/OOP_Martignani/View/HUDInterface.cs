using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.View
{
    public interface HUDInterface
    {
        int CheckPoints();

        int CheckLifePoints();

        bool CheckGameStatus();

        HUDPowerUp GetPowerUpImpl();

        HUDLife GetLifeImpl();

        HUDPoints GetPointsImpl();
    }
}
