using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ClassesBasicas;
using Biblioteca.Dados;

namespace Biblioteca.Negocio
{
    public class NegocioAgenda : Exception
    {
        private void validarDados(Agenda A) 
        {
            if (A == null)
            {
                Exception ex = new Exception();
                throw new Exception("Não é possível cadastrar um objeto nulo" + ex.Message);
            }

        }
       
   
        public void InserirAgenda(Agenda A)
        {     
           DadosAgenda D = new DadosAgenda();
        if (D.VerificarExistencia(A) == true)
        {
            throw new Exception("Data e hora ja cadastrada");
	    }
      
            DadosAgenda dl = new DadosAgenda();
            dl.InserirAgenda(A);

        }


        public void DeleteAgenda(Agenda A)
        {
            DadosAgenda dl = new DadosAgenda();
            dl.DeleteAgenda(A);
        }

        public void CancelarAgenda(Agenda A)
        {
            DadosAgenda dl = new DadosAgenda();
            dl.CancelarAgenda(A);
        }

        public List<Agenda> SelecionarAgenda()
        {
            DadosAgenda da = new DadosAgenda();
            return da.SelecionarAgenda();
        }


        public void AtualizarAgenda(Agenda A)
        {
            if (A == null)
            {
                throw new Exception("Não é possível alterar um objeto nulo");
            }
            DadosAgenda dl = new DadosAgenda();
            dl.AtualizarAgenda(A);
        }

        public void VerificarExistencia(Agenda A)
        {
            DadosAgenda dl = new DadosAgenda();
            dl.VerificarExistencia(A);
        }
    }
}
