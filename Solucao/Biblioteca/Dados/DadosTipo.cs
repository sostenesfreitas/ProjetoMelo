using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace Biblioteca.Dados
{
    public class DadosTipo : Conexao
    {
        #region selecionando os registros da tabela
        public List<Tipo> SelecionarTipo()
        {
            List<Tipo> retorno = new List<Tipo>();
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
                    Tipo T = new Tipo();
                    //acessando os valores das colunas do resultado
                    T.CodigoTipo = DbReader.GetInt32(DbReader.GetOrdinal("CodigoTipo"));
                    T.NomeTipo = DbReader.GetString(DbReader.GetOrdinal("NomeTipo"));
                    retorno.Add(T);
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
        public void InserirTipo(Tipo T)
        {

            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Tipo (NomeTipo) values('" + T.NomeTipo + "')";
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
        public void AtualizarTipo(Tipo T)
        {

            try
            {
                this.abrirConexao();
                string sql = "UPDATE Tipo SET NomeTipo = '" + T.NomeTipo + "' WHERE CodigoTipo =" + T.CodigoTipo;
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
        public void DeleteTipo(Tipo T)
        {

            try
            {
                this.abrirConexao();
                string sql = "DELETE FROM Tipo WHERE CodigoTipo =" + T.CodigoTipo;
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
