Public Class Orcamento

    Public Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        If chkMarmore.Checked = True And chkLaminado.Checked = False And chkQd.Checked = True Then
            Call Marmore.CalcMarm()

        ElseIf chkMarmore.Checked = False And chkLaminado.Checked = True And chkQd.Checked = True Then
            Call Laminado.CalcLam()

        ElseIf chkMarmore.Checked = False And chkLaminado.Checked = False And chkQd.Checked = True Then
            Call ErroOrc.Erro1()

        ElseIf chkMarmore.Checked = True And chkLaminado.Checked = True And chkQd.Checked = False Then
            Call ErroOrc.Erro2()

        ElseIf chkMarmore.Checked = True And chkLaminado.Checked = True And chkQd.Checked = True Then
            Call ErroOrc.Erro2()

        ElseIf chkMarmore.Checked = False And chkLaminado.Checked = False And chkQd.Checked = False Then
            Call ErroOrc.Erro3()

        ElseIf chkMarmore.Checked = False And chkLaminado.Checked = True And chkQd.Checked = False Then
            Call ErroOrc.Erro4()

        Else
            Call ErroOrc.Erro4()

        End If
    End Sub
End Class
