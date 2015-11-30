using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.Dados;
using Biblioteca.ClassesBasicas;
using Biblioteca.Negocio;

namespace ServidorPetSpa
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Funcionario> SelecionarFuncionario()
        {
            return new DadosFuncionario().SelecionarFuncionario();
        }

        public void InserirFuncionario(Funcionario F)
        {
            new DadosFuncionario().InserirFuncionario(F);
        }

        public void AtualizarFuncionario(Funcionario F)
        {
            new DadosFuncionario().AtualizarFuncionario(F);
        }

        public void DeleteFuncionario(Funcionario F)
        {
            new DadosFuncionario().DeleteFuncionario(F);
        }

        public List<Funcionario> SelecionaComboBoxFuncao(Funcionario F)
        {
            return new DadosFuncionario().SelecionaComboBoxFuncao(F);
        }

        //------------------------------------------------------------------------------------------

        public List<Servico> SelecionarServico()
        {
            return new DadosServico().SelecionarServico();
        }

        public void InserirServico(Servico S)
        {
            new DadosServico().InserirServico(S);
        }

        public void AtualizarServico(Servico S)
        {
            new DadosServico().AtualizarServico(S);
        }

        public void DeleteServico(Servico S)
        {
            new DadosServico().DeleteServico(S);
        }

        public List<Servico> SelecionaComboBoxServico()
        {
            return new DadosServico().SelecionaComboBoxServico();
        }
        //------------------------------------------------------------------------------------------

        public List<Endereco> SelecionarEndereco()
        {
            return new DadosEndereco().SelecionarEndereco();
        }

        public List<Endereco> SelecionarEnderecoCliente(Endereco E)
        {
            return new DadosEndereco().SelecionarEnderecoCliente(E);
        }

        public List<Endereco> SelecionarEnderecosDoCPF(Endereco E)
        {
            return new DadosEndereco().SelecionarEnderecosDoCPF(E);
        }

        public void InserirEndereco(Endereco E)
        {
            new DadosEndereco().InserirEndereco(E);
        }

        public void AtualizarEndereco(Endereco E)
        {
            new DadosEndereco().AtualizarEndereco(E);
        }

        public void DeleteEndereco(Endereco E)
        {
            new DadosEndereco().DeleteEndereco(E);
        }

        //------------------------------------------------------------------------------------------

        public List<Cliente> SelecionarCliente()
        {
            return new DadosCliente().SelecionarCliente();
        }

        public void InserirCliente(Cliente C)
        {
            new DadosCliente().InserirCliente(C);
        }

        public void AtualizarCliente(Cliente C)
        {
            new DadosCliente().AtualizarCliente(C);
        }

        public void DeleteCliente(Cliente C)
        {
            new DadosCliente().DeleteCliente(C);
        }

        public List<Cliente> SelecionaComboBoxCliente()
        {
            return new DadosCliente().SelecionaComboBoxCliente();
        }
        //------------------------------------------------------------------------------------------

        public List<Atendimento> SelecionarAtendimento()
        {
            return new DadosAtendimento().SelecionarAtendimento();
        }

        public void InserirAtendimento(Atendimento A)
        {
            new DadosAtendimento().InserirAtendimento(A);
        }

        public void AtualizarAtendimento(Atendimento A)
        {
            new DadosAtendimento().AtualizarAtendimento(A);
        }

        public void DeleteAtendimento(Atendimento A)
        {
            new DadosAtendimento().DeleteAtendimento(A);
        }

        public List<Atendimento> SelecionarAgendaPorAnimal(Atendimento A)
        {
            return new DadosAtendimento().SelecionarAgendaPorAnimal(A);
        }

        public List<Atendimento> SelecionarAgendaPorCpf(Atendimento A)
        {
            return new DadosAtendimento().SelecionarAgendaPorCpf(A);
        }

        public List<Atendimento> ListaComboBoxATAnimal(Atendimento A)
        {
            return new DadosAtendimento().ListaComboBoxATAnimal(A);
        }

        public List<Atendimento> SelecionarComboBoxFuncionario(Atendimento A)
        {
            return new DadosAtendimento().SelecionarComboBoxFuncionario(A);
        }

        public List<Atendimento> SelecionarClientePorCPF(Atendimento A)
        {
            return new DadosAtendimento().SelecionarClientePorCPF(A);
        }

        //------------------------------------------------------------------------------------------

        public List<Animal> SelecionarAnimal()
        {
            return new DadosAnimal().SelecionarAnimal();
        }

        public List<Animal> SelecionarAClientePorCPF(Animal A)
        {
            return new DadosAnimal().SelecionarAClientePorCPF(A);
        }

        public List<Animal> SelecionarAnimaisDoCPF(Animal A)
        {
            return new DadosAnimal().SelecionarAnimaisDoCPF(A);
        }

        public List<Animal> SelecionarAnimalTipo(Animal A)
        {
            return new DadosAnimal().SelecionarAnimalTipo(A);
        }

        public List<Animal> SelecionarAnimalRaca(Animal A)
        {
            return new DadosAnimal().SelecionarAnimalRaca(A);
        }

        public void InserirAnimal(Animal A)
        {
            new DadosAnimal().InserirAnimal(A);
        }

        public void AtualizarAnimal(Animal A)
        {
            new DadosAnimal().AtualizarAnimal(A);
        }

        public void DeleteAnimal(Animal A)
        {
            new DadosAnimal().DeleteAnimal(A);
        }

        public List<Animal> SelecionaComboBoxAnimal(Cliente A)
        {
            return new DadosAnimal().SelecionaComboBoxAnimal(A);
        }
        //------------------------------------------------------------------------------------------

        public List<Agenda> SelecionarAgenda()
        {
            return new DadosAgenda().SelecionarAgenda();
        }

        public List<Agenda> SelecionarPorCodigo(Agenda A)
        {
            return new DadosAgenda().SelecionarPorCodigo(A);
        }

        public void InserirAgenda(Agenda A)
        {
            new NegocioAgenda().InserirAgenda(A);
        }

        public void AtualizarAgenda(Agenda A)
        {
            new NegocioAgenda().AtualizarAgenda(A);
        }

        public void DeleteAgenda(Agenda A)
        {
            new NegocioAgenda().DeleteAgenda(A);
        }

        public void CancelarAgenda(Agenda A)
        {
            new NegocioAgenda().CancelarAgenda(A);
        }

        public void VerificarExistencia(Agenda A)
        {
            new DadosAgenda().VerificarExistencia(A);
        }

        //------------------------------------------------------------------------------------------

        public List<Raca> SelecionarRacaTipo(Raca R)
        {
            return new DadosRaca().SelecionarRacaTipo(R);
        }

        public List<Raca> SelecionarRaca()
        {
            return new DadosRaca().SelecionarRaca();
        }

        public void InserirRaca(Raca R)
        {
            new DadosRaca().InserirRaca(R);
        }

        public void AtualizarRaca(Raca R)
        {
            new DadosRaca().AtualizarRaca(R);
        }

        public void DeleteRaca(Raca R)
        {
            new DadosRaca().DeleteRaca(R);
        }

        //------------------------------------------------------------------------------------------

        public List<Funcao> SelecionarFuncao()
        {
            return new DadosFuncao().SelecionarFuncao();
        }

        public void InserirFuncao(Funcao F)
        {
            new DadosFuncao().InserirFuncao(F);
        }

        public void AtualizarFuncao(Funcao F)
        {
            new DadosFuncao().AtualizarFuncao(F);
        }

        public void DeleteFuncao(Funcao F)
        {
            new DadosFuncao().DeleteFuncao(F);
        }

        //------------------------------------------------------------------------------------------

        public List<Tipo> SelecionarTipo()
        {
            return new DadosTipo().SelecionarTipo();
        }

        public void InserirTipo(Tipo T)
        {
            new DadosTipo().InserirTipo(T);
        }

        public void AtualizarTipo(Tipo T)
        {
            new DadosTipo().AtualizarTipo(T);
        }

        public void DeleteTipo(Tipo T)
        {
            new DadosTipo().DeleteTipo(T);
        }

        //------------------------------------------------------------------------------------------
    }
}
