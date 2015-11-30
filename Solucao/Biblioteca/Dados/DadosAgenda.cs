using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Biblioteca.Dados
{
    public class DadosAgenda : Conexao
    {
        #region selecionando os registros da tabela
        public Boolean VerificarExistencia(Agenda A)
        {
            Boolean retorno = false;
            this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("SELECT * FROM AGENDA where data ='"+A.Data+"' and hora = '"+A.Hora+"'", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();

                return retorno;

        }
        public List<Agenda> SelecionarAgenda()
        {
            List<Agenda> retorno = new List<Agenda>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("select Agenda.codigoAgenda, Agenda.Data, Agenda.Hora, Cliente.nome, Animal.nomeDoAnimal, Servico.nomeServico,status,encaixe FROM agenda,cliente, animal,SERVICO where agenda.codigoAnimal = animal.codigoAnimal and agenda.codigoServico = servico.Codigoservico and agenda.cpf = cliente.cpf", sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Agenda A = new Agenda();
                    //acessando os valores das colunas do resultado
                    A.CodigoAgenda = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAgenda"));

                    A.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    A.Animal.Nome = DbReader.GetString(DbReader.GetOrdinal("nomeDoAnimal"));
                    A.Servico.NomeServico = DbReader.GetString(DbReader.GetOrdinal("nomeServico"));
                    A.Data = DbReader.GetString(DbReader.GetOrdinal("Data"));
                    A.Hora = DbReader.GetString(DbReader.GetOrdinal("Hora"));
                    A.Status = DbReader.GetString(DbReader.GetOrdinal("status"));
                    A.Encaixe = DbReader.GetString(DbReader.GetOrdinal("encaixe"));

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
        public void InserirAgenda(Agenda A)
        {

            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Agenda (Hora, Data, CodigoAnimal, CodigoServico, CPF,status,encaixe) values('" + A.Hora + "','" + A.Data + "'," + A.Animal.CodigoAnimal + "," + A.Servico.CodigoServico + "," + A.Cliente.Cpf + ",'agendado','NAO')";
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
        public void AtualizarAgenda(Agenda A)
        {

            try
            {
                this.abrirConexao();
                string sql = "UPDATE Agenda SET Hora = '" + A.Hora + "', Data = '" + A.Data + "', codigoAnimal =" + A.Animal.CodigoAnimal + " ,codigoServico =" + A.Servico.CodigoServico + ",cpf=" + A.Cliente.Cpf + ",encaixe='"+A.Encaixe+"' WHERE CodigoAgenda =" + A.CodigoAgenda;
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
        public void DeleteAgenda(Agenda A)
        {

            try
            {
                this.abrirConexao();
                string sql = "DELETE FROM Agenda WHERE CodigoAgenda =" + A.CodigoAgenda;
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

        #region selecionando os registros da tabela
        public List<Agenda> SelecionarPorCodigo(Agenda A)
        {
            List<Agenda> retorno = new List<Agenda>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand("select Agenda.codigoAgenda, Agenda.Data, Agenda.Hora, Cliente.nome, Animal.nomeDoAnimal, Servico.nomeServico,status,encaixe FROM agenda,cliente, animal,SERVICO where agenda.codigoAnimal = animal.codigoAnimal and agenda.codigoServico = servico.Codigoservico and agenda.cpf = cliente.cpf and agenda.codigoAgenda="+A.CodigoAgenda, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                
                    //acessando os valores das colunas do resultado
                    A.CodigoAgenda = DbReader.GetInt32(DbReader.GetOrdinal("CodigoAgenda"));

                    A.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    A.Animal.Nome = DbReader.GetString(DbReader.GetOrdinal("nomeDoAnimal"));
                    A.Servico.NomeServico = DbReader.GetString(DbReader.GetOrdinal("nomeServico"));
                    A.Data = DbReader.GetString(DbReader.GetOrdinal("Data"));
                    A.Hora = DbReader.GetString(DbReader.GetOrdinal("Hora"));
                    A.Status = DbReader.GetString(DbReader.GetOrdinal("status"));
                    A.Encaixe = DbReader.GetString(DbReader.GetOrdinal("encaixe"));

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

        #region Delete registro na tabela
        public void CancelarAgenda(Agenda A)
        {

            try
            {
                this.abrirConexao();
                string sql = "UPDATE  Agenda SET STATUS = 'CANCELADO' WHERE CodigoAgenda =" + A.CodigoAgenda;
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

