namespace AlbertoContasCorrentes
{
    partial class FormClientes
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.lblRefInterna = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMarcador = new System.Windows.Forms.TextBox();
            this.txtRefInterna = new System.Windows.Forms.TextBox();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.lstFormClientes = new System.Windows.Forms.ListBox();
            this.lblNovoNome = new System.Windows.Forms.Label();
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.btnAlterarNome = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNomeAEliminar = new System.Windows.Forms.Label();
            this.txtNomeAEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminaCliente = new System.Windows.Forms.Button();
            this.lblSeparador2 = new System.Windows.Forms.Label();
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.Location = new System.Drawing.Point(15, 134);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(63, 15);
            this.lblMarcador.TabIndex = 1;
            this.lblMarcador.Text = "Marcador:";
            // 
            // lblRefInterna
            // 
            this.lblRefInterna.AutoSize = true;
            this.lblRefInterna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefInterna.Location = new System.Drawing.Point(143, 134);
            this.lblRefInterna.Name = "lblRefInterna";
            this.lblRefInterna.Size = new System.Drawing.Size(73, 15);
            this.lblRefInterna.TabIndex = 2;
            this.lblRefInterna.Text = "Ref. Interna:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtMarcador
            // 
            this.txtMarcador.Location = new System.Drawing.Point(18, 162);
            this.txtMarcador.Name = "txtMarcador";
            this.txtMarcador.Size = new System.Drawing.Size(60, 20);
            this.txtMarcador.TabIndex = 4;
            // 
            // txtRefInterna
            // 
            this.txtRefInterna.Location = new System.Drawing.Point(146, 162);
            this.txtRefInterna.Name = "txtRefInterna";
            this.txtRefInterna.Size = new System.Drawing.Size(219, 20);
            this.txtRefInterna.TabIndex = 5;
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirCliente.Location = new System.Drawing.Point(375, 119);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(151, 46);
            this.btnInserirCliente.TabIndex = 6;
            this.btnInserirCliente.Text = "Inserir Cliente";
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // lstFormClientes
            // 
            this.lstFormClientes.FormattingEnabled = true;
            this.lstFormClientes.Location = new System.Drawing.Point(531, 26);
            this.lstFormClientes.Name = "lstFormClientes";
            this.lstFormClientes.Size = new System.Drawing.Size(395, 433);
            this.lstFormClientes.TabIndex = 7;
            // 
            // lblNovoNome
            // 
            this.lblNovoNome.AutoSize = true;
            this.lblNovoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoNome.Location = new System.Drawing.Point(12, 220);
            this.lblNovoNome.Name = "lblNovoNome";
            this.lblNovoNome.Size = new System.Drawing.Size(78, 15);
            this.lblNovoNome.TabIndex = 8;
            this.lblNovoNome.Text = "Novo Nome: ";
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Location = new System.Drawing.Point(12, 250);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(353, 20);
            this.txtNovoNome.TabIndex = 9;
            this.txtNovoNome.TextChanged += new System.EventHandler(this.txtNovoNome_TextChanged);
            // 
            // btnAlterarNome
            // 
            this.btnAlterarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarNome.Location = new System.Drawing.Point(374, 247);
            this.btnAlterarNome.Name = "btnAlterarNome";
            this.btnAlterarNome.Size = new System.Drawing.Size(151, 23);
            this.btnAlterarNome.TabIndex = 10;
            this.btnAlterarNome.Text = "Alterar nome";
            this.btnAlterarNome.UseVisualStyleBackColor = true;
            this.btnAlterarNome.Click += new System.EventHandler(this.btnAlterarNome_Click);
            // 
            // lblNomeAEliminar
            // 
            this.lblNomeAEliminar.AutoSize = true;
            this.lblNomeAEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAEliminar.Location = new System.Drawing.Point(12, 321);
            this.lblNomeAEliminar.Name = "lblNomeAEliminar";
            this.lblNomeAEliminar.Size = new System.Drawing.Size(102, 15);
            this.lblNomeAEliminar.TabIndex = 11;
            this.lblNomeAEliminar.Text = "Nome a eliminar:";
            // 
            // txtNomeAEliminar
            // 
            this.txtNomeAEliminar.Location = new System.Drawing.Point(12, 349);
            this.txtNomeAEliminar.Name = "txtNomeAEliminar";
            this.txtNomeAEliminar.Size = new System.Drawing.Size(356, 20);
            this.txtNomeAEliminar.TabIndex = 12;
            this.txtNomeAEliminar.TextChanged += new System.EventHandler(this.txtNomeAEliminar_TextChanged);
            // 
            // btnEliminaCliente
            // 
            this.btnEliminaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaCliente.Location = new System.Drawing.Point(374, 346);
            this.btnEliminaCliente.Name = "btnEliminaCliente";
            this.btnEliminaCliente.Size = new System.Drawing.Size(151, 23);
            this.btnEliminaCliente.TabIndex = 13;
            this.btnEliminaCliente.Text = "Eliminar cliente";
            this.btnEliminaCliente.UseVisualStyleBackColor = true;
            this.btnEliminaCliente.Click += new System.EventHandler(this.btnEliminaCliente_Click);
            // 
            // lblSeparador2
            // 
            this.lblSeparador2.AutoSize = true;
            this.lblSeparador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador2.ForeColor = System.Drawing.Color.Red;
            this.lblSeparador2.Location = new System.Drawing.Point(11, 295);
            this.lblSeparador2.Name = "lblSeparador2";
            this.lblSeparador2.Size = new System.Drawing.Size(514, 15);
            this.lblSeparador2.TabIndex = 14;
            this.lblSeparador2.Text = "Eliminar Cliente____________________________________________________________\r\n";
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.AutoSize = true;
            this.lblSeparador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador1.ForeColor = System.Drawing.Color.Red;
            this.lblSeparador1.Location = new System.Drawing.Point(12, 196);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(509, 15);
            this.lblSeparador1.TabIndex = 15;
            this.lblSeparador1.Text = "Alterar Nome (selecionar na lista o nome  a alterar)_____________________________" +
    "___";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Inserir novo Cliente_________________________________________________________";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeparador1);
            this.Controls.Add(this.lblSeparador2);
            this.Controls.Add(this.btnEliminaCliente);
            this.Controls.Add(this.txtNomeAEliminar);
            this.Controls.Add(this.lblNomeAEliminar);
            this.Controls.Add(this.btnAlterarNome);
            this.Controls.Add(this.txtNovoNome);
            this.Controls.Add(this.lblNovoNome);
            this.Controls.Add(this.lstFormClientes);
            this.Controls.Add(this.btnInserirCliente);
            this.Controls.Add(this.txtRefInterna);
            this.Controls.Add(this.txtMarcador);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblRefInterna);
            this.Controls.Add(this.lblMarcador);
            this.Controls.Add(this.lblNome);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClientes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.Label lblRefInterna;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMarcador;
        private System.Windows.Forms.TextBox txtRefInterna;
        private System.Windows.Forms.Button btnInserirCliente;
        private System.Windows.Forms.ListBox lstFormClientes;
        private System.Windows.Forms.Label lblNovoNome;
        private System.Windows.Forms.TextBox txtNovoNome;
        private System.Windows.Forms.Button btnAlterarNome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNomeAEliminar;
        private System.Windows.Forms.TextBox txtNomeAEliminar;
        private System.Windows.Forms.Button btnEliminaCliente;
        private System.Windows.Forms.Label lblSeparador2;
        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.Label label1;
    }
}