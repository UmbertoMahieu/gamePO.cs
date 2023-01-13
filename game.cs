
class Game
{
    private int playerX;
    private int playerY;
    private List<Enemy> enemies;
    private List<Enemy> door;

    public Game()
    {
        
        playerX = 1;
        playerY = 1;

        Random rnd = new Random();
        int v1 = rnd.Next(1,9);
        int v2 = rnd.Next(1,9);
        int v3 = rnd.Next(1,9);
        int v4 = rnd.Next(1,9);


        enemies = new List<Enemy>();
        enemies.Add(new Enemy(v1, v2));

        // door = new List<door>();
        // door.Add(new door(v1, v2));
    }

     public void Run()
    {
        while (true)
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == playerX && j == playerY)
                    {
                        Console.Write("P");
                    }
                    else
                    {
                        bool enemyExist = false;
                        foreach (Enemy enemy in enemies)
                        {
                            if (i == enemy.X && j == enemy.Y)
                            {
                                Console.Write("E");
                                enemyExist = true;
                                break;
                            }
                        }
                        if (!enemyExist)
                        {
                            Console.Write(map[i, j]);
                        }
                    }
                }
                Console.WriteLine();
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (playerX > 0) 
                playerX--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (playerX < 9) 
                playerX++;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (playerY > 0) 
                playerY--;
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (playerY < 9) 
                playerY++;
            }
            foreach (Enemy enemy in enemies)
                {
                if (playerX == enemy.X && playerY == enemy.Y)
                {
                    Console.WriteLine("Game Over!");
                    return;
                }
            }
        }
    }
}
               
