class Door
{
    private int x;
    private int y;
    private int nextMap;

    public Door(int x, int y, int nextMap)
    {
        this.x = x;
        this.y = y;
        this.nextMap = nextMap;
    }

    public int X { get { return x; } }
    public int Y { get { return y; } }
    public int NextMap { get { return nextMap; } }
}