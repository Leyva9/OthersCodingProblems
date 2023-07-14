internal class Program
{
    public static void DeslizaArray(int[] array, int n)
    {
        int aux = 0;
        /*if(array.Length == n || array.Length%n == 0)
            {
                System.Console.WriteLine("No hay nada que hacer...");
                return;
            }*/
        for (int i = 0; i < array.Length; i++)
        {
            if(i + n > array.Length)
            {
                aux = array[n-array.Length];
                array[i] = array[n-array.Length];
                i = n-array.Length;
            }
            else if(i + n < array.Length)
            {
                
            }  
        }
    }
    private static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4};
        DeslizaArray(arr, 1);
        foreach(var a in arr)
        {
            System.Console.Write(" {0}", a);
        }
    }
}