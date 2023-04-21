namespace AlbertoContasCorrentes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.dgvMovimentos = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblListagemClientes = new System.Windows.Forms.Label();
            this.lblSeparadorNovoMovimento = new System.Windows.Forms.Label();
            this.lblEscolheData = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValorDebitar = new System.Windows.Forms.Label();
            this.lblValorCreditar = new System.Windows.Forms.Label();
            this.dtpMovimentos = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValorDebitar = new System.Windows.Forms.TextBox();
            this.txtValorCreditar = new System.Windows.Forms.TextBox();
            this.btnEnviarParaBD = new System.Windows.Forms.Button();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.inserirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recolonizarTabelaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recolonizarTabelaClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirMovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMovimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarMovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEntreDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recolonizarTabelaMovimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblListagemMovimentos = new System.Windows.Forms.Label();
            this.btnListarEntreDatas = new System.Windows.Forms.Button();
            this.btnListarMesCorrente = new System.Windows.Forms.Button();
            this.btnListaMovimentosClienteMesCorrente = new System.Windows.Forms.Button();
            this.iMPRESSOESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFiltro.Location = new System.Drawing.Point(15, 65);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(311, 23);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(15, 133);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(311, 316);
            this.lstClientes.TabIndex = 5;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // dgvMovimentos
            // 
            this.dgvMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimentos.Location = new System.Drawing.Point(377, 65);
            this.dgvMovimentos.Name = "dgvMovimentos";
            this.dgvMovimentos.Size = new System.Drawing.Size(882, 384);
            this.dgvMovimentos.TabIndex = 6;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFiltro.Location = new System.Drawing.Point(12, 45);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(169, 17);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Digite o nome a procurar:";
            // 
            // lblListagemClientes
            // 
            this.lblListagemClientes.AutoSize = true;
            this.lblListagemClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagemClientes.Location = new System.Drawing.Point(12, 101);
            this.lblListagemClientes.Name = "lblListagemClientes";
            this.lblListagemClientes.Size = new System.Drawing.Size(116, 16);
            this.lblListagemClientes.TabIndex = 8;
            this.lblListagemClientes.Text = "Listagem Clientes:";
            // 
            // lblSeparadorNovoMovimento
            // 
            this.lblSeparadorNovoMovimento.AutoSize = true;
            this.lblSeparadorNovoMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparadorNovoMovimento.ForeColor = System.Drawing.Color.Red;
            this.lblSeparadorNovoMovimento.Location = new System.Drawing.Point(12, 466);
            this.lblSeparadorNovoMovimento.Name = "lblSeparadorNovoMovimento";
            this.lblSeparadorNovoMovimento.Size = new System.Drawing.Size(1272, 26);
            this.lblSeparadorNovoMovimento.TabIndex = 10;
            this.lblSeparadorNovoMovimento.Text = resources.GetString("lblSeparadorNovoMovimento.Text");
            // 
            // lblEscolheData
            // 
            this.lblEscolheData.AutoSize = true;
            this.lblEscolheData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolheData.ForeColor = System.Drawing.Color.Red;
            this.lblEscolheData.Location = new System.Drawing.Point(12, 492);
            this.lblEscolheData.Name = "lblEscolheData";
            this.lblEscolheData.Size = new System.Drawing.Size(194, 15);
            this.lblEscolheData.TabIndex = 11;
            this.lblEscolheData.Text = "Clicar, caso não seja a data do dia";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Red;
            this.lblDescricao.Location = new System.Drawing.Point(251, 492);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(241, 15);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Descrição: (sem limite de nº de caracteres)";
            // 
            // lblValorDebitar
            // 
            this.lblValorDebitar.AutoSize = true;
            this.lblValorDebitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDebitar.ForeColor = System.Drawing.Color.Red;
            this.lblValorDebitar.Location = new System.Drawing.Point(701, 494);
            this.lblValorDebitar.Name = "lblValorDebitar";
            this.lblValorDebitar.Size = new System.Drawing.Size(86, 15);
            this.lblValorDebitar.TabIndex = 13;
            this.lblValorDebitar.Text = "Valor a debitar";
            // 
            // lblValorCreditar
            // 
            this.lblValorCreditar.AutoSize = true;
            this.lblValorCreditar.ForeColor = System.Drawing.Color.Red;
            this.lblValorCreditar.Location = new System.Drawing.Point(881, 494);
            this.lblValorCreditar.Name = "lblValorCreditar";
            this.lblValorCreditar.Size = new System.Drawing.Size(78, 13);
            this.lblValorCreditar.TabIndex = 14;
            this.lblValorCreditar.Text = "Valor a creditar";
            // 
            // dtpMovimentos
            // 
            this.dtpMovimentos.Location = new System.Drawing.Point(15, 520);
            this.dtpMovimentos.Name = "dtpMovimentos";
            this.dtpMovimentos.Size = new System.Drawing.Size(200, 20);
            this.dtpMovimentos.TabIndex = 15;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(254, 520);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(404, 20);
            this.txtDescricao.TabIndex = 16;
            // 
            // txtValorDebitar
            // 
            this.txtValorDebitar.Location = new System.Drawing.Point(704, 520);
            this.txtValorDebitar.Name = "txtValorDebitar";
            this.txtValorDebitar.Size = new System.Drawing.Size(124, 20);
            this.txtValorDebitar.TabIndex = 17;
            this.txtValorDebitar.TextChanged += new System.EventHandler(this.txtValorDebitar_TextChanged);
            // 
            // txtValorCreditar
            // 
            this.txtValorCreditar.Location = new System.Drawing.Point(884, 520);
            this.txtValorCreditar.Name = "txtValorCreditar";
            this.txtValorCreditar.Size = new System.Drawing.Size(112, 20);
            this.txtValorCreditar.TabIndex = 18;
            this.txtValorCreditar.TextChanged += new System.EventHandler(this.txtValorCreditar_TextChanged);
            // 
            // btnEnviarParaBD
            // 
            this.btnEnviarParaBD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnviarParaBD.Location = new System.Drawing.Point(1060, 492);
            this.btnEnviarParaBD.Name = "btnEnviarParaBD";
            this.btnEnviarParaBD.Size = new System.Drawing.Size(127, 48);
            this.btnEnviarParaBD.TabIndex = 19;
            this.btnEnviarParaBD.Text = "Enviar para a base de dados";
            this.btnEnviarParaBD.UseVisualStyleBackColor = false;
            this.btnEnviarParaBD.Click += new System.EventHandler(this.btnEnviarParaBD_Click);
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Location = new System.Drawing.Point(373, 18);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(0, 24);
            this.lblInformacao.TabIndex = 21;
            // 
            // inserirClienteToolStripMenuItem
            // 
            this.inserirClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarClientesToolStripMenuItem,
            this.alterarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem,
            this.recolonizarTabelaClientesToolStripMenuItem,
            this.recolonizarTabelaClientesToolStripMenuItem1});
            this.inserirClienteToolStripMenuItem.Name = "inserirClienteToolStripMenuItem";
            this.inserirClienteToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inserirClienteToolStripMenuItem.Text = "CLIENTES";
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.listarClientesToolStripMenuItem.Text = "Inserir Cliente";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.inserirClientesToolStripMenuItem_Click);
            // 
            // alterarClienteToolStripMenuItem
            // 
            this.alterarClienteToolStripMenuItem.Name = "alterarClienteToolStripMenuItem";
            this.alterarClienteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.alterarClienteToolStripMenuItem.Text = "Listar Clientes";
            this.alterarClienteToolStripMenuItem.Click += new System.EventHandler(this.listarClienteToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Alterar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.alterarClienteToolStripMenuItem_Click);
            // 
            // recolonizarTabelaClientesToolStripMenuItem
            // 
            this.recolonizarTabelaClientesToolStripMenuItem.Name = "recolonizarTabelaClientesToolStripMenuItem";
            this.recolonizarTabelaClientesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.recolonizarTabelaClientesToolStripMenuItem.Text = "Eliminar Cliente";
            this.recolonizarTabelaClientesToolStripMenuItem.Click += new System.EventHandler(this.eliminarClientesToolStripMenuItem_Click);
            // 
            // recolonizarTabelaClientesToolStripMenuItem1
            // 
            this.recolonizarTabelaClientesToolStripMenuItem1.Name = "recolonizarTabelaClientesToolStripMenuItem1";
            this.recolonizarTabelaClientesToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.recolonizarTabelaClientesToolStripMenuItem1.Text = "Recolonizar tabela Clientes";
            this.recolonizarTabelaClientesToolStripMenuItem1.Click += new System.EventHandler(this.recolonizarTabelaClientesToolStripMenuItem1_Click);
            // 
            // mOVIMENTOSToolStripMenuItem
            // 
            this.mOVIMENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirMovimentoToolStripMenuItem,
            this.listarMovimentosToolStripMenuItem,
            this.alterarMovimentoToolStripMenuItem,
            this.eliminarMovimentoToolStripMenuItem,
            this.eliminarEntreDatasToolStripMenuItem,
            this.recolonizarTabelaMovimentosToolStripMenuItem});
            this.mOVIMENTOSToolStripMenuItem.Name = "mOVIMENTOSToolStripMenuItem";
            this.mOVIMENTOSToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mOVIMENTOSToolStripMenuItem.Text = "MOVIMENTOS";
            // 
            // inserirMovimentoToolStripMenuItem
            // 
            this.inserirMovimentoToolStripMenuItem.Name = "inserirMovimentoToolStripMenuItem";
            this.inserirMovimentoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.inserirMovimentoToolStripMenuItem.Text = "Inserir Movimento";
            this.inserirMovimentoToolStripMenuItem.Click += new System.EventHandler(this.inserirMovimentoToolStripMenuItem_Click);
            // 
            // listarMovimentosToolStripMenuItem
            // 
            this.listarMovimentosToolStripMenuItem.Name = "listarMovimentosToolStripMenuItem";
            this.listarMovimentosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.listarMovimentosToolStripMenuItem.Text = "Listar todos os Movimentos";
            this.listarMovimentosToolStripMenuItem.Click += new System.EventHandler(this.listarMovimentosToolStripMenuItem_Click);
            // 
            // alterarMovimentoToolStripMenuItem
            // 
            this.alterarMovimentoToolStripMenuItem.Name = "alterarMovimentoToolStripMenuItem";
            this.alterarMovimentoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.alterarMovimentoToolStripMenuItem.Text = "Alterar Movimento";
            this.alterarMovimentoToolStripMenuItem.Click += new System.EventHandler(this.alterarMovimentoToolStripMenuItem_Click);
            // 
            // eliminarMovimentoToolStripMenuItem
            // 
            this.eliminarMovimentoToolStripMenuItem.Name = "eliminarMovimentoToolStripMenuItem";
            this.eliminarMovimentoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.eliminarMovimentoToolStripMenuItem.Text = "Eliminar Movimento";
            this.eliminarMovimentoToolStripMenuItem.Click += new System.EventHandler(this.eliminarMovimentoToolStripMenuItem_Click);
            // 
            // eliminarEntreDatasToolStripMenuItem
            // 
            this.eliminarEntreDatasToolStripMenuItem.Name = "eliminarEntreDatasToolStripMenuItem";
            this.eliminarEntreDatasToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.eliminarEntreDatasToolStripMenuItem.Text = "Eliminar entre datas";
            // 
            // recolonizarTabelaMovimentosToolStripMenuItem
            // 
            this.recolonizarTabelaMovimentosToolStripMenuItem.Name = "recolonizarTabelaMovimentosToolStripMenuItem";
            this.recolonizarTabelaMovimentosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.recolonizarTabelaMovimentosToolStripMenuItem.Text = "Recolonizar tabela Movimentos";
            this.recolonizarTabelaMovimentosToolStripMenuItem.Click += new System.EventHandler(this.recolonizarTabelaMovimentosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirClienteToolStripMenuItem,
            this.mOVIMENTOSToolStripMenuItem,
            this.iMPRESSOESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(15, 643);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 22;
            // 
            // dtpFim
            // 
            this.dtpFim.Location = new System.Drawing.Point(245, 643);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(200, 20);
            this.dtpFim.TabIndex = 23;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(12, 627);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(58, 13);
            this.lblDataInicio.TabIndex = 24;
            this.lblDataInicio.Text = "Data Inicio";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(242, 627);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(49, 13);
            this.lblDataFim.TabIndex = 25;
            this.lblDataFim.Text = "Data Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1323, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(479, 627);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 36);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar entre datas";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblListagemMovimentos
            // 
            this.lblListagemMovimentos.AutoSize = true;
            this.lblListagemMovimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagemMovimentos.Location = new System.Drawing.Point(374, 46);
            this.lblListagemMovimentos.Name = "lblListagemMovimentos";
            this.lblListagemMovimentos.Size = new System.Drawing.Size(141, 16);
            this.lblListagemMovimentos.TabIndex = 28;
            this.lblListagemMovimentos.Text = "Listagem Movimentos:";
            // 
            // btnListarEntreDatas
            // 
            this.btnListarEntreDatas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListarEntreDatas.ForeColor = System.Drawing.Color.Red;
            this.btnListarEntreDatas.Location = new System.Drawing.Point(661, 627);
            this.btnListarEntreDatas.Name = "btnListarEntreDatas";
            this.btnListarEntreDatas.Size = new System.Drawing.Size(156, 36);
            this.btnListarEntreDatas.TabIndex = 29;
            this.btnListarEntreDatas.Text = "Listar entre datas";
            this.btnListarEntreDatas.UseVisualStyleBackColor = false;
            this.btnListarEntreDatas.Click += new System.EventHandler(this.btnListarEntreDatas_Click);
            // 
            // btnListarMesCorrente
            // 
            this.btnListarMesCorrente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListarMesCorrente.Location = new System.Drawing.Point(1030, 627);
            this.btnListarMesCorrente.Name = "btnListarMesCorrente";
            this.btnListarMesCorrente.Size = new System.Drawing.Size(147, 36);
            this.btnListarMesCorrente.TabIndex = 30;
            this.btnListarMesCorrente.Text = "Listar mês corrente";
            this.btnListarMesCorrente.UseVisualStyleBackColor = false;
            this.btnListarMesCorrente.Click += new System.EventHandler(this.btnListarMesCorrente_Click);
            // 
            // btnListaMovimentosClienteMesCorrente
            // 
            this.btnListaMovimentosClienteMesCorrente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListaMovimentosClienteMesCorrente.Location = new System.Drawing.Point(842, 627);
            this.btnListaMovimentosClienteMesCorrente.Name = "btnListaMovimentosClienteMesCorrente";
            this.btnListaMovimentosClienteMesCorrente.Size = new System.Drawing.Size(154, 36);
            this.btnListaMovimentosClienteMesCorrente.TabIndex = 31;
            this.btnListaMovimentosClienteMesCorrente.Text = "Lista movimentos do cliente no mes corrente";
            this.btnListaMovimentosClienteMesCorrente.UseVisualStyleBackColor = false;
            this.btnListaMovimentosClienteMesCorrente.Click += new System.EventHandler(this.btnListaMovimentosClienteMesCorrente_Click);
            // 
            // iMPRESSOESToolStripMenuItem
            // 
            this.iMPRESSOESToolStripMenuItem.Name = "iMPRESSOESToolStripMenuItem";
            this.iMPRESSOESToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.iMPRESSOESToolStripMenuItem.Text = "IMPRESSOES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 748);
            this.Controls.Add(this.btnListaMovimentosClienteMesCorrente);
            this.Controls.Add(this.btnListarMesCorrente);
            this.Controls.Add(this.btnListarEntreDatas);
            this.Controls.Add(this.lblListagemMovimentos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.btnEnviarParaBD);
            this.Controls.Add(this.txtValorCreditar);
            this.Controls.Add(this.txtValorDebitar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dtpMovimentos);
            this.Controls.Add(this.lblValorCreditar);
            this.Controls.Add(this.lblValorDebitar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblEscolheData);
            this.Controls.Add(this.lblSeparadorNovoMovimento);
            this.Controls.Add(this.lblListagemClientes);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgvMovimentos);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Red;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblListagemClientes;
        public System.Windows.Forms.DataGridView dgvMovimentos;
        private System.Windows.Forms.Label lblSeparadorNovoMovimento;
        private System.Windows.Forms.Label lblEscolheData;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValorDebitar;
        private System.Windows.Forms.Label lblValorCreditar;
        private System.Windows.Forms.DateTimePicker dtpMovimentos;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValorDebitar;
        private System.Windows.Forms.TextBox txtValorCreditar;
        private System.Windows.Forms.Button btnEnviarParaBD;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.ToolStripMenuItem inserirClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recolonizarTabelaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recolonizarTabelaClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mOVIMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirMovimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMovimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarMovimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMovimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEntreDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recolonizarTabelaMovimentosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblListagemMovimentos;
        private System.Windows.Forms.Button btnListarEntreDatas;
        private System.Windows.Forms.Button btnListarMesCorrente;
        private System.Windows.Forms.Button btnListaMovimentosClienteMesCorrente;
        private System.Windows.Forms.ToolStripMenuItem iMPRESSOESToolStripMenuItem;
    }
}

