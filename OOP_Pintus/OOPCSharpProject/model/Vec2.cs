using System;

/*
 my prototype model of javaFx vector, this implementation is not correct.
 it's just a placeholder for c#.
 */
namespace OOPCSharpProject.model
{
    public class Vec2
    {
        private double _x, _y;

        public Vec2()
        {
            _x = 0;
            _y = 0;
        }

        public Vec2(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Vec2 Add(double x)
        {
            return new Vec2(_x + x, _y + x);
        }

        public Vec2 Add(Vec2 x)
        {
            return new Vec2(_x + x._x, _y + x._y);
        }

        public Vec2 Copy()
        {
            return new Vec2(_x, _y);
        }

        public Vec2 Mul(double x)
        {
            _x *= x;
            _y *= x;
            return this;
        }

        public double Length()
        {
            return 0.0f;
        }

        public Vec2 Normalize()
        {
            return new Vec2();
        }

        public double Angle()
        {
            return 0.0f;
        }

        public Vec2 SetFromAngle(double f)
        {
            _x = Math.Cos(f);
            _y = Math.Sin(f);
            return this;
        }


        public Vec2 Sub(Vec2 vec)
        {
            _x -= vec._x;
            _y -= vec._y;
            return this;
        }
    }
}