using ComunidadPOO.Interfaces;

namespace ComunidadPOO.Class
{
    public abstract class MiembroComunidad : IMiembroComando
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? Edad { get; set; }

        public virtual void Guardar(MiembroComunidad miembro)
        {
            Console.WriteLine("");
        }

        public virtual void Obtener(MiembroComunidad miembro)
        {
            Console.WriteLine("Nombres: {0}", Nombres);
            Console.WriteLine("Apellidos: {0}", Apellidos);
            Console.WriteLine("Edad: {0}", Edad);
        }

        public virtual void Modificar(MiembroComunidad miembro)
        {
            Console.WriteLine("");
        }

        public virtual void Borrar(MiembroComunidad miembro)
        {
            Nombres = null;
            Apellidos = null;
            Edad = null;
        }
    }
}
