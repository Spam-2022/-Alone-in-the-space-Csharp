using System;

namespace OOP_Stratu.Utilities
{
    public static class PlayerValues
    {
        //SHIP VALUES
        private const int maxHealth = 100;
        private const float maxSpeed = 3;
        private const int rotationSpeed = 2;

        /// <summary>
        /// How much Max Health the Player has
        /// </summary>
        public static int MaxHealth { get { return maxHealth; } }

        /// <summary>
        /// How fast the Player can travel
        /// </summary>
        public static float MaxSpeed { get { return maxSpeed; } }
        
        /// <summary>
        /// How fast the Player can rotate on its pivot
        /// </summary>
        public static int RotationSpeed { get { return rotationSpeed; } }

        //GUN VALUES
        private const int bulletDamage = 10;
        private const float bulletMaxSpeed = 5;
        private const int bulletAcceleration = 2;

        /// <summary>
        /// How much Damage the Bullet should do
        /// </summary>
        public static int BulletDamage { get { return bulletDamage; } }
        /// <summary>
        /// How fast a Bullet can travel
        /// </summary>
        public static float BulletMaxSpeed { get { return bulletMaxSpeed; } }
        /// <summary>
        /// How fast a Bullet can reach its Max Speed
        /// </summary>
        public static int BulletAcceleration { get { return bulletAcceleration; } }

        //LEVEL
        private const int expRequired = 10;
       
        /// <summary>
        /// Required Experience to level up based on current level
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public static int NextLevelUp(int level)
        {
            return (int)(expRequired * Math.Pow(2, level)) + 1; 
        }

    }
}