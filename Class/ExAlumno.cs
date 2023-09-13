namespace ComunidadPOO.Class
{
    public class ExAlumno : MiembroComunidad
    {
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public string TituloObtenido { get; set; }
        public DateTime? FechaGraduacion { get; set; }

        public override void Guardar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("ExAlumno guardado");
        }

        public override void Obtener(MiembroComunidad miembro)
        {
            base.Obtener(miembro);
            Console.WriteLine("Matricula: {0}", Matricula);
            Console.WriteLine("Carrera: {0}", Carrera);
            Console.WriteLine("Titulo Obtenido: {0}", TituloObtenido);
            Console.WriteLine("Fecha Graduacion: {0}", FechaGraduacion);
        }

        public override void Modificar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("ExAlumno modificado");
        }

        public override void Borrar(MiembroComunidad miembro)
        {
            base.Borrar(miembro);
            Matricula = null;
            TituloObtenido = null;
            Carrera = null;
            FechaGraduacion = null;
            Console.WriteLine("ExAlumno borrado");
        }
    }
}