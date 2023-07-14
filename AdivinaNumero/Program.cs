internal class Program
{
    //Función que busca coincidencias entre el numero elegido del usuario y un numero random de la pc
    public static int NumeroDeVeces(int a, int b)
    {
        //Se inicializa un bool encontrado y keepPlaying para tener una condición de parada
        bool encontrado = false;
        bool keepPlaying = true;
        int intentos = 0;
        //Se inicializa un objeto random de la clase random para poder usarlo.
        Random rand = new Random();
        while(!encontrado && !keepPlaying)
        {
            intentos++;
            System.Console.WriteLine("Escribe un numero entre {0} y {1}", a, b);
            int aleatorio = Int32.Parse(Console.ReadLine());
            //Se asegura que el numero que coja el usuario no esté fuera del rango
            if(aleatorio < a || aleatorio > b)
            {
                System.Console.WriteLine("Escoge un numero entre {0} y {1}, no hagas trampas... ", a, b);
            }
            //La pc asigna una numero aleatorio
            int aleatorio1 = rand.Next(a,b);
            //Si coinciden los numeros devuelve true;
            if(aleatorio == aleatorio1)
            {
                encontrado = true;
                System.Console.WriteLine("Encontrado... En {0} intentos XD ", intentos);
                System.Console.WriteLine("Quieres volver a jugar? presiona 1 si es así...");
                if(Int32.Parse(Console.ReadLine()) == 1)
                {
                    System.Console.WriteLine("Perfecto, Seguimos...");
                    intentos=0;
                }
                else{
                    keepPlaying = false;
                }
            }
            if((Math.Abs(aleatorio1 - aleatorio) < 2) && !encontrado)
            {
                System.Console.WriteLine("Casi acierto... ");
            }
        }
        return intentos;
        
    }
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Selecciona el rango de numeros que quieres para q la computadora adivine");
        System.Console.WriteLine("Desde: ");
        int inicio = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Hasta: ");
        int final = Int32.Parse(Console.ReadLine());
        if(Math.Abs(final-inicio) < 100)
        {
            NumeroDeVeces(inicio, final);
        }
        else
        {
            System.Console.WriteLine("Si no quieres morir en el intento baja un poco el tamaño del rango de numeros ");
        }
    }
}