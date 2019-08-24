<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orcamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPiso = New System.Windows.Forms.Label
        Me.chkLaminado = New System.Windows.Forms.CheckBox
        Me.chkMarmore = New System.Windows.Forms.CheckBox
        Me.lblTipoPiso = New System.Windows.Forms.Label
        Me.chkQd = New System.Windows.Forms.CheckBox
        Me.txtValor1 = New System.Windows.Forms.TextBox
        Me.lblX = New System.Windows.Forms.Label
        Me.txtValor2 = New System.Windows.Forms.TextBox
        Me.btnCalc = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Location = New System.Drawing.Point(7, 9)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(123, 13)
        Me.lblPiso.TabIndex = 0
        Me.lblPiso.Text = "Selecione o tipo de piso:"
        '
        'chkLaminado
        '
        Me.chkLaminado.AutoSize = True
        Me.chkLaminado.Location = New System.Drawing.Point(11, 29)
        Me.chkLaminado.Name = "chkLaminado"
        Me.chkLaminado.Size = New System.Drawing.Size(72, 17)
        Me.chkLaminado.TabIndex = 1
        Me.chkLaminado.Text = "Laminado"
        Me.chkLaminado.UseVisualStyleBackColor = True
        '
        'chkMarmore
        '
        Me.chkMarmore.AutoSize = True
        Me.chkMarmore.Location = New System.Drawing.Point(121, 29)
        Me.chkMarmore.Name = "chkMarmore"
        Me.chkMarmore.Size = New System.Drawing.Size(67, 17)
        Me.chkMarmore.TabIndex = 2
        Me.chkMarmore.Text = "Marmore"
        Me.chkMarmore.UseVisualStyleBackColor = True
        '
        'lblTipoPiso
        '
        Me.lblTipoPiso.AutoSize = True
        Me.lblTipoPiso.Location = New System.Drawing.Point(8, 67)
        Me.lblTipoPiso.Name = "lblTipoPiso"
        Me.lblTipoPiso.Size = New System.Drawing.Size(69, 13)
        Me.lblTipoPiso.TabIndex = 3
        Me.lblTipoPiso.Text = "Tipo de Piso:"
        '
        'chkQd
        '
        Me.chkQd.AutoSize = True
        Me.chkQd.Location = New System.Drawing.Point(12, 86)
        Me.chkQd.Name = "chkQd"
        Me.chkQd.Size = New System.Drawing.Size(143, 17)
        Me.chkQd.TabIndex = 4
        Me.chkQd.Text = "Quadrado ou Retangulo:"
        Me.chkQd.UseVisualStyleBackColor = True
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(11, 109)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(101, 20)
        Me.txtValor1.TabIndex = 5
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(118, 112)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(12, 13)
        Me.lblX.TabIndex = 6
        Me.lblX.Text = "x"
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(136, 109)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(197, 226)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calcular"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Orcamento
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.chkQd)
        Me.Controls.Add(Me.lblTipoPiso)
        Me.Controls.Add(Me.chkMarmore)
        Me.Controls.Add(Me.chkLaminado)
        Me.Controls.Add(Me.lblPiso)
        Me.Name = "Orcamento"
        Me.Text = "Orçamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPiso As System.Windows.Forms.Label
    Friend WithEvents chkLaminado As System.Windows.Forms.CheckBox
    Friend WithEvents chkMarmore As System.Windows.Forms.CheckBox
    Friend WithEvents lblTipoPiso As System.Windows.Forms.Label
    Friend WithEvents chkQd As System.Windows.Forms.CheckBox
    Friend WithEvents txtValor1 As System.Windows.Forms.TextBox
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents txtValor2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
