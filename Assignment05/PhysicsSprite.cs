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
    public class PhysicsSprite : CollisionSprite
    {
        protected float gX, gY, aX, aY, vX, vY;

        enum MotionModels {Static, SetPath, Kinematic};

        MotionModels MotionModel=MotionModels.Static;

        public float Gx
        {
            get { return gX; }
            set { gX = value; }
        }

        public float Gy
        {
            get { return gY; }
            set { gY = value; }
        }

        public float Ax
        {
            get { return aX; }
            set { aX = value; }
        }

        public float Ay
        {
            get { return aY; }
            set { aY = value; }
        }

        public float Vx
        {
            get { return vX; }
            set { vX = value; }
        }

        public float Vy
        {
            get { return vY; }
            set { vY = value; }
        }

        public PhysicsSprite(Image image) : base(image)
        {

        }

        public PhysicsSprite(Image image, int x, int y):base(image)
        {
            X = x;
            Y = y;
        }

        public override void act()
        {
            if (MotionModel != MotionModels.Static)
            {
                X += Vx;
                Y += Vy;
            }
            if(MotionModel == MotionModels.Kinematic)
            {
                Vx += Ax + Gx;
                Vy += Ay + Gy;
            }
        }

        public override void paint(Graphics g)
        {
            base.paint(g);
        }

    }
}
