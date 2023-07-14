internal class Program
{
    public static int CheckCost(int[,] a)
    {
        int[] array = new int[a.GetLength(0) * a.GetLength(1)];
        int index = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                array[index++] = a[i, j];
            }
        }
        return Math.Abs(array.Min() - array.Max());
    }
    public static int ReturnMinCost(int[,] a, int fila, int columna)
    {
        int[,] airport = new int[fila,columna];
        int minCost = int.MaxValue;
        int cost = 0;
        for(int i = 0; i <= a.GetLength(0)+1 - fila; i++)
        {
            for(int j = 0; j < fila; j++)
            {
                Array.Copy(a, (i+j)*a.GetLength(1), airport, j*fila, columna);
            }
            cost = CheckCost(airport);
            if(cost<minCost)
            {
                minCost=cost;
            }
        }
        return minCost;
        for(int i = 0; i <= a.GetLength(1)+1 - columna; i++)
        {
            for(int j = 0; j < columna; j++)
            {
                
            }
        }
    } 
    private static void Main(string[] args)
    {
        int[,] map = {{2, 2, 2, 4, 1},
                    {4, 1, 5, 7, 8},
                    {2, 1, 2, 2, 4},
                    {2, 2, 2, 2, 1},
                    {-10, 10, 3, 2, 1}};
        ReturnMinCost(map, 2, 2);
    }
}