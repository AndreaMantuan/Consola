using proyecto_consola.Models;
    
class Program
{
    static void Main(string[] args)
    {
        //agregarEstudiante();
        modificarEstudiante();
        consultarEstudiante();

    }

    public static void agregarEstudiante()
    {
        Console.WriteLine("Metodo agregar estudiante");
        TablaContext context = new TablaContext();
        Cliente std = new Cliente();
        std.Id = 3;
        std.Nombre = "Pedro";
        std.Apellido = "mantuano";
        std.Direccion = "brisas del rio";
        std.Telefono = Convert.ToInt32("097602739");
        std.FechaNacimiento = Convert.ToDateTime("2023-03-05");
        std.Estado = "activo";
        context.Clientes.Add(std);
        context.SaveChanges();


        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre);

    }
    public static void consultarEstudiante()
    {
        Console.WriteLine("Metodo consultar estudiante por Id");
        TablaContext context = new TablaContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(2);

        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre);

    }

    public static void modificarEstudiante()
    {
        Console.WriteLine("Metodo modificar estudiante");
        TablaContext context = new TablaContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(1);

        std.Nombre = "Anahi";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre);

    }

}
