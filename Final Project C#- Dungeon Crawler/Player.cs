namespace DungeonCrawler
{

    public class Player
    {
        internal char m_Symbol = '@';

        internal int x;
        internal int y;
        //1.initilize a symbol to represent the player
        //2.setting input for movment inside the map


        public Player(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Move(char[,] currentMap)
        {
            ConsoleKey currentKey = Console.ReadKey().Key;
            int previousPosition;
            switch (currentKey)
            {
                case ConsoleKey.W:
                    previousPosition = y;
                    if (currentMap[previousPosition - 1, x] == Maps.Empty)
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.S:
                    previousPosition = y;
                    if (currentMap[previousPosition + 1, x] == Maps.Empty)
                    {
                        y++;
                    }
                    break;
                case ConsoleKey.D:
                    previousPosition = x;
                    if (currentMap[y, previousPosition + 1] == Maps.Empty)
                    {
                        x++;
                    }
                    break;
                case ConsoleKey.A:
                    previousPosition = x;
                    if (currentMap[y, previousPosition - 1] == Maps.Empty)
                    {
                        x--;
                    }
                    break;
                default:
                    break;
            }
            //public void Move(char[,] currentMap)
            //{
            //    ConsoleKey currentKey = Console.ReadKey().Key;
            //    int previousPosition;
            //    switch (currentKey)
            //    {
            //        case ConsoleKey.W:
            //            previousPosition = y;
            //            if (currentMap[previousPosition - 1, x] == (Maps.empty))
            //            {
            //                Console.SetCursorPosition(x, previousPosition);
            //                Console.Write(Maps.empty);
            //                y--;
            //                Console.SetCursorPosition(x, y);
            //                Console.Write(m_Symbol);
            //            }
            //            break;
            //        case ConsoleKey.S:
            //            previousPosition = y;
            //            if (currentMap[previousPosition + 1, x] == Maps.empty)
            //            {
            //                Console.SetCursorPosition(x, previousPosition);
            //                Console.Write(Maps.empty);
            //                y++;
            //                Console.SetCursorPosition(x, y);
            //                Console.Write(m_Symbol);
            //            }
            //            break;
            //        case ConsoleKey.D:
            //            previousPosition = x;
            //            if (currentMap[y, previousPosition + 1] == Maps.empty)
            //            {
            //                Console.SetCursorPosition(previousPosition, y);
            //                Console.Write(Maps.empty);
            //                x++;
            //                Console.SetCursorPosition(x, y);
            //                Console.Write(m_Symbol);
            //            }
            //            break;
            //        case ConsoleKey.A:
            //            previousPosition = x;
            //            if (currentMap[y, previousPosition - 1] == Maps.empty)
            //            {
            //                Console.SetCursorPosition(previousPosition, y);
            //                Console.Write(Maps.empty);
            //                x--;
            //                Console.SetCursorPosition(x, y);
            //                Console.Write(m_Symbol);
            //            }
            //            break;
            //        default:
            //            break;
            //    }
            //    Console.SetCursorPosition(0, 24);
        }
    }
}

