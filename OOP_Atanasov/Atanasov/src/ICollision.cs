
namespace Atanasov;

public interface ICollision
{
    /// <summary>
    /// Check if there is a collision with enemies.
    /// </summary>
    /// <param name="playerShip"></param>
    /// <param name="enemy"></param>
    /// <returns>True if a collision occurred</returns>
    bool CheckEnemyCollision(Entity playerShip, Entity enemy);

    /// <summary>
    /// Check if there is a collision with bullets.
    /// </summary>
    /// <param name="playerShip"></param>
    /// <param name="bullet"></param>
    /// <returns>True if a collision occurred</returns>
    bool CheckBulletCollision(Entity playerShip, Entity bullet);
    
    /// <summary>
    /// Check collision with enemies and bullets.
    /// </summary>
    /// <param name="playerShip"></param>
    /// <param name="enemies"></param>
    /// <param name="bullets"></param>
    void CheckAllCollision(Entity playerShip, List<Entity> enemies, List<Entity> bullets);

    /// <summary>
    /// Check if there is a collision with borders then send the player on the other side
    /// </summary>
    /// <param name="playerShip"></param>
    void CheckBorderCollision(Entity playerShip);
}