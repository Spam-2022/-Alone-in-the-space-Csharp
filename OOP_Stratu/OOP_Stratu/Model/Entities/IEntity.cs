using System;
using System.Numerics;

namespace OOP_Stratu.Model.Entities
{
    ///<summary>
    ///The main class to represent all moving Objects in the game
    ///</summary>
    public interface IEntity
    {
        ///<summary>
        ///Moves the Entity based on the tic update time
        ///</summary>
        public void Move(long deltaTime);

        ///<summary>
        ///Destroys the current Entity
        ///</summary>
        public void Destroy();

        ///<summary>
        ///Current position of the Entity
        ///</summary>
        public Vector2 Position { get; set; }

        ///<summary>
        ///Current rotation of the Entity
        ///</summary>
        public double Rotation { get; }

        ///<summary>
        ///If the Entity is alive
        ///</summary>
        public bool IsAlive { get; }

    }
}