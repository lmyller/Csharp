using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{

    public partial class SistemaCadastroGUI : Form
    {
        private const string DEFAULT_STRING_VAZIA = "";

        private ListaPessoas listaPessoas;

        public SistemaCadastroGUI()
        {
            InitializeComponent();

            listaPessoas = new ListaPessoas();
        }

        private void CadastrarAlterarButton_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                listaPessoas.AdicionarPessoa(CriarPessoa());
                MessageBox.Show("Pessoa cadastrada com sucesso");

                LimparCampos();
            }
        }

        private bool ValidaDados()
        {
            if (string.IsNullOrEmpty(nomeTextBox.Text))
            {
                MessageBox.Show("Preencha o nome");
                nomeTextBox.Focus();
                
                return false;
            }

            if(!masculinoRadioButton.Checked && !femininoRadioButton.Checked)
            {
                MessageBox.Show("Escolha o sexo");

                return false;   
            }

            if (string.IsNullOrEmpty(telefoneMaskedTextBox.Text))
            {
                MessageBox.Show("Preencha o telefone");
                telefoneMaskedTextBox.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(estadoCivilComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Escolha o estado civil");
                estadoCivilComboBox.Focus();

                return false;
            }

            if (dataNascimentoDateTimePicker.Value.Equals(DateTime.Now))
            {
                MessageBox.Show("Informe a data de nascimento");
                dataNascimentoDateTimePicker.Focus();

                return false;
            }

            return true;
        }

        private Pessoa CriarPessoa()
        {
            return new Pessoa(nomeTextBox.Text.Trim(), ObterSexo(), telefoneMaskedTextBox.Text, estadoCivilComboBox.SelectedItem.ToString(), 
                       dataNascimentoDateTimePicker.Text);
        }

        private string ObterSexo()
        {
            if(masculinoRadioButton.Checked)  
                return masculinoRadioButton.Text.Trim();

            return femininoRadioButton.Text.Trim();
        }

        private void ListarButton_Click(object sender, EventArgs e)
        {
            listaListBox.Items.Clear();

            for (int indice = 0; indice < listaPessoas.QuantidadePessoas(); indice++)
            {
                Pessoa pessoa = listaPessoas.ObterPessoa(indice);

                listaListBox.Items.Add(pessoa.Nome);
                listaListBox.Items.Add(pessoa.Sexo);
                listaListBox.Items.Add(pessoa.Telefone);
                listaListBox.Items.Add(pessoa.EstadoCivil);
                listaListBox.Items.Add(pessoa.DataNascimento);
                listaListBox.Items.Add(DEFAULT_STRING_VAZIA);
            }
        }

        private void LimparCampos()
        {
            nomeTextBox.Text = DEFAULT_STRING_VAZIA;
            telefoneMaskedTextBox.Text = DEFAULT_STRING_VAZIA;
            estadoCivilComboBox.SelectedIndex = 0;
            masculinoRadioButton.Checked = false;
            femininoRadioButton.Checked = false;
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeTextBox.Text))
            {
                MessageBox.Show("Preencha o nome");
                nomeTextBox.Focus();

                return;
            }

            if (listaPessoas.RemoverPessoa(nomeTextBox.Text))
            {
                MessageBox.Show("Pessoa removida");
            }

            else
            {
                MessageBox.Show("Pessoa não encontrada");
            }
        }
    }
}
