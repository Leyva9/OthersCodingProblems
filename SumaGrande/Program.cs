internal class Program
{
    public static int BusqSubSeqMax(int[] a)
    {
        int sumaMax = 0;
        int sumTemp = 0;
        for(int i = 0; i < a.Length; i++)
        {
            sumTemp = a[i];
            for(int j = i+1; j < a.Length; j++)
            {
                sumTemp+=a[j];
                if(sumTemp > sumaMax)
                {
                    sumaMax = sumTemp;
                }
            }
        }
        return sumaMax;
    }
    private static void Main(string[] args)
    {
        int[] array = {4, -2, 14, 1, -11, 7, 2};
        System.Console.WriteLine(BusqSubSeqMax(array));
    }
}