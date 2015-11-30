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
    public partial class TelaRaca : Form
    {   Raca R = new Raca();
        public TelaRaca()
        {
            InitializeComponent();
            ListarComboBoxR(R);
            ListarComboBox(R);
            Listar();
        }

        private void Listar()
        {
            try
            {
                List<Raca> lista = new Service1Client().SelecionarRaca().ToList();
                listViewRaca.Items.Clear();
                foreach (Raca R in lista)
                {
                    ListViewItem itListView = listViewRaca.Items.Add(Convert.ToString(R.CodigoRaca));
                    itListView.SubItems.Add(R.Tipo.NomeTipo);
                    itListView.SubItems.Add(R.NomeRaca);
                    itListView.SubItems.Add(R.DescricaoRaca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarComboBox(Raca R)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            Raca Ra = new Raca();
            try
            {
                List<Raca> ListaComboBox = new Service1Client().SelecionarRacaTipo(R).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Raca Raca in ListaComboBox)
                {
                    comboSource.Add(Raca.Tipo.CodigoTipo, Raca.Tipo.NomeTipo);
                }
                comboBoxTipo.DataSource = new BindingSource(comboSource, null);
                comboBoxTipo.DisplayMember = "Value";
                comboBoxTipo.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarComboBoxR(Raca R)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            Raca Ra = new Raca();
            try
            {
                List<Raca> ListaComboBox = new Service1Client().SelecionarRacaTipo(R).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Raca Raca in ListaComboBox)
                {
                    comboSource.Add(Raca.Tipo.CodigoTipo, Raca.Tipo.NomeTipo);
                }
                comboBoxTipoR.DataSource = new BindingSource(comboSource, null);
                comboBoxTipoR.DisplayMember = "Value";
                comboBoxTipoR.ValueMember = "Key";

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
                Raca R = new Raca();
                R.NomeRaca = textBoxNome.Text;
                R.DescricaoRaca = richTextBoxDescricao.Text;
                R.Tipo.CodigoTipo = ((KeyValuePair<int, string>)comboBoxTipo.SelectedItem).Key;
                if ((R.Tipo.CodigoTipo) == 0)
                {
                    MessageBox.Show("Escolha um Tipo");
                }
                else
                {
                    new Service1Client().InserirRaca(R);
                    textBoxNome.Clear();
                    richTextBoxDescricao.Clear();
                    MessageBox.Show("Cadastrada com sucesso");
                    Listar();
                }
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
                Raca R = new Raca();
                R.CodigoRaca = Int32.Parse(textBoxCodigo.Text);
                R.NomeRaca = textBoxNomeR.Text;
                R.DescricaoRaca = richTextBoxDescricaoR.Text;
                R.Tipo.CodigoTipo = ((KeyValuePair<int, string>)comboBoxTipoR.SelectedItem).Key;
                if ((R.Tipo.CodigoTipo) == 0)
                {
                    MessageBox.Show("Escolha um Tipo");
                }
                else
                {
                    new Service1Client().AtualizarRaca(R);
                    textBoxCodigo.Clear();
                    textBoxNome.Clear();
                    richTextBoxDescricao.Clear();
                    MessageBox.Show("Alterado com sucesso");
                    Listar();
                }
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
                Raca R = new Raca();
                R.CodigoRaca = Int32.Parse(textBoxCodigo.Text);
                if ((R.CodigoRaca) == 0)
                {
                    MessageBox.Show("Insira o Codigo");
                }
                else
                {
                    new Service1Client().DeleteRaca(R);
                    textBoxCodigo.Clear();
                    textBoxNome.Clear();
                    richTextBoxDescricao.Clear();
                    MessageBox.Show("Removido com sucesso");
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
