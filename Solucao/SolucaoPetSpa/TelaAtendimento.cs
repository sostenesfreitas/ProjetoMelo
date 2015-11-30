using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Dados;
using Biblioteca.ClassesBasicas;
using SolucaoPetSpa.ServiceReference1;
using System.IO;


namespace SolucaoPetSpa
{
    public partial class TelaAtendimento : Form
    {
        DateTime date_time;
        public TelaAtendimento()
        {
            InitializeComponent();
            ListarComboBoxStatus();
            ListarComboBoxFuncionario();
        }

        private void SelecionarAgendaPorCpf(Atendimento A)
        {
            try
            {
                List<Atendimento> lista = new Service1Client().SelecionarAgendaPorCpf(A).ToList();
                listViewAgendaCPF.Items.Clear();
                foreach (Atendimento Atendimento in lista)
                {
                    ListViewItem itListView = listViewAgendaCPF.Items.Add(Atendimento.Agenda.Data);
                    itListView.SubItems.Add(Atendimento.Agenda.Hora);
                    itListView.SubItems.Add(Atendimento.Animal.Nome);
                    itListView.SubItems.Add(Atendimento.Servico.NomeServico);
                    itListView.SubItems.Add(Atendimento.Cliente.Cpf);
                    itListView.SubItems.Add(Atendimento.Cliente.Nome);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarServico()
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

        private void ListarCliente()
        {
            try
            {
                List<Cliente> lista = new Service1Client().SelecionarCliente().ToList();
                listViewCliente.Items.Clear();
                foreach (Cliente C in lista)
                {
                    ListViewItem itListView = listViewCliente.Items.Add(C.Cpf);
                    itListView.SubItems.Add(C.Nome);
                    itListView.SubItems.Add(C.SobreNome);
                    itListView.SubItems.Add(C.Telefone);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    itListView.SubItems.Add(A.Tipo.NomeTipo);
                    itListView.SubItems.Add(A.Raca.NomeRaca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaComboBoxATAnimal(Atendimento A)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            try
            {
                List<Atendimento> ListaComboBox = new Service1Client().ListaComboBoxATAnimal(A).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Atendimento At in ListaComboBox)
                {
                    comboSource.Add(At.Animal.CodigoAnimal, At.Animal.Nome);
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

        private void ListarComboBoxFuncionario()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            try
            {
                List<Funcionario> ListaComboBox = new Service1Client().SelecionarFuncionario().ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Funcionario F in ListaComboBox)
                {
                    comboSource.Add(F.Matricula, F.Nome);
                }
                comboBoxFuncionario.DataSource = new BindingSource(comboSource, null);
                comboBoxFuncionario.DisplayMember = "Value";
                comboBoxFuncionario.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarComboBoxStatus()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            try
            {
                comboSource.Add(" ", "- Escolha -");
                comboSource.Add("Espera", "Espera");
                comboSource.Add("Andamento", "Andamento");
                comboSource.Add("Concluido", "Concluido");
                comboBoxStatus.DataSource = new BindingSource(comboSource, null);
                comboBoxStatus.DisplayMember = "Value";
                comboBoxStatus.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TelaFuncionario TF = new TelaFuncionario();
                TF.Show();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao abrir tela de cadastro do Funcionario " + ex.Message);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TelaCliente TC = new TelaCliente();
                TC.Show();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao abrir tela de cadastro do Cliente " + ex.Message);
            }
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TelaServico TS = new TelaServico();
                TS.Show();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao abrir tela de cadastro do Serviço " + ex.Message);
            }
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TelaAnimal TA = new TelaAnimal();
                TA.Show();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao abrir tela de cadastro do Animal " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarCliente();
            ListarServico();
            ListarAnimal();
            date_time = DateTime.Now;
            lb_date_time.Text = "Data : " + date_time.ToLongDateString() + "  Hora: " + date_time.ToLongTimeString();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fábio José Lucena \nBrunno Barbosa \nSostenes Freitas \nVinicius Marinho", "Desenvolvedores:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void testaConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao con = new Conexao();
                con.abrirConexao();
                MessageBox.Show("Conexão efetuada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cadastra_Click(object sender, EventArgs e)
        {
            try
            {
                Atendimento A = new Atendimento();
                A.Descricao = richTextBoxDescricao.Text;
                A.Agenda.CodigoAgenda = ((KeyValuePair<int, string>)comboBoxAgenda.SelectedItem).Key;
                A.Status = ((KeyValuePair<string, string>)comboBoxStatus.SelectedItem).Key;
                A.Funcionario.Matricula = ((KeyValuePair<int, string>)comboBoxFuncionario.SelectedItem).Key;
                new Service1Client().InserirAtendimento(A);
                richTextBoxDescricao.Clear();
                textBoxCPF.Clear();
                comboBoxAnimal.DataSource = null;
                comboBoxStatus.DataSource = null;
                comboBoxAgenda.DataSource = null;
                comboBoxFuncionario.DataSource = null;
                lb_Logradouro.Text = " ";
                lb_Estado.Text = " ";
                lb_Cidade.Text = " ";
                lb_Bairro.Text = " ";
                lb_Numero.Text = " ";
                lb_Complemento.Text = " ";
                MessageBox.Show("Cadastrada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void funçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                TelaFuncao TF = new TelaFuncao();
                TF.Show();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao abrir tela de cadastro do Função " + ex.Message);
            }
        }

        private void raçaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                TelaRaca TR = new TelaRaca(); ;
                TR.Show();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao abrir tela de cadastro do Raça " + ex.Message);
            }
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TelaTipo TT = new TelaTipo();
                TT.Show();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao abrir tela de cadastro do Tipo " + ex.Message);
            }
        }

        private void textBoxCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                Atendimento A = new Atendimento();
                A.Cliente.Cpf = textBoxCPF.Text;
                SelecionarAgendaPorCpf(A);
                SelecionarNomePorCPF(A);
                ListaComboBoxATAnimal(A);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelecionarAgendaPorAnimal(Atendimento A)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            try
            {
                List<Atendimento> ListaComboBox = new Service1Client().SelecionarAgendaPorAnimal(A).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Atendimento At in ListaComboBox)
                {
                    comboSource.Add(At.Agenda.CodigoAgenda, Convert.ToString(At.Agenda.CodigoAgenda));
                }
                comboBoxAgenda.DataSource = new BindingSource(comboSource, null);
                comboBoxAgenda.DisplayMember = "Value";
                comboBoxAgenda.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelecionarNomePorCPF(Atendimento A)
        {
            try
            {
                List<Atendimento> ListaComboBox = new Service1Client().SelecionarClientePorCPF(A).ToList();
                foreach (Atendimento At in ListaComboBox)
                {
                    lb_NomeCliente.Text = (At.Cliente.Nome + "   " + At.Cliente.SobreNome);
                    lb_CEP.Text = (At.Endereco.Cep);
                    lb_Logradouro.Text = (At.Endereco.Logradouro);
                    lb_Estado.Text = (At.Endereco.Estado);
                    lb_Cidade.Text = (At.Endereco.Cidade);
                    lb_Bairro.Text = (At.Endereco.Bairro);
                    lb_Numero.Text = (At.Endereco.Numero);
                    lb_Complemento.Text = (At.Endereco.Complemento);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxAnimal_Leave(object sender, EventArgs e)
        {
            lb_NomeAnimal.Text = ((KeyValuePair<int, string>)comboBoxAnimal.SelectedItem).Value;
            Atendimento A = new Atendimento();
            A.Cliente.Cpf = textBoxCPF.Text;
            A.Animal.CodigoAnimal = ((KeyValuePair<int, string>)comboBoxAnimal.SelectedItem).Key;
            SelecionarAgendaPorAnimal(A);
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamento A = new Agendamento();
                A.Show();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao abrir tela de agendamento " + ex.Message);
            }
        }

        private void textBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

    }
}
