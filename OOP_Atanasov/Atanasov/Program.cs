namespace Atanasov;

static class Program
{
    private const int Width = 200;
    private const int Height = 150;
    private const int BulletWidth = 75;
    private const int BulletHeight = 35;


    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ICollision detection = new Collision();
        
        Entity ship = new Entity(new PictureBox());
        Entity enemy1 = new Entity(new PictureBox());
        Entity enemy2 = new Entity(new PictureBox());
        Entity bullet1 = new Entity(new PictureBox());
        Entity bullet2 = new Entity(new PictureBox());
        
        ship._picture.SetBounds(515, 345, Width, Height);
        enemy1._picture.SetBounds(600, 300, Width, Height);
        enemy2._picture.SetBounds(400, 265, Width, Height);
        bullet1._picture.SetBounds(578, 363, BulletWidth, BulletHeight);
        bullet2._picture.SetBounds(496, 200, BulletWidth, BulletHeight);

        List<Entity> enemies = new List<Entity>();
        List<Entity> bullets = new List<Entity>();
        enemies.Add(enemy1);
        enemies.Add(enemy2);
        bullets.Add(bullet1);
        bullets.Add(bullet2);
        
        detection.CheckAllCollision(ship, enemies, bullets);
        
        Console.WriteLine("Update ship position");
        ship._picture.SetBounds(1290, 300, Width, Height);
        
        detection.CheckAllCollision(ship, enemies, bullets);
        Console.WriteLine("Coordinates:" + "X: " + ship._picture.Bounds.X +" y: " + ship._picture.Bounds.Y);
    }
}