namespace ComunidadPOO.Class
{
    public class Administrador : Docente
    {
        public List<string> Responsabilidades { get; set; }
        public override void Guardar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Administrador guardado");
        }

        public override void Obtener(MiembroComunidad miembro)
        {
            base.Obtener(miembro);
            foreach (string responsabilidades in Responsabilidades)
            {
                Console.WriteLine("Responsabilidades: {0}", responsabilidades);
            }
        }

        public override void Modificar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Administrador modificado");
        }

        public override void Borrar(MiembroComunidad miembro)
        {
            base.Borrar(miembro);
            Especialidad = null;
            MateriaImpartida = null;
            Console.WriteLine("Administrador borrado");
        }
    }
}
