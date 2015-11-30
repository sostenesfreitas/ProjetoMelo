using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Biblioteca.Dados
{
    public class DadosEndereco : Conexao
    {
        #region selecionando os registros da tabela
        public List<Endereco> SelecionarEndereco()
        {
            List<Endereco> retorno = new List<Endereco>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT CodigoEndereco, Logradouro, Complemento, Bairro, Estado, CEP, Numero, Cidade FROM Endereco ", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Endereco E = new Endereco();
                    //acessando os valores das colunas do resultado
                    E.CodigoEndereco = DbReader.GetInt32(DbReader.GetOrdinal("CodigoServico"));
                    E.Logradouro = DbReader.GetString(DbReader.GetOrdinal("Logradouro"));
                    E.Complemento = DbReader.GetString(DbReader.GetOrdinal("Complemento"));
                    E.Bairro = DbReader.GetString(DbReader.GetOrdinal("Bairro"));
                    E.Estado = DbReader.GetString(DbReader.GetOrdinal("Estado"));
                    E.Cep = DbReader.GetString(DbReader.GetOrdinal("CEP"));
                    E.Numero = DbReader.GetString(DbReader.GetOrdinal("Numero"));
                    E.Cidade = DbReader.GetString(DbReader.GetOrdinal("Cidade"));
                    retorno.Add(E);
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
        public void InserirEndereco(Endereco E)
        {

            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Endereco (Logradouro, Complemento, Bairro, Estado, CEP, Numero, Cidade, CPF) values('" + E.Logradouro + "','" + E.Complemento + "','" + E.Bairro + "','" + E.Estado + "'," + E.Cep + ",'" + E.Numero + "','" + E.Cidade + "','" + E.Cliente.Cpf + "')";
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
        public void AtualizarEndereco(Endereco E)
        {

            try
            {
                this.abrirConexao();
                string sql = "UPDATE E SET E.Logradouro ='" + E.Logradouro + "', E.Complemento ='" + E.Complemento + "', E.Bairro ='" + E.Bairro + "', E.Estado ='" + E.Estado + "', E.CEP = " + E.Cep + ",Numero = '" + E.Numero + "', E.Cidade ='" + E.Cidade + "'FROM Endereco AS E, Cliente AS C WHERE CodigoEndereco = " + E.CodigoEndereco + " AND C.CPF = E.CPF";
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
        public void DeleteEndereco(Endereco E)
        {

            try
            {
                this.abrirConexao();
                string sql = "DELETE FROM Endereco WHERE CodigoEndereco =" + E.CodigoEndereco;
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

        #region selecionando os registros da CodigosEndereço
        public List<Endereco> SelecionarEnderecosDoCPF(Endereco En)
        {
            List<Endereco> retorno = new List<Endereco>();

            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT E.CodigoEndereco FROM Endereco AS E, Cliente AS C WHERE C.CPF =" + En.Cliente.Cpf;
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {   
                    Endereco E = new Endereco();
                    //acessando os valores das colunas do resultado
                    E.CodigoEndereco = DbReader.GetInt32(DbReader.GetOrdinal("CodigoEndereco"));
                    retorno.Add(E);
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

        #region selecionando os registros da tabela
        public List<Endereco> SelecionarEnderecoCliente(Endereco En)
        {
            List<Endereco> retorno = new List<Endereco>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT C.CPF, C.NOME , Logradouro, CodigoEndereco, Cidade, Estado, Complemento, Bairro, CEP, Numero FROM Endereco AS E, Cliente AS C ORDER BY C.NOME", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Endereco E = new Endereco();
                    //acessando os valores das colunas do resultado
                    E.Cliente.Cpf = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    E.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("NOME"));
                    E.CodigoEndereco = DbReader.GetInt32(DbReader.GetOrdinal("CodigoEndereco"));
                    E.Logradouro = DbReader.GetString(DbReader.GetOrdinal("Logradouro"));
                    E.Estado = DbReader.GetString(DbReader.GetOrdinal("Estado"));
                    E.Cidade = DbReader.GetString(DbReader.GetOrdinal("Cidade"));
                    E.Complemento = DbReader.GetString(DbReader.GetOrdinal("Complemento"));
                    E.Bairro = DbReader.GetString(DbReader.GetOrdinal("Bairro"));
                    E.Cep = DbReader.GetString(DbReader.GetOrdinal("CEP"));
                    E.Numero = DbReader.GetString(DbReader.GetOrdinal("Numero"));
                    retorno.Add(E);
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
