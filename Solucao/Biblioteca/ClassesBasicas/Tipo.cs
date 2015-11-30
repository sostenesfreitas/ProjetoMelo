using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Tipo
    {
        private int codigoTipo;

        public int CodigoTipo
        {
            get { return codigoTipo; }
            set { codigoTipo = value; }
        }

        private String nomeTipo;

        public String NomeTipo
        {
            get { return nomeTipo; }
            set { nomeTipo = value; }
        }
    }
}
