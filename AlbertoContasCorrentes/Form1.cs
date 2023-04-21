using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlbertoContasCorrentes.FormClientes;
using Diversos;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace AlbertoContasCorrentes
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Construtor que vai iniciar os componentes, chamar os métodos de povoar a listBox e limpar a grid dos movimentos
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            PovoarListBox();
            LimpaGrid();
            dgvMovimentos.KeyDown += dgvMovimentos_KeyDown;

        }
        //======================================================================================================= Métodos auxiliares 
        /// <summary>
        /// Método utilizado para alterar o formato da data
        /// </summary>
        /// <param name="data"> Data a ser alterada </param>
        /// <returns> Devolve a data alterada </returns>
        private string FormataData(string data) { 
            string str1, str2, str3, dataFinal;
            int pos = data.IndexOf('/');
            str1 = data.Substring(0, pos);
            str2 = data.Substring(pos, 4);
            str3 = data.Substring((pos + 3) + 1);
            dataFinal = str3+str2+str1;
            return dataFinal;
        }
        /// <summary>
        /// Método para limpar a dgvMovimentos
        /// </summary>
        private void LimpaGrid()
        {
            // Limpeza da datagrid
            dgvMovimentos.DataSource = null;
            dgvMovimentos.Rows.Clear();
            dgvMovimentos.Columns.Clear();
        }
        /// <summary>
        /// Método usado para povoar por ordem alfabética a lstClientes que pode ou não usar o texto da txtFiltro para filtrar
        /// </summary>
        public void PovoarListBox()
        {
            // Instanciacao de um objeto da classe conecta
            ConectaBD obj = new ConectaBD();

            if (txtFiltro.Text != "") //=============== Devolve dados com filtragem =====================
            {
                // Declaração e inicialização da variavel s que recebe o texto da textbox
                string s = txtFiltro.Text;
                obj.ssql = "Select * FROM cliente WHERE nomeCliente like '" + s + "%';";
            }
            else //=========================== Devolve dados sem filtragem ==============
            {
                // Resultado da string sql vai povoar a lista dos clientes
                obj.ssql = "SELECT * FROM cliente ORDER BY nomeCliente;";
            }
            lstClientes.DisplayMember = "nomeCliente";
            lstClientes.ValueMember = "id";
            lstClientes.DataSource = obj.BuscarDados();
        }
        /// <summary>
        /// Método utilizado para povoar a dgvMovimentos
        /// </summary>
        private void PovoarDgvMovimentos()
        {
            //=== Chamada do método que limpa a grid ===========
            LimpaGrid();

            //===  Instanciacao de um objeto da classe conecta =========
            ConectaBD obj = new ConectaBD();
            if (lstClientes.Items.Count > 0) //=== Se a listbox dos clientes nao estiver vazia dgvMovimentos é povoada ========
            {
                // String sql que vai devolver os dados desejados
                obj.ssql = "SELECT * FROM movimento WHERE clienteId=" + lstClientes.SelectedValue + ";";
                dgvMovimentos.DataSource = obj.BuscarDados();

            }
            else //============== Se a lista de clientes estiver vazia limpa a datagrid =========================
            {
                LimpaGrid(); //=== Chamada do método que limpa a dgvMovimentos ====
            }
            CalculaSaldo();
            foreach (DataGridViewColumn col in dgvMovimentos.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LimpaZerosDaGrid();
        }
        /// <summary>
        /// Método usado para limpar os zeros que vão aprecer na grid quando se inserir um novo movimento
        /// </summary>
        public void LimpaZerosDaGrid()
        {
            for (int i = 0; i < dgvMovimentos.RowCount; i++)
            {
                if (dgvMovimentos.Rows[i].Cells[4].Value.ToString() == "0,0000")
                {
                    DataGridViewCell cell = dgvMovimentos.Rows[i].Cells[4];
                    cell.Value = DBNull.Value;
                }
                else if (dgvMovimentos.Rows[i].Cells[5].Value.ToString() == "0,0000")
                {
                    DataGridViewCell cell = dgvMovimentos.Rows[i].Cells[5];
                    cell.Value = DBNull.Value;
                }
            }
        }
        /// <summary>
        /// Método usado para calcular o saldo dos clientes
        /// </summary>
        public void CalculaSaldo()
        {

            if (!dgvMovimentos.Columns.Contains("Saldo"))
            {
                dgvMovimentos.Columns.Add("Saldo", "Saldo");
            }
            FormatarGrid obj1 = new FormatarGrid();
            obj1.GridFormatar(dgvMovimentos);
            double saldo = 0;
            double credito = 0;
            double debito = 0;
            for (int i = 0; i < dgvMovimentos.RowCount; i++)
            {
                try
                {
                    debito = Convert.ToDouble(dgvMovimentos.Rows[i].Cells[4].Value);
                }
                catch (Exception)
                {
                    debito = 0;
                }
                try
                {
                    credito = Convert.ToDouble(dgvMovimentos.Rows[i].Cells[5].Value);
                }
                catch (Exception)
                {
                    credito = 0;
                }
                saldo += -debito + credito;

                dgvMovimentos.Rows[i].Cells[7].Style.Format = "0.00€";// Formata o valor do saldo para € com 2 casas decimais
                dgvMovimentos.Rows[i].Cells[7].Value = saldo;
            }

        }
        /// <summary>
        /// Método que insere novo movimento na base de dados para um cliente especifico
        /// </summary>
        private void InserirMovimento()
        {
            //================= Instanciacao de um objeto da classe ConectaBD ==================================================
            ConectaBD obj = new ConectaBD();
            //========================== Declaração e inicialização das variaveis a utilizar =====================================================
            double valorCredito = 0;
            double valorDebito = 0;
            String data = dtpMovimentos.Value.ToString("yyyy/MM/dd");//Formata a data para o tipo aceite pela BD
            String descricao = txtDescricao.Text;
            String cliente = lstClientes.GetItemText(lstClientes.SelectedItem);//Guarda o nome do cliente
            int clienteId = Convert.ToInt32(lstClientes.SelectedValue.ToString());
            //==================================== Testa as caixas de texto e tentar converter os valores ===========================================
            if (txtValorCreditar.Text != "")
            {
                try
                {
                    valorCredito = Convert.ToDouble(txtValorCreditar.Text);
                    valorDebito = 0;
                    obj.ssql = "insert into movimento(data, descricao, valorCredito, clienteId) values('" + data + "', '" + descricao + "'," + valorCredito + "," + clienteId + ");";
                }
                catch (Exception)
                {
                    MessageBox.Show("Dados inseridos nao sao aceites", "AVISO!!");//Avisa da falha na converção
                }
            }
            else if (txtValorDebitar.Text != "")
            {
                try
                {
                    valorDebito = Convert.ToDouble(txtValorDebitar.Text);
                    valorCredito = 0;
                    obj.ssql = "insert into movimento(data, descricao, valorDebito, clienteId) values('" + data + "', '" + descricao + "'," + valorDebito + "," + clienteId + ");";
                }
                catch (Exception)
                {
                    MessageBox.Show("Dados inseridos nao sao aceites", "AVISO!!");
                }
            }
            //=========== Declaracao e inicializacao das variaveis necessárias para construir a mensagem da MessageBox ================================
            String data_hora = dtpMovimentos.Value.ToString("yyyy-MM-dd hh:mm:ss");
            String diaSemana = dtpMovimentos.Value.ToString("dddd");
            String debito = Convert.ToString(valorDebito);
            String credito = Convert.ToString(valorCredito);
            //=========== Prepara butões necessários para a MessageBox e a respetiva mensagem ===============================================
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;
            result = MessageBox.Show(data_hora + "\nCliente: " + cliente + "\nData: " + diaSemana + "\nDescrição: " + descricao + "\nValor débito: " + debito + "\nValor crédito: " + credito + "\n\nCONFIRMA?", "VERIFIQUE OS DADOS", buttons);
            //============ Testa o butão que foi pressionado e executa as ordens presentes no mesmo ===============================================
            if (result == DialogResult.Yes)
            {
                obj.BuscarDados();
                // Limpa caixas de texto depois de atualizar
                txtDescricao.Text = "";
                txtValorCreditar.Text = "";
                txtValorDebitar.Text = "";
                // Atualiza a grid com os novos dados
                ConectaBD obj1 = new ConectaBD();
                obj1.ssql = "SELECT * FROM movimento WHERE clienteId=" + clienteId + ";";
                obj1.BuscarDados();
            }
            else
            {
                MessageBox.Show("Operação cancelada por sua ordem.");
            }
        }
        /// <summary>
        /// Método que altera o registo de um cliente em especifico
        /// </summary>
        private void AlteraRegisto()
        {
            //=== Delcaração das variaveis a utilizar para guardar os valores dos dados a alterar
            int linha = dgvMovimentos.CurrentCell.RowIndex;
            int registo = Convert.ToInt32(dgvMovimentos.Rows[linha].Cells[0].Value);
            String data = "";//= (Convert.ToString(dgvMovimentos.Rows[linha].Cells[1].Value));
            String descricao = "";// = dgvMovimentos.Rows[linha].Cells[2].Value.ToString();
            String estado = "";// = dgvMovimentos.Rows[linha].Cells[3].Value.ToString();
            double debito;// = Convert.ToDouble(dgvMovimentos.Rows[linha].Cells[4].Value.ToString());
            double credito;// = Convert.ToDouble(dgvMovimentos.Rows[linha].Cells[5].Value.ToString());

            //=== Atribuições dos valores ás variaveis com testes de excepções
            try
            {
                data = dgvMovimentos.Rows[linha].Cells[1].Value.ToString();
                // Separa a hora da data, pq o valor retornado anteriormente vem com a hora
                int pos = data.IndexOf(" ");
                data = data.Substring(0, pos);
            }
            catch (Exception)
            {
                MessageBox.Show("Algum valor é inválido.");
            }
            try
            {
                descricao = dgvMovimentos.Rows[linha].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                descricao = null;
            }
            try
            {
                estado = dgvMovimentos.Rows[linha].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                estado = null;
            }
            try
            {
                debito = Convert.ToDouble(dgvMovimentos.Rows[linha].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                debito = 0;
            }
            try
            {
                credito = Convert.ToDouble(dgvMovimentos.Rows[linha].Cells[5].Value.ToString());
            }
            catch (Exception)
            {
                credito = 0;
            }
            //=== Chamada do método que vai alterar a data para o formato aceite pela BD
            data = FormataData(data);
            //=== Testa a existência de valores de débito e crédito em simultâneo, tal não é permitido pela BD
            if (credito != 0 && debito != 0)
            {
                MessageBox.Show("Impossivel conter valores de debito e credito em simultaneo");
            }
            else
            {
                ConectaBD obj = new ConectaBD();
                obj.ssql = "update movimento set data ='" + data + "',descricao ='" + descricao + "', estado ='" + estado + "', valorDebito=" + debito + ", valorCredito=" + credito + " where id=" + registo + ";";
                MessageBox.Show(obj.ssql);
                obj.BuscarDados();
                PovoarDgvMovimentos();
            }

        }
        /// <summary>
        /// Método que apaga um registo de um determinado cliente
        /// </summary>
        private void ApagaRegisto()
        {
            // Instanciação de um objeto da classe ConectaBD
            ConectaBD obj = new ConectaBD();

            // Declaração e inicialização das variaveis a usar
            int linha = dgvMovimentos.CurrentCell.RowIndex;
            int registo = Convert.ToInt32(dgvMovimentos.Rows[linha].Cells[0].Value);
            String data = (Convert.ToString(dgvMovimentos.Rows[linha].Cells[1].Value));
            String descricao = dgvMovimentos.Rows[linha].Cells[2].Value.ToString();
            double valorDebito; 
            double valorCredito;
            // === Try catch para tentar converter os valores de credito e debito ==================================================
            try
            {
                valorDebito = Convert.ToDouble(dgvMovimentos.Rows[linha].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                valorDebito = 0;
            }
            try
            {
                valorCredito = Convert.ToDouble(dgvMovimentos.Rows[linha].Cells[5].Value.ToString());
            }
            catch (Exception)
            {
                valorCredito = 0;
            }
            //=== Atribuição dos valores às variaveis depois de testados
            String debito = Convert.ToString(valorDebito);
            String credito = Convert.ToString(valorCredito);
            //=========== Prepara butões necessários para a MessageBox e a respetiva mensagem ===============================================
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;
            result = MessageBox.Show("\nRegisto: " + descricao + "\nData: " + data + "\nValor débito: " + debito + "\nValor crédito: " + credito + "\n\nCONFIRMA?", "VERIFIQUE OS DADOS", buttons);
            //============ Testa o butão que foi pressionado e executa as ordens presentes no mesmo ===============================================
            if (result == DialogResult.Yes)
            {
                // Atualiza a grid com os novos dados
                obj.ssql = "DELETE FROM movimento WHERE id=" + registo + ";";
                obj.BuscarDados();
                PovoarDgvMovimentos();
            }
            else
            {
                MessageBox.Show("Operação cancelada por sua ordem.");
            }
        }
        /// <summary>
        /// Método usado para mostrar uma label controlada por temporizador
        /// </summary>
        /// <param name="label"> Label a ser mostrada </param>
        /// <param name="seconds"> Segundos que a label fica visivel </param>
        private void MostraLabelInformativa(Label label, int seconds)
        {
            label.Visible = true;

            Timer timer = new Timer();
            timer.Interval = seconds * 1000;
            timer.Tick += (sender, e) =>
            {
                label.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }
        /// <summary>
        /// Método utilizado para apagar registos entre datas de um determinado cliente
        /// </summary>
        private void ApagaRegistosEntreDatas()
        {

            // Instanciação de um objeto da classe ConectaBD e DataTable
            ConectaBD obj = new ConectaBD();
            DataTable dt = new DataTable();

            // Declaração e inicialização das variaveis a usar
            //String dataInicio = dtpInicio.Value.ToString("dd/MM/yyyy");//Formata a data para o tipo aceite pela BD
            //String dataFim = dtpFim.Value.ToString("dd/MM/yyyy");//Formata a data para o tipo aceite pela BD
            String dataInicio = dtpInicio.Value.ToString("yyyy-MM-dd");
            String dataFim = dtpFim.Value.ToString("yyyy-MM-dd");
            int idCliente = Convert.ToInt32(lstClientes.SelectedValue.ToString());
            String nomeCliente = lstClientes.GetItemText(lstClientes.SelectedItem);

            //String SQL para obter os dados desejados que sao guardados no objeto dt criado anteriormente
            obj.ssql = "select SUM(valorDebito), SUM(valorCredito), COUNT(id) from movimento Where clienteId =" + idCliente + " AND data BETWEEN '" + dataInicio + "' and '" + dataFim + "';";
            MessageBox.Show(obj.ssql);
            dt = obj.BuscarDados();

            String totalDebito = dt.Rows[0][0].ToString();
            String totalCredito = dt.Rows[0][1].ToString();
            String numeroLinhas = dt.Rows[0][2].ToString();
            

            //=========== Prepara butões necessários para a MessageBox e a respetiva mensagem ===============================================
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;
            result = MessageBox.Show("Cliente: " + nomeCliente + "\nTotal debito:" + totalDebito + "\nTotal credito:" + totalCredito + "\nTotal de linhas: " + numeroLinhas + "\n\nCONFIRMA?", "VERIFIQUE OS DADOS", buttons);
            //============ Testa o butão que foi pressionado e executa as ordens presentes no mesmo ===============================================
            if (result == DialogResult.Yes)
            {
                try
                {
                    obj.ssql = "DELETE FROM movimento WHERE clienteId=" + idCliente + ";";
                    obj.BuscarDados();
                    MessageBox.Show("Operacao realizada com sucesso.");
                    PovoarDgvMovimentos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro! Algo correu mal.");
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada por sua ordem.");
            }
        }
        /// <summary>
        /// Método que lista movimentos entre datas
        /// </summary>
        /// <param name="dataInicio"> Data da inicio da filtragem </param>
        /// <param name="dataFim"> Data do fim da filtragem </param>
        /// <param name="clienteId"> ID do cliente a filtrar </param>
        private void ListaMovimentosEntreDatas(string dataInicio, string dataFim, int clienteId)
        {
            //=== Instanciação de um objeto da classe ConectaBD
            ConectaBD obj = new ConectaBD();

            //=== String SQL que devolve os dados pretendidos
            obj.ssql = ($"SELECT * FROM movimento WHERE clienteId = {clienteId} AND data BETWEEN '{dataInicio}' AND '{dataFim}';");

            //=== Envia dados obtidos para a dgvMovimentos
            dgvMovimentos.DataSource = obj.BuscarDados();
        }
        /// <summary>
        /// Método que lista os movimentos do mês a decorrer
        /// </summary>
        /// <param name="clienteId"> Usado para filtrar por cliente, se valor for inferior a 1 mostra de todos os clientes </param>
        private void ListarMovimentosClienteMesCorrente(int clienteId)
        {
            //=== Instanciação de um objeto da classe conectaBD 
            ConectaBD obj = new ConectaBD();

            //=== Se o argumento do método for diferente de 0 filtra os resultados pelo ID e calcula o saldo do mes na grid
            if (clienteId != 0)
            {
                //=== String SQL para obtenção dos dados pretendidos
                obj.ssql = ($"select * from movimento where clienteId={clienteId} and datepart(Month, data) = datepart(Month, dateadd(month, -0, getdate())) and datepart(Year, data) = datepart(year, dateadd(month, -0, getdate())) ORDER BY clienteId;");
                //=== Povoar a dgvMovimentos com os dados obtidos
                dgvMovimentos.DataSource = obj.BuscarDados();
                CalculaSaldo();
            }
            //=== Senão apresenta os movimentos de todos os clientes no mês corrente ordenado pelos id's dos mesmos
            else {
                //=== String SQL para obtenção dos dados pretendidos
                obj.ssql = "select * from movimento where datepart(Month, data) = datepart(Month, dateadd(month, -0, getdate())) and datepart(Year, data) = datepart(year, dateadd(month, -0, getdate())) ORDER BY clienteId;";
                //=== Povoar a dgvMovimentos com os dados obtidos
                dgvMovimentos.DataSource = obj.BuscarDados();
            } 
        }

        //============================================================================================ Eventos 
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PovoarDgvMovimentos();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            PovoarListBox();
            PovoarDgvMovimentos();
        }
        private void btnEnviarParaBD_Click(object sender, EventArgs e)
        {
            InserirMovimento();
            PovoarDgvMovimentos();
        }
        private void dgvMovimentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) // Se a tecla F2 for pressionada, é chamado o método que altera o registo
            {
                AlteraRegisto();
            }
            if (e.KeyCode == Keys.F3) // Se a tecla F3 for pressionada, é chamado o método que apaga o registo
            {
                ApagaRegisto();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ApagaRegistosEntreDatas();
        }
        private void btnListarEntreDatas_Click(object sender, EventArgs e)
        {
            //=== Declaracao e inicialização das variaveis que guardam a informação necessária
            String dataInicio = dtpInicio.Value.ToString("yyyy-MM-dd");
            String dataFim = dtpFim.Value.ToString("yyyy-MM-dd");
            int clienteId = Convert.ToInt32(lstClientes.SelectedValue.ToString());

            //=== Chamada do método que lista os movimentos com passagem dos dados por argumento
            ListaMovimentosEntreDatas(dataInicio, dataFim, clienteId);
        }

        private void btnListarMesCorrente_Click(object sender, EventArgs e)
        {
            LimpaGrid(); //=== Método que limpa a grid
            ListarMovimentosClienteMesCorrente(0); // Passagem de argumento 0 para indicar ao método que são movimentos de todos os clientes
            LimpaZerosDaGrid();//=== Método que limpa zeros da grid
        }
        private void btnListaMovimentosClienteMesCorrente_Click(object sender, EventArgs e)
        {           
            //=== Variavel que guarda valor do id do cliente
            int clienteId = Convert.ToInt32(lstClientes.SelectedValue.ToString());

            LimpaGrid(); //=== Método que limpa a grid
            ListarMovimentosClienteMesCorrente(clienteId);// Passagem de argumento clienteId para indicar ao método que são movimentos apenas daquele cliente
            LimpaZerosDaGrid(); //=== Método que limpa zeros da grid
        }
        //============================================================================================= Tool Strip Menu Options

        private void inserirClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes myform = new FormClientes(this);
            myform.ShowDialog();
        }
        private void listarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes myform = new FormClientes(this);
            myform.ShowDialog();

        }
        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes myform = new FormClientes(this);
            myform.ShowDialog();
        }
        private void eliminarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes myform = new FormClientes(this);
            myform.ShowDialog();
        }
        private void recolonizarTabelaClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RecolonizarBD obj = new RecolonizarBD();
            obj.RecolonizarTabelaClientes();
            obj.RecolonizarMovimentos();
            PovoarListBox();
        }
        private void inserirMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescricao.Select(); //Cursor fica na caixa de texto da descricao
        }
        private void listarMovimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciação de um objeto da classe ConectaBD
            ConectaBD obj = new ConectaBD();
            // String sql para obter os dados pretendidos
            obj.ssql = "select * from movimento;";
            // Método da classe que vai buscar os dados à BD dependendo da string sql
            dgvMovimentos.DataSource = obj.BuscarDados();
            LimpaZerosDaGrid();
        }
        private void recolonizarTabelaMovimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecolonizarBD obj = new RecolonizarBD();
            obj.RecolonizarTabelaClientes();
            obj.RecolonizarMovimentos();
            PovoarListBox();
        }
        private void alterarMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInformacao.Text = "Selecione o registo na grid, altere o que pretende e em seguida pressione F2";
            MostraLabelInformativa(lblInformacao, 5);
        }
        private void eliminarMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInformacao.Text = "Selecione o registo na grid que pretende apagar e em seguida pressione F3";
            MostraLabelInformativa(lblInformacao, 5);
        }
        //=========================================================================================== Contolo de alterações nas caixas de texto
        private void txtValorDebitar_TextChanged(object sender, EventArgs e)
        {
            // Se for intoduzido um valor de debito, a caixa de texto que recebe o valor de credito é desbilitada
            if (txtValorDebitar.Text == "")
            {
                txtValorCreditar.Enabled = true;
            }
            else
            {
                txtValorCreditar.Enabled = false;
            }
        }
        private void txtValorCreditar_TextChanged(object sender, EventArgs e)
        {
            // Se for intoduzido um valor de credito, a caixa de texto que recebe o valor de debito é desbilitada
            if (txtValorCreditar.Text == "")
            {
                txtValorDebitar.Enabled = true;
            }
            else
            {
                txtValorDebitar.Enabled = false;
            }
        }
        
    }
}
