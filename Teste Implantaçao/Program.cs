using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Divisores de {numero}:");
        List<int> divisores = CalcularDivisores(numero);
        foreach (var divisor in divisores)
        {
            Console.Write(divisor + " ");
        }

        Console.WriteLine("\nDivisores primos de {numero}:");
        List<int> divisoresPrimos = CalcularDivisoresPrimos(divisores);
        foreach (var divisor in divisoresPrimos)
        {
            Console.Write(divisor + " ");
        }
    }

    static List<int> CalcularDivisores(int numero)
    {
        List<int> divisores = new List<int>();
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores.Add(i);
            }
        }
        return divisores;
    }

    static List<int> CalcularDivisoresPrimos(List<int> divisores)
    {
        List<int> divisoresPrimos = new List<int>();
        foreach (var divisor in divisores)
        {
            if (EhPrimo(divisor))
            {
                divisoresPrimos.Add(divisor);
            }
        }
        return divisoresPrimos;
    }

    static bool EhPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}