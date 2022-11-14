using Xunit;

namespace Atanasov.Testing;

public class CollisionTest
{
    private const int Width = 200;
    private const int Height = 150;
    private const int BulletWidth = 75;
    private const int BulletHeight = 35;
    
    
    private ICollision detection = new Collision();

    Entity _ship = new Entity(new PictureBox());
    Entity _enemy1 = new Entity(new PictureBox());
    Entity _enemy2 = new Entity(new PictureBox());
    Entity _bullet1 = new Entity(new PictureBox());
    Entity _bullet2 = new Entity(new PictureBox());

    private void SetUp()
    {
        _ship._picture.SetBounds(515, 345, Width, Height);
        _enemy1._picture.SetBounds(600, 300, Width, Height);
        _enemy2._picture.SetBounds(300, 545, Width, Height);
        _bullet1._picture.SetBounds(578, 363, BulletWidth, BulletHeight);
        _bullet2._picture.SetBounds(496, 200, BulletWidth, BulletHeight);    
    }

    public void CheckCollisionBetweenPlayerAndEnemies()
    {
        SetUp();
        Assert.True(detection.CheckEnemyCollision(_ship, _enemy1));
        Assert.False(detection.CheckEnemyCollision(_ship, _enemy2));
    }

    public void CheckCollisionBetweenPlayerAndBullets()
    {
        SetUp();
        Assert.True(detection.CheckBulletCollision(_ship, _bullet1));
        Assert.False(detection.CheckBulletCollision(_ship, _bullet2));
    }
    
}