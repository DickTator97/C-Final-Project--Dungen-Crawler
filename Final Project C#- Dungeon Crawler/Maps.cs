namespace DungeonCrawler
{

    public class Maps
    {
        public char[,] Map1 = new char[20, 40];
        //char[,] Map2 = new char[25, 25];
        //char[,] Map3 = new char[25, 25];
        //char[,] Map4 = new char[25, 25];
        //char[,] Map5 = new char[25, 25];
        //char[,] Map6 = new char[25, 25];
        //char[,] Map7 = new char[25, 25];
        //char[,] Map8 = new char[25, 25];
        //char[,] Map9 = new char[25, 25];
        //char[,] Map10 = new char[25, 25];
        //char[,] CurrentMap = new char[25, 25]
        public const char TopNbottom = '-';
        public const char Empty = ' ';
        public const char Walls = '|';
        public const char Obstacles = '-';
        public const char Obstacles2 = '-';
        public const char Entrance = 'E';

        public int EntrancePosX = 4;
        public int EntrancePosY = 5;
        
        
        // 1. Add To Map/s
        // 2.make Player Spawn in position
        // 3.reapet step two in next Area After map 1 

        public const char Exit = 'X';
        public int ExitPosX = 10;
        public int ExitPosY = 15;
        
        //1.Add To Map/s
        //2. Load Next Area if Player position is the same 
        //3. Reapets step 2 for next Area 

        //1.print once after first Symbole
        //2. Print in a new line after 1st time 
        public void InitMap(char[,] currentMap)
        {
            for (int i = 0; i < currentMap.GetLength(0); i++)
            {
                for (int j = 0; j < currentMap.GetLength(1); j++)
                {
                    if (i > 0 && i < currentMap.GetLength(0) - 1 && j > 0 && j < currentMap.GetLength(1) - 1)
                    {


                        currentMap[i, j] = Empty;
                        continue;
                    }
                    else
                    {
                        //is border
                        if (j == 0 || j == currentMap.GetLength(1) - 1)
                        {
                            currentMap[i, j] = Walls;

                            continue;
                        }
                    }
                    currentMap[i, j] = TopNbottom;
                }
            }
        }
        public void PrintMap(char[,] currentMap, Player player)
        {
            Console.Clear();
          
            
            for (int i = 0; i < currentMap.GetLength(0); i++)
            {
                for (int j = 0; j < currentMap.GetLength(1); j++)
                {
                    if (player.x == j && player.y == i)
                    {
                        Console.Write(player.m_Symbol);
                        continue;
                    }

                    //move to different method which will spawn player on E 
                    if (j == EntrancePosX && i == EntrancePosY)
                    {
                        Console.Write(Entrance);
                        continue;
                    }

                    if (j==ExitPosX && i==ExitPosY)
                    {
                        Console.Write(Exit);
                        continue;
                    }

                    Console.Write(currentMap[i, j]);

                }

                Console.WriteLine();
            }
        }
        public void AddLine(int x, int y, int size, char[,] currentMap, bool isHor)
        {
            for (int i = 0; i < size; i++)
            {
                if (isHor)
                {
                    currentMap[x, y + i] = Obstacles;
                    
                }
                else
                {
                    currentMap[x + i, y] = Obstacles;
                }

            }

        }
        public void AddLShape(int x, int y, int size, char[,] currentMap, bool isHor, bool IsPositive)
        {
            for (int i = 0; i < size; i++)
            {
                if (IsPositive)
                {
                    if (isHor)
                    {
                        currentMap[x, y + i] = Obstacles;
                    }
                    else
                    {
                        currentMap[x + i, y] = Obstacles;
                    }
                }
                else
                {
                    if (isHor)
                    {
                        currentMap[x, y - i] = Obstacles;
                    }
                    else
                    {
                        currentMap[x - i, y] = Obstacles;
                    }

                }

            }
            for (int i = 0; i < size; i++)
            {
                if (IsPositive)
                {
                    if (isHor)
                    {
                        currentMap[x + i, y] = Obstacles;
                    }
                    else
                    {
                        currentMap[x, y + i] = Obstacles;
                    }
                }
                else
                {
                    if (isHor)
                    {
                        currentMap[x - i, y] = Obstacles;
                    }
                    else
                    {
                        currentMap[x, y - i] = Obstacles;
                    }
                }
            }
        }
        public void AddUShape(int x, int y, int size, char[,] currentMap, bool Ver,bool IsNegative)
        {
            for (int i = 0; i < size; i++)
            {
                if (IsNegative)
                {
                    if (Ver)
                    {
                        currentMap[x, y + i] = Obstacles;
                    }
                    else
                    {
                        currentMap[x + i, y] = Obstacles;
                    }
                }
                else
                {
                    if (Ver)
                    {
                        currentMap[x, y - i] = Obstacles;
                    }
                    else
                    {
                        currentMap[x - i, y] = Obstacles;
                    }

                }
            }
            for (int i = 0; i < size; i++)
            {
                if (IsNegative)
                {
                    if (Ver)
                    {
                        currentMap[x + i, y] = Obstacles;
                    }
                    else
                    {
                        currentMap[x, y + i] = Obstacles;
                    }
                }
                else
                {
                    if (Ver)
                    {
                        currentMap[x - i, y] = Obstacles;
                    }
                    else
                    {
                        currentMap[x, y - i] = Obstacles;
                    }
                }
            }


        }
    }
}