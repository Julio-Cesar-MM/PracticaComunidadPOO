using ComunidadPOO.Class;

namespace ComunidadPOO.Interfaces
{
    public interface IMiembroComando
    {
        void Guardar(MiembroComunidad miembro);

        void Modificar(MiembroComunidad miembro);

        void Obtener(MiembroComunidad miembro);

        void Borrar(MiembroComunidad miembro);

    }
}
