using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoFLF.Negocios;

namespace CursoFLF.Desktop
{
    public partial class Form1 : Form
    {
        // Declarando e Instanciando a classe Conexão
        //private Conexao _Conexao = new Conexao();
        private ConexaoLinq _Conexao = new ConexaoLinq();
        private Clientes _cliente = new Clientes();

        // Construtor da classe
        public Form1()
        {
            // Método default do Windows Forms que inicializa o form ao executar o programa
            InitializeComponent();
        }

        /// <summary>
        /// Método que é chamado ao clicar no botao Inserir
        /// </summary>
        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Chamar o metodo de inserir e verifica se o retorno é verdadeiro
            if (_Conexao.Inserir(_cliente))
            {
                // Se sim... O registro foi inserido
                MessageBox.Show("Registro Cadastrado com sucesso!!");
            }
            else
            {
                // Se não... Apresenta uma mensagem de erro
                MessageBox.Show("Ocorreu um problema!!");
            }
        }

        /// <summary>
        /// Método que é chamado ao clicar no botao Atualizar
        /// </summary>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Chamar o metodo de atualizar e verifica se o retorno é verdadeiro
            if (_Conexao.Atualizar(_cliente))
            {
                // Se sim... O registro foi atualizado
                MessageBox.Show("Registro Atualizado com sucesso!!");
            }
            else
            {
                // Se não... Apresenta uma mensagem de erro
                MessageBox.Show("Ocorreu um problema!!");
            }
        }

        /// <summary>
        /// Método que é chamado ao clicar no botao Excluir
        /// </summary>
        private void Excluir_Click(object sender, EventArgs e)
        {
            // Chamar o metodo de excluir e verifica se o retorno é verdadeiro
            if (_Conexao.Excluir(_cliente))
            {
                // Se sim... O registro foi excluido
                MessageBox.Show("Registro Excluído com sucesso!!");
            }
            else
            {
                // Se não... Apresenta uma mensagem de erro
                MessageBox.Show("Ocorreu um problema!!");
            }
        }

        /// <summary>
        /// Método que é chamado ao clicar no botao Pesquisar
        /// </summary>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Atribuido a fonte de dados ao controle datagrid
            dgvClientes.DataSource = _Conexao.Pesquisar();

            // Informando qual tabela que existe no dataset será a fonte dos dados
            //dgvClientes.DataMember = "Tb_Clientes";
        }
    }
}
