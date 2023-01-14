namespace MyApp
{
    enum CellTypes {
        Wall,
        Empty
    }
    class Cell
    {
        public int X {get;}
        public int Y {get;}
        public CellTypes CellType {get;}
        public bool Empty {get;set;}
        public Map Map {get;}
        public Cell(Map map, int x, int y, CellTypes celltype)
        {
            this.Map = map;
            this.Empty = true;
            this.X = x;
            this.Y = y;
            this.CellType = celltype;
        }
        public Cell Top {
            get {
                return this.Map.GetCell(this.X, this.Y - 1);
            }
        }
        public Cell Left {
            get {
                return this.Map.GetCell(this.X - 1, this.Y);
            }
        }
        public Cell Right {
            get {
                return this.Map.GetCell(this.X + 1, this.Y);
            }
        }
        public Cell Bottom {
            get {
                return this.Map.GetCell(this.X, this.Y + 1);
            }
        }
        public bool CanStep() {
            return this.Empty && this.CellType == CellTypes.Empty;
        }
    }
}
