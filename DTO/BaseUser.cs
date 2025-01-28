using System.Runtime.CompilerServices;

namespace DTO
{
    public class BaseUser : BaseClass
    {
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Sexo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Edad { get; set; }

        public string Direccion { get; set; }

        public string Foto { get; set; }

        public string Rol { get; set; }

        public int Estado { get; set; }

        public string Clave { get; set; }

        public string Identificacion { get; set; }

        public string Ubicacion { get; set; }

        public int OTP { get; set; }

        public string Verificacion { get; set; } 

        public DateTime Timeout { get; set; }

    }
}
