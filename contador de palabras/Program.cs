using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        int contadorPalabras = 0;
        int contadorVocales = 0;
        bool estaEnPalabra = false;

        for (int i = 0; i < frase.Length; i++)
        {
            char caracter = frase[i];

            if (char.IsLetter(caracter))
            {
                if (!estaEnPalabra)
                {
                    contadorPalabras++;
                    estaEnPalabra = true;
                }

                if (EsVocal(caracter))
                {
                    contadorVocales++;
                }
            }
            else
            {
                estaEnPalabra = false;
            }
        }

        Console.WriteLine($"La cantidad de palabras es: {contadorPalabras}");
        Console.WriteLine($"La cantidad de vocales es: {contadorVocales}");
    }

    static bool EsVocal(char caracter)
    {
        char caracterMinuscula = char.ToLower(caracter);
        return caracterMinuscula == 'a' || caracterMinuscula == 'e' || caracterMinuscula == 'i' || caracterMinuscula == 'o' || caracterMinuscula == 'u';
    }
}