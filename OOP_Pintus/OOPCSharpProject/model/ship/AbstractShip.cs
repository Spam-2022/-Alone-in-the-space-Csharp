using System;
using OOPCSharpProject.model.bullet;
using OOPCSharpProject.model.gun;

namespace OOPCSharpProject.model.ship
{
    public abstract class AbstractShip : IShip
    {
        private readonly float _acceleration;
        private readonly long _attackCooldown;
        private readonly float _maxSpeed;
        private readonly float _rotationSpeed;
        private Vec2 _direction;
        private int _health;
        private long _lastAttack;
        private Vec2 _position;
        private Vec2 _speed;

        private IShip _target;

        //private ImageView sprite;
        private IGun _gun;

        protected AbstractShip(int health, float maxSpeed, float acceleration, float rotationSpeed, long attackCD,
            Vec2 newPosition)
        {
            _attackCooldown = attackCD * 1000000L;

            _health = health;
            _maxSpeed = maxSpeed;
            _acceleration = acceleration;
            _rotationSpeed = rotationSpeed;
            _position = newPosition;
            _direction = new Vec2(0, 1);
            _speed = new Vec2(0, 0);
        }

        public void Move(long deltaTime)
        {
            var newdeltaTime = (double)deltaTime / 1000000000L; // conversion to seconds
            if (_target != null)
            {
                var angle = CalculateDir();
                if (Math.Abs(_speed.Angle() - angle) > 90 || Math.Abs(angle) > _gun.GetDegRange() / 2)
                    _direction = _direction
                        .Add(new Vec2(1, 0).SetFromAngle(angle).Mul(newdeltaTime * _rotationSpeed));
            }

            _speed = _speed.Add(_direction.Mul(newdeltaTime * _acceleration));
            if (_speed.Length() > _maxSpeed) _speed = _speed.Normalize().Mul(_maxSpeed);

            _position = _position.Add(_speed.Mul(newdeltaTime));
        }

        public IBullet Shot()
        {
            _lastAttack -= _attackCooldown;
            var bullet = _gun.Shot(GetDirection());
            bullet.SetPosition(_position.Copy());
            return bullet;
        }


        public void Destroy()
        {
            _health = 0;
            _target = null;
        }


        public void SetTarget(IShip enemy)
        {
            _target = enemy;
            _target.GetPosition().Copy();
        }


        public IShip GetTarget()
        {
            return _target;
        }


        public double GetAngle()
        {
            return _speed.Angle() + 90;
        }


        public Vec2 GetPosition()
        {
            return _position.Copy();
        }


        public Vec2 GetDirection()
        {
            return _direction.Copy();
        }


        public void SetPosition(Vec2 newPos)
        {
            _position = newPos;
        }


        public bool IsInRangeOfAttack(long deltaTime)
        {
            if (_lastAttack > _attackCooldown) return _gun.IsInRange(_position.Copy(), _direction.Copy(), _target);

            _lastAttack += deltaTime;
            return false;
        }


        public void SetGun(IGun gun)
        {
            this._gun = gun;
        }
        /*
        public void SetSprite(Image img)
        {
            this.sprite = new ImageView();
            this.sprite.setImage(img);
            this.sprite.setViewOrder(-2);
        }

        

        public Node getNode()
        {
            return this.sprite;
        }*/


        public string Drop()
        {
            return null;
        }


        public void Strike(int damage)
        {
            _health -= damage;
        }


        public bool IsAlive()
        {
            if (_health > 0) return true;

            {
                Destroy();
            }
            return false;
        }

        public int GetHealth()
        {
            return _health;
        }

        /**
 * calculate the angle from the actual Direction, and ideal Direction
 * 
 * @return new Direction
 */
        private double CalculateDir()
        {
            return _target.GetPosition().Sub(_position).Angle();
        }
    }
}