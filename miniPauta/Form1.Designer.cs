namespace miniPauta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPauta = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freguesia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Média = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Negativas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnContarRaparigas = new System.Windows.Forms.Button();
            this.txtTotalNegativas = new System.Windows.Forms.TextBox();
            this.btnContaRapazesMaximinos = new System.Windows.Forms.Button();
            this.txtTotalRapazesMaximinos = new System.Windows.Forms.TextBox();
            this.btnMaisRapazesOuRaparigas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReprovadosComMediaMaiorQue12 = new System.Windows.Forms.Button();
            this.btnEncontra3Melhores = new System.Windows.Forms.Button();
            this.lstTresMelhores = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPauta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPauta
            // 
            this.dgvPauta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPauta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nome,
            this.Freguesia,
            this.Ano,
            this.Sexo,
            this.dom1,
            this.dom2,
            this.dom3,
            this.dom4,
            this.dom5,
            this.dom6,
            this.dom7,
            this.dom8,
            this.dom9,
            this.dom10,
            this.Média,
            this.Negativas});
            this.dgvPauta.Location = new System.Drawing.Point(12, 12);
            this.dgvPauta.Name = "dgvPauta";
            this.dgvPauta.RowTemplate.Height = 25;
            this.dgvPauta.Size = new System.Drawing.Size(1175, 288);
            this.dgvPauta.TabIndex = 0;
            this.dgvPauta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPauta_CellClick);
            this.dgvPauta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPauta_CellValueChanged);
            this.dgvPauta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPauta_CellValueChanged);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "N.";
            this.Numero.Name = "Numero";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            // 
            // Freguesia
            // 
            this.Freguesia.HeaderText = "FREGUESIA";
            this.Freguesia.Name = "Freguesia";
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // dom1
            // 
            this.dom1.HeaderText = "POR";
            this.dom1.Name = "dom1";
            // 
            // dom2
            // 
            this.dom2.HeaderText = "ING";
            this.dom2.Name = "dom2";
            // 
            // dom3
            // 
            this.dom3.HeaderText = "FIL";
            this.dom3.Name = "dom3";
            // 
            // dom4
            // 
            this.dom4.HeaderText = "MAT";
            this.dom4.Name = "dom4";
            // 
            // dom5
            // 
            this.dom5.HeaderText = "FIS";
            this.dom5.Name = "dom5";
            // 
            // dom6
            // 
            this.dom6.HeaderText = "QUI";
            this.dom6.Name = "dom6";
            // 
            // dom7
            // 
            this.dom7.HeaderText = "GEO";
            this.dom7.Name = "dom7";
            // 
            // dom8
            // 
            this.dom8.HeaderText = "HIS";
            this.dom8.Name = "dom8";
            // 
            // dom9
            // 
            this.dom9.HeaderText = "EF";
            this.dom9.Name = "dom9";
            // 
            // dom10
            // 
            this.dom10.HeaderText = "MOR";
            this.dom10.Name = "dom10";
            // 
            // Média
            // 
            this.Média.HeaderText = "Média";
            this.Média.Name = "Média";
            // 
            // Negativas
            // 
            this.Negativas.HeaderText = "Nº Negativas";
            this.Negativas.Name = "Negativas";
            // 
            // btnContarRaparigas
            // 
            this.btnContarRaparigas.Location = new System.Drawing.Point(12, 316);
            this.btnContarRaparigas.Name = "btnContarRaparigas";
            this.btnContarRaparigas.Size = new System.Drawing.Size(161, 29);
            this.btnContarRaparigas.TabIndex = 1;
            this.btnContarRaparigas.Text = "Conta Raparigas";
            this.btnContarRaparigas.UseVisualStyleBackColor = true;
            this.btnContarRaparigas.Click += new System.EventHandler(this.btnContarRaparigas_Click);
            // 
            // txtTotalNegativas
            // 
            this.txtTotalNegativas.Location = new System.Drawing.Point(191, 320);
            this.txtTotalNegativas.Name = "txtTotalNegativas";
            this.txtTotalNegativas.Size = new System.Drawing.Size(100, 23);
            this.txtTotalNegativas.TabIndex = 2;
            // 
            // btnContaRapazesMaximinos
            // 
            this.btnContaRapazesMaximinos.Location = new System.Drawing.Point(308, 318);
            this.btnContaRapazesMaximinos.Name = "btnContaRapazesMaximinos";
            this.btnContaRapazesMaximinos.Size = new System.Drawing.Size(171, 25);
            this.btnContaRapazesMaximinos.TabIndex = 3;
            this.btnContaRapazesMaximinos.Text = "Rapazes de Maximinos";
            this.btnContaRapazesMaximinos.UseVisualStyleBackColor = true;
            this.btnContaRapazesMaximinos.Click += new System.EventHandler(this.btnContaRapazesMaximinos_Click);
            // 
            // txtTotalRapazesMaximinos
            // 
            this.txtTotalRapazesMaximinos.Location = new System.Drawing.Point(485, 320);
            this.txtTotalRapazesMaximinos.Name = "txtTotalRapazesMaximinos";
            this.txtTotalRapazesMaximinos.Size = new System.Drawing.Size(100, 23);
            this.txtTotalRapazesMaximinos.TabIndex = 4;
            // 
            // btnMaisRapazesOuRaparigas
            // 
            this.btnMaisRapazesOuRaparigas.Location = new System.Drawing.Point(600, 316);
            this.btnMaisRapazesOuRaparigas.Name = "btnMaisRapazesOuRaparigas";
            this.btnMaisRapazesOuRaparigas.Size = new System.Drawing.Size(176, 29);
            this.btnMaisRapazesOuRaparigas.TabIndex = 5;
            this.btnMaisRapazesOuRaparigas.Text = "Mais Rapazes ou Raparigas?";
            this.btnMaisRapazesOuRaparigas.UseVisualStyleBackColor = true;
            this.btnMaisRapazesOuRaparigas.Click += new System.EventHandler(this.btnMaisRapazesOuRaparigas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(792, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mais Velho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReprovadosComMediaMaiorQue12
            // 
            this.btnReprovadosComMediaMaiorQue12.Location = new System.Drawing.Point(924, 316);
            this.btnReprovadosComMediaMaiorQue12.Name = "btnReprovadosComMediaMaiorQue12";
            this.btnReprovadosComMediaMaiorQue12.Size = new System.Drawing.Size(263, 27);
            this.btnReprovadosComMediaMaiorQue12.TabIndex = 7;
            this.btnReprovadosComMediaMaiorQue12.Text = "Reprovados c/ média maior que 12";
            this.btnReprovadosComMediaMaiorQue12.UseVisualStyleBackColor = true;
            this.btnReprovadosComMediaMaiorQue12.Click += new System.EventHandler(this.btnReprovadosComMediaMaiorQue12_Click);
            // 
            // btnEncontra3Melhores
            // 
            this.btnEncontra3Melhores.Location = new System.Drawing.Point(12, 375);
            this.btnEncontra3Melhores.Name = "btnEncontra3Melhores";
            this.btnEncontra3Melhores.Size = new System.Drawing.Size(136, 26);
            this.btnEncontra3Melhores.TabIndex = 8;
            this.btnEncontra3Melhores.Text = "Encontra 3 melhores";
            this.btnEncontra3Melhores.UseVisualStyleBackColor = true;
            this.btnEncontra3Melhores.Click += new System.EventHandler(this.btnEncontra3Melhores_Click);
            // 
            // lstTresMelhores
            // 
            this.lstTresMelhores.FormattingEnabled = true;
            this.lstTresMelhores.ItemHeight = 15;
            this.lstTresMelhores.Location = new System.Drawing.Point(154, 375);
            this.lstTresMelhores.Name = "lstTresMelhores";
            this.lstTresMelhores.Size = new System.Drawing.Size(166, 94);
            this.lstTresMelhores.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 561);
            this.Controls.Add(this.lstTresMelhores);
            this.Controls.Add(this.btnEncontra3Melhores);
            this.Controls.Add(this.btnReprovadosComMediaMaiorQue12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMaisRapazesOuRaparigas);
            this.Controls.Add(this.txtTotalRapazesMaximinos);
            this.Controls.Add(this.btnContaRapazesMaximinos);
            this.Controls.Add(this.txtTotalNegativas);
            this.Controls.Add(this.btnContarRaparigas);
            this.Controls.Add(this.dgvPauta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPauta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPauta;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Freguesia;
        private DataGridViewTextBoxColumn Ano;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn dom1;
        private DataGridViewTextBoxColumn dom2;
        private DataGridViewTextBoxColumn dom3;
        private DataGridViewTextBoxColumn dom4;
        private DataGridViewTextBoxColumn dom5;
        private DataGridViewTextBoxColumn dom6;
        private DataGridViewTextBoxColumn dom7;
        private DataGridViewTextBoxColumn dom8;
        private DataGridViewTextBoxColumn dom9;
        private DataGridViewTextBoxColumn dom10;
        private DataGridViewTextBoxColumn Média;
        private DataGridViewTextBoxColumn Negativas;
        private Button btnContarRaparigas;
        private TextBox txtTotalNegativas;
        private Button btnContaRapazesMaximinos;
        private TextBox txtTotalRapazesMaximinos;
        private Button btnMaisRapazesOuRaparigas;
        private Button button1;
        private Button btnReprovadosComMediaMaiorQue12;
        private Button btnEncontra3Melhores;
        private ListBox lstTresMelhores;
    }
}