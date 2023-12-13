using System;

public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Calificación: {Calificacion}");
    }
}
