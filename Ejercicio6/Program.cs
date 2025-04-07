using System;

class NumPrimos
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número para verificar si es primo:");
        int numero;

        // Validar entrada
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo válido:");
        }

        if (EsPrimo(numero))
        {
            Console.WriteLine($"El número {numero} es primo.");
        }
        else
        {
            Console.WriteLine($"El número {numero} no es primo.");
        }
    }

    static bool EsPrimo(int num)
    {
        // Casos especiales
        if (num == 1) return false; // 1 no es primo
        if (num == 2) return true;  // 2 es el único número par primo

        // Revisar divisibilidad desde 2 hasta la raíz cuadrada de n
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
