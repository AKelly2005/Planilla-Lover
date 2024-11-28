using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla_Lover
{
    public abstract class Usuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        // Constructor
        public Usuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;
        }

        // Método común que puede ser sobrescrito
        public abstract string ObtenerTipoUsuario();
    }

    public class UsuarioCorriente : Usuario
    {
        public UsuarioCorriente(string nombre, string contraseña)
            : base(nombre, contraseña)
        {
        }

        // Sobrescribir para indicar que es un usuario corriente
        public override string ObtenerTipoUsuario()
        {
            return "Usuario Corriente";
        }
    }

    public class Administrador : Usuario
    {
        public Administrador(string nombre, string contraseña)
            : base(nombre, contraseña)
        {
        }

        // Sobrescribir para indicar que es un administrador
        public override string ObtenerTipoUsuario()
        {
            return "Administrador";
        }
    }



    public class GestorUsuarios
    {
        private List<Usuario> usuarios;

        public GestorUsuarios()
        {
            usuarios = new List<Usuario>();
        }

        // Método para agregar un usuario
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }
    }
}
