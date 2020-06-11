using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boneHeads
{
    class Demon : Zombie
    {
        private int fly;
        public Demon()
        {

        }
        public void setFly(int f = 3)
        {
            fly = f;
        }

        public void Fly()
        {
            rec.Y += fly;
            if (rec.Top <= cage.Top|| rec.Bottom >= cage.Bottom)
                fly = -fly;
        }
    }
}
