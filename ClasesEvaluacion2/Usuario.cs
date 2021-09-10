using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEvaluacion2
{
    public class Usuario
    {
        private int _identificador;
        /// <summary></summary>
        private string _nombreUsuario;
        private string _password;
        private Privilegio _tipoUsuario;

        public Usuario()
        {
        }

        public Usuario(int _identificador, string _nombreUsuario, string _password, Privilegio _tipoUsuario)
        {
        }

        public int Identificador
        {
            get => _identificador;
            set => _identificador = value;
        }

        public string NombreUsuario
        {
            get => _nombreUsuario;
            set => _nombreUsuario = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public Privilegio TipoUsuario
        {
            get => _tipoUsuario;
            set => _tipoUsuario = value;
        }

        public string MostrarDatos()
        {
            return string.Format("Identificador: {0}\nUsername: {1}\nPassword: {2}\nTipo: {3}\n",
                _identificador, _nombreUsuario, _password, _tipoUsuario);
        }
    }
}
