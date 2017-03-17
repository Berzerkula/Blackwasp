//http://www.blackwasp.co.uk/CSharpOperatorOverloading.aspx
using System;

namespace VectorDemo
{
    class Vector
    {
        private int _x, _y;

        public Vector(int x, int y)
        {
            _x = x; _y = y;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new VectorDemo.Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new VectorDemo.Vector(v1.X - v2.X, v1.Y - v2.Y);
        }

        //http://www.blackwasp.co.uk/CSharpOperatorOverloading_2.aspx
        public static Vector operator *(Vector v1, int scale)
        {
            return new VectorDemo.Vector(v1.X * scale, v1.Y * scale);
        }

        //Variation where int can be left of vector
        public static Vector operator *(int scale, Vector v1)
        {
            return new Vector(v1.X * scale, v1.Y * scale);
        }

        public static Vector operator /(Vector v1, int scale)
        {
            if (scale == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return new VectorDemo.Vector(v1.X / scale, v1.Y / scale);
            }
        }

        //Variation where int can be left of vector
        public static Vector operator /(int scale, Vector v1)
        {
            return new VectorDemo.Vector(v1.X / scale, v1.Y / scale);
        }

        //Unary Operator Overloading
        public static Vector operator ++(Vector v)
        {
            v.X++;
            v.Y++;
            return v;
        }

        public static Vector operator --(Vector v)
        {
            v.X--;
            v.Y--;
            return v;
        }

        //Negation operator
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        //http://www.blackwasp.co.uk/CSharpTrueFalseOverload.aspx
        //True and False Operators
        public static bool operator true(Vector v)
        {
            if ((v.X != 0) || (v.Y != 0))
                return true;
            else
                return false;
        }

        public static bool operator false(Vector v)
        {
            if ((v.X == 0) && (v.Y == 0))
                return true;
            else
                return false;
        }

        //http://www.blackwasp.co.uk/CSharpLogicalOpOverload.aspx
        //Logical Operator Overload
        //public static bool operator &(Vector v1, Vector v2)
        //Short Circuit Operator Overload
        public static Vector operator &(Vector v1, Vector v2)
        {
            bool v1flag = !((v1.X == 0) && (v1.Y == 0));
            bool v2flag = !((v2.X == 0) && (v2.Y == 0));

            //return v1flag & v2flag;
            
            //Short-Circuit Operator
            if (v1flag & v2flag)
                return new Vector(1, 1);
            else
                return new Vector(0, 0);
        }

        //public static bool operator |(Vector v1, Vector v2)
        //Short Circuit Operator Overload
        public static Vector operator |(Vector v1, Vector v2)
        {
            bool v1flag = !((v1.X == 0) && (v1.Y == 0));
            bool v2flag = !((v2.X == 0) && (v2.Y == 0));

            //return v1flag | v2flag;

            //Short-Circuit Operator
            if (v1flag | v2flag)
                return new Vector(1, 1);
            else
                return new Vector(0, 0);
        }

        public static bool operator ^(Vector v1, Vector v2)
        {
            bool v1flag = !((v1.X == 0) && (v1.Y == 0));
            bool v2flag = !((v2.X == 0) && (v2.Y == 0));

            return v1flag ^ v2flag;
        }

        //public static bool operator !(op-type operand)
        //public static bool operator !(Vector v1)

        //http://www.blackwasp.co.uk/CSharpLogicalOpOverload_2.aspx
        public static bool operator !(Vector v)
        {
            return ((v.X == 0) && (v.Y == 0));
        }

        //http://www.blackwasp.co.uk/CSharpRelationalOverload.aspx
        //Relational Operation Overload
        public static bool operator ==(Vector v1, Vector v2)
        {
            return (v1.X == v2.X && v1.Y == v2.Y);
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return (v1.X != v2.X || v1.Y != v2.Y);
        }

        //Overloading Comparison Operators
        //http://www.blackwasp.co.uk/CSharpRelationalOverload_2.aspx
        public double Length
        {
            get
            {
                return Math.Sqrt(_x * _x + _y * _y);
            }
        }

        public static bool operator >(Vector v1, Vector v2)
        {
            return (v1.Length > v2.Length);
        }

        public static bool operator <(Vector v1, Vector v2)
        {
            return (v1.Length < v2.Length);
        }

        public static bool operator >=(Vector v1, Vector v2)
        {
            return (v1.Length >= v2.Length);
        }

        public static bool operator <=(Vector v1, Vector v2)
        {
            return (v1.Length <= v2.Length);
        }

        //http://www.blackwasp.co.uk/CSharpConversionOverload.aspx
        //Conversion Overload
        //implicit
        public static implicit operator double(Vector v)
        {
            return v.Length;
        }

        //explicit
        public static explicit operator float(Vector v)
        {
            return (float)v.Length;
        }
    }
}