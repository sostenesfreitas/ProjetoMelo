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
using Biblioteca.Dados;

namespace SolucaoPetSpa
{
    public partial class TelaCliente : Form
    {
        Endereco E = new Endereco();
        public TelaCliente()
        {
            InitializeComponent();
            ListarEnderecoCliente(E);
            Listar();
        }

        private void ListarEnderecosDoCPF(Endereco E)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            Endereco En = new Endereco();
            try
            {
                List<Endereco> ListaComboBox = new Service1Client().SelecionarEnderecosDoCPF(E).ToList();
                comboSource.Add(0, "- Escolha -");
                foreach (Endereco Endereco in ListaComboBox)
                {
                    comboSource.Add(Endereco.CodigoEndereco, Endereco.CodigoEndereco.ToString());
                }
                comboBoxCodigo.DataSource = new BindingSource(comboSource, null);
                comboBoxCodigo.DisplayMember = "Value";
                comboBoxCodigo.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listar()
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

        private void ListarEnderecoCliente(Endereco E)
        {
            try
            {
                List<Endereco> lista = new Service1Client().SelecionarEnderecoCliente(E).ToList();
                listViewEndereco.Items.Clear();
                foreach (Endereco Endereco in lista)
                {
                    ListViewItem itListView = listViewEndereco.Items.Add(Endereco.Cliente.Cpf);
                    itListView.SubItems.Add(Endereco.Cliente.Nome);
                    itListView.SubItems.Add(Convert.ToString(Endereco.CodigoEndereco));
                    itListView.SubItems.Add(Endereco.Logradouro);
                    itListView.SubItems.Add(Endereco.Estado);
                    itListView.SubItems.Add(Endereco.Cidade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSobreNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void textBoxCEPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumeroC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxComplementoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void textBoxCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxComplemeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente C = new Cliente
                {
                    Cpf = textBoxCPF.Text,
                    Nome = textBoxNome.Text,
                    SobreNome = textBoxSobreNome.Text,
                    Telefone = textBoxTelefone.Text
                };
                new Service1Client().InserirCliente(C);
                textBoxCPF.Clear();
                textBoxNome.Clear();
                textBoxSobreNome.Clear();
                textBoxTelefone.Clear();
                MessageBox.Show("Cadastrada com sucesso");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente C = new Cliente
                {
                    Cpf = textBoxCPF.Text,
                    Nome = textBoxNome.Text,
                    SobreNome = textBoxSobreNome.Text,
                    Telefone = textBoxTelefone.Text
                };
                new Service1Client().AtualizarCliente(C);
                textBoxCPF.Clear();
                textBoxNome.Clear();
                textBoxSobreNome.Clear();
                textBoxTelefone.Clear();
                MessageBox.Show("Atualizar com sucesso");
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
                Cliente C = new Cliente
                {
                    Cpf = textBoxCPF.Text,
                };
                new Service1Client().DeleteCliente(C);
                textBoxCPF.Clear();
                textBoxNome.Clear();
                textBoxSobreNome.Clear();
                textBoxTelefone.Clear();
                MessageBox.Show("Remover com sucesso");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCadastraE_Click(object sender, EventArgs e)
        {
            try
            {
                Endereco E = new Endereco();
                E.Cliente.Cpf = textBoxCPFE.Text;
                E.Cep = textBoxCEP.Text;
                E.Logradouro = lb_logradouro.Text;
                E.Estado = lb_Estado.Text;
                E.Cidade = lb_Cidade.Text;
                E.Bairro = lb_Bairro.Text;
                E.Numero = textBoxNumero.Text;
                E.Complemento = textBoxComplemento.Text;
                new Service1Client().InserirEndereco(E);
                textBoxNome.Clear();
                textBoxCPFE.Clear();
                textBoxCEP.Clear();
                lb_logradouro.Text = "";
                lb_Estado.Text = "";
                lb_Cidade.Text = "";
                lb_Bairro.Text = "";
                textBoxNumero.Clear();
                textBoxComplemento.Clear();
                MessageBox.Show("Cadastrada com sucesso");
                ListarEnderecoCliente(E);
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterarE_Click(object sender, EventArgs e)
        {
            try
            {
                Endereco E = new Endereco();
                E.Cliente.Cpf = textBoxCPFEA.Text;
                E.Cep = textBoxCEPA.Text;
                E.Logradouro = lb_LogradouroA.Text;
                E.Estado = lb_EstadoA.Text;
                E.Cidade = lb_CidadeA.Text;
                E.Bairro = lb_BairroA.Text;
                E.Numero = textBoxNumeroA.Text;
                E.Complemento = textBoxComplementoA.Text;
                new Service1Client().AtualizarEndereco(E);
                comboBoxCodigo.DataSource = null;
                textBoxCPFEA.Clear();
                textBoxCEPA.Clear();
                lb_LogradouroA.Text = "";
                lb_EstadoA.Text = "";
                lb_CidadeA.Text = "";
                lb_BairroA.Text = "";
                textBoxNumeroA.Clear();
                textBoxComplementoA.Clear();
                MessageBox.Show("Alterado com sucesso");
                ListarEnderecoCliente(E);
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRemoverE_Click(object sender, EventArgs e)
        {
            try
            {
                Endereco E = new Endereco();
                E.CodigoEndereco = ((KeyValuePair<int, string>)comboBoxCodigo.SelectedItem).Key;
                new Service1Client().DeleteEndereco(E);
                comboBoxCodigo.DataSource = null;
                textBoxCPFEA.Clear();
                textBoxCEPA.Clear();
                lb_LogradouroA.Text = "";
                lb_EstadoA.Text = "";
                lb_CidadeA.Text = "";
                lb_BairroA.Text = "";
                textBoxNumeroA.Clear();
                textBoxComplementoA.Clear();
                MessageBox.Show("Remover com sucesso");
                ListarEnderecoCliente(E);
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCPFEA_Leave(object sender, EventArgs e)
        {
            Endereco E = new Endereco();
            E.Cliente.Cpf = textBoxCPFEA.Text;
            ListarEnderecosDoCPF(E);
        }

        private void textBoxCEP_Leave(object sender, EventArgs e)
        {
            var modeloRetorno = new DadosBuscaCEP().RetornarCEP(textBoxCEP.Text);
            if (modeloRetorno.Resultado.Equals("1") || modeloRetorno.Resultado.Equals("2"))
            {
                lb_logradouro.Text = modeloRetorno.TipoLogradouro + " " + modeloRetorno.Logradouro;
                lb_Bairro.Text = modeloRetorno.Bairro;
                lb_Cidade.Text = modeloRetorno.Cidade;
                lb_Estado.Text = modeloRetorno.UF;
            }
            else
                MessageBox.Show("Sua busca não retornou resultados!");
        }

        private void textBoxCEPA_Leave(object sender, EventArgs e)
        {
            var modeloRetorno = new DadosBuscaCEP().RetornarCEP(textBoxCEPA.Text);
            if (modeloRetorno.Resultado.Equals("1") || modeloRetorno.Resultado.Equals("2"))
            {
                lb_LogradouroA.Text = modeloRetorno.TipoLogradouro + " " + modeloRetorno.Logradouro;
                lb_BairroA.Text = modeloRetorno.Bairro;
                lb_CidadeA.Text = modeloRetorno.Cidade;
                lb_EstadoA.Text = modeloRetorno.UF;
            }
            else
                MessageBox.Show("Sua busca não retornou resultados!");
        }

    }
}

