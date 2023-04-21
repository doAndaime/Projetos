using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlbertoContasCorrentes.Form1;
using Diversos;
using System.Security.Cryptography;

namespace AlbertoContasCorrentes
{
    public partial class FormClientes : Form
    {
        private Form1 parent;
        public FormClientes(Form1 prnt)
        {
            parent = prnt;
            InitializeComponent();
            PovoaListClientes();
            btnInserirCliente.Enabled = false;// No arranque do form o butão fica desabilitado
            btnAlterarNome.Enabled = false;// No arranque do form o butão fica desabilitado
            btnEliminaCliente.Enabled = false;// No arranque do form o butão fica desabilitado
           
        }
//========================================================================================================== Métodos 
        private void InsereNaBD()
        {
            //======== Instanciação de um objeto da classe ConectaBD ===============
            ConectaBD obj = new ConectaBD();
            //======== Variaveis para guardar os dados =============
            String nome, marcador, refInterna;
            nome = txtNome.Text;         
            marcador = txtMarcador.Text;
            refInterna = txtRefInterna.Text;
            //========= String SQL para devolver dados pretendidos =============
            obj.ssql = "INSERT INTO cliente(nomeCliente,marcador,refInterna) VALUES('" + nome + "','" + marcador + "','" + refInterna + "');";
            obj.BuscarDados();
            parent.PovoarListBox();
        }
        private void PovoaListClientes()
        {
            //======== Instanciação de um objeto da classe ConectaBD ===============
            ConectaBD obj = new ConectaBD();
            
            //========= String SQL para devolver dados pretendidos =============
            obj.ssql = "SELECT * FROM cliente ORDER BY nomeCliente;";
            lstFormClientes.DisplayMember = "nomeCliente";
            lstFormClientes.ValueMember = "id";
            lstFormClientes.DataSource = obj.BuscarDados();
            txtNome.Text = ""; txtMarcador.Text = ""; txtRefInterna.Text = "";
            btnInserirCliente.Enabled = false;
        }
        /// <summary>
        /// Método utilizado para alterar o nome do cliente com informação de controlo
        /// </summary>
        private void AlterarNome() {
            // Instanciacao de um objeto da classe conectaBD e declaracao e inicializacao das variaveis a usar
            ConectaBD obj = new ConectaBD();
            String novoNome, nomeMudar;
            nomeMudar = lstFormClientes.GetItemText(lstFormClientes.SelectedItem); //Recebe a string do item selecionado na lista
            novoNome = txtNovoNome.Text;

            // Adiciona butões de Sim/Nao na messageBox
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Adiciona a informação recolhida à MessageBox, um título e os butões de controlo
            result = MessageBox.Show($"Nome a mudar: '{nomeMudar}'\nNovo nome: '{novoNome}'", "Aviso", buttons);
            //=== Se o butão clicado for o sim, faz update na base de dados e actualiza as duas listBoxes que usam a informação
            if (result == DialogResult.Yes)
            {
                obj.ssql = "UPDATE cliente SET nomeCliente='" + novoNome + "' WHERE id =" + lstFormClientes.SelectedValue + ";";
                obj.BuscarDados();
                PovoaListClientes();
                parent.PovoarListBox();
                txtNovoNome.Text = "";
            }
            //=== Senão informa o utilizador que a operação foi cancelada
            else
            {
                MessageBox.Show("Operação cancelada por sua ordem.");
            }
        }
        /// <summary>
        /// Método que vai permitir eliminar um cliente da base de dados e os respectivos movimentos
        /// </summary>
        private void EliminarCliente() {
            //Instanciação de um objeto da classe conectaBD
            Diversos.ConectaBD obj = new Diversos.ConectaBD();
            // Declaração e inicialização das variáveis a usar
            string nomeAEliminar = txtNomeAEliminar.Text;
            int indice = BuscarNome(nomeAEliminar); // Método que procura a existência do nome e retribui o indice do mesmo
            double totalDebito = 0;
            double totalCredito = 0;

            // Se indice for -1 informa o utilizador da inexistencia do nome
            if (indice == -1)
            {
                MessageBox.Show("Nome inexistente na BD");
            }
            // Senao, se o nome existir vai calcular os valores de debito e credito do cliente e guardar nas respectivas variaveis
            else
            {
                try
                {//================ Calcula o valor do debito e caso seja null passa a 0 ==============================================
                    obj.ssql = "select sum(valorDebito) from movimento Where clienteId =" + indice + ";";
                    totalDebito = Convert.ToDouble(obj.BuscarDados().Rows[0][0]);
                }
                catch (Exception)
                {
                    totalDebito = 0;
                }
                try
                {//================ Calcula o valor do credito e caso seja null passa a 0 ==============================================
                    obj.ssql = "select sum(valorCredito) from movimento Where clienteId =" + indice + ";";
                    totalCredito = Convert.ToDouble(obj.BuscarDados().Rows[0][0]);
                }
                catch (Exception)
                {
                    totalCredito = 0;
                }
                //======================= Informa o utilizador da importância da operação a realizar e informa o mesmo =====================================================

                // Adiciona butões de Sim/Nao na messageBox e avisa o utilizador dos valores a débito e crédito e se quer proseguir
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Total de debito: " + Convert.ToString(totalDebito) + "\nTotal de crédito: " + Convert.ToString(totalCredito), "Deseja continuar?", buttons);

                if (result == DialogResult.Yes) //=========== Se a resposta for sim volta a apresentar a mensagem de texto ========================
                {
                    int totLinhas;
                    obj.ssql = "select count(*) from movimento where clienteId=" + indice + ";";
                    bool boolT = int.TryParse(Convert.ToString(obj.BuscarDados().Rows[0][0]), out totLinhas);
                    if (boolT == false) totLinhas = 0;

                    // Adiciona butões de Sim/Nao na messageBox e avisa o utilizador do total de movimentos e a importância da decisão seguinte      
                    MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                    DialogResult result2;
                    result2 = MessageBox.Show("Total de linhas de movimento: " + Convert.ToString(totLinhas), "O processo é irreversivel, tem a certeza?", buttons2);
                    if (result2 == DialogResult.Yes)
                    {
                        //================================================================= Elimina os movimentos
                        obj.ssql = "delete from movimento where clienteId=" + indice + ";";
                        obj.BuscarDados();
                        //================================================================= Elimina o cliente
                        obj.ssql = "delete from cliente where id=" + indice + ";";
                        obj.BuscarDados();
                    }
                    PovoaListClientes(); // Atualiza lista dos clientes
                    parent.PovoarListBox();// Vai povoar a lista dos clientes do form1 com as alterações efectuadas
                }
                // Se a opção for cancelar o processo, o utilizador é informado do mesmo e a mesma é cancelada
                else
                {
                    MessageBox.Show("Operação cancelada por sua ordem.");
                }
            }
        }
        /// <summary>
        /// Método utilizado para pesquisar a existencia de um nome na base de dados
        /// </summary>
        /// <param name="nome">Nome a pesquisar na base de dados</param>
        /// <returns>Devolve o id do cliente caso exista, caso não exista devolve -1</returns>
        private int BuscarNome(string nome)
        {
            // Instanciação de um objecto da classe conectaBD 
            ConectaBD obj = new ConectaBD();
            int control;
            try
            {
                obj.ssql = "select id from cliente WHERE nomeCliente like '" + nome + "';";
                control = Convert.ToInt32((obj.BuscarDados()).Rows[0][0].ToString());
            }
            catch (Exception)
            {
                control = -1;
            }
            return control;
        }
        /// <summary>
        /// Método usado para listar todos os clientes na listBox
        /// </summary>
        private void ListarClientes()
        {
            //Instanciação de um objeto da classe conectaBD
            ConectaBD obj = new ConectaBD();
            //String SQL que retorna os dados pretendidos
            obj.ssql = "SELECT * FROM cliente;";
            //Povoar a lista dos clientes
            lstFormClientes.DataSource = obj.ssql;
        }

        //==================================================================================================== Eventos
        /// <summary>
        /// Evento associado ao clique no butão de inserir cliente, no qual são chamados métodos definidos para tal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            InsereNaBD();
            PovoaListClientes();
        }
        /// <summary>
        /// Evento que controla alterações na caixa de texto do nome do cliente a inserir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            // Habilita e desabilita o botão da inserção consoante o que for digitado na caixa de texto
            if (txtNome.Text.Length == 0)
            {
                btnInserirCliente.Enabled = false;
            }
            else
            {
                btnInserirCliente.Enabled = true;
            }     
        }
        /// <summary>
        /// Evento que controla se butão de alterar nome do cliente foi clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlterarNome_Click(object sender, EventArgs e)
        {
            AlterarNome();
        }
        /// <summary>
        /// Evento que controla alterações na caixa de texto da alteração do nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNovoNome_TextChanged(object sender, EventArgs e)
        {
            // Habilita e desabilita o botão da alteração consoante o que for digitado na caixa de texto
            if (txtNovoNome.Text.Length == 0)
            {
                btnAlterarNome.Enabled = false;
            }
            else
            {
                btnAlterarNome.Enabled = true;
            }    
        }
        /// <summary>
        /// Evento que controla se butão de eliminar cliente foi clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminaCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente();
        }
        /// <summary>
        /// Evento que controla alterações na caixa de texto do nome do cliente a eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNomeAEliminar_TextChanged(object sender, EventArgs e)
        {
            // Habilita e dasabilita o butão de eliminar consoante o conteudo da caixa de texto
            if (txtNomeAEliminar.Text.Length == 0)
            {
                btnEliminaCliente.Enabled = false;
            }
            else
            {
                btnEliminaCliente.Enabled = true;
            }  
        }
        private void FormClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
