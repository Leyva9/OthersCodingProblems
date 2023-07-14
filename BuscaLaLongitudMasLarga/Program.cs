internal class Program
{
    private int LongMasLarga(int[] a)
    {
        int count = 0;
        for(int i = 0; i < a.Length; i++)
        {
            if (a[i] < a[i+1])
            {
                count++;
            }
            else
            {
                
            }
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}