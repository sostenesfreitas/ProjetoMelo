using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Funcao
    {
        private int codigoFuncao;

        public int CodigoFuncao
        {
            get { return codigoFuncao; }
            set { codigoFuncao = value; }
        }

        private String nomeFuncao;

        public String NomeFuncao
        {
            get { return nomeFuncao; }
            set { nomeFuncao = value; }
        }

        private String descricaoFuncao;

        public String DescricaoFuncao
        {
            get { return descricaoFuncao; }
            set { descricaoFuncao = value; }
        }
    }
}
