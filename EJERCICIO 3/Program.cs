class Program
{
    static void Main()
    {
        EstudianteGraduado graduado1 = new EstudianteGraduado();

        graduado1.Nombre = "JuanPa";
        graduado1.Edad = 24;
        graduado1.Calificacion = 10;
        graduado1.Titulo = "Ingeniero de Software";

        
        graduado1.MostrarInformacion();
        Console.WriteLine($"Título obtenido: {graduado1.Titulo}");
    }
}