namespace ComunidadPOO.Class
{
    public class Estudiante : MiembroComunidad //Herencia
    {
        //Abstracion
        public string Matricula { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string Carrera { get; set; }
        public double? Promedio { get; set; }

        //Polimorfismo
        public override void Guardar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Estudiante guardado");
        }

        //Polimorfismo
        public override void Obtener(MiembroComunidad miembro)
        {
            base.Obtener(miembro);
            Console.WriteLine("Matricula: {0}", Matricula);
            Console.WriteLine("Fecha Ingreso: {0}", FechaIngreso);
            Console.WriteLine("Carrera: {0}", Carrera);
            Console.WriteLine("Promedio: {0}", Promedio);
        }

        //Polimorfismo
        public override void Modificar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Estudiante modificado");
        }

        //Polimorfismo
        public override void Borrar(MiembroComunidad miembro)
        {
            base.Borrar(miembro);
            Matricula = null;
            FechaIngreso = null;
            Carrera = null;
            Promedio = null;
            Console.WriteLine("Estudiante borrado");
        }

    }
}
