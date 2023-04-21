Public Class Form2
    Public equipas(16) As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adiciona os 29 clubes à lista associada na abertura do form
        lstTodasEquipas.Items.Add("Porto")
        lstTodasEquipas.Items.Add("Estoril")
        lstTodasEquipas.Items.Add("Benfica")
        lstTodasEquipas.Items.Add("Sporting")
        lstTodasEquipas.Items.Add("Braga")
        lstTodasEquipas.Items.Add("Santa Clara")
        lstTodasEquipas.Items.Add("Feirense")
        lstTodasEquipas.Items.Add("Boavista")
        lstTodasEquipas.Items.Add("Paços de Ferreira")
        lstTodasEquipas.Items.Add("Moreirense")
        lstTodasEquipas.Items.Add("Belenenses")
        lstTodasEquipas.Items.Add("Tondela")
        lstTodasEquipas.Items.Add("Académica")
        lstTodasEquipas.Items.Add("Varzim")
        lstTodasEquipas.Items.Add("Vizela")
        lstTodasEquipas.Items.Add("Farense")
        lstTodasEquipas.Items.Add("Freamunde")
        lstTodasEquipas.Items.Add("Aves")
        lstTodasEquipas.Items.Add("Amares")
        lstTodasEquipas.Items.Add("Olhanense")
        lstTodasEquipas.Items.Add("Leiria")
        lstTodasEquipas.Items.Add("Vianense")
        lstTodasEquipas.Items.Add("Fafe")
        lstTodasEquipas.Items.Add("Covilhã")
        lstTodasEquipas.Items.Add("Portimonense")
        lstTodasEquipas.Items.Add("Salgueiros")
        lstTodasEquipas.Items.Add("Oriental")
        lstTodasEquipas.Items.Add("Atlético")
        lstTodasEquipas.Items.Add("Barreirense")
        'Actualiza caixa de texto dos total
        txtTotalEquipas.Text = lstTodasEquipas.Items.Count
    End Sub
    Private Sub lstTodasEquipas_Click(sender As Object, e As EventArgs) Handles lstTodasEquipas.Click
        ''Declaro var clube q recebe o clube ao ser clicado na lista, remove da mesma
        ''e adiciona à lista a enviar
        Dim clube As String
        clube = lstTodasEquipas.SelectedItem
        lstEquipasOitavos.Items.Add(clube)
        lstTodasEquipas.Items.Remove(clube)
        ''Caixas com os totais são atualizadas
        txtTotalEquipas.Text = lstTodasEquipas.Items.Count
        txtTotal.Text = lstEquipasOitavos.Items.Count
        txtFaltam.Text = 16 - lstEquipasOitavos.Items.Count
    End Sub
    Private Sub lstEquipasOitacos_Click(sender As Object, e As EventArgs) Handles lstEquipasOitavos.Click
        'Declaro a var clube q recebe a string da lista ao ser selecionada, remove da mesma
        'e adiciona de volta à lista completa
        Dim clube As String
        clube = lstEquipasOitavos.SelectedItem
        lstEquipasOitavos.Items.Remove(clube)
        lstTodasEquipas.Items.Add(clube)
        'Atualiza caixas de texto com os totais
        txtTotalEquipas.Text = lstTodasEquipas.Items.Count
        txtTotal.Text = lstEquipasOitavos.Items.Count
        txtFaltam.Text = 16 - lstEquipasOitavos.Items.Count
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dim contador As Integer
        Dim clube As String
        contador = lstEquipasOitavos.Items.Count
        If contador = 16 Then
            For index = 0 To 15
                clube = lstEquipasOitavos.Items(index)
                equipas(index) = clube
            Next
        End If
        Form1.Visible = True 'Faz aparecer form principal
        Me.Visible = False
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        Dim cont As Integer
        cont = CInt(txtTotal.Text)
        If cont = 16 Then
            lblOk.ForeColor = Color.Red
            lblKo.ForeColor = Color.Black
        Else
            lblOk.ForeColor = Color.Black
            lblKo.ForeColor = Color.Red
        End If
    End Sub
End Class