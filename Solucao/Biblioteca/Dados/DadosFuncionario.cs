using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Biblioteca.Dados
{
    public class DadosFuncionario : Conexao
    {
        #region selecionando os registros da tabela
        public List<Funcionario> SelecionarFuncionario()
        {
            List<Funcionario> retorno = new List<Funcionario>();
           try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT CodigoMatricula, NomeDoFuncionario, SobreNome, FC.CodigoFuncao, FC.NomeFuncao FROM Funcionario AS F, Funcao AS FC WHERE F.CodigoFuncao = FC.CodigoFuncao", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Funcionario F = new Funcionario();
                    //acessando os valores das colunas do resultado
                    F.Matricula = DbReader.GetInt32(DbReader.GetOrdinal("CodigoMatricula"));
                    F.Nome = DbReader.GetString(DbReader.GetOrdinal("NomeDoFuncionario"));
                    F.SobreNome = DbReader.GetString(DbReader.GetOrdinal("SobreNome"));
                    F.Funcao.CodigoFuncao = DbReader.GetInt32(DbReader.GetOrdinal("CodigoFuncao"));
                    F.Funcao.NomeFuncao = DbReader.GetString(DbReader.GetOrdinal("NomeFuncao"));
                    retorno.Add(F);
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
        public void InserirFuncionario(Funcionario F)
        {
            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Funcionario (CodigoFuncao, NomeDoFuncionario, SobreNome) values(" + F.Funcao.CodigoFuncao + ",'" + F.Nome + "','" + F.SobreNome + "')";
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
        public void AtualizarFuncionario(Funcionario F)
        {

            try
            {
                this.abrirConexao();
                string sql = "UPDATE Funcionario SET CodigoFuncao = " + F.Funcao.CodigoFuncao + ", NomeDoFuncionario = '" + F.Nome + "', SobreNome = '" + F.SobreNome + "' WHERE CodigoMatricula =" + F.Matricula;
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
        public void DeleteFuncionario(Funcionario F)
        {

            try
            {
                this.abrirConexao();
                string sql = "DELETE FROM Funcionario WHERE CodigoMatricula =" + F.Matricula;
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

        #region selecionando os registros Para ComboBoxFuncao
        public List<Funcionario> SelecionaComboBoxFuncao(Funcionario Fu)
        {
            List<Funcionario> retorno = new List<Funcionario>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT CodigoFuncao, NomeFuncao, DescricaoFuncao FROM Funcao", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Funcionario F = new Funcionario();
                    //acessando os valores das colunas do resultado
                    F.Funcao.CodigoFuncao = DbReader.GetInt32(DbReader.GetOrdinal("CodigoFuncao"));
                    F.Funcao.NomeFuncao = DbReader.GetString(DbReader.GetOrdinal("NomeFuncao"));
                    F.Funcao.DescricaoFuncao = DbReader.GetString(DbReader.GetOrdinal("DescricaoFuncao"));
                    retorno.Add(F);
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


