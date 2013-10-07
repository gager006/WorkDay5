Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim x As Double
        x = CDbl(txtSideOne.Text)
        Dim y As Double
        y = CDbl(txtSideTwo.Text)
        Dim z As Double
        z = hypotenuse(x, y)
        txtHyp.Text = CStr(z)
    End Sub
    Function hypotenuse(ByVal num1 As Double, num2 As Double) As Double
        Dim c As Double
        c = Math.Sqrt(num1 ^ 2 + num2 ^ 2)
        Return c


    End Function

End Class
