namespace SolucaoPetSpa
{
    partial class Agendamento
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
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.listViewAnimal = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CPF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxServico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.OkCPF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEncaixe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(483, 270);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 76;
            // 
            // listViewAnimal
            // 
            this.listViewAnimal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.Status,
            this.columnHeader7});
            this.listViewAnimal.Location = new System.Drawing.Point(288, 24);
            this.listViewAnimal.Name = "listViewAnimal";
            this.listViewAnimal.Size = new System.Drawing.Size(749, 231);
            this.listViewAnimal.TabIndex = 75;
            this.listViewAnimal.UseCompatibleStateImageBehavior = false;
            this.listViewAnimal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CodigoAgenda";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NomeAnimal";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NomeCliente";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NomeServico";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            this.columnHeader5.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hora";
            this.columnHeader6.Width = 74;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 98;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Encaixe";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(769, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 35);
            this.button3.TabIndex = 74;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 35);
            this.button2.TabIndex = 73;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CPF
            // 
            this.CPF.FormattingEnabled = true;
            this.CPF.Location = new System.Drawing.Point(13, 36);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(121, 21);
            this.CPF.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 148);
            this.button1.TabIndex = 69;
            this.button1.Text = "GerarAgendamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxServico
            // 
            this.comboBoxServico.FormattingEnabled = true;
            this.comboBoxServico.Location = new System.Drawing.Point(17, 115);
            this.comboBoxServico.Name = "comboBoxServico";
            this.comboBoxServico.Size = new System.Drawing.Size(198, 21);
            this.comboBoxServico.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Serviços:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Animal:";
            // 
            // comboBoxAnimal
            // 
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Location = new System.Drawing.Point(17, 75);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(198, 21);
            this.comboBoxAnimal.TabIndex = 63;
            // 
            // OkCPF
            // 
            this.OkCPF.Location = new System.Drawing.Point(140, 36);
            this.OkCPF.Name = "OkCPF";
            this.OkCPF.Size = new System.Drawing.Size(75, 23);
            this.OkCPF.TabIndex = 62;
            this.OkCPF.Text = "&Ok";
            this.OkCPF.UseVisualStyleBackColor = true;
            this.OkCPF.Click += new System.EventHandler(this.OkCPF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "CPF do dono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "CodigoAgenda  :";
            // 
            // comboBoxEncaixe
            // 
            this.comboBoxEncaixe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncaixe.FormattingEnabled = true;
            this.comboBoxEncaixe.Location = new System.Drawing.Point(13, 239);
            this.comboBoxEncaixe.Name = "comboBoxEncaixe";
            this.comboBoxEncaixe.Size = new System.Drawing.Size(105, 21);
            this.comboBoxEncaixe.TabIndex = 78;
            this.comboBoxEncaixe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Encaixe";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(17, 157);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 82;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(13, 200);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 83;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 298);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxEncaixe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.listViewAnimal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxServico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAnimal);
            this.Controls.Add(this.OkCPF);
            this.Controls.Add(this.label1);
            this.Name = "Agendamento";
            this.Text = "Agendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.ListView listViewAnimal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.Button OkCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ComboBox comboBoxEncaixe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;

    }
}