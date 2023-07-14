internal class Program
{
    //int[] a = {1,2,4,4,1,7,3,8,2,34,2};
    public static void OrdenaBloques(int[] a, int k)
    {
        int pro = 0;
        int aux = 0;
        for(int i = 0; i < a.Length; i = i + k)
        {
            for(int j = i; j < i+k; j++)
            {
                pro = j+1;
                if(a[j] > a[pro])
                {
                    aux = a[pro];
                    a[pro] = a[j];
                    a[j] = aux;
                }
                if(j+k > a.Length)
                {
                    OrdenaPedacito(a,(i+k)-a.Length, j);
                    return;
                }
            }
            
        }
    }
    public static void OrdenaPedacito(int[] a, int k, int j)
    {
        int aux = 0;
        for(int i = j; i < a.Length - 1; i++)
        {
            if(a[i] > a[i+1])
            {
                aux = a[i];
                a[i] = a[i+1];
                a[i+1] = aux;
            }
        }
    }
    private static void Main(string[] args)
    {
        int[] a = {4,1,2,7,4,1,3,8,2,34,2};
        OrdenaBloques(a, 3);
        foreach (var item in a)
        {
            System.Console.Write("[{0}]", item);
        }
    }
}