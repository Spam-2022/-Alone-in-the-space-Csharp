namespace OOPCSharpProject.model.bullet
{
/*
import com.almasb.fxgl.core.math.Vec2;

import model.Entity;*/


    public interface IBullet : IEntity
    {
        /**
	 * getter
	 * @return how much damage the bullet does
	 */
        int GetDamage();
    }
}