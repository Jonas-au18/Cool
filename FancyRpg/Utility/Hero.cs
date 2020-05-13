using System;

namespace FancyRpg.Utility
{
    public class Hero
    {
        public int hp;
        public int level;
        public int exp;
        public bool block = false;

        public Hero()
        {
            hp = 100;
            level = 1;
            exp = 0;
        }

        public void getExp(int monsterlevel)
        {
            exp = monsterlevel * 5;
            Console.WriteLine(" Hero got {0} exp",monsterlevel*5);
            if (exp == 10*level)
            {
                level++;
                hp += 100;
                exp = exp - 10*level;
                ding();
            }
        }

        public void ding()
        {
            Console.WriteLine(" congratulations you leveled up, now you are level {0}", level);
        }

        public void tookDmg(int dmg)
        {
            hp -= dmg;
            Console.WriteLine(" Hero took {0} damage, hp at {1}",dmg,hp);
        }
    }
}