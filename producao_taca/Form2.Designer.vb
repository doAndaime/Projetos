<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTodasEquipas = New System.Windows.Forms.Label()
        Me.lstTodasEquipas = New System.Windows.Forms.ListBox()
        Me.lblTotalEquipas = New System.Windows.Forms.Label()
        Me.txtTotalEquipas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstEquipasOitavos = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFaltam = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtFaltam = New System.Windows.Forms.TextBox()
        Me.lblOk = New System.Windows.Forms.Label()
        Me.lblKo = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTodasEquipas
        '
        Me.lblTodasEquipas.AutoSize = True
        Me.lblTodasEquipas.Location = New System.Drawing.Point(98, 30)
        Me.lblTodasEquipas.Name = "lblTodasEquipas"
        Me.lblTodasEquipas.Size = New System.Drawing.Size(95, 15)
        Me.lblTodasEquipas.TabIndex = 0
        Me.lblTodasEquipas.Text = "Todas as equipas"
        '
        'lstTodasEquipas
        '
        Me.lstTodasEquipas.FormattingEnabled = True
        Me.lstTodasEquipas.ItemHeight = 15
        Me.lstTodasEquipas.Location = New System.Drawing.Point(98, 48)
        Me.lstTodasEquipas.Name = "lstTodasEquipas"
        Me.lstTodasEquipas.Size = New System.Drawing.Size(120, 364)
        Me.lstTodasEquipas.TabIndex = 1
        '
        'lblTotalEquipas
        '
        Me.lblTotalEquipas.AutoSize = True
        Me.lblTotalEquipas.Location = New System.Drawing.Point(98, 429)
        Me.lblTotalEquipas.Name = "lblTotalEquipas"
        Me.lblTotalEquipas.Size = New System.Drawing.Size(121, 15)
        Me.lblTotalEquipas.TabIndex = 2
        Me.lblTotalEquipas.Text = "Nº de equipas na lista"
        '
        'txtTotalEquipas
        '
        Me.txtTotalEquipas.Location = New System.Drawing.Point(98, 456)
        Me.txtTotalEquipas.Name = "txtTotalEquipas"
        Me.txtTotalEquipas.Size = New System.Drawing.Size(120, 23)
        Me.txtTotalEquipas.TabIndex = 3
        Me.txtTotalEquipas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Equipas para os oitavos"
        '
        'lstEquipasOitavos
        '
        Me.lstEquipasOitavos.FormattingEnabled = True
        Me.lstEquipasOitavos.ItemHeight = 15
        Me.lstEquipasOitavos.Location = New System.Drawing.Point(407, 48)
        Me.lstEquipasOitavos.Name = "lstEquipasOitavos"
        Me.lstEquipasOitavos.Size = New System.Drawing.Size(130, 229)
        Me.lstEquipasOitavos.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(407, 293)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(124, 15)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Nº de equipas na lista:"
        '
        'lblFaltam
        '
        Me.lblFaltam.AutoSize = True
        Me.lblFaltam.Location = New System.Drawing.Point(407, 337)
        Me.lblFaltam.Name = "lblFaltam"
        Me.lblFaltam.Size = New System.Drawing.Size(46, 15)
        Me.lblFaltam.TabIndex = 7
        Me.lblFaltam.Text = "Faltam:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(407, 311)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(130, 23)
        Me.txtTotal.TabIndex = 8
        '
        'txtFaltam
        '
        Me.txtFaltam.Location = New System.Drawing.Point(407, 355)
        Me.txtFaltam.Name = "txtFaltam"
        Me.txtFaltam.Size = New System.Drawing.Size(130, 23)
        Me.txtFaltam.TabIndex = 9
        '
        'lblOk
        '
        Me.lblOk.AutoSize = True
        Me.lblOk.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOk.Location = New System.Drawing.Point(417, 394)
        Me.lblOk.Name = "lblOk"
        Me.lblOk.Size = New System.Drawing.Size(54, 25)
        Me.lblOk.TabIndex = 10
        Me.lblOk.Text = "OK  /"
        '
        'lblKo
        '
        Me.lblKo.AutoSize = True
        Me.lblKo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblKo.Location = New System.Drawing.Point(475, 394)
        Me.lblKo.Name = "lblKo"
        Me.lblKo.Size = New System.Drawing.Size(50, 25)
        Me.lblKo.TabIndex = 11
        Me.lblKo.Text = "KO ?"
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(407, 440)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(130, 38)
        Me.btnFechar.TabIndex = 12
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 507)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.lblKo)
        Me.Controls.Add(Me.lblOk)
        Me.Controls.Add(Me.txtFaltam)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblFaltam)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstEquipasOitavos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalEquipas)
        Me.Controls.Add(Me.lblTotalEquipas)
        Me.Controls.Add(Me.lstTodasEquipas)
        Me.Controls.Add(Me.lblTodasEquipas)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTodasEquipas As Label
    Friend WithEvents lstTodasEquipas As ListBox
    Friend WithEvents lblTotalEquipas As Label
    Friend WithEvents txtTotalEquipas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstEquipasOitavos As ListBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblFaltam As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtFaltam As TextBox
    Friend WithEvents lblOk As Label
    Friend WithEvents lblKo As Label
    Friend WithEvents btnFechar As Button
End Class
