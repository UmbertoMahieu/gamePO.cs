
namespace MyApp
{
    class Map
    {
        private char[][] matrix;

        public int lenght {get;}

        public int height {get;}


        public Map(int lenght, int height)
        {
            this.lenght = lenght;
            this.height = height;
            matrix = new char[height][];
            for (int i = 0; i < height; i++)
            {
                matrix[i] = new char[lenght];

                for (int j = 0; j < lenght; j++)
                {
                    if (i == 0 || i == height -1 || j == 0 || j == lenght -1)
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


        public void Draw(){
            for (int i = 0; i < this.height; i++)
            {   
                for (int j = 0; j < this.lenght; j++)
                {
                    System.Console.Write(matrix[i][j]);
                }
                System.Console.WriteLine();
            }
        }

        public void DrawEntities(List<Entity> entities){
            for (int i = 0 ; i < entities.Length ; i++)
            {   
                System.Console.WriteLine(entities[0].X);
                System.Console.WriteLine(entities[0].Y);
            }
        }

        public void DrawAll(){
            Draw();
            DrawEntities(Entity[])
        }

        public char getCell(int x, int y)
        {
            return this.matrix[x][y];
        }
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