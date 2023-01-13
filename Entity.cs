class Entity
{
    public int x;
    private int y;

    public Entity(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int X { get { return x; } set { this.x = value; } }
    public int Y { get { return y; } set { this.y = value; } }
}

