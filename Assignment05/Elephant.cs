using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment05
{
    class Elephant:PhysicsSprite
    {
        public Elephant(int x, int y) : base(Properties.Resources.elephant, x, y)
        {
            image = Properties.Resources.elephant;
            X = x;
            Y = y;
        }
    }
}
