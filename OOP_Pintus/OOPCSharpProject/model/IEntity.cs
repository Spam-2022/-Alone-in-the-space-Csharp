namespace OOPCSharpProject.model
{
    public interface IEntity
    {
        /**
	 * get the current angle of this ship.
	 * @return angle in degrees
	 */
        double GetAngle();

        /**
	  * Get the position of the entity
	  * @return vec2 position of the entity
	  */
        Vec2 GetPosition();

        /**
	  * Get the direction of the entity
	  * @return vec2 direction of the entity
	  */
        Vec2 GetDirection();

        /**
	  * boolean statement if the entity is still alive
	  * @return true or false
	  */
        bool IsAlive();

        /**
	  * destroy all item attached to the object
	  */
        void Destroy();

        /**
	  * move the entity for the interval specified
	  * @param deltaTime tic update
	  */
        void Move(long deltaTime);

        /**
      * return the node (of javaFX) associate at the object
      * @return javafx node
      */
        //Node GetNode();

        /**
      * Set the sprite of the entity
      * @param img sprite of the entity
      */
        // void SetSprite(Image img);

        /**
	  * Set the position.
	  * @param newPos new vec2 pos of the entity
	  */
        void SetPosition(Vec2 newPos);
    }
}