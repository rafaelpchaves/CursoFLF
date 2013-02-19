using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFLF.Negocios
{
    /// <summary>
    /// Classe responsável em gerenciar todas as ações referente a conexão
    /// </summary>
    public class Conexao
    {
        // Criando o objeto que contém a string de conexão
        private SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=CursoFLF;Integrated Security=True");

        // Encapsulando a string de conexão para somente leitura
        public SqlConnection Con
        {
            get { return con; }
        }

        // Declarando o objeto resposnável em executar os comandos ao BD
        private SqlCommand _command;

        /// <summary>
        /// Método responsável em abrir a conexão do BD
        /// </summary>
        /// <param name="con">Objeto que contem a conexão</param>
        private void AbrirConexao(SqlConnection con)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        /// <summary>
        /// Método responsável em fechar a conexão do BD
        /// </summary>
        /// <param name="con">Objeto que contem a conexão</param>
        private void FecharConexao(SqlConnection con)
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        /// <summary>
        /// Método responsável em inserir um registro do BD
        /// </summary>
        /// <returns>Retorna verdadeiro/falso indicando se o comando foi realizado com sucesso</returns>
        public bool Inserir()
        {
            try
            {
                // Instanciado o objeto sqlcommand
                _command = new SqlCommand();

                // Atribuido o objeto que contem a string de conexao ao objeto sqlcommand
                _command.Connection = con;

                // Craindo o comando de insert
                _command.CommandText = "INSERT INTO Tb_Clientes (Cli_Nome, Cli_Endereco, Cli_Bairro, Cli_Estado, Cli_Telefone, Cli_Celular, Cli_Email) VALUES (@Cli_Nome, @Cli_Endereco, @Cli_Bairro, @Cli_Estado, @Cli_Telefone, @Cli_Celular, @Cli_Email)";

                // Atribuindo os parâmetros para inserir no BD
                _command.Parameters.AddWithValue("@Cli_Nome", "Fernando");
                _command.Parameters.AddWithValue("@Cli_Endereco", "Rua A");
                _command.Parameters.AddWithValue("@Cli_Bairro", "Centro");
                _command.Parameters.AddWithValue("@Cli_Estado", "CE");
                _command.Parameters.AddWithValue("@Cli_Telefone", "2222222");
                _command.Parameters.AddWithValue("@Cli_Celular", "8888888");
                _command.Parameters.AddWithValue("@Cli_Email", "teste@teste.com");

                // Chamando o método para abrir a conexão
                AbrirConexao(con);

                // Executando o comando
                _command.ExecuteNonQuery();

                // Chamando o método para fechar a conexão
                FecharConexao(con);

                // Retornando verdadeiro, indicando que não aocnteceu nenhum errro e o registro foi inserido no BD
                return true;
            }
            catch (SqlException)
            {
                // Retornar falso, indicando que ocorrreu um erro vindo do BD SQL Server
                return false;
            }
            catch (Exception)
            {
                // Retornar falso, indicando que ocorrreu um erro na aplicação
                return false;
            }
            finally
            {
                // Garantir que a conexão será fechada sempre
                FecharConexao(con);
            }
        }

        /// <summary>
        /// Método responsável em atualizar um registro do BD
        /// </summary>
        /// <returns>Retorna verdadeiro/falso indicando se o comando foi realizado com sucesso</returns>
        public bool Atualizar()
        {
            try
            {
                // Instanciado o objeto sqlcommand
                _command = new SqlCommand();

                // Atribuido o objeto que contem a string de conexao ao objeto sqlcommand
                _command.Connection = con;

                // Craindo o comando de update
                _command.CommandText = "UPDATE Tb_Clientes SET Cli_Endereco = @Cli_Endereco, Cli_Telefone =  @Cli_Telefone, Cli_Celular = @Cli_Celular WHERE Cli_Id = @Cli_Id";

                // Atribuindo os parâmetros para inserir no BD
                _command.Parameters.AddWithValue("@Cli_Id", "4");
                _command.Parameters.AddWithValue("@Cli_Endereco", "Rua Z");
                _command.Parameters.AddWithValue("@Cli_Telefone", "55555555");
                _command.Parameters.AddWithValue("@Cli_Celular", "99999999");

                // Chamando o método para abrir a conexão
                AbrirConexao(con);

                // Executando o comando
                _command.ExecuteNonQuery();

                // Chamando o método para fechar a conexão
                FecharConexao(con);

                // Retornando verdadeiro, indicando que não aocnteceu nenhum errro e o registro foi atualizado no BD
                return true;
            }
            catch (SqlException)
            {
                // Retornar falso, indicando que ocorrreu um erro vindo do BD SQL Server
                return false;
            }
            catch (Exception)
            {
                // Retornar falso, indicando que ocorrreu um erro na aplicação
                return false;
            }
            finally
            {
                // Garantir que a conexão será fechada sempre
                FecharConexao(con);
            }
        }

        /// <summary>
        /// Método responsável em deletar um registro do BD
        /// </summary>
        /// <returns>Retorna verdadeiro/falso indicando se o comando foi realizado com sucesso</returns>
        public bool Excluir()
        {
            try
            {
                // Instanciado o objeto sqlcommand
                _command = new SqlCommand();

                // Atribuido o objeto que contem a string de conexao ao objeto sqlcommand
                _command.Connection = con;

                // Craindo o comando de delete
                _command.CommandText = "DELETE FROM Tb_Clientes WHERE Cli_Id = @Cli_Id";

                // Atribuindo os parâmetros para inserir no BD
                _command.Parameters.AddWithValue("@Cli_Id", "4");

                // Chamando o método para abrir a conexão
                AbrirConexao(con);

                // Executando o comando
                _command.ExecuteNonQuery();

                // Chamando o método para fechar a conexão
                FecharConexao(con);

                // Retornando verdadeiro, indicando que não aocnteceu nenhum errro e o registro foi atualizado no BD
                return true;
            }
            catch (SqlException)
            {
                // Retornar falso, indicando que ocorrreu um erro vindo do BD SQL Server
                return false;
            }
            catch (Exception)
            {
                // Retornar falso, indicando que ocorrreu um erro na aplicação
                return false;
            }
            finally
            {
                // Garantir que a conexão será fechada sempre
                FecharConexao(con);
            }
        }

        /// <summary>
        /// Método responsável em pesquisar um registro do BD
        /// </summary>
        /// <returns>Retorna um objeto DataSet contendo o retorno da consulta</returns>
        public DataSet Pesquisar()
        {
            // Criando e instanciando o objeto DataSet
            DataSet dataSet = new DataSet();

            // Criando e instanciando o objeto dataadapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tb_Clientes", con);

            // Realizando a pesquisa no DataAdapter e populando o dataset
            dataAdapter.Fill(dataSet, "Tb_Clientes");

            // Retorna o dataset populado caso a consulta tenha algum retorno
            return dataSet;
        }
    }
}
