
namespace Atanasov;

public class Collision : ICollision
{
    private const int Width = 1280;
    private const int Height = 720;
    
    /// <inheritdoc />
    public bool CheckEnemyCollision(Entity playerShip, Entity enemy)
    {
        return playerShip._picture.Bounds.IntersectsWith(enemy._picture.Bounds);
    }
    
    /// <inheritdoc />
    public bool CheckBulletCollision(Entity playerShip, Entity bullet)
    {
        return playerShip._picture.Bounds.IntersectsWith(bullet._picture.Bounds);
    }

    /// <inheritdoc />
    public void CheckAllCollision(Entity playerShip, List<Entity> enemies, List<Entity> bullets)
    {
        CheckBorderCollision(playerShip);
        
        foreach (var entity in enemies)
        {
            if (CheckEnemyCollision(playerShip, entity))
            {
                Console.WriteLine("Collision detected with enemy.");
            }
        }

        foreach (var bullet in bullets)
        {
            if (CheckBulletCollision(playerShip, bullet))
            {
                Console.WriteLine("Collision detected with bullet.");
            }
        }
    }

    /// <inheritdoc />
    public void CheckBorderCollision(Entity playerShip)
    {
        if (playerShip._picture.Bounds.Y >= Height)
        {
            Console.WriteLine("Border Collision");
            playerShip._picture.SetBounds(playerShip._picture.Bounds.X, 0, playerShip._picture.Width, playerShip._picture.Height);
        }
        else if (playerShip._picture.Bounds.Y <= 0)
        {
            Console.WriteLine("Border Collision");
            playerShip._picture.SetBounds(playerShip._picture.Bounds.X, Height, playerShip._picture.Width, playerShip._picture.Height);
        }
        else if (playerShip._picture.Bounds.X >= Width)
        {
            Console.WriteLine("Border Collision");
            playerShip._picture.SetBounds(0, playerShip._picture.Bounds.Y, playerShip._picture.Width, playerShip._picture.Height);
        } 
        else if (playerShip._picture.Bounds.X <= 0)
        {
            Console.WriteLine("Border Collision");
            playerShip._picture.SetBounds(Width, playerShip._picture.Bounds.Y, playerShip._picture.Width, playerShip._picture.Height);
        }
    }
}