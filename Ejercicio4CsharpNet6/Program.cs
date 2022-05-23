Console.Write("Ingrese la cantidad de columnas: ");
int cantColumnas = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de filas: ");
int cantFilas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantFilas, cantColumnas];

int numDeColumnas = numeros.GetUpperBound(1) + 1;
int numDeFilas = numeros.GetUpperBound(0) + 1;
int suma = 0;
double[] promedios = new double[numDeColumnas];

for (int columna = 0; columna < numDeColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine($"Valores de la columna nº {columna + 1}:");

    for (int fila = 0; fila < numDeFilas; fila++)
    {
        Console.WriteLine($"Por favor, ingrese el valor nº {fila + 1}");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
        suma += numeros[fila, columna];
    }

    promedios[columna] = suma / (double)numDeFilas;
    suma = 0;
}

for (int columna = 0; columna < numDeColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine();
    Console.WriteLine($"Valores de la columna nº {columna + 1}:");

    for (int fila = 0; fila < numDeFilas; fila++)
    {
        Console.Write($"Valor nº {fila + 1}: ");
        Console.WriteLine(numeros[fila, columna]);
    }
}

for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine();
    Console.WriteLine($"El promedio de la columna {i + 1} es: {promedios[i]}");
}