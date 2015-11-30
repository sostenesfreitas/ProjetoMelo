using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Animal
    {
        private int codigoAnimal;

        public int CodigoAnimal
        {
            get { return codigoAnimal; }
            set { codigoAnimal = value; }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String idade;

        public String Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private String peso;

        public String Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        private Raca raca = new Raca();

        public Raca Raca
        {
            get { return raca; }
            set { raca = value; }
        }

        private Tipo tipo = new Tipo();

        public Tipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private Cliente cliente = new Cliente();

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

    }
}
