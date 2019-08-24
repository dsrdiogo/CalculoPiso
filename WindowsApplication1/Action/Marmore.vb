Module Marmore
    Public Sub CalcMarm()
        Dim _valUnit As Double
        Dim _total As Double
        Dim _valor1 As Double
        Dim _valor2 As Double

        If IsNumeric(Orcamento.txtValUnit.Text) Then
            If IsNumeric(Orcamento.txtValor1.Text) Then
                If IsNumeric(Orcamento.txtValor2.Text) Then

                    _valUnit = Orcamento.txtValUnit.Text
                    _valor1 = Orcamento.txtValor1.Text
                    _valor2 = Orcamento.txtValor2.Text

                    _total = ((_valor1 * _valor2) * _valUnit)
                    MsgBox("O valor do orçamento será: R$" & _total)

                Else
                    Call ErroOrc.Erro6()
                End If

            Else
                Call ErroOrc.Erro6()
            End If

        Else
            Call ErroOrc.Erro5()
        End If

    End Sub
End Module
