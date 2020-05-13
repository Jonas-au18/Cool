using System;

namespace FancyRpg.Utility
{
    public class Monster
    {
        private int hp;
        private int level;

        private string[] loottable =
        {
            "A dirty shirt", "Used underwear", "A shiny coin", "A moldy sandwich", "Legendary graded coffe",
            "A baby pig"
        };

        public Monster()
        {
            var rand = new Random();
            level = rand.Next(1, 5);
            hp = rand.Next(20*level, 50*level);
        }

        public int getLevel()
        {
            return level;
        }

        public int monsterAttack(Hero myHero)
        {
            int dmg;
            var rand = new Random();
            int critical = rand.Next(1, 20);
            if (critical < 14 && myHero.block == false)
            {
                dmg = rand.Next(2 * level * 2, 10 * level * 2);
            }
            else if (critical < 14 && myHero.block == true)
            {
                dmg = rand.Next(2 * level * 2, 10 * level * 2) / 3;
            }
            else if (critical ! < 14 && myHero.block == true)
            {
                dmg = rand.Next(2 * level, 10 * level) / 3;
            }
            else
            {
                dmg = rand.Next(2 * level, 10 * level);
            }

            return dmg;
        }

        public void tookDamage(int dmg)
        {
            hp -= dmg;
            Console.WriteLine(" Monsters hp at {0}",hp);
            if (hp < 0)
            {
                Console.WriteLine("s Monster is dead");
                Console.WriteLine(loot());
            }
        }

        public string loot()
        {
            var rand = new Random();
            return loottable[rand.Next(0, 5)];
        }

        public int getHeath()
        {
            return hp;
        }
    }
}