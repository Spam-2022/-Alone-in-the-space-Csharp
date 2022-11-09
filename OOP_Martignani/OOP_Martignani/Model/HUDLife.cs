using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.Model
{
    /// <summary>
    /// Life points HUD interface.
    /// </summary>
    public interface HUDLife
    {
        /// <summary>
        /// Check actual life points.
        /// </summary>
        /// <returns> value of life points </returns>
        int GetLifePoints();

        /// <summary>
        /// Check game status.
        /// </summary>
        /// <returns> game status value </returns>
        bool GetGameStatus();

        /// <summary>
        /// Update life points value.
        /// </summary>
        /// <param name="lifePoints"></param>
        void update(int lifePoints);
    }
}
