using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Biblioteca.Dados
{
    public class DadosFuncao  : Conexao
    {
        #region selecionando os registros da tabela
        public List<Funcao> SelecionarFuncao()
        {
            List<Funcao> retorno = new List<Funcao>();
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
                    Funcao F = new Funcao();
                    //acessando os valores das colunas do resultado
                    F.CodigoFuncao = DbReader.GetInt32(DbReader.GetOrdinal("CodigoFuncao"));
                    F.NomeFuncao = DbReader.GetString(DbReader.GetOrdinal("NomeFuncao"));
                    F.DescricaoFuncao = DbReader.GetString(DbReader.GetOrdinal("DescricaoFuncao"));
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
        public void InserirFuncao(Funcao F)
        {

            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Funcao (NomeFuncao, DescricaoFuncao) values('" + F.NomeFuncao + "','" + F.DescricaoFuncao + "')";
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
        public void AtualizarFuncao(Funcao F)
        {

            try
            {
                this.abrirConexao();
                string sql = "UPDATE Funcao SET NomeFuncao = '" + F.NomeFuncao + "', DescricaoFuncao = '" + F.DescricaoFuncao + "' WHERE CodigoFuncao =" + F.CodigoFuncao;
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
        public void DeleteFuncao(Funcao F)
        {

            try
            {
                this.abrirConexao();
                string sql = "DELETE FROM Funcao WHERE CodigoFuncao =" + F.CodigoFuncao;
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

        }
    }