//http://www.blackwasp.co.uk/CSharpOperatorOverloading.aspx
using System;

namespace VectorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int scale = 3;

            Vector v1 = new Vector(6, 15);
            Vector v2 = new Vector(0, 8);

            Console.WriteLine("v1: ({0}, {1})", v1.X, v1.Y);
            Console.WriteLine("v2: ({0}, {1})", v2.X, v2.Y);

            Vector v3 = v1 + v2;

            Console.WriteLine("Addition: ({0}, {1})", v3.X, v3.Y);

            v3 = v1 - v2;
            //Vector v4 = v1 - v2;

            Console.WriteLine("Subtraction: ({0}, {1})", v3.X, v3.Y);
            //Console.WriteLine("Subtraction: ({0}, {1})", v4.X, v4.Y);

            //vector must be left of int by default
            v3 = v1 * scale;
            //Vector v5 = v1 * scale;
                                    
            Console.WriteLine("Multiplication *{0}: ({1}, {2})", scale, v3.X, v3.Y);
            //Console.WriteLine("Multiplication: ({0}, {1})", v5.X, v5.Y);

            //Use variation where int can be left of vector
            v3 = scale * v1;
            //Vector v6 = scale * v1;

            Console.WriteLine("Multvariation {0}*: ({1}, {2})", scale, v3.X, v3.Y);
            //Console.WriteLine("Multvariation: ({0}, {1})", v6.X, v6.Y);

            v3 = v1 / scale;
            //Vector v7 = v1 / scale;

            Console.WriteLine("Division /{0}: ({1}, {2})", scale, v3.X, v3.Y);

            //Use variation where int can be left of vector
            v3 = 3 / v1;
            //Vector v7 = 3 / v1;

            Console.WriteLine("Divariation {0}/: ({1}, {2})", scale, v3.X, v3.Y);


            //Compound assignment operator
            v1 *= 5;

            Console.WriteLine("CompoundMult *5: ({0}, {1})", v1.X, v1.Y);

            //Unary operator ++
            Console.WriteLine("v1: {0}, {1}", v1.X, v1.Y);
            v1++;
            Console.WriteLine("Unary++: {0}, {1})", v1.X, v1.Y);

            //Unary operator --
            Console.WriteLine("v1: {0}, {1}", v1.X, v1.Y);
            v1--;
            Console.WriteLine("Unary--: {0}, {1})", v1.X, v1.Y);

            Vector v9 = -v1;
            Console.WriteLine("v1: {0}, {1}", v1.X, v1.Y);
            Console.WriteLine("({0}, {1})", v9.X, v9.Y);

            //http://www.blackwasp.co.uk/CSharpTrueFalseOverload.aspx
            //True or False operator
            Vector test_true = new VectorDemo.Vector(4, 3);
            if (test_true)
                Console.WriteLine("v: ({0}, {1}) !0: True", test_true.X, test_true.Y);
            else
                Console.WriteLine("v !0: False");

            Vector test_false = new VectorDemo.Vector(0, 0);
            if (test_false)
                Console.WriteLine("v !0: True");
            else
                Console.WriteLine("v: ({0}, {1}) !0: False", test_false.X, test_false.Y);

            //http://www.blackwasp.co.uk/CSharpLogicalOpOverload.aspx
            //Logical operator
            Vector vl1 = new Vector(0, 0);
            Vector vl2 = new Vector(10, 0);

            Console.WriteLine("({0}, {1} & {2}, {3}): {4}", vl1.X, vl1.Y, vl1.X, vl1.Y, (vl1 & vl1));
            Console.WriteLine("({0}, {1} & {2}, {3}): {4}", vl1.X, vl1.Y, vl2.X, vl2.Y, (vl1 & vl2));
            Console.WriteLine("({0}, {1} & {2}, {3}): {4}", vl2.X, vl2.Y, vl1.X, vl1.Y, (vl2 & vl1));
            Console.WriteLine("({0}, {1} & {2}, {3}): {4}", vl2.X, vl2.Y, vl2.X, vl2.Y, (vl2 & vl2));

            Console.WriteLine("({0}, {1} | {2}, {3}): {4}", vl1.X, vl1.Y, vl1.X, vl1.Y, (vl1 | vl1));
            Console.WriteLine("({0}, {1} | {2}, {3}): {4}", vl1.X, vl1.Y, vl2.X, vl2.Y, (vl1 | vl2));
            Console.WriteLine("({0}, {1} | {2}, {3}): {4}", vl2.X, vl2.Y, vl1.X, vl1.Y, (vl2 | vl1));
            Console.WriteLine("({0}, {1} | {2}, {3}): {4}", vl2.X, vl2.Y, vl2.X, vl2.Y, (vl2 | vl2));

            Console.WriteLine("({0}, {1} ^ {2}, {3}): {4}", vl1.X, vl1.Y, vl1.X, vl1.Y, (vl1 ^ vl1));
            Console.WriteLine("({0}, {1} ^ {2}, {3}): {4}", vl1.X, vl1.Y, vl2.X, vl2.Y, (vl1 ^ vl2));
            Console.WriteLine("({0}, {1} ^ {2}, {3}): {4}", vl2.X, vl2.Y, vl1.X, vl1.Y, (vl2 ^ vl1));
            Console.WriteLine("({0}, {1} ^ {2}, {3}): {4}", vl2.X, vl2.Y, vl2.X, vl2.Y, (vl2 ^ vl2));
            
            Console.WriteLine("!({0} == 0 && {1} == 0): {2}", vl1.X, vl1.Y, !vl1);
            Console.WriteLine("!({0} == 0 && {1} == 0): {2}", vl2.X, vl2.Y, !vl2);

            if (vl1 && vl2)
                Console.WriteLine("vl1 && vl2 = True");
            else
                Console.WriteLine("vl1 && vl2 = False");

            if (vl1 || vl2)
                Console.WriteLine("vl1 || vl2 = True");
            else
                Console.WriteLine("vl1 || vl2 = False");

            Vector vl3 = new VectorDemo.Vector(3, 4);
            Vector vl4 = new VectorDemo.Vector(3, 4);
            Vector vl5 = vl4;

            Console.WriteLine("vl3: ({0}, {1}) vl4: ({2}, {3}) vl5: ({4}, {5})", vl3.X, vl3.Y, vl4.X, vl4.Y, vl5.X, vl5.Y);

            // True and True when using relational operational overload
            Console.WriteLine("vl4 == vl3: {0}", vl4 == vl3);
            Console.WriteLine("vl5 == vl4: {0}", vl5 == vl4);
            Console.WriteLine("vl4.Equals(vl3): {0}", vl4.Equals(vl3));
            Console.WriteLine("vl5.Equals(vl4): {0}", vl5.Equals(vl4));

            vl3 = new VectorDemo.Vector(3, 4);
            vl4 = new VectorDemo.Vector(4, 3);
            vl5 = new VectorDemo.Vector(3, 5);

            Console.WriteLine("vl3: ({0}, {1}) vl4: ({2}, {3}) vl5: ({4}, {5})", vl3.X, vl3.Y, vl4.X, vl4.Y, vl5.X, vl5.Y);

            Console.WriteLine("vl3 > vl4: {0}", vl3 > vl4);
            Console.WriteLine("vl3 < vl4: {0}", vl3 < vl4);
            Console.WriteLine("vl3 >= vl4: {0}", vl3 >= vl4);
            Console.WriteLine("vl3 <= vl4: {0}", vl3 <= vl4);
            Console.WriteLine("vl3 > vl5: {0}", vl3 > vl5);
            Console.WriteLine("vl3 < vl5: {0}", vl3 < vl5);
            Console.WriteLine("vl3 >= vl5: {0}", vl3 >= vl5);
            Console.WriteLine("vl3 <= vl5: {0}", vl3 <= vl5);

            Vector v = new VectorDemo.Vector(5, 5);

            double d = v;
            Console.WriteLine("Implicit double d = v({0}, {1}): {2}", v.X, v.Y, d);

            float f = (float)v;
            Console.WriteLine("Explicit float f = (float)({0}, {1}): {2}", v.X, v.Y, f);
        }
    }
}
