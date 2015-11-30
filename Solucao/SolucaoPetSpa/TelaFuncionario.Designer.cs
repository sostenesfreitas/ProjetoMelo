namespace SolucaoPetSpa
{
    partial class TelaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionario));
            this.tabControlFuncionario = new System.Windows.Forms.TabControl();
            this.tabPageCadastrar = new System.Windows.Forms.TabPage();
            this.buttonCadastra = new System.Windows.Forms.Button();
            this.comboBoxFuncao = new System.Windows.Forms.ComboBox();
            this.textBoxSobreNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageAlterarRemover = new System.Windows.Forms.TabPage();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.comboBoxFuncaoF = new System.Windows.Forms.ComboBox();
            this.textBoxSobreNomeF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNomeF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewFuncionario = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlFuncionario.SuspendLayout();
            this.tabPageCadastrar.SuspendLayout();
            this.tabPageAlterarRemover.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFuncionario
            // 
            this.tabControlFuncionario.Controls.Add(this.tabPageCadastrar);
            this.tabControlFuncionario.Controls.Add(this.tabPageAlterarRemover);
            this.tabControlFuncionario.Location = new System.Drawing.Point(39, 194);
            this.tabControlFuncionario.Name = "tabControlFuncionario";
            this.tabControlFuncionario.SelectedIndex = 0;
            this.tabControlFuncionario.Size = new System.Drawing.Size(772, 224);
            this.tabControlFuncionario.TabIndex = 5;
            // 
            // tabPageCadastrar
            // 
            this.tabPageCadastrar.Controls.Add(this.buttonCadastra);
            this.tabPageCadastrar.Controls.Add(this.comboBoxFuncao);
            this.tabPageCadastrar.Controls.Add(this.textBoxSobreNome);
            this.tabPageCadastrar.Controls.Add(this.label2);
            this.tabPageCadastrar.Controls.Add(this.textBoxNome);
            this.tabPageCadastrar.Controls.Add(this.label3);
            this.tabPageCadastrar.Controls.Add(this.label8);
            this.tabPageCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastrar.Name = "tabPageCadastrar";
            this.tabPageCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastrar.Size = new System.Drawing.Size(764, 198);
            this.tabPageCadastrar.TabIndex = 0;
            this.tabPageCadastrar.Text = "Cadastrar";
            this.tabPageCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastra
            // 
            this.buttonCadastra.Location = new System.Drawing.Point(345, 160);
            this.buttonCadastra.Name = "buttonCadastra";
            this.buttonCadastra.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastra.TabIndex = 41;
            this.buttonCadastra.Text = "Cadastrar";
            this.buttonCadastra.UseVisualStyleBackColor = true;
            this.buttonCadastra.Click += new System.EventHandler(this.buttonCadastra_Click);
            // 
            // comboBoxFuncao
            // 
            this.comboBoxFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncao.FormattingEnabled = true;
            this.comboBoxFuncao.Items.AddRange(new object[] {
            "- Escolha -"});
            this.comboBoxFuncao.Location = new System.Drawing.Point(483, 47);
            this.comboBoxFuncao.Name = "comboBoxFuncao";
            this.comboBoxFuncao.Size = new System.Drawing.Size(171, 21);
            this.comboBoxFuncao.TabIndex = 39;
            // 
            // textBoxSobreNome
            // 
            this.textBoxSobreNome.Location = new System.Drawing.Point(152, 122);
            this.textBoxSobreNome.MaxLength = 50;
            this.textBoxSobreNome.Name = "textBoxSobreNome";
            this.textBoxSobreNome.Size = new System.Drawing.Size(502, 20);
            this.textBoxSobreNome.TabIndex = 38;
            this.textBoxSobreNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSobreNome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Função:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(152, 84);
            this.textBoxNome.MaxLength = 50;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(502, 20);
            this.textBoxNome.TabIndex = 35;
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Sobrenome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nome:";
            // 
            // tabPageAlterarRemover
            // 
            this.tabPageAlterarRemover.Controls.Add(this.buttonRemover);
            this.tabPageAlterarRemover.Controls.Add(this.buttonAlterar);
            this.tabPageAlterarRemover.Controls.Add(this.textBoxMatricula);
            this.tabPageAlterarRemover.Controls.Add(this.comboBoxFuncaoF);
            this.tabPageAlterarRemover.Controls.Add(this.textBoxSobreNomeF);
            this.tabPageAlterarRemover.Controls.Add(this.label4);
            this.tabPageAlterarRemover.Controls.Add(this.label5);
            this.tabPageAlterarRemover.Controls.Add(this.textBoxNomeF);
            this.tabPageAlterarRemover.Controls.Add(this.label6);
            this.tabPageAlterarRemover.Controls.Add(this.label7);
            this.tabPageAlterarRemover.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlterarRemover.Name = "tabPageAlterarRemover";
            this.tabPageAlterarRemover.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlterarRemover.Size = new System.Drawing.Size(764, 198);
            this.tabPageAlterarRemover.TabIndex = 1;
            this.tabPageAlterarRemover.Text = "Alterar";
            this.tabPageAlterarRemover.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(381, 159);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 51;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(300, 159);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 50;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(152, 48);
            this.textBoxMatricula.MaxLength = 10;
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(122, 20);
            this.textBoxMatricula.TabIndex = 49;
            this.textBoxMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMatricula_KeyPress);
            // 
            // comboBoxFuncaoF
            // 
            this.comboBoxFuncaoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncaoF.FormattingEnabled = true;
            this.comboBoxFuncaoF.Location = new System.Drawing.Point(483, 47);
            this.comboBoxFuncaoF.Name = "comboBoxFuncaoF";
            this.comboBoxFuncaoF.Size = new System.Drawing.Size(171, 21);
            this.comboBoxFuncaoF.TabIndex = 48;
            // 
            // textBoxSobreNomeF
            // 
            this.textBoxSobreNomeF.Location = new System.Drawing.Point(152, 122);
            this.textBoxSobreNomeF.MaxLength = 50;
            this.textBoxSobreNomeF.Name = "textBoxSobreNomeF";
            this.textBoxSobreNomeF.Size = new System.Drawing.Size(502, 20);
            this.textBoxSobreNomeF.TabIndex = 47;
            this.textBoxSobreNomeF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSobreNomeF_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Matricula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Função:";
            // 
            // textBoxNomeF
            // 
            this.textBoxNomeF.Location = new System.Drawing.Point(152, 84);
            this.textBoxNomeF.MaxLength = 50;
            this.textBoxNomeF.Name = "textBoxNomeF";
            this.textBoxNomeF.Size = new System.Drawing.Size(502, 20);
            this.textBoxNomeF.TabIndex = 44;
            this.textBoxNomeF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomeF_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Sobrenome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Nome:";
            // 
            // listViewFuncionario
            // 
            this.listViewFuncionario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewFuncionario.Location = new System.Drawing.Point(39, 39);
            this.listViewFuncionario.Name = "listViewFuncionario";
            this.listViewFuncionario.Size = new System.Drawing.Size(768, 121);
            this.listViewFuncionario.TabIndex = 4;
            this.listViewFuncionario.UseCompatibleStateImageBehavior = false;
            this.listViewFuncionario.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Matricula";
            this.columnHeader1.Width = 226;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 344;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Função";
            this.columnHeader3.Width = 190;
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 456);
            this.Controls.Add(this.tabControlFuncionario);
            this.Controls.Add(this.listViewFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaFuncionario";
            this.Text = "Cadastro de Funcionario";
            this.tabControlFuncionario.ResumeLayout(false);
            this.tabPageCadastrar.ResumeLayout(false);
            this.tabPageCadastrar.PerformLayout();
            this.tabPageAlterarRemover.ResumeLayout(false);
            this.tabPageAlterarRemover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFuncionario;
        private System.Windows.Forms.TabPage tabPageCadastrar;
        private System.Windows.Forms.Button buttonCadastra;
        private System.Windows.Forms.ComboBox comboBoxFuncao;
        private System.Windows.Forms.TextBox textBoxSobreNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageAlterarRemover;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.ComboBox comboBoxFuncaoF;
        private System.Windows.Forms.TextBox textBoxSobreNomeF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNomeF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewFuncionario;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonRemover;


    }
}