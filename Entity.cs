
namespace MyApp
{
    public enum Directions {
            Top,
            Right,
            Bottom,
            Left
    }
    class Entity
    {
        public Cell Cell {get;set;}
        public Map Map {get;}

        public Entity(Map map, Cell cell)
        {
            this.Map = map;
            if (!cell.Empty)
                throw new Exception();
            this.Cell = cell;
            cell.Empty = false;
        }

        public bool ChangeCell(Directions direction) {
            Cell origin = this.Cell;
            Cell dest = null;
            switch (direction) {
                case Directions.Top:
                    dest = origin.Top;
                    break;
                case Directions.Right:
                    dest = origin.Right;
                    break;
                case Directions.Bottom:
                    dest = origin.Bottom;
                    break;
                case Directions.Left:
                    dest = origin.Left;
                    break;
            }
            if (dest == null || !dest.CanStep()) return false;
            origin.Empty = true;
            dest.Empty = false;
            this.Cell = dest;
            return true;
        }
    }
}