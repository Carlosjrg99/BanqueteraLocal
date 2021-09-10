using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEvaluacion2
{
    public class ClienteEmpresa : Cliente
    {
        private string _nombreFantasia;
        /// <summary></summary>
        private string _razonSocial;
        private string _rut;

        public ClienteEmpresa()
        {
        }

        public ClienteEmpresa(string _rut, string _nombreFantasia, string _razonSocial)
        {
        }

        public string NombreFantasia
        {
            get => _nombreFantasia;
            set => _nombreFantasia = value;
        }

        public string RazonSocial
        {
            get => _razonSocial;
            set => _razonSocial = value;
        }

        public string Rut
        {
            get => _rut;
            set => _rut = value;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("ID: ");
            datos.AppendLine(Id.ToString());
            datos.Append(string.Format("Nombre: {0}\nRut: {1}\nRazón social: {2}\n", _nombreFantasia, _rut, _razonSocial));
            datos.Append("Dirección: ");
            datos.AppendLine(Direccion);
            datos.Append("Comuna: ");
            datos.AppendLine(Comuna);
            datos.Append("Region: ");
            datos.AppendLine(Region);
            return datos.ToString();
        }
    }
}
