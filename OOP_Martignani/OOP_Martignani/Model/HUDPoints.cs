using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.Model
{
    /// <summary>
    /// Points HUD interface.
    /// </summary>
    public interface HUDPoints
    {
        /// <summary>
        /// Checks actual points.
        /// </summary>
        /// <returns>current amount of points</returns>
        int GetPoints();

        /// <summary>
        /// Update points.
        /// </summary>
        /// <param name="points"></param>
        void update(int points);
    }
}
