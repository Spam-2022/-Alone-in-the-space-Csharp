using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Martignani.Model
{
    public class HUDLifeImpl : HUDLife
    {
        /// <summary>
        /// Variables.
        /// </summary>
        private readonly int MAXHEALTH = 100;
        private readonly int ZERO = 0;

        private int lifePoints;
        private bool gameStatus;

        /// <summary>
        /// Constructor.
        /// </summary>
        public HUDLifeImpl()
        {
            this.lifePoints = MAXHEALTH;
            this.gameStatus = true;
        }

        public bool GetGameStatus()
        {
            Console.WriteLine("Game Status now is {0}", this.gameStatus);
            return this.gameStatus;
        }

        public int GetLifePoints()
        {
            return this.lifePoints;
        }

        public void update(int lifePoints)
        {
            this.lifePoints = lifePoints;
            Console.WriteLine("Life Points: {0}", this.GetLifePoints());
            if (this.lifePoints <= ZERO)
            {
                this.gameStatus = false;
            }
        }
    }
}
