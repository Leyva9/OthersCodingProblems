internal class Program
{
    private static int CalculoMontañaRusa(int[] a) {
        int sumaEnergia = 0;
        int posicion = 0;
        for (int i = 0; i < a.Length; i++) {
            if(a[i] == 1) {
                sumaEnergia++;
            } else {
                sumaEnergia--;
                if(sumaEnergia == 0) {
                    System.Console.WriteLine("Se para el tren en la posición: " + i);
                    for (int j = i; j >= 0; j--) {
                        posicion = j;
                        System.Console.WriteLine("J: " + j);
                        if(a[j] == 0) {
                            sumaEnergia += 1;
                            System.Console.WriteLine("La suma de energia es:" + sumaEnergia);
                        } else {
                            sumaEnergia -= 1;
                            System.Console.WriteLine("La suma de energia es:" + sumaEnergia);
                            if (sumaEnergia == 0) {
                                break;
                            }
                        } 
                    }
                }
            }
            
        } return posicion;
    }

    private static void Main(string[] args)
    {
        int[] energiaCinetica = {1, 1, 1, 1, 1, -1, 0, 0, 1, 1, -1, 0, 1, -1, 0, 0, 0, 0};
        System.Console.WriteLine(CalculoMontañaRusa(energiaCinetica));
    }
}