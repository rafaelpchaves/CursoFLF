using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CursoFLF.Negocios
{
    public class ConexaoLinq
    {
        private DbClientesDataContext _dbClientesDataContext;

        #region Entidade de Exemplo

        Clientes _cliente = new Clientes()
                                 {
                                     Cli_Nome = "Fernando Jr",
                                     Cli_Endereco = "Rua C",
                                     Cli_Bairro = "Centro",
                                     Cli_Estado = "CE",
                                     Cli_Telefone = "22222222",
                                     Cli_Celular = "99999999",
                                     Cli_Email = "teste@teste.com"
                                 };
        #endregion

        public bool Inserir(Clientes cliente)
        {
            try
            {
                _dbClientesDataContext = new DbClientesDataContext();
                _dbClientesDataContext.Clientes.InsertOnSubmit(_cliente);
                _dbClientesDataContext.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Atualizar(Clientes cliente)
        {
            try
            {
                _dbClientesDataContext = new DbClientesDataContext();
                Clientes objCliente = _dbClientesDataContext.Clientes.Single(c => c.Cli_Id == cliente.Cli_Id);

                objCliente.Cli_Nome = _cliente.Cli_Nome;
                objCliente.Cli_Endereco = _cliente.Cli_Endereco;
                objCliente.Cli_Bairro = _cliente.Cli_Bairro;
                objCliente.Cli_Estado = _cliente.Cli_Estado;
                objCliente.Cli_Telefone = _cliente.Cli_Telefone;
                objCliente.Cli_Celular = _cliente.Cli_Celular;
                objCliente.Cli_Email = _cliente.Cli_Email;

                _dbClientesDataContext.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Excluir(Clientes cliente)
        {
            try
            {
                _dbClientesDataContext = new DbClientesDataContext();
                Clientes objCliente = _dbClientesDataContext.Clientes.Single(c => c.Cli_Id == cliente.Cli_Id);
                _dbClientesDataContext.Clientes.DeleteOnSubmit(objCliente);
                _dbClientesDataContext.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Clientes> Pesquisar()
        {
            _dbClientesDataContext = new DbClientesDataContext();
            var cliente = (from c in _dbClientesDataContext.Clientes
                           select c);

            return cliente.ToList();
        }

        public List<Clientes> Pesquisar(Clientes cliente)
        {

            #region Exemplo 1

            _dbClientesDataContext = new DbClientesDataContext();
            var cli = (from c in _dbClientesDataContext.Clientes
                       where c.Cli_Nome == cliente.Cli_Nome
                       select c);

            #endregion

            #region Exemplo 2

            //_dbClientesDataContext = new DbClientesDataContext();
            //var cli = (from c in _dbClientesDataContext.Clientes
            //           select c);

            //if (!String.IsNullOrEmpty(_cliente.Cli_Telefone))
            //{
            //    cli = cli.Where(c => c.Cli_Nome == _cliente.Cli_Nome);
            //}

            #endregion

            return cli.ToList();
        }
    }
}
