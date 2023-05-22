using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AlbertoContasCorrentes;

namespace Diversos
{
    public class ConectaBD
    {
        public string strConn = "data source = ;Initial Catalog = AlbertoContasCorrentes;User Id=EFAAlberto;Password = ;";
        public string strConn2 = "data source =;Initial Catalog = AlbertoContasCorrentes;User Id=EFAAlberto;Password = ;";

        public string ssql = "";
        public System.Data.DataTable BuscarDados()
        {
            //criar uma conexão:
            SqlConnection C = new SqlConnection(strConn2);
            C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = ssql;

            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);

            //desligar a conexão:
            C.Close();
            return dt;
        }
    }

    public class FormatarGrid 
    {
        public void GridFormatar(DataGridView dgvMovimentos)
        {
            dgvMovimentos.AllowUserToAddRows = false;
            dgvMovimentos.ColumnHeadersVisible = true;
            dgvMovimentos.RowHeadersVisible = false;

            //id:
            dgvMovimentos.Columns[0].Name = "id";
            dgvMovimentos.Columns[0].HeaderText = "PK";
            dgvMovimentos.Columns["id"].Visible = false;
            dgvMovimentos.Columns["id"].Width = 30;

            //data
            dgvMovimentos.Columns[1].Name = "data"; dgvMovimentos.Columns[1].HeaderText = "Data";
            dgvMovimentos.Columns["data"].Visible = true; dgvMovimentos.Columns["data"].Width = 80;
            dgvMovimentos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //descricao:
            dgvMovimentos.Columns[2].Name = "descricao"; dgvMovimentos.Columns[2].HeaderText = "Descrição";
            dgvMovimentos.Columns["descricao"].Visible = true; dgvMovimentos.Columns["descricao"].Width = 300;
            for (int i = 0; i < dgvMovimentos.RowCount; i++)
            { dgvMovimentos.Rows[i].Cells[2].Style.Font = new Font("Arial", 8, FontStyle.Bold); }

            //estado
            dgvMovimentos.Columns[3].Name = "estado"; dgvMovimentos.Columns[3].HeaderText = "Estado";
            dgvMovimentos.Columns["estado"].Visible = true; dgvMovimentos.Columns["estado"].Width = 80;

            //valorDebito:
            dgvMovimentos.Columns[4].Name = "valorDebito"; dgvMovimentos.Columns[4].HeaderText = "Valor Débito";
            dgvMovimentos.Columns["valorDebito"].Visible = true; dgvMovimentos.Columns["valorDebito"].Width = 80;
            dgvMovimentos.Columns[4].DefaultCellStyle.Format = "c2";
            // for (int i = 0; i < dgvMovimentos.RowCount; i++) { dgvMovimentos.Rows[i].Cells[3].Style.Format = "0.00"; }//funciona
            dgvMovimentos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //valorCredito
            dgvMovimentos.Columns[5].Name = "valorCredito"; dgvMovimentos.Columns[5].HeaderText = "Valor Crédito";
            dgvMovimentos.Columns["valorCredito"].Visible = true; dgvMovimentos.Columns["valorCredito"].Width = 80;
            dgvMovimentos.Columns[5].DefaultCellStyle.Format = "c2";
            //for (int i = 0; i < dgvMovimentos.RowCount; i++) {dgvMovimentos.Rows[i].Cells[4].Style.Format = "0.00";} funciona
            dgvMovimentos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //idCliente
            dgvMovimentos.Columns[6].Name = "idCliente"; dgvMovimentos.Columns[6].HeaderText = "Id Cliente";
            dgvMovimentos.Columns["idCliente"].Visible = false; dgvMovimentos.Columns["idCliente"].Width = 40;

            //saldo
            //gvMovimentos.Columns[6].Name = "saldo"; dgvMovimentos.Columns[6].HeaderText = "Saldo";
            dgvMovimentos.Columns["Saldo"].Visible = true; dgvMovimentos.Columns["Saldo"].Width = 100;
            //dgvMovimentos.Columns[6].DefaultCellStyle.Format = "# ##0.00";//funciona
            dgvMovimentos.Columns[7].DefaultCellStyle.Format = "c2";
            dgvMovimentos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMovimentos.Columns["Saldo"].ReadOnly = true;//proteger contra alteração pelo utilizador
            dgvMovimentos.Columns["Saldo"].DefaultCellStyle.ForeColor = Color.Navy;
            dgvMovimentos.Columns["Saldo"].DefaultCellStyle.BackColor = Color.Lavender;


            dgvMovimentos.Sort(dgvMovimentos.Columns["data"], ListSortDirection.Ascending);

            try
            {//mostrar sempre os últimos registos da grid:
                   dgvMovimentos.FirstDisplayedScrollingRowIndex = dgvMovimentos.RowCount - 1;
            }
            catch (Exception)
            {
                ;
            }
        }
    }

    public class RecolonizarBD
    {
        public void RecolonizarTabelaClientes()
        {
            ConectaBD obj = new ConectaBD();

            obj.ssql = "USE [AlbertoContasCorrentes];DELETE FROM movimento; DELETE FROM cliente; DBCC CHECKIDENT ('cliente', RESEED, 0); SET IDENTITY_INSERT [dbo].[cliente] ON; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (1, N'Alfreds Futterkiste', N'', N'Alemanha'); " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (2, N'Ana Trujillo Emparedados y helados', N'', N'México'); " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (3, N'Antonio Moreno Taquería', N'', N'México'); " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (4, N'Around the Horn', N'', N'RU') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (5, N'Berglunds snabbköp', N'', N'Suécia') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (6, N'Blauer See Delikatessen', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (7, N'Blondel père et fils', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (8, N'Bólido Comidas preparadas', N'', N'Espanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (9, N'Bon app''', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (10, N'Bottom-Dollar Markets', N'', N'Canadá') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (11, N'B''s Beverages', N'', N'RU') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (12, N'Cactus Comidas para llevar', N'', N'Argentina') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (13, N'Centro comercial Moctezuma', N'', N'Mexico') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (14, N'Chop-suey Chinese', N'', N'Suíça') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (15, N'Comércio Mineiro', N'', N'Brasil') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (16, N'Consolidated Holdings', N'', N'RU') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (17, N'Drachenblut Delikatessen', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (18, N'Du monde entier', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (19, N'Eastern Connection', N'', N'RU') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (20, N'Ernst Handel', N'', N'Áustria') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (21, N'Familia Arquibaldo', N'', N'Brasil') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (22, N'FISSA Fabrica Inter. Salchichas S.A.', N'', N'Espanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (23, N'Folies gourmandes', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (24, N'Folk och fä HB', N'', N'Suécia') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (25, N'Frankenversand', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (26, N'France restauration', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (27, N'Franchi S.p.A.', N'', N'Itália') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (28, N'Furia Bacalhau e Frutos do Mar', N'', N'Portugal') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (29, N'Galería del gastrónomo', N'', N'Espanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (30, N'Godos Cocina Típica', N'', N'Espanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (31, N'Gourmet Lanchonetes', N'', N'Brasil') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (32, N'Great Lakes Food Market', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (33, N'GROSELLA-Restaurante', N'', N'Venezuela') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (34, N'Hanari Carnes', N'', N'Brasil') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (35, N'HILARIÓN-Abastos', N'', N'Venezuela') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (36, N'Hungry Coyote Import Store', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (37, N'Hungry Owl All-Night Grocers', N'', N'Irlanda') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (38, N'Island Trading', N'', N'RU') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (39, N'Königlich Essen', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (40, N'La corne d''abondance', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (41, N'La maison d''Asie', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (42, N'Laughing Bacchus Wine Cellars', N'', N'Canadá') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (43, N'Lazy K Kountry Store', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (44, N'Lehmanns Marktstand', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (45, N'Let''s Stop N Shop', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (46, N'LILA-Supermercado', N'', N'Venezuela') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (47, N'LINO-Delicateses', N'', N'Venezuela') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (48, N'Lonesome Pine Restaurant', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (49, N'Magazzini Alimentari Riuniti', N'', N'Itália') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (50, N'Maison Dewey', N'', N'Bélgica') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (51, N'Mère Paillarde', N'', N'Canadá') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (52, N'Morgenstern Gesundkost', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (53, N'North/South', N'', N'RU') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (54, N'Océano Atlántico Ltda.', N'', N'Argentina') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (55, N'Old World Delicatessen', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (56, N'Ottilies Käseladen', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (57, N'Paris spécialités', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (58, N'Pericles Comidas clásicas', N'', N'México') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (59, N'Piccolo und mehr', N'', N'Áustria') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (60, N'Princesa Isabel Vinhos', N'', N'Portugal') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (61, N'Que Delícia', N'', N'Brasil') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (62, N'Queen Cozinha', N'', N'Brasil') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (63, N'QUICK-Stop', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (64, N'Rancho grande', N'', N'Argentina') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (65, N'Rattlesnake Canyon Grocery', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (66, N'Reggiani Caseifici', N'', N'Itália') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (67, N'Ricardo Adocicados', N'', N'Brasil') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (68, N'Richter Supermarkt', N'', N'Suíça') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (69, N'Romero y tomillo', N'', N'Espanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (70, N'Santé Gourmet', N'', N'Noruega') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (71, N'Save-a-lot Markets', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (72, N'Seven Seas Imports', N'', N'RU') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (73, N'Simons bistro', N'', N'Dinamarca') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (74, N'Spécialités du monde', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (75, N'Split Rail Beer & Ale', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (76, N'Suprêmes délices', N'', N'Bélgica') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (77, N'The Big Cheese', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (78, N'The Cracker Box', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (79, N'Toms Spezialitäten', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (80, N'Tortuga Restaurante', N'', N'México') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (81, N'Tradição Hipermercados', N'', N'Brasil') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (82, N'Trail''s Head Gourmet Provisioners', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (83, N'Vaffeljernet', N'', N'Dinamarca') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (84, N'Victuailles en stock', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (85, N'Vins et alcools Chevalier', N'', N'França') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (86, N'Die Wandernde Kuh', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (87, N'Wartian Herkku', N'', N'Finlândia') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (88, N'Wellington Importadora', N'', N'Brasil') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (89, N'White Clover Markets', N'', N'EUA') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (90, N'Wilman Kala', N'', N'Finlândia') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (91, N'Wolski  Zajazd', N'', N'Polónia') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (93, N'Justino Cabaça', N'', N'Alemanha') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (94, N'Castores dos Rios', N'', N'El Salvador') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (95, N'Antonio Faustino Carnes Exoticas LDA', N'', N'Argentina') ; " +
                "INSERT [dbo].[cliente] ([id], [nomeCliente], [marcador], [refInterna]) VALUES (96, N'Pescados Antunes', N'', N'Portugal') ; " +
                "SET IDENTITY_INSERT [dbo].[cliente] OFF;";

            try
            {
                obj.BuscarDados();
                MessageBox.Show("Tabela dos clientes recolonizada com sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro! Alguma coisa correu mal.");
            }           
        }
        public void RecolonizarMovimentos() { 
            ConectaBD obj = new ConectaBD();
            obj.ssql = "USE [AlbertoContasCorrentes];DBCC CHECKIDENT ('movimento', RESEED, 0);SET IDENTITY_INSERT [dbo].[movimento] ON; " +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (1, CAST(N'2020-01-10' AS Date), N'Documento 1', N'', NULL, 100.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (2, CAST(N'2020-10-15' AS Date), N'Documento 2', N'', 110.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (3, CAST(N'2020-10-28' AS Date), N'Documento 3', N'', NULL, 200.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (4, CAST(N'2020-10-01' AS Date), N'Documento 4', N'', 120.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (5, CAST(N'2020-10-15' AS Date), N'Documento 5', N'', 99.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (6, CAST(N'2020-10-28' AS Date), N'Documento 6', N'', NULL, 105.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (7, CAST(N'2020-11-02' AS Date), N'Documento 7', N'', 80.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (8, CAST(N'2020-11-02' AS Date), N'Documento 8', N'', 100.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (9, CAST(N'2020-11-04' AS Date), N'Documento 9', N'', NULL, 21.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (10, CAST(N'2020-11-05' AS Date), N'Documento 10', N'', NULL, 77.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (11, CAST(N'2020-11-06' AS Date), N'Documento 11', N'', 200.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (12, CAST(N'2020-11-07' AS Date), N'Documento 12', N'', NULL, 192.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (13, CAST(N'2020-11-04' AS Date), N'Documento 13', N'', 150.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (14, CAST(N'2020-11-05' AS Date), N'Documento 14', N'', 120.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (15, CAST(N'2020-11-06' AS Date), N'Documento 15', N'', 112.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (16, CAST(N'2020-11-07' AS Date), N'Documento 16', N'', NULL, 21.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (17, CAST(N'2020-11-04' AS Date), N'Documento 17', N'', NULL, 77.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (18, CAST(N'2020-11-05' AS Date), N'Documento 18', N'', NULL, 88.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (19, CAST(N'2020-11-06' AS Date), N'Documento 19', N'', 22.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (20, CAST(N'2020-11-07' AS Date), N'Documento 20', N'', 66.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (21, CAST(N'2020-11-04' AS Date), N'Documento 21', N'', 99.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (22, CAST(N'2020-11-05' AS Date), N'Documento 22', N'', NULL, 200.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (23, CAST(N'2020-11-06' AS Date), N'Documento 23', N'', NULL, 250.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (24, CAST(N'2020-11-07' AS Date), N'Documento 24', N'', 123.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (25, CAST(N'2020-11-04' AS Date), N'Documento 25', N'', 215.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (26, CAST(N'2020-11-05' AS Date), N'Documento 26', N'', NULL, 44.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (27, CAST(N'2023-03-05' AS Date), N'Documento 124', N'', 0.0000, 155.0000, 4);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (28, CAST(N'2020-11-07' AS Date), N'Documento 28', N'', 123.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (29, CAST(N'2020-11-04' AS Date), N'Documento 29', N'', 321.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (30, CAST(N'2020-09-05' AS Date), N'Documento 30', N'', NULL, 77.0000, 77);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (31, CAST(N'2020-10-01' AS Date), N'Documento 31', N'', NULL, 100.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (32, CAST(N'2020-10-15' AS Date), N'Documento 32', N'', 110.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (33, CAST(N'2020-10-28' AS Date), N'Documento 33', N'', NULL, 200.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (34, CAST(N'2020-10-01' AS Date), N'Documento 34', N'', 120.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (35, CAST(N'2020-10-15' AS Date), N'Documento 35', N'', 99.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (36, CAST(N'2020-10-28' AS Date), N'Documento 36', N'', NULL, 105.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (37, CAST(N'2020-11-02' AS Date), N'Documento 37', N'', 80.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (38, CAST(N'2020-11-02' AS Date), N'Documento 38', N'', 100.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (39, CAST(N'2020-11-04' AS Date), N'Documento 39', N'', NULL, 21.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (40, CAST(N'2020-11-05' AS Date), N'Documento 40', N'', NULL, 77.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (41, CAST(N'2020-11-06' AS Date), N'Documento 41', N'', 200.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (42, CAST(N'2020-11-07' AS Date), N'Documento 42', N'', NULL, 192.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (43, CAST(N'2020-11-04' AS Date), N'Documento 43', N'', 150.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (44, CAST(N'2020-11-05' AS Date), N'Documento 44', N'', 120.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (45, CAST(N'2020-11-06' AS Date), N'Documento 45', N'', 112.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (46, CAST(N'2020-11-07' AS Date), N'Documento 46', N'', NULL, 21.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (47, CAST(N'2020-11-04' AS Date), N'Documento 47', N'', NULL, 77.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (48, CAST(N'2020-11-05' AS Date), N'Documento 48', N'', NULL, 88.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (49, CAST(N'2020-11-06' AS Date), N'Documento 49', N'', 22.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (50, CAST(N'2020-11-07' AS Date), N'Documento 50', N'', 66.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (51, CAST(N'2020-11-04' AS Date), N'Documento 51', N'', 99.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (52, CAST(N'2020-11-05' AS Date), N'Documento 52', N'', NULL, 200.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (53, CAST(N'2020-11-06' AS Date), N'Documento 53', N'', NULL, 250.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (54, CAST(N'2020-11-07' AS Date), N'Documento 54', N'', 123.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (55, CAST(N'2020-11-04' AS Date), N'Documento 55', N'', 215.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (56, CAST(N'2020-11-05' AS Date), N'Documento 56', N'', NULL, 44.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (57, CAST(N'2023-03-05' AS Date), N'Documento 124', N'', 0.0000, 155.0000, 4);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (58, CAST(N'2020-11-07' AS Date), N'Documento 58', N'', 123.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (59, CAST(N'2020-11-04' AS Date), N'Documento 59', N'', 321.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (60, CAST(N'2020-09-05' AS Date), N'Documento 60', N'', NULL, 77.0000, 77);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (61, CAST(N'2020-10-01' AS Date), N'Documento 61', N'', NULL, 100.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (62, CAST(N'2020-10-15' AS Date), N'Documento 62', N'', 110.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (63, CAST(N'2020-10-28' AS Date), N'Documento 63', N'', NULL, 200.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (64, CAST(N'2020-10-01' AS Date), N'Documento 64', N'', 120.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (65, CAST(N'2020-10-15' AS Date), N'Documento 65', N'', 99.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (66, CAST(N'2020-10-28' AS Date), N'Documento 66', N'', NULL, 105.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (67, CAST(N'2020-11-02' AS Date), N'Documento 67', N'', 80.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (68, CAST(N'2020-11-02' AS Date), N'Documento 68', N'', 100.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (69, CAST(N'2020-11-04' AS Date), N'Documento 69', N'', NULL, 21.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (70, CAST(N'2020-11-05' AS Date), N'Documento 70', N'', NULL, 77.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (71, CAST(N'2020-11-06' AS Date), N'Documento 71', N'', 200.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (72, CAST(N'2020-11-07' AS Date), N'Documento 72', N'', NULL, 192.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (73, CAST(N'2020-11-04' AS Date), N'Documento 73', N'', 150.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (74, CAST(N'2020-11-05' AS Date), N'Documento 74', N'', 120.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (75, CAST(N'2020-11-06' AS Date), N'Documento 75', N'', 112.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (76, CAST(N'2020-11-07' AS Date), N'Documento 76', N'', NULL, 21.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (77, CAST(N'2020-11-04' AS Date), N'Documento 77', N'', NULL, 77.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (78, CAST(N'2020-11-05' AS Date), N'Documento 78', N'', NULL, 88.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (79, CAST(N'2020-11-06' AS Date), N'Documento 79', N'', 22.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (80, CAST(N'2020-11-07' AS Date), N'Documento 80', N'', 66.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (81, CAST(N'2020-11-04' AS Date), N'Documento 81', N'', 99.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (82, CAST(N'2020-11-05' AS Date), N'Documento 82', N'', NULL, 200.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (83, CAST(N'2020-11-06' AS Date), N'Documento 83', N'', NULL, 250.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (84, CAST(N'2020-11-07' AS Date), N'Documento 84', N'', 123.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (85, CAST(N'2020-11-04' AS Date), N'Documento 85', N'', 215.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (86, CAST(N'2020-11-05' AS Date), N'Documento 86', N'', NULL, 44.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (87, CAST(N'2023-03-05' AS Date), N'Documento 124', N'', 0.0000, 155.0000, 4);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (88, CAST(N'2020-11-07' AS Date), N'Documento 88', N'', 123.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (89, CAST(N'2020-11-04' AS Date), N'Documento 89', N'', 321.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (90, CAST(N'2020-09-05' AS Date), N'Documento 90', N'', NULL, 77.0000, 77);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (91, CAST(N'2020-10-01' AS Date), N'Documento 91', N'', NULL, 100.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (92, CAST(N'2020-10-15' AS Date), N'Documento 92', N'', 110.0000, NULL, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (93, CAST(N'2020-10-28' AS Date), N'Documento 93', N'', NULL, 200.0000, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (94, CAST(N'2020-10-01' AS Date), N'Documento 94', N'', 120.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (95, CAST(N'2020-10-15' AS Date), N'Documento 95', N'', 99.0000, NULL, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (96, CAST(N'2020-10-28' AS Date), N'Documento 96', N'', NULL, 105.0000, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (97, CAST(N'2020-11-02' AS Date), N'Documento 97', N'', 80.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (98, CAST(N'2020-11-02' AS Date), N'Documento 98', N'', 100.0000, NULL, 1);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (99, CAST(N'2020-11-04' AS Date), N'Documento 99', N'', NULL, 21.0000, 2);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (100, CAST(N'2020-11-05' AS Date), N'Documento 100', N'', NULL, 77.0000, 3);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (102, CAST(N'2023-03-05' AS Date), N'Saldar divida', NULL, NULL, 500.0000, 6);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (103, CAST(N'2023-05-03' AS Date), N'Documento 124', N'', 0.0000, 200.0000, 4);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (104, CAST(N'2023-05-03' AS Date), N'Documento 126', NULL, NULL, 1500.0000, 91);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (105, CAST(N'2023-05-03' AS Date), N'Documento 300', NULL, NULL, 320.0000, 90);" +
                "INSERT [dbo].[movimento] ([id], [data], [descricao], [estado], [valorDebito], [valorCredito], [clienteId]) VALUES (106, CAST(N'2023-05-03' AS Date), N'Documento 301', NULL, 130.0000, NULL, 90);" +
                "SET IDENTITY_INSERT [dbo].[movimento] OFF;";
            try
            {
                obj.BuscarDados();
                MessageBox.Show("Tabela recolonizada com sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro! Alguma coisa correu mal.");
            }
        }
    }
}