
using System;
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
        map.Draw();
        
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

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (this.character.X > 0) 
                this.character.X--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (this.character.X < this.map.lenght - 1) 
                this.character.X++;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (this.character.Y > 0) 
                this.character.Y--;
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (this.character.Y < this.map.height -1) 
                this.character.Y++;
            }
            foreach (Entity enemy in this.ennemies)
                {
                if (this.character.X == enemy.X && this.character.Y == enemy.Y)
                {
                    Console.WriteLine("Game Over!");
                    return;
                }
            }
        }
    }
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
