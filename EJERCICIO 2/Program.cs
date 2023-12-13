using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa tu edad: ");

        if (int.TryParse(Console.ReadLine(), out int edad))
        {
            if (edad >= 18)
            {
                Console.WriteLine("La persona es mayor de edad.");
            }
            else
            {
                Console.WriteLine("La persona no es mayor de edad.");
            }
        }
        else
        {
            Console.WriteLine("Error: Ingresa un número válido para la edad.");
        }
    }
}
