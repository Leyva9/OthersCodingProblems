internal class Program
{
    private static void MinimoSuces(int[] array)
    {
        int minvalue = 0;
        int pos = 0;
        for(int i = 0; i < array.Length; i++)
        {
            minvalue = array[i];
            for(int j = i + 1; j < array.Length; j++)
            { 
                if(array[j] < minvalue)
                {
                    minvalue = array[j];
                    pos = j;
                }
            }
            minvalue = array[i];
            array[i] = array[pos];
            array[pos] = minvalue;
        }
    }
    private static void Main(string[] args)
    {
        int[] array = {2,5,1,6,7,1,7,8,1};
        MinimoSuces(array);
        foreach(var a in array)
        {
            System.Console.WriteLine(a);
        }
    }
}