using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        bool esPalindromo = EsPalindromo(palabra);

        if (esPalindromo)
        {
            Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
        }
    }

    static bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;

        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}