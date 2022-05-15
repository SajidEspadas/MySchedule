using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchedule
{
    // Clase [Usuario].
    class Usuario
    {
        // Campos de la clase [Usuario].
        public string Usu_Nombre { get; set; }
        public string Usu_Apellido { get; set; }
        public string Usu_Correo { get; set; }
        public string Usu_Contraseña { get; set; }

        // Constructor básico.
        public Usuario() { }

        // Constructor para capturar los datos.
        public Usuario(string Nombre, string Apellido, string Correo, string Contraseña)
        {
            Usu_Nombre = Nombre;
            Usu_Apellido = Apellido;
            Usu_Correo = Correo;
            Usu_Contraseña = Contraseña;
        }
    }
}
