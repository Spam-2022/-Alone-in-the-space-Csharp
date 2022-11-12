using OOPCSharpProject.model.bullet;
using OOPCSharpProject.model.gun;

namespace OOPCSharpProject.model.ship
{
    public interface IShip : IEntity
    {
        /**
	 * Generate a bullet with the current Direction and position of the ship.
	 * @return new bullet
	 */
        IBullet Shot();


        /**
	 * Set the gun for this ship.
	 * @param gun new Gun
	 */
        void SetGun(IGun gun);

        /**
	 * decrease the ship current health for the damage specified.
	 * @param damage damage inflicted
	 */
        void Strike(int damage);

        /**
	 * set the current target of this ship.
	 * @param target new target
	 */
        void SetTarget(IShip target);


        /**
	 * get the current target of this ship.
	 * @return target
	 */
        IShip GetTarget();


        /**
	 * Drop of this ship when destroyed.
	 * @return item dropped
	 */
        string Drop();

        /**
	 * check if at least an enemy is in range of this ship and attack cooldown is off.
	 * @param deltaTime tic update
	 * @return true or false
	 */
        bool IsInRangeOfAttack(long deltaTime);

        /**
	 * getter
	 * @return current health of the ship
	 */
        int GetHealth();
    }
}