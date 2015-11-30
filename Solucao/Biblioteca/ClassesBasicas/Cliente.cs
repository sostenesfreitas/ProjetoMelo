using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Cliente
    {
        private String cpf;

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String sobreNome;

        public String SobreNome
        {
            get { return sobreNome; }
            set { sobreNome = value; }
        }

        private String telefone;

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

    }
}
