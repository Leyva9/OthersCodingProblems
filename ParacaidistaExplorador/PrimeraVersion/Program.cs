internal class Program
{
    static int[] dx = {-1, 0, 1, 0};
    static int[] dy = {0, -1, 0, 1};
    public static bool ParacaidistaExplorador(int[,] a, bool[,] b, int k, int abscisa, int ordenada)
    {
        if(b[abscisa , ordenada])

        b[abscisa, ordenada] = true;
        for(int i = 0; i < dx.GetLength(0); i++)
        {
            if()
        }
    }
    private static void Main(string[] args)
    {
        int[,] mapmontaña = {{3, 1, 9, 2, 1, 10},
                            {5, 0, 6, 7, 8, 11},
                            {7, 1, 1, 2, 15, 12},
                            {1, 5, 8, 11, 14, 7}};
        bool[,] mapmontañaBool = new bool [mapmontaña.GetLength(0), mapmontaña.GetLength(1)];
    }
}