namespace ComunidadPOO.Class
{
    public class Empleado : MiembroComunidad
    {
        public string Codigo { get; set; }
        public string Cargo { get; set; }
        public double? Salario { get; set; }
        public int? AñosExperiencia { get; set; }

        public override void Guardar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Empleado guardado");
        }

        public override void Obtener(MiembroComunidad miembro)
        {
            base.Obtener(miembro);
            Console.WriteLine("Codigo: {0}", Codigo);
            Console.WriteLine("Cargo: {0}", Cargo);
            Console.WriteLine("Salario: {0}", Salario);
            Console.WriteLine("Años Experiencia: {0}", AñosExperiencia);
        }

        public override void Modificar(MiembroComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Empleado modificado");
        }

        public override void Borrar(MiembroComunidad miembro)
        {
            base.Borrar(miembro);
            Codigo = null;
            Cargo = null;
            Salario = null;
            AñosExperiencia = null;
            Console.WriteLine("Empleado borrado");
        }
    }
}