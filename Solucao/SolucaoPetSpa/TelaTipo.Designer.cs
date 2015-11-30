namespace SolucaoPetSpa
{
    partial class TelaTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTipo));
            this.tabControlRaca = new System.Windows.Forms.TabControl();
            this.tabPageCadastra = new System.Windows.Forms.TabPage();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCadastra = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewTipo = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlRaca.SuspendLayout();
            this.tabPageCadastra.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRaca
            // 
            this.tabControlRaca.Controls.Add(this.tabPageCadastra);
            this.tabControlRaca.Location = new System.Drawing.Point(39, 194);
            this.tabControlRaca.Name = "tabControlRaca";
            this.tabControlRaca.SelectedIndex = 0;
            this.tabControlRaca.Size = new System.Drawing.Size(772, 224);
            this.tabControlRaca.TabIndex = 11;
            // 
            // tabPageCadastra
            // 
            this.tabPageCadastra.Controls.Add(this.textBoxCodigo);
            this.tabPageCadastra.Controls.Add(this.label4);
            this.tabPageCadastra.Controls.Add(this.button1);
            this.tabPageCadastra.Controls.Add(this.button2);
            this.tabPageCadastra.Controls.Add(this.buttonCadastra);
            this.tabPageCadastra.Controls.Add(this.textBoxNome);
            this.tabPageCadastra.Controls.Add(this.label8);
            this.tabPageCadastra.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastra.Name = "tabPageCadastra";
            this.tabPageCadastra.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastra.Size = new System.Drawing.Size(764, 198);
            this.tabPageCadastra.TabIndex = 0;
            this.tabPageCadastra.Text = "Cadastrar";
            this.tabPageCadastra.UseVisualStyleBackColor = true;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(132, 87);
            this.textBoxCodigo.MaxLength = 10;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(122, 20);
            this.textBoxCodigo.TabIndex = 89;
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Codigo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 86;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCadastra
            // 
            this.buttonCadastra.Location = new System.Drawing.Point(304, 155);
            this.buttonCadastra.Name = "buttonCadastra";
            this.buttonCadastra.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastra.TabIndex = 84;
            this.buttonCadastra.Text = "Cadastrar";
            this.buttonCadastra.UseVisualStyleBackColor = true;
            this.buttonCadastra.Click += new System.EventHandler(this.buttonCadastra_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(132, 113);
            this.textBoxNome.MaxLength = 60;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(502, 20);
            this.textBoxNome.TabIndex = 81;
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Nome:";
            // 
            // listViewTipo
            // 
            this.listViewTipo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Nome});
            this.listViewTipo.Location = new System.Drawing.Point(39, 39);
            this.listViewTipo.Name = "listViewTipo";
            this.listViewTipo.Size = new System.Drawing.Size(768, 121);
            this.listViewTipo.TabIndex = 10;
            this.listViewTipo.UseCompatibleStateImageBehavior = false;
            this.listViewTipo.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 138;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 214;
            // 
            // TelaTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 456);
            this.Controls.Add(this.tabControlRaca);
            this.Controls.Add(this.listViewTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaTipo";
            this.Text = "Cadastro de Tipo";
            this.tabControlRaca.ResumeLayout(false);
            this.tabPageCadastra.ResumeLayout(false);
            this.tabPageCadastra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRaca;
        private System.Windows.Forms.TabPage tabPageCadastra;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCadastra;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewTipo;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Nome;
    }
}