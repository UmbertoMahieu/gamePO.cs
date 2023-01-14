using System;
using System.Collections.Generic;
using System.Threading;

namespace MyApp
{
    class Game
    {
        private Entity character;
        private List<Entity> enemies;
        private Map map;

        public Game()
        {
            this.map = new Map(10,10);
            this.character = new Entity(this.map, map.GetCell(1, 1));
            this.enemies = new List<Entity>();
            this.addEnnemy();
            this.addEnnemy();
        }

        public void addEnnemy()
        {
            Random rnd = new Random();
            int monsterX, monsterY;
            Cell monsterCell;
            do {
                monsterX = rnd.Next(0, this.map.Width);
                monsterY = rnd.Next(0, this.map.Height);
                monsterCell = this.map.GetCell(monsterX, monsterY);
            } while (monsterCell == null || !monsterCell.CanStep());
            try {
                this.enemies.Add(new Entity(this.map, monsterCell));
            } catch (Exception){};
        }

        public void DrawEntities(){
            int tmpLeft = Console.CursorLeft;
            int tmpTop = Console.CursorTop;
            ConsoleColor tmpColor = Console.BackgroundColor;

            Console.CursorTop = this.character.Cell.Y;
            Console.CursorLeft = this.character.Cell.X * Map.SquareWidth;
            Console.BackgroundColor = ConsoleColor.Blue;

            for (int i = 0; i < Map.SquareWidth; i++) {
                Console.Write(' ');
            }

            Console.CursorTop = tmpTop;
            Console.CursorLeft = tmpLeft;
            Console.BackgroundColor = tmpColor;

            foreach (Entity entity in this.enemies) {
                Console.CursorTop = entity.Cell.Y;
                Console.CursorLeft = entity.Cell.X * Map.SquareWidth;
                Console.BackgroundColor = ConsoleColor.DarkRed;

                for (int i = 0; i < Map.SquareWidth; i++) {
                    Console.Write(' ');
                }
            }
            Console.CursorTop = tmpTop;
            Console.CursorLeft = tmpLeft;
         
            Console.BackgroundColor = tmpColor;
        }

        private static readonly object LockCount = new object();
        public void Draw() {
            lock (LockCount) {
                Console.Clear();
                this.map.Draw();
                this.DrawEntities();
            }
        }
        public void Run() {
            var th2 = new Thread(wander);
            th2.Start();
            while (true) {
                this.Draw();
                ConsoleKey ck;
                do {
                    ck = Console.ReadKey().Key;
                    if (handleKeys(ck)) break;
                } while (true);
            }
        }

        private bool handleKeys(ConsoleKey ck) {
            switch (ck) {
                case ConsoleKey.UpArrow:
                    return this.character.ChangeCell(Directions.Top);
                case ConsoleKey.RightArrow:
                    return this.character.ChangeCell(Directions.Right);
                case ConsoleKey.DownArrow:
                    return this.character.ChangeCell(Directions.Bottom);
                case ConsoleKey.LeftArrow:
                    return this.character.ChangeCell(Directions.Left);
                default:
                    return false;
            }
        } 

        private void wander() {
            Random rnd;
            while (true) {
                rnd = new Random();
                foreach (Entity enemy in this.enemies) {
                    Array values = Enum.GetValues(typeof(Directions));
                    Directions randomDirection = (Directions)values.GetValue(rnd.Next(values.Length));
                    if (enemy.ChangeCell(randomDirection)) this.Draw();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}