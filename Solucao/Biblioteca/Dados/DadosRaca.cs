using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Biblioteca.Dados
{
    public class DadosRaca  : Conexao
    {
        #region selecionando os registros da tabela
        public List<Raca> SelecionarRaca()
        {
            List<Raca> retorno = new List<Raca>();
           try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT CodigoRaca, NomeRaca, DescricaoRaca, T.CodigoTipo, T.NomeTipo FROM Raca AS R, Tipo AS T WHERE R.CodigoTipo = T.CodigoTipo ", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Raca R = new Raca();
                    //acessando os valores das colunas do resultado
                    R.CodigoRaca = DbReader.GetInt32(DbReader.GetOrdinal("CodigoRaca"));
                    R.NomeRaca = DbReader.GetString(DbReader.GetOrdinal("NomeRaca"));
                    R.DescricaoRaca = DbReader.GetString(DbReader.GetOrdinal("DescricaoRaca"));
                    R.Tipo.CodigoTipo = DbReader.GetInt32(DbReader.GetOrdinal("CodigoTipo"));
                    R.Tipo.NomeTipo = DbReader.GetString(DbReader.GetOrdinal("NomeTipo"));
                    retorno.Add(R);
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
        public void InserirRaca(Raca R)
        {

            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Raca (NomeRaca, DescricaoRaca, CodigoTipo) values('" + R.NomeRaca + "','" + R.DescricaoRaca + "'," + R.Tipo.CodigoTipo + ")";
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
        public void AtualizarRaca(Raca R)
        {

            try
            {
                this.abrirConexao();
                string sql = "UPDATE Raca SET NomeRaca = '" + R.NomeRaca + "', DescricaoRaca = '" + R.DescricaoRaca + "' , CodigoTipo = " + R.Tipo.CodigoTipo + " WHERE CodigoRaca =" + R.CodigoRaca;
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
        public void DeleteRaca(Raca R)
        {

            try
            {
                this.abrirConexao();
                string sql = "DELETE FROM Raca WHERE CodigoRaca =" + R.CodigoRaca;
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
        public List<Raca> SelecionarRacaTipo(Raca Ra)
        {
            List<Raca> retorno = new List<Raca>();
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
                    Raca R = new Raca();
                    //acessando os valores das colunas do resultado
                    R.Tipo.CodigoTipo = DbReader.GetInt32(DbReader.GetOrdinal("CodigoTipo"));
                    R.Tipo.NomeTipo = DbReader.GetString(DbReader.GetOrdinal("NomeTipo"));
                    retorno.Add(R);
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
