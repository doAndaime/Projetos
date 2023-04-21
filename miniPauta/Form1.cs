using System;

namespace miniPauta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct ficha
        {
            public int numero;
            public string nome;
            public string freguesia;
            public int ano;
            public char sexo;
        }

        private const FontStyle bold = FontStyle.Bold;
        public bool flag = false; // Usada para sinalizar o preenchimento da grid
        private void Form1_Load(object sender, EventArgs e)
        {

            //ColonizarGridA();
            ColonizarGrid();
            CalcularMediaENegativas();
            FormatarGrid();
        }

        //private int GeraNota()
        //{
        //    //int nota;
        //    //return nota;
        //}
        private void ColonizarGridA()
        {// Método usado como teste de colonização da grid ========================
            int nota = 0;
            var random = new Random();
            dgvPauta.Rows.Add("1", "Ana Rita Cunha", "Gualtar", "1997", "F");
            dgvPauta.Rows.Add("2", "Bela Costa Silva", "Maximinos", "1999", "F");
            for (int i = 0; i < dgvPauta.RowCount - 1; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    nota = random.Next(1, 20);
                    dgvPauta.Rows[i].Cells[j].Value = Convert.ToString(nota);
                }
            }    
        }
        private void ColonizarGridB()
        {//========= Método que coloniza a grid na totalidade ============================
            dgvPauta.Rows.Add("1", "Ana Rita Cunha", "Gualtar", "1997", 'F', "10", "11", "12", "10", "11", "12", "10", "11", "12", "11", "--", "--");
            dgvPauta.Rows.Add("2", "Bela Costa Silva", "Maximinos", "1999", "F", "15", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("3", "Carlos Alberto Costa", "Aveleda", "2000", "M", "10", "11", "12", "10", "11", "12", "10", "19", "12", "12", "--", "--");
            dgvPauta.Rows.Add("4", "Carlos Daniel Ferreira", "Gualtar", "2000", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("5", "Daniel Bastos Gomes", "Maximinos", "2001", "M", "10", "8", "8", "10", "11", "12", "10", "9", "12", "18", "--", "--");
            dgvPauta.Rows.Add("6", "Daniel Silva Ferraz", "Ferreiros", "1997", "M", "10", "11", "12", "10", "11", "12", "7", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("7", "Elvira Gomes Pendes", "Maximinos", "2002", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("8", "Fernanda Maria Silva", "Aveleda", "2001", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("9", "Fernando Gomes Barros", "Gualtar", "1997", "M", "7", "11", "12", "10", "9", "12", "10", "11", "12", "16", "--", "--");
            dgvPauta.Rows.Add("10", "Guilherme Alexandre Barros", "Aveleda", "1997", "M", "10", "11", "19", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("11", "Hilda Fonseca Silva", "Maximinos", "1997", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("12", "José Manuel Carvalho", "Sé", "2001", "M", "10", "11", "16", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("13", "José Alberto Gomes", "Maximinos", "2002", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("14", "Maria Silvéria Bastos", "Lovios", "2001", "F", "10", "11", "12", "16", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("15", "Anabela Bastos Torres", "Ferreiros", "1997", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "14", "--", "--");
            dgvPauta.Rows.Add("16", "Rui Vasco Santos", "Maximinos", "2001", "M", "10", "11", "12", "10", "15", "12", "10", "11", "12", "5", "--", "--");
            dgvPauta.Rows.Add("17", "Otávio Ferreira", "Gualtar", "2002", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("18", "Silvério Silva Teixeira", "Ferreiros", "1997", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("19", "Teodoro Armando Matos", "Maximinos", "2004", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("20", "Zacarias Alexandre Sampaio", "Sequeira", "1995", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
        }
        public void InitArrayOfFicha(ref ficha[] A)
        {
            A[0].numero = 1; A[0].nome = "Ana Rita Cunha"; A[0].freguesia = "Gualtar"; A[0].ano = 1997; A[0].sexo = 'F';
            A[1].numero = 2; A[1].nome = "Bela Costa Silva"; A[1].freguesia = "Maximinos"; A[1].ano = 1999; A[1].sexo = 'F';
            A[2].numero = 3; A[2].nome = "Carlos Alberto Costa"; A[2].freguesia = "Aveleda"; A[2].ano = 2000; A[2].sexo = 'M';
            A[3].numero = 4; A[3].nome = "Carlos Daniel Ferreira"; A[3].freguesia = "Gualtar"; A[3].ano = 2000; A[3].sexo = 'M';
            A[4].numero = 5; A[4].nome = "Daniel Bastos Gomes"; A[4].freguesia = "Maximinos"; A[4].ano = 2001; A[4].sexo = 'M';
            A[5].numero = 6; A[5].nome = "Daniel Silva Ferraz"; A[5].freguesia = "Ferreiros"; A[5].ano = 1997; A[5].sexo = 'M';

            A[6].numero = 7; A[6].nome = "Elvira Gomes Pendes"; A[6].freguesia = "Maximinos"; A[6].ano = 2002; A[6].sexo = 'F';
            A[7].numero = 8; A[7].nome = "Fernanda Maria Silva"; A[7].freguesia = "Aveleda"; A[7].ano = 2001; A[7].sexo = 'F';
            A[8].numero = 9; A[8].nome = "Fernando Gomes Barros"; A[8].freguesia = "Gualtar"; A[8].ano = 1997; A[8].sexo = 'M';
            A[9].numero = 10; A[9].nome = "Guilherme Alexandre Barros"; A[9].freguesia = "Aveleda"; A[9].ano = 1997; A[9].sexo = 'M';
            A[10].numero = 11; A[10].nome = "Hilda Fonseca Silva"; A[10].freguesia = "Maximinos"; A[10].ano = 1997; A[10].sexo = 'F';

            A[11].numero = 12; A[11].nome = "José Manuel Carvalho"; A[11].freguesia = "Sé"; A[11].ano = 2001; A[11].sexo = 'M';
            A[12].numero = 13; A[12].nome = "José Alberto Gomes"; A[12].freguesia = "Maximinos"; A[12].ano = 2002; A[12].sexo = 'M';
            A[13].numero = 14; A[13].nome = "Maria Silvéria Bastos"; A[13].freguesia = "Lovios"; A[13].ano = 2001; A[13].sexo = 'F';
            A[14].numero = 15; A[14].nome = "Anabela Bastos Torres"; A[14].freguesia = "Ferreiros"; A[14].ano = 1997; A[14].sexo = 'F';
            A[15].numero = 16; A[15].nome = "Rui Vasco Santos"; A[15].freguesia = "Maximinos"; A[15].ano = 2001; A[15].sexo = 'M';

            A[16].numero = 17; A[16].nome = "Otávio Ferreira"; A[16].freguesia = "Gualtar"; A[16].ano = 2002; A[16].sexo = 'M';
            A[17].numero = 18; A[17].nome = "Silvério Silva Teixeira"; A[17].freguesia = "Ferreiros"; A[17].ano = 1997; A[17].sexo = 'M';
            A[18].numero = 19; A[18].nome = "Teodoro Armando Matos"; A[18].freguesia = "Maximinos"; A[18].ano = 2004; A[18].sexo = 'M';
            A[19].numero = 20; A[19].nome = "Zacarias Alexandre Sampaio"; A[19].freguesia = "Sequeira"; A[19].ano = 1995; A[19].sexo = 'M';

        }

        public void InitMatriz(ref int[,] m)
        {
            int fator = 1000000;//modificar este valor se a geração ficar lenta

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < fator; k++)
                    {
                        //diversão ao processador, 
                        //para melhorar a geração de aleatórios
                    }
                    m[i, j] = GeraValor();
                }
            }
        }
        private int GeraValor()
        {   //devolve valor entre 6 e 20
            int avaliacao;
            Random r = new Random();

            avaliacao = r.Next(6, 21);
            //reduzir, mas não impossibilitar, a ocorrência de negativas e de valores acima de 18:
            if (avaliacao < 10 || avaliacao > 18) { avaliacao = r.Next(6, 21); }
            return avaliacao;
        }

        public void ColonizarGrid()
        {
            ficha[] arrayDeFormandos = new ficha[20];//array de 20 fichas
            int[,] matrizDeNotas = new int[20, 10]; //matrix de 20x10 inteiros
            InitArrayOfFicha(ref arrayDeFormandos);
            InitMatriz(ref matrizDeNotas);
            //Ciclo para preencher a grid com os dados e as notas 
            for (int i = 0; i < 20; i++)
            {
                dgvPauta.Rows.Add(Convert.ToString(arrayDeFormandos[i].numero), Convert.ToString(arrayDeFormandos[i].nome),Convert.ToString(arrayDeFormandos[i].freguesia), Convert.ToString(arrayDeFormandos[i].ano), Convert.ToString(arrayDeFormandos[i].sexo));
                int aux1 = 5;
                for (int j = 0; j < 10; j++)
                {
                    dgvPauta.Rows[i].Cells[aux1].Value = matrizDeNotas[i, j].ToString();
                    aux1++;
                }
            }
            flag = true;
        }
        private void ContaRaparigas()
        {
            // Declaração da variável contador usada para contar o numero de raparigas
            int contador = 0;

            // Ciclo para percorrer cada linha da grid e verificar se é rapariga

            for (int i = 0; i < dgvPauta.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "F")
                {
                    contador++;
                }
            }
            if (contador == 0)
            {
                MessageBox.Show("Não existem raparigas na grid.");
            }
            else
            {
                txtTotalNegativas.Text = Convert.ToString(contador);
            }
        }
        private void FormatarGrid()
        {
            if (flag == true)
            { // Flag sinaliza o preencimento total da grid

                // Ciclo para formatar a largura das células
                for (int i = 0; i < 17; i++)
                {
                    dgvPauta.AutoResizeColumn(i);
                }
                for (int i = 0; i < dgvPauta.RowCount - 1; i++)
                {
                    int pos = Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value);
                    if (pos >= 3)//Muda a cor da row para azul
                    {
                        dgvPauta.Rows[i].DefaultCellStyle.BackColor = Color.PowderBlue;

                    }
                    else//Senao a cor passa a branco
                    {
                        dgvPauta.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
                // Dois ciclos, um para percorrer as linhas e outro para percorrer as colunas
                for (int i = 0; i < dgvPauta.RowCount - 1; i++)
                {
                    for (int j = 5; j < 15; j++)
                    {

                        if (Convert.ToInt16(dgvPauta.Rows[i].Cells[j].Value) == 9)
                        {
                            dgvPauta.Rows[i].Cells[j].Style.ForeColor = Color.Olive;
                            //dgvPauta.Rows[i].Cells[j].Style.Font = bold;
                        }
                        if (Convert.ToInt16(dgvPauta.Rows[i].Cells[j].Value) == 8)
                        {
                            dgvPauta.Rows[i].Cells[j].Style.ForeColor = Color.Orange;
                           /* dgvPauta.Rows[i].Cells[j].Style.Font = bold*//*;*/
                        }
                        if (Convert.ToInt16(dgvPauta.Rows[i].Cells[j].Value) == 7)
                        {
                            dgvPauta.Rows[i].Cells[j].Style.ForeColor = Color.OrangeRed;
                            //dgvPauta.Rows[i].Cells[j].Style.Font = bold;
                        }
                        if (Convert.ToInt16(dgvPauta.Rows[i].Cells[j].Value) == 6)
                        {
                            dgvPauta.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                            //dgvPauta.Rows[i].Cells[j].Style.Font = bold;
                        }
                    }
                }
            }
        }
        private void CalcularMediaENegativas()
        {// ========= Método que calcula a média e conta as negativas através dos valores da grid
            decimal media = 0;
            decimal soma = 0;
            int contador = 0;
            // Dois ciclos, um para percorrer as linhas e outro para percorrer as colunas
            for (int i = 0; i < dgvPauta.RowCount - 1; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    soma = soma + Convert.ToDecimal(dgvPauta.Rows[i].Cells[j].Value);
                    // Ciclo para contar o numero de notas menores que 10
                    if (Convert.ToInt16(dgvPauta.Rows[i].Cells[j].Value) < 10)
                    {
                        contador++;
                    }
                }
                // Calcula a média e mostra no respectivo lugar a média e as negativas
                media = soma / 10;
                dgvPauta.Rows[i].Cells[15].Value = media.ToString("F");
                dgvPauta.Rows[i].Cells[16].Value = Convert.ToString(contador);// Mostra o numero de negativas na célula definida para tal
                ////int tot = Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value);
                //MessageBox.Show(Convert.ToString(contador));
                //if (contador >= 3)
                //{
                //    dgvPauta.Rows[i].DefaultCellStyle.BackColor = Color.PowderBlue;
                //}
                // Zera a soma, média e contador para voltar a usar na próxima linha
                soma = 0;
                media = 0;
                contador = 0;
            }
        }
        private void ContaRapazesMaximinos()
        {
            //Declaração e inicialização da variável contador usada para contar rapazes de maximinos
            int contador = 0;

            for (int i = 0; i < dgvPauta.RowCount; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[2].Value) == "Maximinos" && Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "M")
                {
                    contador++;
                }
            }
            txtTotalRapazesMaximinos.Text = Convert.ToString(contador);
        }
        private void MaisRapazesOuRaparigas()
        {
            //Declaração e inicialização dos contadores a usar
            int contaRapazes = 0;
            int contaRaparigas = 0;

            //Ciclo para percorrer a grid e contar
            for (int i = 0; i < dgvPauta.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "M")
                {
                    contaRapazes++;
                }
                else if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "F")
                {
                    contaRaparigas++;
                }
            }
            if (contaRaparigas > contaRapazes)
            {
                MessageBox.Show("Existem mais raparigas.");
            }
            else if (contaRapazes > contaRaparigas)
            {
                MessageBox.Show("Existem mais rapazes.");
            }
            else
            {
                MessageBox.Show("Existe o mesmo numero de rapazes e raparigas.");
            }
        }
        private void MaisVelho()
        {
            // Declaração e inicialização das variáveis
            int idade = 0;
            int maisVelho = 0;
            int ano = 0;
            String nomeMaisVelho = null;

            //ano = Convert.ToInt32(dgvPauta.Rows[0].Cells[3].Value);
            //idade = 2023 - ano;
            //maisVelho = idade;

            for (int i = 0; i < dgvPauta.RowCount - 1; i++)
            {
                ano = Convert.ToInt32(dgvPauta.Rows[i].Cells[3].Value);
                idade = 2023 - ano;
                if (idade > maisVelho)
                {
                    maisVelho = idade;
                    nomeMaisVelho = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value);
                }

            }
            MessageBox.Show("O mais velho é " + nomeMaisVelho + " com " + maisVelho + " anos.");
        }
        private void ReprovadosMediaMaiorQue12()
        {
            // Declaração e inicilização do contador a utilizar
            int contador = 0;

            // Ciclo para percorrer a grid
            for (int i = 0; i < dgvPauta.RowCount - 1; i++)
            {
                if (Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) > 12.00 && Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) >= 3)
                {
                    contador++;
                }
            }
            if (contador == 0)
            {
                MessageBox.Show("Existem 0 alunos reprovados com média maior que 12.");
            }
            else
            {
                MessageBox.Show("Existem " + Convert.ToString(contador) + " alunos reprovados com média maior que 12.");
            }
            
        }
        private void Encontra3Melhores()
        {
            // Declaração das variáveis a usar
            double maior = 0;
            double maior1 = 0;
            double maior2 = 0;
            double maior3 = 0;
            int[] indiceNotasMaiores = new int[3];

            for (int i = 0; i < dgvPauta.RowCount; i++)
            {//======================= Primeiro ciclo descobre a maior nota e guarda o indice no array =====================================
                if (Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) > maior)
                {
                    maior = Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value);
                    maior1 = maior;
                    indiceNotasMaiores[0] = i;
                }
            }
            maior = 0;
            for (int i = 0; i < dgvPauta.RowCount; i++)
            {//===================== Segundo ciclo descobre a segunda maior nota e guarda o indice no array =================================
                if (Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) > maior && Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) < maior1)
                {
                    maior = Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value);
                    maior2 = maior;
                    indiceNotasMaiores[1] = i;
                }
            }
            maior = 0;
            for (int i = 0; i < dgvPauta.RowCount; i++)
            {//==================== Terceiro ciclo descobre a terceira maior nota e guarda o indice no array =====================================
                if (Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) > maior && Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) < maior2)
                {
                    maior = Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value);
                    maior3 = maior;
                    if (maior3 == maior2)
                    {
                        indiceNotasMaiores[2] = i + 1;
                    }
                    else
                    {
                        indiceNotasMaiores[2] = i;
                    }
                }

            }
            //=== Limpa a lista para o caso de atualizações =========================================
            lstTresMelhores.Items.Clear();
            //=============== Preenche a listbox com os nomes dos melhores através do indices guardados no array ====================================
            lstTresMelhores.Items.Add("1 - " + Convert.ToString(dgvPauta.Rows[indiceNotasMaiores[0]].Cells[1].Value));
            lstTresMelhores.Items.Add("2 - " + Convert.ToString(dgvPauta.Rows[indiceNotasMaiores[1]].Cells[1].Value));
            lstTresMelhores.Items.Add("3 - " + Convert.ToString(dgvPauta.Rows[indiceNotasMaiores[2]].Cells[1].Value));
           
            
        }
        private void ProcessaAlteracao(int index, int index2)
        {
            // Capta o valor que foi alterado
            dgvPauta.Rows[index].Cells[index2].Value = dgvPauta.Rows[index].Cells[index2].Value;
            // Calcula a alteração e formata a grid
            CalcularMediaENegativas();
            FormatarGrid();
        }
        private void btnContarRaparigas_Click(object sender, EventArgs e)
        {
            ContaRaparigas();//Chamada do método usado para contar as raparigas
        }
        private void btnContaRapazesMaximinos_Click(object sender, EventArgs e)
        {
            ContaRapazesMaximinos();// Chamada do método usado para contar os rapazes de Maximinos
        }
        private void btnMaisRapazesOuRaparigas_Click(object sender, EventArgs e)
        {
            MaisRapazesOuRaparigas(); //Chamada do método que determina se existem mais rapazes ou raparigas
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MaisVelho(); //Chamada do método que descobre o mais velho
        }
        private void btnReprovadosComMediaMaiorQue12_Click(object sender, EventArgs e)
        {
            ReprovadosMediaMaiorQue12(); // Chamada do método usado para contar reprovados c/ média maior que 12
        }
        private void btnEncontra3Melhores_Click(object sender, EventArgs e)
        {
            Encontra3Melhores(); //Chamada do método que encontra os melhores alunos através da média
        }

        private void dgvPauta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == true) // Se a grid estiver preenchida
            {   //Capta os indices da posição alterada e passa-os como argumentos do método que processa a alteração
                int indice = e.RowIndex;
                int indice2 = e.ColumnIndex;
                ProcessaAlteracao(indice, indice2);
            }
        }

        private void dgvPauta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}