namespace SistemaCadastro
{
    partial class SistemaCadastroGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomeLabel = new System.Windows.Forms.Label();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.estadoCivilLabel = new System.Windows.Forms.Label();
            this.dataNascimentoLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.estadoCivilComboBox = new System.Windows.Forms.ComboBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.masculinoRadioButton = new System.Windows.Forms.RadioButton();
            this.femininoRadioButton = new System.Windows.Forms.RadioButton();
            this.CadastrarAlterarButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.ListarButton = new System.Windows.Forms.Button();
            this.listaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(19, 34);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(64, 25);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneLabel.Location = new System.Drawing.Point(19, 140);
            this.telefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(89, 25);
            this.telefoneLabel.TabIndex = 1;
            this.telefoneLabel.Text = "Telefone";
            // 
            // estadoCivilLabel
            // 
            this.estadoCivilLabel.AutoSize = true;
            this.estadoCivilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivilLabel.Location = new System.Drawing.Point(19, 193);
            this.estadoCivilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estadoCivilLabel.Name = "estadoCivilLabel";
            this.estadoCivilLabel.Size = new System.Drawing.Size(115, 25);
            this.estadoCivilLabel.TabIndex = 2;
            this.estadoCivilLabel.Text = "Estado Civil";
            // 
            // dataNascimentoLabel
            // 
            this.dataNascimentoLabel.AutoSize = true;
            this.dataNascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimentoLabel.Location = new System.Drawing.Point(19, 246);
            this.dataNascimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataNascimentoLabel.Name = "dataNascimentoLabel";
            this.dataNascimentoLabel.Size = new System.Drawing.Size(188, 25);
            this.dataNascimentoLabel.TabIndex = 3;
            this.dataNascimentoLabel.Text = "Data de Nascimento";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(227, 31);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(532, 30);
            this.nomeTextBox.TabIndex = 4;
            // 
            // estadoCivilComboBox
            // 
            this.estadoCivilComboBox.DisplayMember = "1";
            this.estadoCivilComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivilComboBox.FormattingEnabled = true;
            this.estadoCivilComboBox.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado"});
            this.estadoCivilComboBox.Location = new System.Drawing.Point(227, 187);
            this.estadoCivilComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoCivilComboBox.Name = "estadoCivilComboBox";
            this.estadoCivilComboBox.Size = new System.Drawing.Size(305, 33);
            this.estadoCivilComboBox.TabIndex = 6;
            this.estadoCivilComboBox.Text = "-- Selecione um item --";
            this.estadoCivilComboBox.ValueMember = "0";
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.CustomFormat = "";
            this.dataNascimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(227, 246);
            this.dataNascimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataNascimentoDateTimePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dataNascimentoDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(532, 30);
            this.dataNascimentoDateTimePicker.TabIndex = 10;
            this.dataNascimentoDateTimePicker.Value = new System.DateTime(2022, 8, 15, 0, 0, 0, 0);
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(227, 131);
            this.telefoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telefoneMaskedTextBox.Mask = "(99) 00000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(305, 30);
            this.telefoneMaskedTextBox.TabIndex = 11;
            // 
            // sexoLabel
            // 
            this.sexoLabel.AutoSize = true;
            this.sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoLabel.Location = new System.Drawing.Point(19, 87);
            this.sexoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(58, 25);
            this.sexoLabel.TabIndex = 7;
            this.sexoLabel.Text = "Sexo";
            // 
            // masculinoRadioButton
            // 
            this.masculinoRadioButton.AutoSize = true;
            this.masculinoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masculinoRadioButton.Location = new System.Drawing.Point(227, 85);
            this.masculinoRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.masculinoRadioButton.Name = "masculinoRadioButton";
            this.masculinoRadioButton.Size = new System.Drawing.Size(122, 29);
            this.masculinoRadioButton.TabIndex = 12;
            this.masculinoRadioButton.TabStop = true;
            this.masculinoRadioButton.Text = "Masculino";
            this.masculinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // femininoRadioButton
            // 
            this.femininoRadioButton.AutoSize = true;
            this.femininoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femininoRadioButton.Location = new System.Drawing.Point(370, 85);
            this.femininoRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.femininoRadioButton.Name = "femininoRadioButton";
            this.femininoRadioButton.Size = new System.Drawing.Size(113, 29);
            this.femininoRadioButton.TabIndex = 13;
            this.femininoRadioButton.TabStop = true;
            this.femininoRadioButton.Text = "Feminino";
            this.femininoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CadastrarAlterarButton
            // 
            this.CadastrarAlterarButton.Location = new System.Drawing.Point(19, 392);
            this.CadastrarAlterarButton.Name = "CadastrarAlterarButton";
            this.CadastrarAlterarButton.Size = new System.Drawing.Size(218, 70);
            this.CadastrarAlterarButton.TabIndex = 14;
            this.CadastrarAlterarButton.Text = "Cadastrar / Alterar";
            this.CadastrarAlterarButton.UseVisualStyleBackColor = true;
            this.CadastrarAlterarButton.Click += new System.EventHandler(this.CadastrarAlterarButton_Click);
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(280, 392);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(218, 70);
            this.ExcluirButton.TabIndex = 15;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // ListarButton
            // 
            this.ListarButton.Location = new System.Drawing.Point(541, 392);
            this.ListarButton.Name = "ListarButton";
            this.ListarButton.Size = new System.Drawing.Size(218, 70);
            this.ListarButton.TabIndex = 16;
            this.ListarButton.Text = "Listar";
            this.ListarButton.UseVisualStyleBackColor = true;
            this.ListarButton.Click += new System.EventHandler(this.ListarButton_Click);
            // 
            // listaListBox
            // 
            this.listaListBox.FormattingEnabled = true;
            this.listaListBox.ItemHeight = 22;
            this.listaListBox.Location = new System.Drawing.Point(19, 508);
            this.listaListBox.Name = "listaListBox";
            this.listaListBox.Size = new System.Drawing.Size(740, 202);
            this.listaListBox.TabIndex = 17;
            // 
            // SistemaCadastroGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 730);
            this.Controls.Add(this.listaListBox);
            this.Controls.Add(this.ListarButton);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.CadastrarAlterarButton);
            this.Controls.Add(this.femininoRadioButton);
            this.Controls.Add(this.masculinoRadioButton);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(this.sexoLabel);
            this.Controls.Add(this.estadoCivilComboBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.dataNascimentoLabel);
            this.Controls.Add(this.estadoCivilLabel);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.nomeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SistemaCadastroGUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.Label estadoCivilLabel;
        private System.Windows.Forms.Label dataNascimentoLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox estadoCivilComboBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.RadioButton masculinoRadioButton;
        private System.Windows.Forms.RadioButton femininoRadioButton;
        private System.Windows.Forms.Button CadastrarAlterarButton;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.Button ListarButton;
        private System.Windows.Forms.ListBox listaListBox;
    }
}

