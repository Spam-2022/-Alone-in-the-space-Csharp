using System;

namespace OOP_Stratu.Model.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBullet : IEntity
    {
        public int Damage { get; set; }
        
    }
}