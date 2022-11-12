namespace OOPCSharpProject.model.bullet
{

    public abstract class AbstractBullet : IBullet
    {
        private readonly int _damage;
        protected readonly float Acceleration;
        protected readonly float MaxSpeed;
        protected readonly float RotationSpeed;
        private bool _alive;
        protected Vec2 Direction;
        protected Vec2 Position;

        protected Vec2 Speed;
        // private ImageView _sprite;


        protected AbstractBullet(float maxSpeed, float acceleration, float rotationSpeed, int damage, Vec2 position,
            Vec2 direction)
        {
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            RotationSpeed = rotationSpeed;
            _damage = damage;
            Position = position;
            Direction = direction;
            _alive = true;
            Speed = direction.Normalize().Mul(maxSpeed);
        }

        public void Move(long deltaTime)
        {
            var newDeltaTime = (double)deltaTime / 1_000_000_000L; //conversion to seconds
            Speed = Speed.Add(Direction.Mul(newDeltaTime * Acceleration));
            if (Speed.Length() > MaxSpeed) Speed = Speed.Normalize().Mul(MaxSpeed);

            Position = Position.Add(Speed.Mul(newDeltaTime));
        }

        public double GetAngle()
        {
            return Direction.Angle();
        }

        public void Destroy()
        {
            _alive = false;
        }

        public int GetDamage()
        {
            return _damage;
        }


        public Vec2 GetPosition()
        {
            return Position.Copy();
        }


        public bool IsAlive()
        {
            return _alive;
        }


        public Vec2 GetDirection()
        {
            return Direction.Copy();
        }

        public void SetPosition(Vec2 newPos)
        {
            Position = newPos;
        }
        /*
         public Node GetNode()
        {
            return this._sprite;
        }
        public void SetSprite(Image img)
        {
            this._sprite = new ImageView();
            this._sprite.setImage(img);
            this._sprite.setViewOrder(-1);
        }*/
    }
}