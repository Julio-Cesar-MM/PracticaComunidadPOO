namespace ComunidadPOO.Class
{
    public class Administrativo : Empleado
    {
        public string Departamento { get; set; }

        public override void Guardar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Administrativo guardado");
        }

        public override void Obtener(MiembroComunidad miembro)
        {
            base.Obtener(miembro);
            Console.WriteLine("Departamento: {0}", Departamento);
        }

        public override void Modificar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Administrativo modificado");
        }

        public override void Borrar(MiembroComunidad miembro)
        {
            base.Borrar(miembro);
            Departamento = null;

        }
    }
}
