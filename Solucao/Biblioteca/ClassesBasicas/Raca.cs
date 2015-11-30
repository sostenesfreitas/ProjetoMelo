using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Raca
    {
        private int codigoRaca;

        public int CodigoRaca
        {
            get { return codigoRaca; }
            set { codigoRaca = value; }
        }

        private String nomeRaca;

        public String NomeRaca
        {
            get { return nomeRaca; }
            set { nomeRaca = value; }
        }

        private String descricaoRaca;

        public String DescricaoRaca
        {
            get { return descricaoRaca; }
            set { descricaoRaca = value; }
        }

        private Tipo tipo = new Tipo();

        public Tipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}
