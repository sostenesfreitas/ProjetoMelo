using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Endereco
    {
        private int codigoEndereco;

        public int CodigoEndereco
        {
        get { return codigoEndereco; }
        set { codigoEndereco = value; }
        }

        private String logradouro;

        public String Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        private String bairro;

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private String cidade;

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private String complemento;

        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private String cep;

        public String Cep
        {
         get { return cep; }
         set { cep = value; }
        }


        private String numero;

        public String Numero
        {
          get { return numero; }
         set { numero = value; }
        }

        private Cliente cliente = new Cliente();

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        }

    }
