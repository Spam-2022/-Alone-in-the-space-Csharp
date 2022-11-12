using OOPCSharpProject.model.bullet;
using OOPCSharpProject.model.ship;

namespace OOPCSharpProject.model.gun
{
    public interface IGun
    {
        /**
	 * shot a bullet in the Direction specified.
	 * @param Direction vec2 Direction of the bullet
	 * @return new bullet shot by the gun
	 */
        IBullet Shot(Vec2 direction);

        /**
	 * check if there is at least an enemy in that Direction, based on the range of the setted gun.
	 * @param shipPos starting position
	 * @param Direction in which Direction to check
	 * @param enemy ship to check
	 * @return true or false
	 */
        bool IsInRange(Vec2 shipPos, Vec2 direction, IShip enemy);

        /**
	 * the actual range of this gun.
	 * @return degrees of range
	 */
        float GetDegRange();
    }
}