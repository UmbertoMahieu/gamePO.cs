
using System.Collections.Generic;

class Game
{
    private Entity character;
    private List<Entity> ennemies;

    private Map map;

    public Game()
    {
        this.character = new Entity(1,1);
        this.map = new Map(10,10);
        this.ennemies = new List<Entity>();
        
    }

    public bool addEnnemy(int x, int y)
    {
        if (this.map.getCell(x,y) == '.')
        {
            this.ennemies.Add(new Entity(x, y));
            return true;
        }
        return false;
    }

    // public void Run()
    // {
    //     while (true)
    //     {
    //         Console.Clear();
            
    //         ConsoleKeyInfo keyInfo = Console.ReadKey();
    //         if (keyInfo.Key == ConsoleKey.UpArrow)
    //         {
    //             if (playerX > 0) 
    //             playerX--;
    //         }
    //         else if (keyInfo.Key == ConsoleKey.DownArrow)
    //         {
    //             if (playerX < 9) 
    //             playerX++;
    //         }
    //         else if (keyInfo.Key == ConsoleKey.LeftArrow)
    //         {
    //             if (playerY > 0) 
    //             playerY--;
    //         }
    //         else if (keyInfo.Key == ConsoleKey.RightArrow)
    //         {
    //             if (playerY < 9) 
    //             playerY++;
    //         }
    //         foreach (Entity enemy in enemies)
    //             {
    //             if (playerX == enemy.X && playerY == enemy.Y)
    //             {
    //                 Console.WriteLine("Game Over!");
    //                 return;
    //             }
    //         }
    //     }
    // }
}
               


               // for (int i = 0; i < 10; i++)
            // {
            //     for (int j = 0; j < 10; j++)
            //     {
            //         if (i == playerX && j == playerY)
            //         {
            //             Console.Write("P");
            //         }
            //         else
            //         {
            //             bool enemyExist = false;
            //             foreach (Enemy enemy in enemies)
            //             {
            //                 if (i == enemy.X && j == enemy.Y)
            //                 {
            //                     Console.Write("E");
            //                     enemyExist = true;
            //                     break;
            //                 }
            //             }
            //             if (!enemyExist)
            //             {
            //                 Console.Write(map[i, j]);
            //             }
            //         }
            //     }
            //     Console.WriteLine();
            // }
