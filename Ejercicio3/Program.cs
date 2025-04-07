using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Multiplicar un número entero por 2\n");

        try
        {
            // Solicitar al usuario que ingrese un número entero
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            // Multiplicar el número por 2
            int resultado = numero * 2;

            // Mostrar el resultado
            Console.WriteLine($"El resultado de multiplicar {numero} por 2 es: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, ingrese un número entero válido.");
        }

        Console.WriteLine("Programa finalizado.");
    }
}
