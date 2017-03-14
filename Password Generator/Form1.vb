Public Class Form1
    Dim pNum As New Random(100)
    Dim pLowerCase As New Random(500)
    Dim pUpperCase As New Random(50)
    Dim password As String
    Dim RandomSelect As New Random(50)

    Public Function getPassword(ByVal passLength As Integer, Optional ByVal Reset As Boolean = False) As String
        Dim i As Integer
        Dim ctr(2) As Integer
        Dim charSelect(2) As String
        Dim iSel As Integer
        If Reset = True Then
            password = ""
        End If
        For i = 1 To passLength
            ctr(0) = pNum.Next(48, 57)
            ctr(1) = pLowerCase.Next(65, 90)
            ctr(2) = pUpperCase.Next(97, 122)
            charSelect(0) = System.Convert.ToChar(ctr(0)).ToString
            charSelect(1) = System.Convert.ToChar(ctr(1)).ToString
            charSelect(2) = System.Convert.ToChar(ctr(2)).ToString
            iSel = RandomSelect.Next(0, 3)
            password &= charSelect(iSel)
            If Reset = True Then
                password.Replace(password, charSelect(iSel))
            End If
        Next
        Return password

    End Function

    Private Sub BunifuRating1_onValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim j As Integer
        For j = 1 To NumericUpDown1.Value
            lbPasswordlist.Items.Add(getPassword(NumericUpDown2.Value, True))
        Next
        Label1.Text = "Sucessfuly Generated : " & lbPasswordlist.Items.Count & " Passwords!"
        lbPasswordlist.SelectedIndex = lbPasswordlist.Items.Count - 1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbPasswordlist.Items.Clear()
    End Sub
End Class

