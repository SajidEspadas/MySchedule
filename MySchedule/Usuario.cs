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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        // Constructor para capturar los datos.
        public Usuario(string Nombre, string Apellido, string Correo, string Contraseña)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Correo = Correo;
            this.Contraseña = Contraseña;
        }
    }
}