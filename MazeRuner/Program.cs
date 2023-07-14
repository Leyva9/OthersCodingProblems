internal class Program
{
    public static bool SalidaDelMapa(int[,] map, int a, int b)
    {
        if(a == 3 && b == 4)  
        {
            return true;
        } 
        else
        {
            map[a,b] = 1;
            if(a+1 < map.GetLength(0) && map[a+1, b] != 1)
            {
                if(SalidaDelMapa(map, a+1, b))
                {
                    return true;
                }
                
            }
            if(a-1 >= 0 && map[a-1, b] != 1)
            {
                if(SalidaDelMapa(map, a-1, b))
                {
                    return true;
                }
            }
            if(b+1 < map.GetLength(1) && map[a, b+1] != 1)
            {
                if(SalidaDelMapa(map, a, b+1))
                {
                    return true;
                }
            }
            if(b-1 >= 0 && map[a, b-1] != 1)
            {
                if(SalidaDelMapa(map, a, b-1))
                {
                    return true;
                }
            }
             else
            {
                map[a,b] = 0;
            }
        }
        return false;        
    }  
    private static void Main(string[] args)
    {
        int[,] mapa = {{0, 1, 1, 0, 1},
                       {0, 0, 0, 0, 1},
                       {1, 0, 1, 1, 0},
                       {1, 0, 0, 0, 0},
                       {0, 0, 1, 1, 1}};

        Console.WriteLine(SalidaDelMapa(mapa, 0, 0));
    }
}