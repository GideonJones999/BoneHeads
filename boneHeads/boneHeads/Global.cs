using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace boneHeads
{
    class Global
    {
        //Data Members
        public static Rectangle[] cage =
        {
            new Rectangle(),
            new Rectangle(200, 0, 300, 300),
            new Rectangle(500, 0, 300, 300),
            new Rectangle(800, 0, 300, 300),
            new Rectangle(200, 300, 300, 300),
            new Rectangle(500, 300, 300, 300),
            new Rectangle(800, 300, 300, 300),
            new Rectangle(200, 600, 300, 300),
            new Rectangle(500, 600, 300, 300),
            new Rectangle(800, 600, 300, 300),
        };

        //Member Method
        Global()
        {

        }
    }
}
