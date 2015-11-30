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
using Biblioteca.Negocio;
using SolucaoPetSpa.ServiceReference1;
using System.IO;


namespace SolucaoPetSpa
{
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();

            ListarComboBoxS();
            ListarComboBoxC();
            ListaraAgenda();
            ListarComboBoxEncaixe();
        }

        private void ListarComboBoxEncaixe()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            try
            {
                comboSource.Add(" ", "- Escolha -");
                comboSource.Add("Sim", "Sim");
                comboSource.Add("Nao", "Nao"); 
                comboBoxEncaixe.DataSource = new BindingSource(comboSource, null);
                comboBoxEncaixe.DisplayMember = "Value";
                comboBoxEncaixe.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ListaraAgenda()
        {
            try
            {
                List<Agenda> lista = new Service1Client().SelecionarAgenda().ToList();
                listViewAnimal.Items.Clear();
                foreach (Agenda A in lista)
                {
                    ListViewItem itListView = listViewAnimal.Items.Add(Convert.ToString(A.CodigoAgenda));
                    itListView.SubItems.Add(A.Animal.Nome);
                    itListView.SubItems.Add(A.Cliente.Nome);
                    itListView.SubItems.Add(A.Servico.NomeServico);
                    itListView.SubItems.Add(A.Data);
                    itListView.SubItems.Add(A.Hora);
                    itListView.SubItems.Add(A.Status);
                    itListView.SubItems.Add(A.Encaixe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaraAgendaUpdate(Agenda A)
        {
            try
            {
                 new Service1Client().SelecionarPorCodigo(A).ToList();
                
               
                   
                    CPF.GetItemText(A.Cliente.Nome);
                    comboBoxServico.GetItemText(A.Servico.NomeServico);
                    comboBoxEncaixe.GetItemText(A.Encaixe);
                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ListarComboBox(Cliente A)
        {

            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            try
            {
                List<Animal> ListaComboBox = new Service1Client().SelecionaComboBoxAnimal(A).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Animal An in ListaComboBox)
                {
                    comboSource.Add(An.CodigoAnimal, An.Nome);
                }
                comboBoxAnimal.DataSource = new BindingSource(comboSource, null);
                comboBoxAnimal.DisplayMember = "Value";
                comboBoxAnimal.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarComboBoxS()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            try
            {
                List<Servico> ListaComboBox = new Service1Client().SelecionaComboBoxServico().ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Servico S in ListaComboBox)
                {
                    comboSource.Add(S.CodigoServico, S.NomeServico);
                }
                comboBoxServico.DataSource = new BindingSource(comboSource, null);
                comboBoxServico.DisplayMember = "Value";
                comboBoxServico.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarComboBoxC()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            try
            {
                List<Cliente> ListaComboBox = new Service1Client().SelecionaComboBoxCliente().ToList();
                comboSource.Add("0", "- Escolha -");
                foreach (Cliente C in ListaComboBox)
                {
                    comboSource.Add(C.Cpf, C.Nome);
                }
                CPF.DataSource = new BindingSource(comboSource, null);
                CPF.DisplayMember = "Value";
                CPF.ValueMember = "Key";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }


       
        private void listViewAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void OkCPF_Click(object sender, EventArgs e)
        {
            Cliente A = new Cliente();
            A.Cpf = ((KeyValuePair<string, string>)CPF.SelectedItem).Key;
            ListarComboBox(A);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Agenda A = new Agenda();
                A.Cliente.Cpf = ((KeyValuePair<string, string>)CPF.SelectedItem).Key;
                A.Animal.CodigoAnimal = ((KeyValuePair<int, string>)comboBoxAnimal.SelectedItem).Key;
                A.Servico.CodigoServico = ((KeyValuePair<int, string>)comboBoxServico.SelectedItem).Key;
                A.Data = maskedTextBox1.Text;
                A.Hora = maskedTextBox2.Text;
                A.Encaixe = ((KeyValuePair<string, string>)comboBoxEncaixe.SelectedItem).Key;
                if ((A.Animal.CodigoAnimal) == 0)
                {
                    MessageBox.Show("Escolha um Animal");
                }
                else if ((A.Servico.CodigoServico) == 0)
                {
                    MessageBox.Show("Escolha um Servico");
                }
                else if ((A.Data) == null)
                {
                    MessageBox.Show("Selecione a Data do Agendamento");
                }
                else if ((A.Hora) == null)
                {
                    MessageBox.Show("Selecione o Horario do Agendamento");
                }
                else
                {
                    new Service1Client().InserirAgenda(A);
                    maskedTextBox1.Clear();
                    maskedTextBox2.Clear();
                    MessageBox.Show("Agenda Cadastrada com sucesso");
                    ListaraAgenda();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo == null)
            {
                MessageBox.Show("Selecione um codigo para alterar");
            }
            else
            {
                try
                {
                    Agenda A = new Agenda();
                    A.CodigoAgenda = Int32.Parse(textBoxCodigo.Text);
                    A.Cliente.Cpf = ((KeyValuePair<string, string>)CPF.SelectedItem).Key;
                    A.Animal.CodigoAnimal = ((KeyValuePair<int, string>)comboBoxAnimal.SelectedItem).Key;
                    A.Servico.CodigoServico = ((KeyValuePair<int, string>)comboBoxServico.SelectedItem).Key;
                    A.Data = maskedTextBox1.Text;
                    A.Hora = maskedTextBox2.Text;
                    A.Encaixe = ((KeyValuePair<string, string>)comboBoxEncaixe.SelectedItem).Key;
                    if ((A.Animal.CodigoAnimal) == 0)
                    {
                        MessageBox.Show("Escolha um Animal");
                    }
                    else
                    {
                        new Service1Client().AtualizarAgenda(A);
                        maskedTextBox1.Clear();
                        maskedTextBox2.Clear();
                        MessageBox.Show("Agenda Atualizado com sucesso");
                        ListaraAgenda();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Agenda A = new Agenda();
                A.CodigoAgenda = Int32.Parse(textBoxCodigo.Text);
                
                
                
                    new Service1Client().CancelarAgenda(A);
                   
                    MessageBox.Show("Agenda Cancelada com sucesso");
                    ListaraAgenda();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Agenda A = new Agenda();
            A.CodigoAgenda = Int32.Parse(textBoxCodigo.Text);
            ListaraAgendaUpdate(A);
        }
    }
}

