using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Biblioteca.Dados
{
    public class DadosAnimal : Conexao
    {
        #region selecionando os registros da tabela
        public List<Animal> SelecionarAnimal()
        {
            List<Animal> retorno = new List<Animal>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT A.CodigoAnimal, A.NomeDoAnimal, R.CodigoRaca, R.NomeRaca, T.CodigoTipo, T.NomeTipo, A.Peso, A.Idade, C.CPF, C.Nome FROM Animal AS A, Raca AS R, Cliente AS C, Tipo AS T WHERE R.CodigoTipo = T.CodigoTipo AND R.CodigoRaca = A.CodigoRaca AND C.CPF =A.CPF", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Animal A = new Animal();
                    //acessando os valores das colunas do resultado
                    A.CodigoAnimal = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAnimal"));
                    A.Nome = DbReader.GetString(DbReader.GetOrdinal("NomeDoAnimal"));
                    A.Raca.CodigoRaca = DbReader.GetInt32(DbReader.GetOrdinal("CodigoRaca"));
                    A.Raca.NomeRaca = DbReader.GetString(DbReader.GetOrdinal("NomeRaca"));
                    A.Peso = DbReader.GetString(DbReader.GetOrdinal("Peso"));
                    A.Idade = DbReader.GetString(DbReader.GetOrdinal("Idade"));
                    A.Tipo.CodigoTipo = DbReader.GetInt32(DbReader.GetOrdinal("CodigoTipo"));
                    A.Tipo.NomeTipo = DbReader.GetString(DbReader.GetOrdinal("NomeTipo"));
                    A.Cliente.Cpf = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    A.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
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
        public void InserirAnimal(Animal A)
        {

            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Animal (NomeDoAnimal, CodigoRaca, Peso, Idade, CPF) values('" + A.Nome + "'," + A.Raca.CodigoRaca + ",'" + A.Peso + "','" + A.Idade + "','" + A.Cliente.Cpf + "')";
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
        public void AtualizarAnimal(Animal A)
        {

            try
            {
                this.abrirConexao();
                string sql = "UPDATE Animal SET NomeDoAnimal = '" + A.Nome + "', CodigoRaca = '" + A.Raca.CodigoRaca + "', Peso = '" + A.Peso + "', Idade = '" + A.Idade + "', CPF = '" + A.Cliente.Cpf + "' WHERE CodigoAnimal =" + A.CodigoAnimal;
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
        public void DeleteAnimal(Animal A)
        {

            try
            {
                this.abrirConexao();
                string sql = "DELETE FROM Agenda WHERE CodigoAnimal =" + A.CodigoAnimal;
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

        #region selecionando os registros da Tipo
        public List<Animal> SelecionarAnimalTipo(Animal An)
        {
            List<Animal> retorno = new List<Animal>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT CodigoTipo, NomeTipo FROM Tipo", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Animal A = new Animal();
                    //acessando os valores das colunas do resultado
                    A.Tipo.CodigoTipo = DbReader.GetInt32(DbReader.GetOrdinal("CodigoTipo"));
                    A.Tipo.NomeTipo = DbReader.GetString(DbReader.GetOrdinal("NomeTipo"));
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
        #endregion,

        #region selecionando os registros da Raca
        public List<Animal> SelecionarAnimalRaca(Animal An)
        {
            List<Animal> retorno = new List<Animal>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT CodigoRaca, NomeRaca FROM Raca, Tipo AS T WHERE T.CodigoTipo =" + An.Tipo.CodigoTipo, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Animal A = new Animal();
                    //acessando os valores das colunas do resultado
                    A.Raca.CodigoRaca = DbReader.GetInt32(DbReader.GetOrdinal("CodigoRaca"));
                    A.Raca.NomeRaca = DbReader.GetString(DbReader.GetOrdinal("NomeRaca"));
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

        #region selecionando os registros da CodigosEndereço
        public List<Animal> SelecionarAnimaisDoCPF(Animal An)
        {
            List<Animal> retorno = new List<Animal>();

            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT A.CodigoAnimal FROM Animal AS A, Cliente AS C WHERE  A.CPF =" + An.Tipo.CodigoTipo + " AND A.CPF = C.CPF";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Animal A = new Animal();
                    //acessando os valores das colunas do resultado
                    A.Raca.CodigoRaca = DbReader.GetInt32(DbReader.GetOrdinal("CodigoRaca"));
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
        public List<Animal> SelecionarAClientePorCPF(Animal An)
        {
            List<Animal> retorno = new List<Animal>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT C.Nome, C.SobreNome FROM Cliente AS C WHERE C.CPF='" + An.Cliente.Cpf + "'", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Animal A = new Animal();
                    //acessando os valores das colunas do resultado
                    A.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    A.Cliente.SobreNome = DbReader.GetString(DbReader.GetOrdinal("SobreNome"));
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

        #region
        public List<Animal> SelecionaComboBoxAnimal(Cliente An)
        {
            List<Animal> retorno = new List<Animal>();
            try
            {

                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT CodigoAnimal, NomeDoAnimal FROM Animal,Cliente WHERE Animal.cpf = Cliente.cpf  and Cliente.cpf =" + An.Cpf, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor

                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Animal A = new Animal();
                    //acessando os valores das colunas do resultado
                    A.CodigoAnimal = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAnimal"));
                    A.Nome = DbReader.GetString(DbReader.GetOrdinal("NomeDoAnimal"));
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
