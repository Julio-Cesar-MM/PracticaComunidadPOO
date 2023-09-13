namespace ComunidadPOO.Class
{
    public class Maestro : Docente
    {
        public List<string> InstitucionActual { get; set; }
        public List<string> InstitucionesAnteriores { get; set; }

        public override void Guardar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Maestro guardado");
        }

        public override void Obtener(MiembroComunidad miembro)
        {
            base.Obtener(miembro);
            foreach (string institucionAnterior in InstitucionesAnteriores)
            {
                Console.WriteLine("Instituciones Anteriores: {0}", institucionAnterior);
            }

            foreach (string institucionActual in InstitucionActual)
            {
                Console.WriteLine("Institucion Actual: {0}", institucionActual);
            }
        }

        public override void Modificar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Maestro modificado");
        }

        public override void Borrar(MiembroComunidad miembro)
        {
            base.Borrar(miembro);
            InstitucionesAnteriores = null;
            InstitucionActual = null;
            Console.WriteLine("Maestro borrado");
        }
    }
}
