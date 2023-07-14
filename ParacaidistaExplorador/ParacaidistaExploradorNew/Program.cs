internal class Program
{
    public static int Mod(int a)
    {
        return (a<0)?a*-1:a;
    }
    public static void RecorreLaMontaña(int[,] mapa, bool[,] mapaboolean, int a, int b)
    {
        System.Console.WriteLine("{0}:{1}", a, b);
        System.Console.WriteLine("{0}", mapa[a,b]);
        mapaboolean[a,b] = true;
        
        if(a < mapa.GetLength(0) - 1 && Mod(mapa[a + 1,b] - mapa[a, b]) <= 3 && !mapaboolean[a+1,b])
        {
            RecorreLaMontaña(mapa, mapaboolean, a + 1, b);
        }
        if(a > 0 && Mod(mapa[a - 1,b] - mapa[a, b]) <= 3 && !mapaboolean[a-1,b])
        {
            RecorreLaMontaña(mapa, mapaboolean, a - 1, b);
        }
        if(b < mapa.GetLength(1) - 1 && Mod(mapa[a,b + 1] - mapa[a, b]) <= 3 && !mapaboolean[a,b+1])
        {
            RecorreLaMontaña(mapa, mapaboolean, a, b + 1);
        }
        if(b > 0 && Mod(mapa[a,b - 1] - mapa[a, b]) <= 3 && !mapaboolean[a,b-1])
        {
            RecorreLaMontaña(mapa, mapaboolean, a, b - 1);
        }
    }
        //Direccion de la matriz
        static int[] drow = { -1, 1,  0, 0 };
        static int[] dcol = {  0, 0, -1, 1 };
        static int ParacaidistaExplorador(int[,] map, bool[,] mask, int currentRow, int currentCol, int nextRow, int nextCol, int k)
        {
            //Conteo de casillas
            int total = 0;
            //Se imprime la coordenada actual
            System.Console.WriteLine("{0}:{1}", currentRow, currentCol);
            //Se establece en la mascara en la posicion actual de la matriz como true
            mask[currentRow, currentCol] = true;
            //Se suma 1 al total
            total++;
            //Ciclo para verificar en las 4 direcciones
            for (int i = 0; i < drow.Length; i++)
            {
                //Se asigna a la variable nextrow y nextcol la casilla proxima a verificar, se hace para hacer una condicional mas organizada.
                nextRow = currentRow + drow[i];
                nextCol = currentCol + dcol[i];
                //Condicional, verifica si no se sale del arreglo, si la casilla no se ha explorado y si es posible avanzar segun K
                if(nextRow >= 0 && nextRow < map.GetLength(0) && nextCol >= 0 && nextCol < map.GetLength(1) && !mask[nextRow, nextCol] && Math.Abs(map[currentRow, currentCol] - map[nextRow, nextCol]) <= k)
                {
                    //Funcion recursiva, con la suma de la variable total...
                    total += ParacaidistaExplorador(map, mask, nextRow, nextCol, nextRow, nextCol, k);
                }
            }
            //Devuelve el total cuando no termina la recursion
            return total;
        }
    private static void Main(string[] args)
    {
        int[,] map = {{3, 1, 9, 2, 1, 10},
                      {5, 0, 6, 7, 8, 11},
                      {7, 1, 1, 2, 15, 12},
                      {1, 5, 8, 11, 14, 7}};
        bool[,] mapbool = new bool[map.GetLength(0), map.GetLength(1)];
        /*RecorreLaMontaña(map, mapbool, 1, 2);*/
        System.Console.WriteLine(ParacaidistaExplorador(map, mapbool, 1, 0, 0, 0, 3));
    }
}