using ComunidadPOO.Class;

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();
        estudiante.Nombres = "Julio Cesar";
        estudiante.Apellidos = "Mendez Medina";
        estudiante.Edad = 20;
        estudiante.Carrera = "Desarrollo Software";
        estudiante.Matricula = "2022-1041";
        estudiante.Promedio = 95;
        estudiante.FechaIngreso = new DateTime(2022, 05, 02);

        estudiante.Guardar(estudiante);
        estudiante.Obtener(estudiante);

        Empleado empleado = new Empleado();
        empleado.Nombres = "Davi";
        empleado.Apellidos = "Mendez Medina";
        empleado.Edad = 32;
        empleado.Salario = 200.000;
        empleado.Cargo = "PL SQL";
        empleado.Codigo = "001";
        empleado.AñosExperiencia = 8;

        empleado.Guardar(empleado);
        empleado.Obtener(empleado);

        Maestro maestro = new Maestro();
        maestro.InstitucionActual = new List<string>();
        maestro.InstitucionesAnteriores = new List<string>();

        maestro.InstitucionActual.Add("ITLA");
        maestro.InstitucionesAnteriores.Add("UASD");

        maestro.Guardar(maestro);
        maestro.Obtener(maestro);

        Administrador administrador = new Administrador();
        administrador.Responsabilidades = new List<string>();

        administrador.Responsabilidades.Add("Supervisar los insumos de la institucion");

        administrador.Guardar(administrador);
        administrador.Obtener(administrador);

    }
}
