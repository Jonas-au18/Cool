using System;

namespace FancyRpg.Utility
{
    public class Map
    {
        private int[,] myMap;
        private Monster encounter;

        public Map()
        {
            myMap = new int[20,20];
        }

        public void GenerateMap()
        {
            var rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    myMap[i, j] = rand.Next(0, 3);
                }
            }
        }

        public int[,] getMap()
        {
            return myMap;
        }

        public string compas(int dir)
        {
            string _compas;
            if (dir == 0)
            {
                _compas = "North";
            }

            if (dir == 1)
            {
                _compas = "East";
            }

            if (dir == 2)
            {
                _compas = "South";
            }
            else
            {
                _compas = "West";
            }

            return _compas;
        }

        public Monster newEncounter()
        {
            encounter = new Monster();
            return encounter;
        }

        public Monster getMonster()
        {
            return encounter;
        }

        public void printMap()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(myMap[i,j]);
                    Console.Write(" ");
                }
            }
        }
    }
}