using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Atendimento
    {
        private int codigoAtendimento;

        public int CodigoAtendimento
        {
            get { return codigoAtendimento; }
            set { codigoAtendimento = value; }
        }

        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        private Servico servico = new Servico();

        public Servico Servico
        {
            get { return servico; }
            set { servico = value; }
        }

        private Funcionario funcionario = new Funcionario();

        public Funcionario Funcionario
        {
            get { return funcionario; }
            set { funcionario = value; }
        }

        private Animal animal = new Animal();

        public Animal Animal
        {
            get { return animal; }
            set { animal = value; }
        }

        private Cliente cliente = new Cliente();

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private Endereco endereco = new Endereco();

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private Agenda agenda = new Agenda();

        public Agenda Agenda
        {
            get { return agenda; }
            set { agenda = value; }
        }
    }
}
