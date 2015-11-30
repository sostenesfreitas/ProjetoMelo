using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ClassesBasicas
{
    public class Agenda
    {
        private int codigoAgenda;

        public int CodigoAgenda
        {
            get { return codigoAgenda; }
            set { codigoAgenda = value; }
        }

        private String hora;

        public String Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        private Servico servico = new Servico();

        public Servico Servico
        {
            get { return servico; }
            set { servico = value; }
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

        String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        String encaixe;

        public String Encaixe
        {
            get { return encaixe; }
            set { encaixe = value; }
        }
    }
}
