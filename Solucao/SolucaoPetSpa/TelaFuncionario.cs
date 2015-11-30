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
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
            ListarComboBoxF();
            ListarComboBox();
            Listar();
        }

        private void Listar()
        {
            try
            {
                List<Funcionario> lista = new Service1Client().SelecionarFuncionario().ToList();
                listViewFuncionario.Items.Clear();
                foreach (Funcionario F in lista)
                {
                    ListViewItem itListView = listViewFuncionario.Items.Add(Convert.ToString(F.Matricula));
                    itListView.SubItems.Add(F.Nome);
                    itListView.SubItems.Add(F.Funcao.NomeFuncao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarComboBox()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            Funcionario Fu = new Funcionario();
            try
            {
                List<Funcionario> ListaComboBox = new Service1Client().SelecionaComboBoxFuncao(Fu).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Funcionario F in ListaComboBox)
                {
                    comboSource.Add(F.Funcao.CodigoFuncao, F.Funcao.NomeFuncao);
                }
                comboBoxFuncao.DataSource = new BindingSource(comboSource, null);
                comboBoxFuncao.DisplayMember = "Value";
                comboBoxFuncao.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarComboBoxF()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            Funcionario Fu = new Funcionario();
            try
            {
                List<Funcionario> ListaComboBox = new Service1Client().SelecionaComboBoxFuncao(Fu).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Funcionario F in ListaComboBox)
                {
                    comboSource.Add(F.Funcao.CodigoFuncao, F.Funcao.NomeFuncao);
                }
                comboBoxFuncaoF.DataSource = new BindingSource(comboSource, null);
                comboBoxFuncaoF.DisplayMember = "Value";
                comboBoxFuncaoF.ValueMember = "Key";

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

        private void textBoxSobreNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void textBoxMatricula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSobreNomeF_KeyPress(object sender, KeyPressEventArgs e)
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
                Funcionario F = new Funcionario();
                F.Nome = textBoxNome.Text;
                F.SobreNome = textBoxSobreNome.Text;
                F.Funcao.CodigoFuncao = ((KeyValuePair<int, string>)comboBoxFuncao.SelectedItem).Key;
                if ((F.Funcao.CodigoFuncao) == 0)
                {
                    MessageBox.Show("Escolha uma Função");
                }
                else
                {
                    new Service1Client().InserirFuncionario(F);
                    textBoxNome.Clear();
                    textBoxSobreNome.Clear();
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
                Funcionario F = new Funcionario();
                F.Matricula = Int32.Parse(textBoxMatricula.Text);
                F.Nome = textBoxNomeF.Text;
                F.SobreNome = textBoxSobreNomeF.Text;
                F.Funcao.CodigoFuncao = ((KeyValuePair<int, string>)comboBoxFuncaoF.SelectedItem).Key;
                if ((F.Funcao.CodigoFuncao) == 0)
                {
                    MessageBox.Show("Escolha uma Função");
                }
                else
                {

                    new Service1Client().AtualizarFuncionario(F);
                    textBoxMatricula.Clear();
                    textBoxNomeF.Clear();
                    textBoxSobreNomeF.Clear();
                    MessageBox.Show("Alterada com sucesso");
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
                Funcionario F = new Funcionario();
                F.Matricula = Int32.Parse(textBoxMatricula.Text);
                new Service1Client().DeleteFuncionario(F);
                textBoxMatricula.Clear();
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
