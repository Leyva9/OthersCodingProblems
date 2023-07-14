internal class Program
{
    private static void Rotar(int[] a, int b)
    {
        int[] c = new int[5];
        
        if(b % 2 != 0)
        {
            for(int j = 0; j < 5; j++)
            {
                int indice = 0;
                for(int k = 0; k < 5; k++)
                {
                    if(a[k] > 0) 
                    {
                        a[k] = a[k] - 1;
                        indice+= 1;
                    }
                    if(a[k] == 0)
                    {
                        continue;
                    }
                } 
                    c[j] = indice;
            }
            foreach(var t in c)
            {
                System.Console.Write(t);
            }      
        }
        else{
            Array.Sort(a);
            Array.Reverse(a);
            foreach(var bb in a)
            {
                System.Console.Write(bb);
            }
        }    
    }
    private static void Main(string[] args)
    {
        int[] arr = {2, 4, 2, 1, 3};
        //Con una rotación debe devolver {5, 4, 2, 1}
        //Con dos rotaciones debe devolver {4, 3, 2, 2, 1}
        Rotar(arr, 1);

    }
}