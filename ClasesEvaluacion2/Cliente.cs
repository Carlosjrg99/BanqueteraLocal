using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEvaluacion2
{
    public class Cliente
    {
        private string _comuna;
        /// <summary></summary>
        private string _direccion;
        private int _id;
        private string _region;

        public Cliente()
        {
        }

        public Cliente(int _id, string _comuna, string _region, string _direccion)
        {
        }

        public string Comuna
        {
            get => _comuna;
            set => _comuna = value;
        }

        public string Direccion
        {
            get => _direccion;
            set => _direccion = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Region
        {
            get => _region;
            set => _region = value;
        }
    }
}
