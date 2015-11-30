using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Biblioteca.Dados
{
    public class DadosAtendimento : Conexao
    {
        #region selecionando os registros da tabela
        public List<Atendimento> SelecionarAtendimento()
        {
            List<Atendimento> retorno = new List<Atendimento>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT CodigoAtendimento, Descricao, Status, CodigoAgenda FROM Atendimento", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Atendimento A = new Atendimento();
                    //acessando os valores das colunas do resultado
                    A.CodigoAtendimento = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAtendimento"));
                    A.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    A.Status = DbReader.GetString(DbReader.GetOrdinal("Status"));
                    A.Agenda.CodigoAgenda = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAgenda"));
                    retorno.Add(A);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
        #endregion

        #region Inserindo registro na tabela
        public void InserirAtendimento(Atendimento A)
        {

            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Atendimento (Descricao, Status, CodigoAgenda, CodigoMatricula) values('" + A.Descricao + "','" + A.Status + "'," + A.Agenda.CodigoAgenda + "," + A.Funcionario.Matricula + ")";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        #endregion

        #region Atualizar registro na tabela
        public void AtualizarAtendimento(Atendimento A)
        {

            try
            {
                this.abrirConexao();
                string sql = "UPDATE Atendimento SET Descricao = '" + A.Descricao + "', Status = '" + A.Status + "', CodigoAgenda = " + A.Agenda.CodigoAgenda + ", CodigoMatricula = " + A.Funcionario.Matricula + "  WHERE CodigoAtendimento = '" + A.CodigoAtendimento;
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e atualizar " + ex.Message);
            }
        }

        #endregion

        #region Delete registro na tabela
        public void DeleteAtendimento(Atendimento A)
        {

            try
            {
                this.abrirConexao();
                string sql = "DELETE FROM Atendimento WHERE CodigoAtendimento = '" + A.CodigoAtendimento;
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e deletar " + ex.Message);
            }
        }

        #endregion

        #region selecionando os registros AgendaPorAnimal
        public List<Atendimento> SelecionarAgendaPorAnimal(Atendimento At)
        {
            List<Atendimento> retorno = new List<Atendimento>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT A.CodigoAgenda FROM Agenda AS A, Animal AS AN, Cliente AS C WHERE A.CodigoAnimal = AN.CodigoAnimal AND A.CPF = C.CPF AND A.CodigoAnimal=" + At.Animal.CodigoAnimal + " AND C.CPF='" + At.Cliente.Cpf + "'", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Atendimento A = new Atendimento();
                    //acessando os valores das colunas do resultado
                    A.Agenda.CodigoAgenda = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAgenda"));
                    retorno.Add(A);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
        #endregion

        #region selecionando os registros ClientePorCPF
        public List<Atendimento> SelecionarClientePorCPF(Atendimento At)
        {
            List<Atendimento> retorno = new List<Atendimento>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT C.Nome, C.SobreNome, E.CEP, E.Logradouro, E.Estado, E.Cidade, E.Bairro, E.Numero, E.Complemento FROM Cliente AS C, Endereco AS E WHERE C.CPF = E.CPF AND C.CPF='" + At.Cliente.Cpf + "'", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Atendimento A = new Atendimento();
                    //acessando os valores das colunas do resultado
                    A.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    A.Endereco.Cep = DbReader.GetString(DbReader.GetOrdinal("SobreNome"));
                    A.Endereco.Cep = DbReader.GetString(DbReader.GetOrdinal("CEP"));
                    A.Endereco.Logradouro = DbReader.GetString(DbReader.GetOrdinal("Logradouro"));
                    A.Endereco.Estado = DbReader.GetString(DbReader.GetOrdinal("Estado"));
                    A.Endereco.Cidade = DbReader.GetString(DbReader.GetOrdinal("Cidade"));
                    A.Endereco.Bairro = DbReader.GetString(DbReader.GetOrdinal("Bairro"));
                    A.Endereco.Numero = DbReader.GetString(DbReader.GetOrdinal("Numero"));
                    A.Endereco.Complemento = DbReader.GetString(DbReader.GetOrdinal("Complemento"));
                    retorno.Add(A);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
        #endregion

        #region selecionando os registros AgendaPorCpf
        public List<Atendimento> SelecionarAgendaPorCpf(Atendimento At)
        {
            List<Atendimento> retorno = new List<Atendimento>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT Cliente.CPF, Cliente.Nome, Cliente.SobreNome, animal.CodigoAnimal,Animal.NomeDoAnimal,agenda.CodigoAgenda,Agenda.Data,Agenda.Hora, Servico.CodigoServico,Servico.NomeServico FROM agenda inner join Cliente on agenda.CPF = Cliente.CPF inner join Animal on Animal.CodigoAnimal = Agenda.CodigoAnimal inner join Servico on Servico.CodigoServico = Agenda.CodigoServico where cliente.cpf = '" + At.Cliente.Cpf + "'", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Atendimento A = new Atendimento();
                    //acessando os valores das colunas do resultado
                    A.Cliente.Cpf = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    A.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    A.Cliente.SobreNome = DbReader.GetString(DbReader.GetOrdinal("SobreNome"));
                    A.Animal.CodigoAnimal = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAnimal"));
                    A.Animal.Nome = DbReader.GetString(DbReader.GetOrdinal("NomeDoAnimal"));
                    A.Servico.CodigoServico = DbReader.GetInt32(DbReader.GetOrdinal("CodigoServico"));
                    A.Servico.NomeServico = DbReader.GetString(DbReader.GetOrdinal("NomeServico"));
                    A.Agenda.CodigoAgenda = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAgenda"));
                    A.Agenda.Hora = DbReader.GetString(DbReader.GetOrdinal("Hora"));
                    A.Agenda.Data = DbReader.GetString(DbReader.GetOrdinal("Data"));
                    retorno.Add(A);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
        #endregion

        #region selecionando os registros de Funcionario Para ComboBox
        public List<Atendimento> SelecionarComboBoxFuncionario(Atendimento At)
        {
            List<Atendimento> retorno = new List<Atendimento>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT MatriculaDoFuncionario, NomeDoFuncionario, SobreNome, FC.CodigoFuncao, NomeFuncao FROM Funcionario AS F, Funcao AS FC WHERE F.CodigoFuncao = FC.CodigoFuncao AND FC.CodigoFuncao >= 2", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Atendimento A = new Atendimento();
                    //acessando os valores das colunas do resultado
                    A.Funcionario.Matricula = DbReader.GetInt32(DbReader.GetOrdinal("MatriculaDoFuncionario"));
                    A.Funcionario.Nome = DbReader.GetString(DbReader.GetOrdinal("NomeDoFuncionario"));
                    A.Funcionario.SobreNome = DbReader.GetString(DbReader.GetOrdinal("SobreNome"));
                    A.Funcionario.Funcao.CodigoFuncao = DbReader.GetInt32(DbReader.GetOrdinal("CodigoFuncao"));
                    A.Funcionario.Funcao.NomeFuncao = DbReader.GetString(DbReader.GetOrdinal("NomeFuncao"));
                    retorno.Add(A);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
        #endregion

        #region selecionando os registros ListaComboBoxATAnimal
        public List<Atendimento> ListaComboBoxATAnimal(Atendimento At)
        {
            List<Atendimento> retorno = new List<Atendimento>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT A.CodigoAnimal, A.NomeDoAnimal FROM Animal AS A, Cliente AS C WHERE A.CPF = A.CPF AND C.CPF ='" + At.Cliente.Cpf + "'", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Atendimento A = new Atendimento();
                    //acessando os valores das colunas do resultado
                    A.Animal.CodigoAnimal = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAnimal"));
                    A.Animal.Nome = DbReader.GetString(DbReader.GetOrdinal("NomeDoAnimal"));
                    retorno.Add(A);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
        #endregion

        #region selecionando os registros da Atendimento em Espera
        public List<Atendimento> SelecionarAtendimentoFuncionario()
        {
            List<Atendimento> retorno = new List<Atendimento>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT CodigoAtendimento, Descricao, Status, CodigoAgenda FROM Atendimento ", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Atendimento A = new Atendimento();
                    //acessando os valores das colunas do resultado
                    A.CodigoAtendimento = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAtendimento"));
                    A.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    A.Status = DbReader.GetString(DbReader.GetOrdinal("Status"));
                    A.Agenda.CodigoAgenda = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAgenda"));
                    retorno.Add(A);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
        #endregion

    }
}
