class Map
{
    private char[][] map;


    public Map()
    {
        map = new char[10][];
        for (int i = 0; i < 10; i++)
        {
            map[i] = new char[10];

            for (int j = 0; j < 10; j++)
            {
                if (i == 0 || i == 9 || j == 0 || j == 9)
                {
                    map[i][j] = '#';
                }
                else
                {
                    map[i][j] = '.';
                }
            }
        }
    }
}




