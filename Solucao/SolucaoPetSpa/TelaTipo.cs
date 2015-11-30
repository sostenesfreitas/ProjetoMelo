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

namespace SolucaoPetSpa
{
    public partial class TelaTipo : Form
    {
        public TelaTipo()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            try
            {
                List<Tipo> lista = new Service1Client().SelecionarTipo().ToList();
                listViewTipo.Items.Clear();
                foreach (Tipo S in lista)
                {
                    ListViewItem itListView = listViewTipo.Items.Add(Convert.ToString(S.CodigoTipo));
                    itListView.SubItems.Add(S.NomeTipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo T = new Tipo
                {
                    NomeTipo = textBoxNome.Text,
                };
                new Service1Client().InserirTipo(T);
                textBoxCodigo.Clear();
                textBoxNome.Clear();
                MessageBox.Show("Cadastrada com sucesso");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo T = new Tipo
                {
                    CodigoTipo = Int32.Parse(textBoxCodigo.Text),
                    NomeTipo = textBoxNome.Text,
                };
                new Service1Client().AtualizarTipo(T);
                textBoxCodigo.Clear();
                textBoxNome.Clear();
                MessageBox.Show("Alterado com sucesso");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo T = new Tipo
                {
                    CodigoTipo = Int32.Parse(textBoxCodigo.Text),
                };
                new Service1Client().DeleteTipo(T);
                textBoxCodigo.Clear();
                MessageBox.Show("Removido com sucesso");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

    }
}
