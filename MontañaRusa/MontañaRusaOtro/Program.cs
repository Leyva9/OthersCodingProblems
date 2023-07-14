internal class Program
{
    private static int Posicion(int[] a) {
        int posicion_canal = 1;
        int energia = a[0];
        bool direccion = true;
        for(int i = 1; i < a.Length; i++) {
            energia = energia - a[i] - 1;
            if(energia == 0) {
                if(direccion) {
                } else if(!direccion) {
                    posicion_canal-=1;
                }
            }
            if(energia < 0) {
                energia+= a[i-1] + 1;
                direccion = false;
                posicion_canal-=1;
            }
            if(energia > 0) {
                posicion_canal+=1;
                energia+=a[i];
            }
                
        }
        return posicion_canal;
    }
    private static void Main(string[] args)
    {
        int[] alturas = {6, 2, 1, 4};
        Console.WriteLine(Posicion(alturas));
    }
}