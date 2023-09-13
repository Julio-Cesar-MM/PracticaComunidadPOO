namespace ComunidadPOO.Class
{
    public class Docente : Empleado
    {
        public string Especialidad { get; set; }

        public string MateriaImpartida { get; set; }

        public override void Guardar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Docente guardado");
        }

        public override void Obtener(MiembroComunidad miembro)
        {
            base.Obtener(miembro);
            Console.WriteLine("Especialidad: {0}", Especialidad);
            Console.WriteLine("Materia Impartida: {0}", MateriaImpartida);
        }

        public override void Modificar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Docente modificado");
        }

        public override void Borrar(MiembroComunidad miembro)
        {
            base.Borrar(miembro);
            Especialidad = null;
            MateriaImpartida = null;
            Console.WriteLine("Docente borrado");
        }

    }
}
