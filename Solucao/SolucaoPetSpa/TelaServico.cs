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
    public partial class TelaServico : Form
    {
        public TelaServico()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            try
            {
                List<Servico> lista = new Service1Client().SelecionarServico().ToList();
                listViewServico.Items.Clear();
                foreach (Servico S in lista)
                {
                    ListViewItem itListView = listViewServico.Items.Add(Convert.ToString(S.CodigoServico));
                    itListView.SubItems.Add(S.NomeServico);
                    itListView.SubItems.Add(S.DescricaoServico);
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

        private void textBoxNomeA_KeyPress(object sender, KeyPressEventArgs e)
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
                Servico S = new Servico
                {
                    NomeServico = textBoxNome.Text,
                    DescricaoServico = richTextBoxDescricao.Text
                };
                new Service1Client().InserirServico(S);
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
                Servico S = new Servico
                {
                    CodigoServico = Int32.Parse(textBoxCodigo.Text),
                    NomeServico = textBoxNomeS.Text,
                    DescricaoServico = richTextBoxDescricaoS.Text
                };
                new Service1Client().AtualizarServico(S);
                textBoxCodigo.Clear();
                textBoxNome.Clear();
                richTextBoxDescricao.Clear();
                MessageBox.Show("Alterado com sucesso");
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
                Servico S = new Servico
                {
                    CodigoServico = Int32.Parse(textBoxCodigo.Text),
                };
                new Service1Client().DeleteServico(S);
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
