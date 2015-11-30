using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Servico
    {
        private int codigoServico;

        public int CodigoServico
        {
            get { return codigoServico; }
            set { codigoServico = value; }
        }

        private String nomeServico;

        public String NomeServico
        {
            get { return nomeServico; }
            set { nomeServico = value; }
        }

        private String descricaoServico;

        public String DescricaoServico
        {
            get { return descricaoServico; }
            set { descricaoServico = value; }
        }
    }
}
