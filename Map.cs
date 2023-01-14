namespace MyApp
{
    class Map {
        public const int SquareWidth = 3;
        private Cell[][] matrix;
        public int Width {get;}
        public int Height {get;}
        public Map(int width, int height) {
            this.Width = width;
            this.Height = height;
            this.matrix = new Cell[height][];
            for (int i = 0; i < height; i++) {
                this.matrix[i] = new Cell[width];
                for (int j = 0; j < width; j++) {
                    if (i == 0 || i == height -1 || j == 0 || j == width -1) {
                        this.matrix[i][j] = new Cell(this, j, i, CellTypes.Wall);
                    }
                    else {
                        this.matrix[i][j] = new Cell(this, j, i, CellTypes.Empty);
                    }
                }
            }
        }
        public void Draw() {
            for (int i = 0; i < this.Height; i++) {
                for (int j = 0; j < this.Width; j++) {
                    for (int k = 0; k < Map.SquareWidth; k++) {
                        switch (this.matrix[i][j].CellType) {
                            case CellTypes.Wall:
                                System.Console.Write('#');
                                break;
                            case CellTypes.Empty:
                                System.Console.Write(' ');
                                break;
                        }
                    }
                }
                System.Console.WriteLine();
            }
        }
        public Cell GetCell(int x, int y)
        {
            if (x >= this.Height || y >= this.Width)
                return null;
            return this.matrix[y][x];
        }
    }
}
