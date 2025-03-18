using System.ComponentModel.DataAnnotations;

int[,] popolaTemperature(int[,] Popola) // Esercizio A
{
    Random pieno = new Random();

    for (int i = 0; i < Popola.GetLength(1); i++)
    {
       Popola[0, i] = pieno.Next(-10, 35);     
    }
    return Popola;
}
int[,] valore(int[,] popola2) // Esercizio B
{
    int Counter = 0;
    int c = 0;
    int media = 0;
    for (int i = 0 ; i < popola2.GetLength(1); i++)
    {
        Console.Write(Counter + ",");
        for (int j = 0; j < popola2.GetLength(0); j++)
        {
            Counter += popola2[0, i];
            c = i + 1;
            media = (Counter / c);
            popola2[1, j] = media;
        }
    }
    return popola2;
}
int Massimo(int[,] popola2)
{
    int max = -200;

    for (int i = 0; i < popola2.GetLength(0); i++)
    {
        for (int j = 0; j < popola2.GetLength(1); j++)
        {
            if (popola2[i, j] > max)
            {
                max = popola2[i, j];
            }
        }
    }
    return max;
}

int[,] popola = new int[2, 12];
int[,] popola2 = popolaTemperature(popola);
int[,] popola3 = valore(popola);
int max1 = Massimo(popola2); 
Console.WriteLine( "Il valore massimo è " + max1);

for (int i = 0; i < popola2.GetLength(0); i++) //Stampa es.A
{
    for (int j = 0; j < popola2.GetLength(1); j++)
    {
        Console.Write("[" + popola2[i, j] + "]");
    }
    Console.WriteLine();
}

Console.WriteLine(); // Serve a distanziare l'output dell'esercizio A e l'output dell'esercizio B

for (int i = 0; i < popola2.GetLength(0); i++) //Stampa es.B
{
    for (int j = 0; j < popola2.GetLength(1); j++)
    {
        Console.Write("[" + popola3[i, j] + "]");
    }
    Console.WriteLine();
}