internal class Program
{
    public static int[] ConcatArray(int[] a, int[] b)
    {
        int[] c = new int[a.Length + b.Length]; 
        for(int i = 0; i < a.Length; i++)
        {
            c[i] = a[i];
        }
        for(int i = 0; i < b.Length; i++)
        {
            c[a.Length + i] = b[i];
        }
        return c;
    }
    private static void Main(string[] args)
    {
        int[] a = {3,6,2,6};
        int[] b = {2,7,1,9,2,1};
        int[] nuevo = ConcatArray(a, b);
        foreach (var item in nuevo)
        {
            System.Console.WriteLine(item);
        }
    }
}