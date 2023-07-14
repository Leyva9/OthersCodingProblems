internal class Program
{
    private static int PosicionArreglo(int[] a) {
        bool direccion = true;
        int i = 0;
        int energia = a[0];
        for(;;) {
            if(energia == 1 && direccion) {
                System.Console.WriteLine(++i);
                break;
            }
            if(energia == 1 && !direccion) {
                System.Console.WriteLine(i);
                break;
            }
            if(direccion) {
                if(energia - a[i+1] -1 >= 0) {
                    ++i;
                    energia-=1;
                    direccion = true;
                    continue;
                }
                if(energia - a[i+1] - 1 < 0) {
                    direccion = false;
                    ++i;
                    energia-=1;
                    continue;
                }
            }
            if(!direccion) {
                if(energia - a[i-1] - 1 >= 0) {
                    i--;
                    energia-=1;
                    direccion = false;
                    continue;
                } 
                if(energia - a[i-1] - 1 < 0) {
                    i--;
                    energia-=1;
                    direccion = true;
                    continue;
                }
            }
        } return i;
    }
    private static void Main(string[] args)
    {
        int[] ArregloAlturas = {11, 1, 2, 2};
        PosicionArreglo(ArregloAlturas);
    }
}