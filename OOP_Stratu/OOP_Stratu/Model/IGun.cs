using OOP_Stratu.Model.Entities;
using System;

namespace OOP_Stratu.Model
{
    public interface IGun
    {
        IBullet Shot(IShip ship);
    }
}