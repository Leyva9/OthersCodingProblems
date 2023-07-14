internal class Program
{
    public static int[] RotaArray(int[] a, int k)
    {
        int aux = 0;
        for(int i = 0; i < a.Length && k > 0; i++)
        {
            aux = a[a.Length-1-i];
            a[a.Length-1-i] = a[i];
            a[i] = aux;
            k--;
        }
        foreach(var b in a)
        {
            System.Console.WriteLine(b);
        }
        return a;
    }
    private static void Main(string[] args)
    {
        int[] arrayCualquiera = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        Console.WriteLine(RotaArray(arrayCualquiera, 2));
    }
}