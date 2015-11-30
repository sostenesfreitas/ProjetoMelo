namespace SolucaoPetSpa
{
    partial class TelaServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaServico));
            this.tabControlServico = new System.Windows.Forms.TabControl();
            this.tabPageCadastra = new System.Windows.Forms.TabPage();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.buttonCadastra = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageAlterarRemover = new System.Windows.Forms.TabPage();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.richTextBoxDescricaoS = new System.Windows.Forms.RichTextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomeS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewServico = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlServico.SuspendLayout();
            this.tabPageCadastra.SuspendLayout();
            this.tabPageAlterarRemover.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlServico
            // 
            this.tabControlServico.Controls.Add(this.tabPageCadastra);
            this.tabControlServico.Controls.Add(this.tabPageAlterarRemover);
            this.tabControlServico.Location = new System.Drawing.Point(39, 194);
            this.tabControlServico.Name = "tabControlServico";
            this.tabControlServico.SelectedIndex = 0;
            this.tabControlServico.Size = new System.Drawing.Size(772, 224);
            this.tabControlServico.TabIndex = 7;
            // 
            // tabPageCadastra
            // 
            this.tabPageCadastra.Controls.Add(this.richTextBoxDescricao);
            this.tabPageCadastra.Controls.Add(this.buttonCadastra);
            this.tabPageCadastra.Controls.Add(this.textBoxNome);
            this.tabPageCadastra.Controls.Add(this.label2);
            this.tabPageCadastra.Controls.Add(this.label3);
            this.tabPageCadastra.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastra.Name = "tabPageCadastra";
            this.tabPageCadastra.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastra.Size = new System.Drawing.Size(764, 198);
            this.tabPageCadastra.TabIndex = 0;
            this.tabPageCadastra.Text = "Cadastrar";
            this.tabPageCadastra.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(130, 96);
            this.richTextBoxDescricao.MaxLength = 300;
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(502, 67);
            this.richTextBoxDescricao.TabIndex = 65;
            this.richTextBoxDescricao.Text = "";
            // 
            // buttonCadastra
            // 
            this.buttonCadastra.Location = new System.Drawing.Point(342, 169);
            this.buttonCadastra.Name = "buttonCadastra";
            this.buttonCadastra.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastra.TabIndex = 64;
            this.buttonCadastra.Text = "Cadastrar";
            this.buttonCadastra.UseVisualStyleBackColor = true;
            this.buttonCadastra.Click += new System.EventHandler(this.buttonCadastra_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(130, 58);
            this.textBoxNome.MaxLength = 60;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(502, 20);
            this.textBoxNome.TabIndex = 61;
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Nome:";
            // 
            // tabPageAlterarRemover
            // 
            this.tabPageAlterarRemover.Controls.Add(this.buttonRemover);
            this.tabPageAlterarRemover.Controls.Add(this.richTextBoxDescricaoS);
            this.tabPageAlterarRemover.Controls.Add(this.buttonAlterar);
            this.tabPageAlterarRemover.Controls.Add(this.textBoxCodigo);
            this.tabPageAlterarRemover.Controls.Add(this.label4);
            this.tabPageAlterarRemover.Controls.Add(this.textBoxNomeS);
            this.tabPageAlterarRemover.Controls.Add(this.label6);
            this.tabPageAlterarRemover.Controls.Add(this.label7);
            this.tabPageAlterarRemover.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlterarRemover.Name = "tabPageAlterarRemover";
            this.tabPageAlterarRemover.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlterarRemover.Size = new System.Drawing.Size(764, 198);
            this.tabPageAlterarRemover.TabIndex = 1;
            this.tabPageAlterarRemover.Text = "Alterar - Remover";
            this.tabPageAlterarRemover.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(383, 169);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 59;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // richTextBoxDescricaoS
            // 
            this.richTextBoxDescricaoS.Location = new System.Drawing.Point(130, 96);
            this.richTextBoxDescricaoS.MaxLength = 300;
            this.richTextBoxDescricaoS.Name = "richTextBoxDescricaoS";
            this.richTextBoxDescricaoS.Size = new System.Drawing.Size(502, 67);
            this.richTextBoxDescricaoS.TabIndex = 58;
            this.richTextBoxDescricaoS.Text = "";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(302, 169);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 57;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(510, 22);
            this.textBoxCodigo.MaxLength = 10;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(122, 20);
            this.textBoxCodigo.TabIndex = 56;
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Codigo:";
            // 
            // textBoxNomeS
            // 
            this.textBoxNomeS.Location = new System.Drawing.Point(130, 58);
            this.textBoxNomeS.MaxLength = 60;
            this.textBoxNomeS.Name = "textBoxNomeS";
            this.textBoxNomeS.Size = new System.Drawing.Size(502, 20);
            this.textBoxNomeS.TabIndex = 54;
            this.textBoxNomeS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomeA_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Nome:";
            // 
            // listViewServico
            // 
            this.listViewServico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Nome,
            this.Descricao});
            this.listViewServico.Location = new System.Drawing.Point(39, 39);
            this.listViewServico.Name = "listViewServico";
            this.listViewServico.Size = new System.Drawing.Size(768, 121);
            this.listViewServico.TabIndex = 6;
            this.listViewServico.UseCompatibleStateImageBehavior = false;
            this.listViewServico.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 179;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 346;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            this.Descricao.Width = 234;
            // 
            // TelaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 456);
            this.Controls.Add(this.tabControlServico);
            this.Controls.Add(this.listViewServico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaServico";
            this.Text = "Cadastro de Serviço";
            this.tabControlServico.ResumeLayout(false);
            this.tabPageCadastra.ResumeLayout(false);
            this.tabPageCadastra.PerformLayout();
            this.tabPageAlterarRemover.ResumeLayout(false);
            this.tabPageAlterarRemover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlServico;
        private System.Windows.Forms.TabPage tabPageCadastra;
        private System.Windows.Forms.TabPage tabPageAlterarRemover;
        private System.Windows.Forms.ListView listViewServico;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Button buttonCadastra;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxDescricaoS;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomeS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.Button buttonRemover;




    }
}