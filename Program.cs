class Programa {

    static void Main()
    {
        int[,] arreglo = {
            {0, 2, 5, 7, 6},
            {0, 0, 0, 3, 8},
            {2, 9, 6, 3, 4},
            {1, 5, 6, 1, 4},
            {0, 9, 2, 5, 0}
        };

        Calculadora gus = new Calculadora();

        int[] cerosPorFila = gus.CalcularCeros(arreglo);
        int[] renglones = gus.CalcularRenglones(arreglo);

        // Mostrar la cantidad de ceros por fila
        for (int i = 0; i < cerosPorFila.Length; i++)
        {
            Console.WriteLine($"Fila {i + 1}:  {cerosPorFila[i]} ceros");
        }
    }
}

public class Calculadora
{
    public int[] CalcularCeros(int[,] arreglo)
    {
        int filas = arreglo.GetLength(0);
        int columnas = arreglo.GetLength(1);
        int[] cerosPorFila = new int[filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (arreglo[i, j] == 0)
                {
                    cerosPorFila[i]++;
                }
            }
        }
        return cerosPorFila;
    }

    public int[] CalcularRenglones(int[,] arreglo)
    {
        int filas = arreglo.GetLength(0);
        int[] renglones = new int[filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < arreglo.GetLength(1); j++)
            {
                renglones[i] += arreglo[i, j];
            }
        }

        return renglones;
    }
}
