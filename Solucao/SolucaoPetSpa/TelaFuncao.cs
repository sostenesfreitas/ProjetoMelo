using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.ClassesBasicas;
using SolucaoPetSpa.ServiceReference1;
using System.IO;

namespace SolucaoPetSpa
{
    public partial class TelaFuncao : Form
    {
        public TelaFuncao()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            try
            {
                List<Funcao> lista = new Service1Client().SelecionarFuncao().ToList();
                listViewFuncao.Items.Clear();
                foreach (Funcao F in lista)
                {
                    ListViewItem itListView = listViewFuncao.Items.Add(Convert.ToString(F.CodigoFuncao));
                    itListView.SubItems.Add(F.NomeFuncao);
                    itListView.SubItems.Add(F.DescricaoFuncao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNomeF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void buttonCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                Funcao F = new Funcao
            {
                NomeFuncao = textBoxNome.Text,
                DescricaoFuncao = richTextBoxDescricao.Text
            };
                new Service1Client().InserirFuncao(F);
                textBoxNome.Clear();
                richTextBoxDescricao.Clear();
                MessageBox.Show("Cadastrada com sucesso");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcao F = new Funcao
             {
                 CodigoFuncao = Int32.Parse(textBoxCodigo.Text),
                 NomeFuncao = textBoxNomeF.Text,
                 DescricaoFuncao = richTextBoxDescricaF.Text
             };
                new Service1Client().AtualizarFuncao(F);
                textBoxCodigo.Clear();
                textBoxNomeF.Clear();
                richTextBoxDescricaF.Clear();
                MessageBox.Show("Alterada com sucesso");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                Funcao F = new Funcao
            {
                CodigoFuncao = Int32.Parse(textBoxCodigo.Text),
            };
                new Service1Client().DeleteFuncao(F);
                textBoxCodigo.Clear();
                MessageBox.Show("Removido com sucesso");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

