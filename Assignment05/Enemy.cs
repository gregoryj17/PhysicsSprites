using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    public class Enemy : PhysicsSprite
    {
        private Boolean left = false;
        private Random r = new Random();

        public Enemy() : base(Properties.Resources.jason)
        {
            Vx = 4f;
        }

        public Enemy(int x, int y) : base(Properties.Resources.jason, x, y)
        {
            Vx = 4f;
        }

        public void Shoot()
        {

            Bullet bullet = new Bullet(Properties.Resources.box, (int)(X + width * Scale * 1.1f), (int)(Y + height * Scale / 2));
            if (left)
            {
                bullet.X = X - 26;
                bullet.Vx *= -1;
            }
            Engine.canvas.add(bullet);
        }

        public bool isWall()
        {
            X += Vx;
            if (getCollisions().Count > 0)
            {
                X -= Vx;
                return true;
            }
            X -= Vx;
            return false;
        }

        public void killCharacter()
        {
            X += Vx;
            List<CollisionSprite> list = getCollisions();
            X -= Vx;
            foreach (CollisionSprite s in list)
            {
                if (s.GetType() == typeof(Elephant)) s.Kill();
            }
        }

        public override void act()
        {
            base.act();
            killCharacter();
            if (r.NextDouble() < .01) Vy = -20;
            if (isWall()) Vx *= -1;
            if (r.NextDouble() < .01) Shoot();
            if (Vx < 0) left = true;
            if (Vx > 0) left = false;
        }

    }
}