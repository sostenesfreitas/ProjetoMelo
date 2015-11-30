using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Funcionario
    {
        private int matricula;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
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

        private Funcao funcao = new Funcao();

        public Funcao Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }

    }
}
