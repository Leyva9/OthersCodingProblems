internal class Program
{
    private static void OrdenaBloque(int bloque, int[] array)
    {
        int aux = 0;
        int count = bloque;
        for(int k = 0; k < array.Length; k+=bloque)
        {
            for(int i = k; i < (count-1); i++)
            {
                for(int j = i+1; j < count; j++)
                {
                    if(array[i] > array[j])
                    {
                        aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            count+=bloque;
        }
        
    }
    private static void Main(string[] args)
    {
        int[] array = {2,5,1,6,7,1,7,8,1};
        OrdenaBloque(3 ,array);
        foreach(var a in array)
        {
            System.Console.WriteLine(a);
        }
    }
}