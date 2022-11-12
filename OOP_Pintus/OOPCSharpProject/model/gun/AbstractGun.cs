using System;
using OOPCSharpProject.model.bullet;
using OOPCSharpProject.model.ship;

namespace OOPCSharpProject.model.gun
{
    internal abstract class AbstractGun
        : IGun
    {
        private readonly int _degRange;
        protected readonly IShip ActualShip;

        protected AbstractGun(int degRange, IShip ship)
        {
            _degRange = degRange;
            ActualShip = ship;
        }

        public IBullet Shot(Vec2 direction)
        {
            throw new NotImplementedException();
            return null;
        }

        public bool IsInRange(Vec2 shipPos, Vec2 direction, IShip enemy)
        {
            // TODO Auto-generated method stub
            return Math.Abs(enemy.GetPosition().Sub(shipPos).Angle() - direction.Angle()) < _degRange / 2f;
        }

        public float GetDegRange()
        {
            // TODO Auto-generated method stub
            return _degRange;
        }
    }
}