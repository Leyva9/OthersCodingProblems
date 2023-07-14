internal class Program
{
    static int[] dx = {1, 0, -1, 0};
    static int[] dy = {0, 1, 0, -1};
    public static bool HayCamino(int[,] map, bool[,] mapbool, int c1x, int c1y, int c2x, int c2y, int e)
    {
        if(c1x == c2x && c1y == c2y)
        {
            return true;
        }
        mapbool[c1x,c1y] = true;
        for(int i = 0; i < dx.Length; i++)
        {
            if(((c1x>0 && c1x < map.GetLongLength(0)) && (c1y>0 && c1y < map.GetLength(0))) && map[c1x + dx[i], c1y + dy[i]] <= map[c1x, c1y] && e > 0)
            {
                HayCamino(map, mapbool, c1x + dx[i], c1y + dy[i], c2x, c2y, e - 1);
            }
            if(((c1x>0 && c1x < map.GetLongLength(0)) && (c1y>0 && c1y < map.GetLength(0))) && map[c1x + dx[i], c1y + dy[i]] > map[c1x, c1y] && e > 0)
            {
                HayCamino(map, mapbool, c1x + dx[i], c1y + dy[i], c2x, c2y, e - (map[c1x + dx[i], c1y + dy[i]] - map[c1x, c1y]));
            }

        } 
        return false;
    }
    private static void Main(string[] args)
    {
        int[,] map = {{4, 4, -5, 9},
                      {3, 0, 15, 1},
                      {7, -1, 8, 10},
                      {4, 1, 0, 14}};
        bool[,] boleanmap = new bool[map.GetLength(0), map.GetLength(1)];
        Console.WriteLine(HayCamino(map, boleanmap, 0, 0, 3, 3, 45));
        
    }
}