using System;

class VisualizadorNumeros
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lectura e impresión de números distintos de cero\n");

        int contador = 0;

        while (true)
        {
            try
            {
                // Solicitar un número al usuario
                Console.Write("Ingrese un número (0 para terminar): ");
                int numero = int.Parse(Console.ReadLine());

                // Verificar si el número es cero para finalizar
                if (numero == 0)
                {
                    break;
                }

                // Imprimir el número y aumentar el contador
                Console.WriteLine($"Número ingresado: {numero}");
                contador++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }

        // Mostrar el número de valores leídos
        Console.WriteLine($"Se leyeron {contador} números en total.");
        Console.WriteLine("Programa finalizado.");
    }
}
