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
    public partial class TelaAnimal : Form
    {
        public TelaAnimal()
        {
            InitializeComponent();
            ListarAnimal();
            ComboBoxRacaTipo();
        }

        private void ListarAnimal()
        {
            try
            {
                List<Animal> lista = new Service1Client().SelecionarAnimal().ToList();
                listViewAnimal.Items.Clear();
                foreach (Animal A in lista)
                {
                    ListViewItem itListView = listViewAnimal.Items.Add(A.Cliente.Cpf);
                    itListView.SubItems.Add(A.Cliente.Nome);
                    itListView.SubItems.Add(Convert.ToString(A.CodigoAnimal));
                    itListView.SubItems.Add(A.Nome);
                    itListView.SubItems.Add(A.Peso);
                    itListView.SubItems.Add(A.Idade);
                    itListView.SubItems.Add(A.Tipo.NomeTipo);
                    itListView.SubItems.Add(A.Raca.NomeRaca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBoxRacaTipo()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            Animal An = new Animal();
            try
            {
                List<Animal> ListaComboBox = new Service1Client().SelecionarAnimalTipo(An).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Animal A in ListaComboBox)
                {
                    comboSource.Add(A.Tipo.CodigoTipo, A.Tipo.NomeTipo);
                }
                comboBoxTipoAnimal.DataSource = new BindingSource(comboSource, null);
                comboBoxTipoAnimal.DisplayMember = "Value";
                comboBoxTipoAnimal.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ComboBoxRacaRaca(Animal A)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            try
            {
                List<Animal> ListaComboBox = new Service1Client().SelecionarAnimalRaca(A).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Animal An in ListaComboBox)
                {
                    comboSource.Add(An.Raca.CodigoRaca, An.Raca.NomeRaca);
                }
                comboBoxRacaAnimal.DataSource = new BindingSource(comboSource, null);
                comboBoxRacaAnimal.DisplayMember = "Value";
                comboBoxRacaAnimal.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelecionarAnimalNomePorCPF(Animal A)
        {
            try
            {
                List<Animal> ListaComboBox = new Service1Client().SelecionarAClientePorCPF(A).ToList();
                foreach (Animal An in ListaComboBox)
                {
                    lb_NomeCliente.Text = (An.Cliente.Nome + "   " + An.Cliente.SobreNome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxIdadeAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxPesoAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNomeAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
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

        private void textBoxIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
                    if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
                    if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxCodigoAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
                    if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void buttonCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                Animal A = new Animal();
                A.Cliente.Cpf = textBoxCPFCliente.Text;
                A.Tipo.CodigoTipo = ((KeyValuePair<int, string>)comboBoxTipoAnimal.SelectedItem).Key;
                A.Raca.CodigoRaca = ((KeyValuePair<int, string>)comboBoxRacaAnimal.SelectedItem).Key;
                A.Peso = textBoxPesoAnimal.Text;
                A.Idade = textBoxIdadeAnimal.Text;
                A.Nome = textBoxNomeAnimal.Text;
                if ((A.Tipo.CodigoTipo) == 0)
                {
                    MessageBox.Show("Escolha uma Tipo");
                }
                if ((A.Raca.CodigoRaca) == 0)
                {
                    MessageBox.Show("Escolha uma Raça");
                }
                else
                {
                    new Service1Client().InserirAnimal(A);
                    ListarAnimal();
                    textBoxCPFCliente.Clear();
                    textBoxPesoAnimal.Clear();
                    textBoxIdadeAnimal.Clear();
                    textBoxNomeAnimal.Clear();
                    MessageBox.Show("Cadastrada com sucesso");
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
                Animal A = new Animal();
                A.Cliente.Cpf = textBoxCPFCliente.Text;
                A.CodigoAnimal = ((KeyValuePair<int, string>)comboBoxCodigo.SelectedItem).Key;
                A.Tipo.CodigoTipo = ((KeyValuePair<int, string>)comboBoxTipoAnimal.SelectedItem).Key;
                A.Raca.CodigoRaca = ((KeyValuePair<int, string>)comboBoxRacaAnimal.SelectedItem).Key;
                A.Peso = textBoxPesoAnimal.Text;
                A.Idade = textBoxIdadeAnimal.Text;
                A.Nome = textBoxNomeAnimal.Text;
                if ((A.Tipo.CodigoTipo) == 0)
                {
                    MessageBox.Show("Escolha uma Tipo");
                }
                if ((A.Raca.CodigoRaca) == 0)
                {
                    MessageBox.Show("Escolha uma Raça");
                }
                else
                {
                    new Service1Client().AtualizarAnimal(A);
                    ListarAnimal();
                    textBoxCPFCliente.Clear();
                    textBoxPesoAnimal.Clear();
                    textBoxIdadeAnimal.Clear();
                    textBoxNomeAnimal.Clear();
                    MessageBox.Show("Atualizado com sucesso");
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
                Animal A = new Animal();
                A.Cliente.Cpf = textBoxCPFCliente.Text;
                A.CodigoAnimal = ((KeyValuePair<int, string>)comboBoxCodigo.SelectedItem).Key;
                if ((A.CodigoAnimal) == 0)
                {
                    MessageBox.Show("Escolha uma Codigo");
                }
                else
                {
                    new Service1Client().DeleteAnimal(A);
                    ListarAnimal();
                    textBoxCPFCliente.Clear();
                    textBoxPesoAnimal.Clear();
                    textBoxIdadeAnimal.Clear();
                    textBoxNomeAnimal.Clear();
                    MessageBox.Show("Removido com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCPFCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void comboBoxTipoAnimal_Leave(object sender, EventArgs e)
        {
            Animal A = new Animal();
            A.Tipo.CodigoTipo = ((KeyValuePair<int, string>)comboBoxTipoAnimal.SelectedItem).Key;
            ComboBoxRacaRaca(A);
        }

        private void textBoxCPFCliente_Leave(object sender, EventArgs e)
        {
            Animal A = new Animal();
            SelecionarAnimalNomePorCPF(A);
        }

    }
}
