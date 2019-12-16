using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_modifier
{
    class DerviedClass : BaseClass
    {
        public override void F()
        {
            _x++;
            _y++;
        }
        public override int X => _x + 10;
        public override int Y => _y++;

    }
}
