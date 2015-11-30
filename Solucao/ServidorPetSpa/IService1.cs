using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.Dados;
using Biblioteca.ClassesBasicas;

namespace ServidorPetSpa
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Funcionario> SelecionarFuncionario();

        [OperationContract]
        void InserirFuncionario(Funcionario F);

        [OperationContract]
        void AtualizarFuncionario(Funcionario F);

        [OperationContract]
        void DeleteFuncionario(Funcionario F);

        [OperationContract]
        List<Funcionario> SelecionaComboBoxFuncao(Funcionario F);

        //------------------------------------------------------------------------------------------

        [OperationContract]
        List<Servico> SelecionarServico();

        [OperationContract]
        void InserirServico(Servico S);

        [OperationContract]
        void AtualizarServico(Servico S);

        [OperationContract]
        void DeleteServico(Servico S);

        [OperationContract]
        List<Servico> SelecionaComboBoxServico();

        //------------------------------------------------------------------------------------------

        [OperationContract]
        List<Endereco> SelecionarEndereco();

        [OperationContract]
        List<Endereco> SelecionarEnderecoCliente(Endereco E);

        [OperationContract]
        List<Endereco> SelecionarEnderecosDoCPF(Endereco E);

        [OperationContract]
        void InserirEndereco(Endereco E);

        [OperationContract]
        void AtualizarEndereco(Endereco E);

        [OperationContract]
        void DeleteEndereco(Endereco E);

        //------------------------------------------------------------------------------------------

        [OperationContract]
        List<Cliente> SelecionarCliente();

        [OperationContract]
        void InserirCliente(Cliente C);

        [OperationContract]
        void AtualizarCliente(Cliente C);

        [OperationContract]
        void DeleteCliente(Cliente C);

        [OperationContract]
        List<Cliente> SelecionaComboBoxCliente();

        //------------------------------------------------------------------------------------------

        [OperationContract]
        List<Atendimento> SelecionarAtendimento();

        [OperationContract]
        void InserirAtendimento(Atendimento A);

        [OperationContract]
        void AtualizarAtendimento(Atendimento A);

        [OperationContract]
        void DeleteAtendimento(Atendimento A);

        [OperationContract]
        List<Atendimento> SelecionarAgendaPorAnimal(Atendimento A);

        [OperationContract]
        List<Atendimento> SelecionarAgendaPorCpf(Atendimento A);

        [OperationContract]
        List<Atendimento> ListaComboBoxATAnimal(Atendimento A);

        [OperationContract]
        List<Atendimento> SelecionarComboBoxFuncionario(Atendimento A);

        [OperationContract]
        List<Atendimento> SelecionarClientePorCPF(Atendimento A);

        //------------------------------------------------------------------------------------------

        [OperationContract]
        List<Animal> SelecionarAnimal();

        [OperationContract]
        List<Animal> SelecionarAClientePorCPF(Animal A);

        [OperationContract]
        List<Animal> SelecionarAnimaisDoCPF(Animal A);

        [OperationContract]
        List<Animal> SelecionarAnimalTipo(Animal A);

        [OperationContract]
        List<Animal> SelecionarAnimalRaca(Animal A);

        [OperationContract]
        void InserirAnimal(Animal A);

        [OperationContract]
        void AtualizarAnimal(Animal A);

        [OperationContract]
        void DeleteAnimal(Animal A);

        [OperationContract]
        List<Animal> SelecionaComboBoxAnimal(Cliente A);
        //------------------------------------------------------------------------------------------

        [OperationContract]
        List<Agenda> SelecionarAgenda();
        
        

        [OperationContract]
        void InserirAgenda(Agenda A);

        [OperationContract]
        void AtualizarAgenda(Agenda A);

        [OperationContract]
        void DeleteAgenda(Agenda A);

        [OperationContract]
        void CancelarAgenda(Agenda A);

        [OperationContract]
        List<Agenda> SelecionarPorCodigo(Agenda A);
        
        [OperationContract]
        void VerificarExistencia(Agenda A);

        //------------------------------------------------------------------------------------------

        [OperationContract]
        List<Raca> SelecionarRaca();

        [OperationContract]
        List<Raca> SelecionarRacaTipo(Raca R);

        [OperationContract]
        void InserirRaca(Raca R);

        [OperationContract]
        void AtualizarRaca(Raca R);

        [OperationContract]
        void DeleteRaca(Raca R);

        //------------------------------------------------------------------------------------------

        [OperationContract]
        List<Funcao> SelecionarFuncao();

        [OperationContract]
        void InserirFuncao(Funcao F);

        [OperationContract]
        void AtualizarFuncao(Funcao F);

        [OperationContract]
        void DeleteFuncao(Funcao F);

        //------------------------------------------------------------------------------------------

        [OperationContract]
        List<Tipo> SelecionarTipo();

        [OperationContract]
        void InserirTipo(Tipo T);

        [OperationContract]
        void AtualizarTipo(Tipo T);

        [OperationContract]
        void DeleteTipo(Tipo T);

        //------------------------------------------------------------------------------------------

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
