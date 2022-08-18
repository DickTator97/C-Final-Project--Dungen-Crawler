//Final Project
//Dor Ben Dor
// Ziv Atad
// Due Date 24.07.22/21.08.22
//Current Date 21.07.22

namespace DungeonCrawler
{
    public class DungeonCrawler
    {
        public static void Main(string[] args)
        {
            bool gameIsRunning = true;
            Console.Title = "Bug Simulator";
            Console.ForegroundColor = ConsoleColor.Red;

            Maps MyMaps = new Maps();
            MyMaps.InitMap(MyMaps.Map1);
           // MyMaps.AddLine(12,12,5,MyMaps.Map1, RandomBool());
            MyMaps.AddLShape(12, 12, 5, MyMaps.Map1, RandomBool(),RandomBool());
          
            Player AwsomeSchtrudel = new Player(MyMaps.EntrancePosX,MyMaps.EntrancePosY);

            //add object to map
            Console.WriteLine();

            while (gameIsRunning)
            {
                Thread.Sleep(10);
                MyMaps.PrintMap(MyMaps.Map1, AwsomeSchtrudel);
                AwsomeSchtrudel.Move(MyMaps.Map1);

            }
        }
        public static bool RandomBool()
        {
            Random random = new Random();
            int numBool = random.Next(0, 2);
            return numBool == 1;
        }
        
    }
}

//1.completing  the obstacles  and making them asymetric
//2.Make The player movement and map load more fluidly 
//3.Adding an entry and an exit(to each level)
//4.Adding Enemies and find a way to include the Combat System from assignement 7 
//5.making an entry and an exit to the level , while also creating more maps , level transitions and additional areas
