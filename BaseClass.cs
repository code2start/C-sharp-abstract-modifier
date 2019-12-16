using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_modifier
{
    abstract class BaseClass
    {
        protected int _x = 100;
        protected int _y = 150;
        public abstract void F();//abstract method
        public abstract int X { get; }
        public abstract int Y { get; }

    }
}
