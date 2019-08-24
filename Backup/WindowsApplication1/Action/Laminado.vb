Module Laminado
    Public Sub CalcLam()
        Dim _valUnit As Double
        Dim _total As Double
        Dim valor1 As Double
        Dim valor2 As Double
        Dim _valor1 As String
        Dim _valor2 As String

        _valUnit = 50
        _valor1 = Orcamento.txtValor1.Text
        valor1 = CDbl(_valor1)
        _valor2 = Orcamento.txtValor2.Text
        valor2 = CDbl(_valor2)

        If (valor1 = 0 Or valor2 = 0 Or _valor1 = "" Or _valor2 = "") Then
            MsgBox("Favor verificar as medidas.")

        Else
            _total = ((valor1 * valor2) * _valUnit)
            MsgBox("O valor do orçamento será: R$" & _total)

        End If
    End Sub
End Module
