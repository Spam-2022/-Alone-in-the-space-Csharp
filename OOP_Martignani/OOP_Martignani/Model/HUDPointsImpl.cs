using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.Model
{
    public class HUDPointsImpl : HUDPoints
    {
        /// <summary>
        /// Variables.
        /// </summary>
        private readonly int ZERO = 0;

        private int points;

        /// <summary>
        /// Constructor.
        /// </summary>
        public HUDPointsImpl()
        {
            this.points = ZERO;
        }

        public int GetPoints()
        {
            return this.points;
        }

        public void update(int points)
        {
            this.points = points;
            Console.WriteLine("Points: {0}", this.GetPoints());
        }
    }
}
