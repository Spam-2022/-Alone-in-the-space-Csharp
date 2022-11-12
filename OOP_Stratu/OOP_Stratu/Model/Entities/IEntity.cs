using System;
using System.Numerics;

namespace OOP_Stratu.Model.Entities
{
    ///<summary>
    ///The main class to represent all moving objects in the game
    ///</summary>
    public interface IEntity
    {
        ///<summary>
        ///</summary>
        public void Move(long deltaTime);

        ///<summary>
        ///</summary>
        public void Destroy();

        ///<summary>
        ///</summary>
        public Vector2 Position { get; set; }

        ///<summary>
        ///</summary>
        public double Rotation { get; }

        ///<summary>
        ///</summary>
        public bool IsAlive { get; }

    }
}