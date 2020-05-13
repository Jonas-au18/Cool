using System;
using FancyRpg.Utility;
using Microsoft.VisualBasic.CompilerServices;

namespace FancyRpg.Concrete
{
    public class Combat
    {
        private Hero myHero;
        private Map _map;
        private Monster monster;

        public Combat(Hero hero, Map map)
        {
            _map = map;
            myHero = hero;
        }

        public void attack()
        {
            monster = _map.getMonster();
            if (monster != null && monster.getHeath() > 0)
            {
                var rand = new Random();
                int dmg = rand.Next(20 * myHero.level, 40 * myHero.level);
                int critical = rand.Next(0, 100);
                if (critical > 60)
                {
                    Console.WriteLine(" Hero attacked, monster took {0} damage", dmg * 2);
                    monster.tookDamage(dmg * 2);
                }
                else
                {
                    Console.WriteLine(" Hero attacked, monster took {0} damage", dmg);
                    monster.tookDamage(dmg);
                }

                myHero.tookDmg(monster.monsterAttack(myHero));
                if (myHero.hp < 0)
                {
                    Console.WriteLine(" you have died");
                    Environment.Exit(1);
                }

                if (monster.getHeath() < 0)
                {
                    myHero.getExp(monster.getLevel());
                }
            }
            else
            {
                Console.WriteLine(" Hero swung his sword out of boredom");
            }
        }

        public void block()
        {
            Console.WriteLine(" Hero now blocking");
            myHero.block = true;
        }
    }
}