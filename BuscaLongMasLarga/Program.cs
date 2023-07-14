internal class Program
{
    public static int Busca(int[] a)
    {
        int max = 0;
        int b = 1;
        for( int i = 0; i < a.Length; i++)
        {
            if(i < (a.Length - 1) && a[i] < a[i+1])
            {
                b++;
            }
            else
            {
                if(b > max)
                {
                    max = b;
                }
                b = 1;
            }
        }
        return max;
    }
    private static void Main(string[] args)
    {
        int[] arreglo = {1, 2, 3, 1, 2, 3, 4, 7, 8, 1, 2, 3, 4, 1, 2, 3, 4, 5 , 6, 7, 8, 9, 10, 1, 2, 4, 6, 7, 12, 34, 45};
        System.Console.WriteLine(Busca(arreglo));
    }
}