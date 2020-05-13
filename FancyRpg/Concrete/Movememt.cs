using System;
using FancyRpg.Utility;

namespace FancyRpg.Concrete
{
    public class Movememt
    {
        private int direction = 0;
        private int[,] myMap;
        private int xCord = 0;
        private int yCord = 0;
        private Monster encounter;
        private Map _map;
        
        public Movememt(Map map)
        {
            _map = map;
            myMap = _map.getMap();
        }
        public void Forward()
        {
            Console.WriteLine("\n");
            if (encounter != null && encounter.getHeath() > 0)
            {
                Console.WriteLine(" Can't escape, currently fighting a monster");
            }
            else
            {
                if (direction == 0 && yCord < 20 && myMap[xCord, yCord] != 2)
                {
                    yCord++;
                    Console.WriteLine(" Hero moving forwards");
                    if (myMap[xCord, yCord] == 1)
                    {
                        encounter = _map.newEncounter();
                        Console.WriteLine(" Encountered a monster at level {0}",encounter.getLevel());
                    }
                }

                else if (direction == 1 && xCord > 0 && myMap[xCord, yCord] != 2)
                {
                    xCord--;
                    Console.WriteLine(" Hero moving forwards");
                    if (myMap[xCord, yCord] == 1)
                    {
                        encounter = _map.newEncounter();
                        Console.WriteLine(" Encountered a monster at level {0}",encounter.getLevel());
                    }
                }

                else if (direction == 2 && yCord > 0 && myMap[xCord, yCord] != 2)
                {
                    yCord--;
                    Console.WriteLine(" Hero moving forwards");
                    if (myMap[xCord, yCord] == 1)
                    {
                        encounter = _map.newEncounter();
                        Console.WriteLine(" Encountered a monster at level {0}",encounter.getLevel());
                    }
                }

                else if (direction == 3 && xCord < 20 && myMap[xCord, yCord] != 2)
                {
                    xCord++;
                    Console.WriteLine(" Hero moving forwards");
                    if (myMap[xCord, yCord] == 1)
                    {
                        encounter = _map.newEncounter();
                        Console.WriteLine(" Encountered a monster at level {0}",encounter.getLevel());
                    }
                }
                else
                {
                    Console.WriteLine(" At the edge of the map, you can't go further");
                }

                if (myMap[xCord, yCord] == 2)
                {
                    Console.WriteLine(" Tree is in the way, you have to jump to get past it");
                }
            }
        }

        public void Backward()
        {
            if (direction == 0 && yCord > 0)
            {
                yCord--;
                Console.WriteLine(" Hero moving backwards");
            }

            if (direction == 1 && xCord > 0)
            {
                xCord++;
                Console.WriteLine(" Hero moving backwards");
            }

            if (direction == 2 && yCord < 20)
            {
                yCord++;
                Console.WriteLine(" Hero moving backwards");
            }

            if (direction == 3 && xCord > 0)
            {
                xCord--;
                Console.WriteLine(" Hero moving backwards");
            }
            else
            {
                Console.WriteLine(" At the edge of the map, you can't go further");
            }
        }

        public void Left()
        {
            if (direction > 0)
            {
                direction--;
            }
            else
            {
                direction = 3;
            }

            string compas = _map.compas(direction);
            Console.WriteLine(" Hero turned to the left, now facing {0}",compas);
        }

        public void Right()
        {
            if (direction < 3)
            {
                direction++;
            }
            else
            {
                direction = 0;
            }

            string compas = _map.compas(direction);
            Console.WriteLine(" Hero turned to the right, now facing {0}",compas);
        }

        public void Jump()
        {
            if (myMap[xCord, yCord] == 2)
            {
                myMap[xCord, yCord] = 0;
            }
            Console.WriteLine(" Hero jumped");
        }
    }
}