using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI
{
    public class Parent
    {
        public int X { get; }
        public int Y { get; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        // virtual so it can be overridden
        public virtual int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }




    public class ChildOverride : Parent
    {
        public int Z { get; }

        public ChildOverride(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

]        public override int Product()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

    public class ChildNew : Parent
    {
        public int Z { get; }

        public ChildNew(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public new int Product()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

}
