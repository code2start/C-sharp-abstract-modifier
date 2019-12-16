using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_modifier
{
    class Square : Shape
    {
        int side;//field
        public Square(int n) => side = n;

        public override int GetArea()
        {
            return side * side;
        }

    }
}
