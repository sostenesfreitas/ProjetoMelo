namespace SolucaoPetSpa
{
    partial class TelaRaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRaca));
            this.tabControlRaca = new System.Windows.Forms.TabControl();
            this.tabPageCadastra = new System.Windows.Forms.TabPage();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.buttonCadastra = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageAlterarRemover = new System.Windows.Forms.TabPage();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.comboBoxTipoR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxDescricaoR = new System.Windows.Forms.RichTextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomeR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewRaca = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlRaca.SuspendLayout();
            this.tabPageCadastra.SuspendLayout();
            this.tabPageAlterarRemover.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRaca
            // 
            this.tabControlRaca.Controls.Add(this.tabPageCadastra);
            this.tabControlRaca.Controls.Add(this.tabPageAlterarRemover);
            this.tabControlRaca.Location = new System.Drawing.Point(39, 194);
            this.tabControlRaca.Name = "tabControlRaca";
            this.tabControlRaca.SelectedIndex = 0;
            this.tabControlRaca.Size = new System.Drawing.Size(772, 224);
            this.tabControlRaca.TabIndex = 9;
            // 
            // tabPageCadastra
            // 
            this.tabPageCadastra.Controls.Add(this.comboBoxTipo);
            this.tabPageCadastra.Controls.Add(this.label1);
            this.tabPageCadastra.Controls.Add(this.richTextBoxDescricao);
            this.tabPageCadastra.Controls.Add(this.buttonCadastra);
            this.tabPageCadastra.Controls.Add(this.textBoxNome);
            this.tabPageCadastra.Controls.Add(this.label3);
            this.tabPageCadastra.Controls.Add(this.label8);
            this.tabPageCadastra.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastra.Name = "tabPageCadastra";
            this.tabPageCadastra.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastra.Size = new System.Drawing.Size(764, 198);
            this.tabPageCadastra.TabIndex = 0;
            this.tabPageCadastra.Text = "Cadastrar";
            this.tabPageCadastra.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(513, 23);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Tipo:";
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(132, 96);
            this.richTextBoxDescricao.MaxLength = 300;
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(502, 67);
            this.richTextBoxDescricao.TabIndex = 85;
            this.richTextBoxDescricao.Text = "";
            // 
            // buttonCadastra
            // 
            this.buttonCadastra.Location = new System.Drawing.Point(344, 169);
            this.buttonCadastra.Name = "buttonCadastra";
            this.buttonCadastra.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastra.TabIndex = 84;
            this.buttonCadastra.Text = "Cadastrar";
            this.buttonCadastra.UseVisualStyleBackColor = true;
            this.buttonCadastra.Click += new System.EventHandler(this.buttonCadastra_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(132, 58);
            this.textBoxNome.MaxLength = 60;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(502, 20);
            this.textBoxNome.TabIndex = 81;
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Descrição:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Nome:";
            // 
            // tabPageAlterarRemover
            // 
            this.tabPageAlterarRemover.Controls.Add(this.buttonRemover);
            this.tabPageAlterarRemover.Controls.Add(this.comboBoxTipoR);
            this.tabPageAlterarRemover.Controls.Add(this.label5);
            this.tabPageAlterarRemover.Controls.Add(this.richTextBoxDescricaoR);
            this.tabPageAlterarRemover.Controls.Add(this.buttonAlterar);
            this.tabPageAlterarRemover.Controls.Add(this.textBoxCodigo);
            this.tabPageAlterarRemover.Controls.Add(this.label4);
            this.tabPageAlterarRemover.Controls.Add(this.textBoxNomeR);
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
            this.buttonRemover.Location = new System.Drawing.Point(383, 169);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 79;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // comboBoxTipoR
            // 
            this.comboBoxTipoR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoR.FormattingEnabled = true;
            this.comboBoxTipoR.Location = new System.Drawing.Point(513, 23);
            this.comboBoxTipoR.Name = "comboBoxTipoR";
            this.comboBoxTipoR.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoR.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tipo:";
            // 
            // richTextBoxDescricaoR
            // 
            this.richTextBoxDescricaoR.Location = new System.Drawing.Point(132, 96);
            this.richTextBoxDescricaoR.MaxLength = 300;
            this.richTextBoxDescricaoR.Name = "richTextBoxDescricaoR";
            this.richTextBoxDescricaoR.Size = new System.Drawing.Size(502, 67);
            this.richTextBoxDescricaoR.TabIndex = 76;
            this.richTextBoxDescricaoR.Text = "";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(302, 169);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 75;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(132, 23);
            this.textBoxCodigo.MaxLength = 10;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(122, 20);
            this.textBoxCodigo.TabIndex = 74;
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Codigo:";
            // 
            // textBoxNomeR
            // 
            this.textBoxNomeR.Location = new System.Drawing.Point(132, 58);
            this.textBoxNomeR.MaxLength = 60;
            this.textBoxNomeR.Name = "textBoxNomeR";
            this.textBoxNomeR.Size = new System.Drawing.Size(502, 20);
            this.textBoxNomeR.TabIndex = 72;
            this.textBoxNomeR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomeA_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Nome:";
            // 
            // listViewRaca
            // 
            this.listViewRaca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Tipo,
            this.Nome,
            this.Descricao});
            this.listViewRaca.Location = new System.Drawing.Point(39, 39);
            this.listViewRaca.Name = "listViewRaca";
            this.listViewRaca.Size = new System.Drawing.Size(768, 121);
            this.listViewRaca.TabIndex = 8;
            this.listViewRaca.UseCompatibleStateImageBehavior = false;
            this.listViewRaca.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 114;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 141;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 214;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            this.Descricao.Width = 294;
            // 
            // TelaRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 456);
            this.Controls.Add(this.tabControlRaca);
            this.Controls.Add(this.listViewRaca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRaca";
            this.Text = "Cadastro de Raça";
            this.tabControlRaca.ResumeLayout(false);
            this.tabPageCadastra.ResumeLayout(false);
            this.tabPageCadastra.PerformLayout();
            this.tabPageAlterarRemover.ResumeLayout(false);
            this.tabPageAlterarRemover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRaca;
        private System.Windows.Forms.TabPage tabPageCadastra;
        private System.Windows.Forms.TabPage tabPageAlterarRemover;
        private System.Windows.Forms.ListView listViewRaca;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Button buttonCadastra;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTipoR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxDescricaoR;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomeR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.Button buttonRemover;
    }
}