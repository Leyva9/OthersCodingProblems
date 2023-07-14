internal class Program
{
    public static bool ItIsPossible(int[,] a, int[,] b)
    {
        if(a.GetLength(0) >= b.GetLength(0) && a.GetLength(1) >= b.GetLength(1))
        {
            return true;
        }
        return false;
    }
    public static int CheckCost(int[,] a)
    {
        int[] array = new int[a.GetLength(0)*a.GetLength(1)];
        Array.Copy(a, 0, array, 0, a.GetLength(0)*a.GetLength(1));
        return Math.Abs(array.Min() - array.Max());
    }
    public static int TheMinorCost(int[,] a, int fila, int columna, int x = 0, int y = 0, int minCost = int.MaxValue)
    {
        int[,] airport = new int[fila,columna];
        int cost = 0;
        if(!(ItIsPossible(a, airport)))
        {
            return -1;
        }
        for(int i = 0; i < airport.GetLength(0); i++)
        {
            Array.Copy(a, i*a.GetLength(1), airport, i*fila, columna);   
        }
        cost = CheckCost(airport);
        if(cost < minCost)
        {
            minCost = cost;
        }
        return minCost;
        
    }
    private static void Main(string[] args)
    {
        int[,] map = {{2, 2, 2, 4, 1},
                    {4, 1, 5, 7, 8},
                    {2, 1, 2, 2, 4},
                    {2, 2, 2, 2, 1},
                    {-10, 10, 3, 2, 1}};

        TheMinorCost(map, 2, 2);
    }
}