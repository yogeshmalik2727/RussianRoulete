using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulete
{
    public class LogicClass
    {
        public int Point = 0;
        public int Bullet;
        public int[] Gun = new int[6] { 0 , 1, 2 , 3 , 4, 5 };
        public int ShootAwayChances = 2;

        public void ShootAtHead()
        {
            if (Bullet == 5)
            {
                MessageBox.Show("WASTED");
                Point = Point - 5;
            }
            else
            {
                MessageBox.Show("ohh!got lucky, play again");
                Bullet++;
            }
        }

        public void ShootAway()
        {
            if (Bullet == 5)
            {
                MessageBox.Show("Alive");
                Point = Point + 5;
            }
            else
            {
                MessageBox.Show("lost all chances");
                Bullet++;
                ShootAwayChances--;

            }
        }
    }
}