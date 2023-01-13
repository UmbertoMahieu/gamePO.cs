class Map
{
    private char[][] matrix;


    public Map(int lenght, int height)
    {
        matrix = new char[height][];
        for (int i = 0; i < height; i++)
        {
            matrix[i] = new char[lenght];

            for (int j = 0; j < lenght; j++)
            {
                if (i == 0 || i == 9 || j == 0 || j == 9)
                {
                    matrix[i][j] = '#';
                }
                else
                {
                    matrix[i][j] = '.';
                }
            }
        }
    }


    public void Draw(Entity[] entity){
        for (int i = 0; i < 10; i++)
        {   
            for (int j = 0; j < 10; j++)
            {
                System.Console.Write(matrix[i][j]);
            }
            System.Console.WriteLine();
        }
    }

    public void DrawEntities(Entity[] entity){
        for (int i = 0 ; i < entity.Length ; i++)
        {   
            System.Console.WriteLine(entity[0].X);
            System.Console.WriteLine(entity[0].Y);
        }
    }

    public char getCell(int x, int y)
    {
        return this.matrix[x][y];
    }
}






    
//     for (int i = 0; i < 10; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//             if (i == playerX && j == playerY)
//             {
//                 Console.Write("P");
//             }
//             else
//             {
//                 bool enemyExist = false;
//                 foreach (Enemy enemy in enemies)
//                 {
//                     if (i == enemy.X && j == enemy.Y)
//                     {
//                         Console.Write("E");
//                         enemyExist = true;
//                         break;
//                     }
//                 }
//                 if (!enemyExist)
//                 {
//                     Console.Write(this.matrix[i][j]);
//                 }
//             }
//         }
//         Console.WriteLine();
//     }