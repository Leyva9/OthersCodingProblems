internal class Program
{
    int[] alturas = {5, 2, 1, 4};
    private static int RecorreElTrenAtras(int[] a, int posicion, int energia) {
        
        System.Console.WriteLine(posicion + "+" + energia);
        for(int i = posicion; i >= 0; i--) {
            System.Console.WriteLine("Llegó al bucle");
            if(energia == 1) {
                System.Console.WriteLine("Se ejecuta paraa E==1");
                i-=1;
                continue;
            } else if (energia - a[i] - 1 >= 0) {
                System.Console.WriteLine("Se ejecuta paraa E >= 0");
                energia -= 1;
                continue;
            } return energia;
            /*} else {
                RecorreElTren(alturas, i - 1, a[i] -1);
            }*/
        
        } return posicion;
    }
    private static int RecorreElTren(int[] a, int posicion, int energia) {
        
        for(int i = posicion; i < a.Length; i++) {
            System.Console.WriteLine(energia);
            if(energia == 1) {
                System.Console.WriteLine("Se ejecuta paraa E==1");
                continue;
            } else if (energia - a[i] - 1 >= 0) {
                System.Console.WriteLine("Se ejecuta paraa E >= 0");
                energia -= 1;
                continue;
            } else {
                System.Console.WriteLine("Se ejecuta paraa E <= 0");
                RecorreElTrenAtras(a, i-1, energia - 1);
                continue;
            }
        } return posicion;
    }
    private static void Main(string[] args)
    {
        int[] alturas = {5, 2, 1, 4};
        System.Console.WriteLine(RecorreElTren(alturas, 1, alturas[0]));
    }
}