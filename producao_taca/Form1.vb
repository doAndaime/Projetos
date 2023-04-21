Public Class Form1
    ''Declaração dos arrays usados para guardar o histórico do programa
    Public equipas4rtos(8), jogos4rtos(4), resultados4rtos(4), equipasMeias(4), jogosMeias(2), resultadosMeias(2), finalistas(2) As String

    ''Método para remover a substring clube do inicio da string jogo 
    Private Function fEncontraClube1(s As String) As String
        Dim clube1 As String
        Dim pos As Integer
        pos = s.IndexOf("-") - 1 ''subrai 1 para limpar o espaço
        clube1 = s.Substring(0, pos)
        Return clube1
    End Function
    Private Function fGeraJogo(ByVal listbox As ListBox)
        ''Declaração e inicialização das variáveis
        Dim clube1, clube2, jogo As String
        Dim n, pos1, pos2, equipas, i As Integer
        i = 0
        Dim r As Random = New Random
        Dim listaAleatoria As New List(Of Integer)()
        equipas = listbox.Items.Count ''Guarda o número de equipas da lista
        While listaAleatoria.Count < equipas ''===================Enquanto a lista de numeros aleatorios for menor q 8
            n = r.Next(0, equipas) ''===================Gera e adiciona a lista se não existir
            If Not listaAleatoria.Contains(n) Then
                listaAleatoria.Add(n)
            End If
        End While

        pos1 = listaAleatoria(i)
        pos2 = listaAleatoria(i + 1)
        clube1 = lstEquipasMeias.Items(pos1)
        clube2 = lstEquipasMeias.Items(pos2)
        jogo = clube1 & " - " & clube2
        lstJogosMeias.Items.Add(jogo)
        jogosMeias(lstJogosMeias.Items.Count - 1) = jogo
        lstEquipasMeias.Items.Remove(clube1)
        lstEquipasMeias.Items.Remove(clube2)
    End Function
    Private Function fEncontraClube2(s As String) As String
        ''Método para remover a substring clube do fim da string jogo 
        Dim clube2 As String
        Dim pos As Integer
        pos = s.IndexOf("-") + 2 ''adiciona para limpar os espaços
        clube2 = s.Substring(pos)
        Return clube2
    End Function
    Private Function fGeraJogosQuartos()
        Dim clube1, clube2, jogo As String
        Dim n, pos1, pos2 As Integer
        Dim r As Random = New Random
        Dim listaAleatoria As New List(Of Integer)()
        While listaAleatoria.Count < 8 'Enquanto a lista de numeros aleatorios for menor q 8
            n = r.Next(0, 8) 'Gera e adiciona a lista se não existir
            If Not listaAleatoria.Contains(n) Then
                listaAleatoria.Add(n)
            End If
        End While
        ''Monta a string do jogo dos quartos aleatoriamente com as equipas disponiveis e retira-as da lista dos oitavos 
        For index = 0 To 7
            pos1 = listaAleatoria(index)
            pos2 = listaAleatoria(index + 1)
            clube1 = lstQuartosFinal.Items(pos1)
            clube2 = lstQuartosFinal.Items(pos2)
            jogo = clube1 & " - " & clube2
            lstJogosQuartos.Items.Add(jogo)
            lstOitavosFinal.Items.Remove(clube1)
            lstOitavosFinal.Items.Remove(clube2)
            index += 1
        Next
        For index = 0 To 3
            jogos4rtos(index) = lstJogosQuartos.Items(index) ''Copia para o array para mostrar mais tarde no histórico
        Next
    End Function
    Private Function fGeraClubeAleatorio()
        Dim clube1, clube2 As String
        Dim pos, i As Integer
        Dim numerosAleatorios As New List(Of Integer)()
        Dim generator As System.Random = New System.Random()
        While numerosAleatorios.Count < 8
            pos = generator.Next(1, 16)
            If Not numerosAleatorios.Contains(pos) Then
                numerosAleatorios.Add(pos)
            End If
        End While
        If lstQuartosFinal.Items.Count = 0 Then
            For index = 0 To 7
                i = numerosAleatorios(index)
                clube1 = Form2.equipas(i)
                lstQuartosFinal.Items.Add(clube1)
                equipas4rtos(index) = clube1 ''Copia para o array"
                lstOitavosFinal.Items.Remove(clube1)
            Next
        End If
    End Function
    Private Sub btnFormCompleta_Click(sender As Object, e As EventArgs) Handles btnFormCompleta.Click
        ''Ao clicar faz aparecer o form usado para completar as equipas
        Form2.Visible = True
    End Sub

    Private Sub btnOitavosFinal_Click(sender As Object, e As EventArgs) Handles btnOitavosFinal.Click
        Dim cont As Integer
        Dim clube As String
        cont = Form2.equipas.Length - 1
        'Se a label ok estiver a vermelho e a lista estiver vazia adiciona clubes à lista
        If Form2.lblOk.ForeColor = Color.Red And lstOitavosFinal.Items.Count = 0 Then
            For index = 0 To cont - 1
                clube = Form2.equipas(index)
                lstOitavosFinal.Items.Add(clube)
            Next
            btnQuartosFinal.Enabled = True
            btnOitavosFinal.Enabled = False
        Else
            'Apenas para não acontecer nada
        End If
    End Sub

    Private Sub btnQuartosFinal_Click(sender As Object, e As EventArgs) Handles btnQuartosFinal.Click
        If lstOitavosFinal.Items.Count > 0 Then
            fGeraClubeAleatorio()
            btnOitavosFinal.Text = "Vencidos dos oitavos-de-final"
            btnQuartosFinal.Enabled = False
            btnSortearQuartos.Enabled = True
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstJogosQuartos.SelectedIndexChanged

    End Sub

    Private Sub btnSortearQuartos_Click(sender As Object, e As EventArgs) Handles btnSortearQuartos.Click
        fGeraJogosQuartos()
        ''Limpas as duas listas anteriores e dasbilita o butão
        lstOitavosFinal.Items.Clear()
        lstQuartosFinal.Items.Clear()
        btnSortearQuartos.Enabled = False
        btnResultadosQuartos.Enabled = True
    End Sub

    Private Sub btnHistorico_Click(sender As Object, e As EventArgs) Handles btnHistorico.Click
        ''Apresenta histórico apenas se a lista dos oitavos estiver vazia
        If lblVencedor.ForeColor = Color.Red Then
            ''Ciclo para apresentar o histórico das 16 equipas
            For index = 0 To 15
                lstOitavosFinal.Items.Add(Form2.equipas(index))
            Next
            ''Hisórico das equipas dos quartos
            For index = 0 To 7
                lstQuartosFinal.Items.Add(equipas4rtos(index))
            Next
            ''Histórico dos jogos e resultados dos quartos e equipas das meias
            For index = 0 To 3
                lstJogosQuartos.Items.Add(jogos4rtos(index))
                lstResultadosQuartos.Items.Add(resultados4rtos(index))
                lstEquipasMeias.Items.Add(equipasMeias(index))
            Next
            ''Historico dos jogos e resultados das meias e finalistas 
            For index = 0 To 1
                lstJogosMeias.Items.Add(jogosMeias(index))
                lstResultadosMeias.Items.Add(resultadosMeias(index))
                lstFinalistas.Items.Add(finalistas(index))
            Next
        Else

        End If

    End Sub

    Private Sub btnReiniciar_Click_1(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        If lstFinalistas.Items.Count > 0 Then
            btnOitavosFinal.Enabled = True
            btnOitavosFinal.Text = "Lista de equipas nos oitavos-de-final"
            lstOitavosFinal.Items.Clear()
            lstQuartosFinal.Items.Clear()
            lstJogosQuartos.Items.Clear()
            lstResultadosQuartos.Items.Clear()
            lstEquipasMeias.Items.Clear()
            lstJogosMeias.Items.Clear()
            lstResultadosMeias.Items.Clear()
            lstFinalistas.Items.Clear()
            lstResultadoFinal.Items.Clear()
            txtVencedor.Text = " "
            lblVencedor.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnResultadosQuartos_Click(sender As Object, e As EventArgs) Handles btnResultadosQuartos.Click
        Dim r1, r2, pos As Integer
        Dim clube1, clube2, jogo, resultado As String
        Dim r As Random = New Random
        ''Ciclo para gerar resultados entre 0 e 4 com obrigação de serem diferentes
        Do
            r1 = r.Next(0, 4)
            r2 = r.Next(0, 4)
        Loop While r1 = r2
        'A cada jogo separa as strings do mesmo e adiciona na frente o respetivo resultado
        jogo = lstJogosQuartos.Items(0)
        clube1 = fEncontraClube1(jogo)
        clube2 = fEncontraClube2(jogo)
        resultado = clube1 & " " & r1 & " - " & clube2 & " " & r2
        'Remove a string da lista jogos e adiciona a lista dos resultados
        lstResultadosQuartos.Items.Add(resultado)
        pos = lstResultadosQuartos.Items.Count - 1
        resultados4rtos(pos) = resultado ''Adiciona o resultado ao array a usar no histórico
        lstJogosQuartos.Items.Remove(jogo)
        'Quando a lista fica vazia butão é desabilitado
        If lstJogosQuartos.Items.Count = 0 Then
            btnResultadosQuartos.Enabled = False
            btnEquipasMeias.Enabled = True
        End If
    End Sub

    Private Sub btnEquipasMeias_Click(sender As Object, e As EventArgs) Handles btnEquipasMeias.Click
        ''Declaração das variáveis a usar
        Dim r1, r2, pos1, pos2 As Integer
        Dim clube1, clube2, jogo, vencedor As String
        jogo = lstResultadosQuartos.Items(0) ''String da primeira posicao da lista resultados
        ''Separa cada um dos clubes com o resultado
        clube1 = fEncontraClube1(jogo)
        clube2 = fEncontraClube2(jogo)
        ''Separa os resultados de cada um dos clubes e converte para inteiros para comparar
        pos1 = clube1.Length - 1
        pos2 = clube2.Length - 1
        r1 = CInt(clube1.Substring(pos1))
        r2 = CInt(clube2.Substring(pos2))
        If r1 > r2 Then ''Compara os resultados obtidos da string
            vencedor = clube1.Substring(0, pos1)
            lstEquipasMeias.Items.Add(vencedor)
            equipasMeias(lstEquipasMeias.Items.Count - 1) = vencedor
            lstResultadosQuartos.Items.Remove(jogo)
        Else
            vencedor = clube2.Substring(0, pos2)
            lstEquipasMeias.Items.Add(vencedor)
            equipasMeias(lstEquipasMeias.Items.Count - 1) = vencedor
            lstResultadosQuartos.Items.Remove(jogo)
        End If
        If lstResultadosQuartos.Items.Count = 0 Then
            btnEquipasMeias.Enabled = False '' Desabilita o butão quando a lista acaba
            btnSortearMeias.Enabled = True '' Habilita o proximo
        End If
    End Sub

    Private Sub btnSortearMeias_Click(sender As Object, e As EventArgs) Handles btnSortearMeias.Click
        fGeraJogo(lstEquipasMeias)
        If lstEquipasMeias.Items.Count = 0 Then
            btnSortearMeias.Enabled = False
            btnResultadosMeias.Enabled = True
        End If
    End Sub

    Private Sub btnResultadosMeias_Click(sender As Object, e As EventArgs) Handles btnResultadosMeias.Click
        Dim r1, r2 As Integer
        Dim clube1, clube2, jogo, resultado As String
        Dim r As Random = New Random
        ''Ciclo para gerar resultados entre 0 e 4 com obrigação de serem diferentes
        Do
            r1 = r.Next(0, 4)
            r2 = r.Next(0, 4)
        Loop While r1 = r2
        'A cada jogo separa as strings do mesmo e adiciona na frente o respetivo resultado
        jogo = lstJogosMeias.Items(0)
        clube1 = fEncontraClube1(jogo)
        clube2 = fEncontraClube2(jogo)
        resultado = clube1 & " " & r1 & " - " & clube2 & " " & r2
        'Remove a string da lista jogos e adiciona a lista dos resultados
        lstResultadosMeias.Items.Add(resultado)
        resultadosMeias(lstResultadosMeias.Items.Count - 1) = resultado
        lstJogosMeias.Items.Remove(jogo)
        'Quando a lista fica vazia butão é desabilitado
        If lstJogosMeias.Items.Count = 0 Then
            btnResultadosMeias.Enabled = False
            btnFinalistas.Enabled = True
        End If
    End Sub

    Private Sub btnFinalistas_Click(sender As Object, e As EventArgs) Handles btnFinalistas.Click
        Dim r1, r2, pos1, pos2 As Integer
        Dim clube1, clube2, jogo, vencedor As String
        jogo = lstResultadosMeias.Items(0) ''String da primeira posicao da lista resultados
        ''Separa cada um dos clubes com o resultado
        clube1 = fEncontraClube1(jogo)
        clube2 = fEncontraClube2(jogo)
        ''Separa os resultados de cada um dos clubes e converte para inteiros para comparar
        pos1 = clube1.Length - 1
        pos2 = clube2.Length - 1
        r1 = CInt(clube1.Substring(pos1))
        r2 = CInt(clube2.Substring(pos2))
        If r1 > r2 Then ''Compara os resultados obtidos da string
            vencedor = clube1.Substring(0, pos1)
            lstFinalistas.Items.Add(vencedor) ''Adiciona o vencedor à lista dos mesmos
            finalistas(lstFinalistas.Items.Count - 1) = vencedor ''Adiciona o vencedor ao array dos mesmos para mostrar no histórico
            lstResultadosMeias.Items.Remove(jogo) '' Remove o jogo da lista de resultados das meias
        Else
            vencedor = clube2.Substring(0, pos2)
            lstFinalistas.Items.Add(vencedor) ''Adiciona o vencedor à lista dos mesmos
            finalistas(lstFinalistas.Items.Count - 1) = vencedor ''Adiciona o vencedor ao array dos mesmos para mostrar no histórico
            lstResultadosMeias.Items.Remove(jogo) '' Remove o jogo da lista de resultados das meias
        End If
        If lstResultadosMeias.Items.Count = 0 Then
            btnFinalistas.Enabled = False '' Desabilita o butão quando a lista acaba
            btnResultadoFinal.Enabled = True '' Habilita o proximo
        End If
    End Sub

    Private Sub btnResultadoFinal_Click(sender As Object, e As EventArgs) Handles btnResultadoFinal.Click
        ''Declaração das variáveis a usar e instanciação de um objeto da classe random
        Dim r1, r2 As Integer
        Dim clube1, clube2, vencedor, resultado As String
        Dim r As Random = New Random
        ''Ciclo para gerar resultados entre 0 e 4 com obrigação de serem diferentes
        Do
            r1 = r.Next(0, 4)
            r2 = r.Next(0, 4)
        Loop While r1 = r2
        'A cada jogo separa as strings do mesmo e adiciona na frente o respetivo resultado
        clube1 = lstFinalistas.Items(0)
        clube2 = lstFinalistas.Items(1)
        resultado = clube1 & " " & r1 & " - " & clube2 & " " & r2
        If r1 > r2 Then
            'txtVencedor.Text = clube1
            vencedor = clube1
        Else
            'txtVencedor.Text = clube2
            vencedor = clube2
        End If
        'Remove a string da lista jogos e adiciona a lista dos resultados
        lstResultadoFinal.Items.Add(resultado)
        lstFinalistas.Items.Remove(clube1)
        lstFinalistas.Items.Remove(clube2)
        'Quando a lista fica vazia butão é desabilitado
        If lstFinalistas.Items.Count = 0 Then
            btnResultadoFinal.Enabled = False
            lblVencedor.ForeColor = Color.Red
            txtVencedor.Text = vencedor
        End If
    End Sub
End Class
