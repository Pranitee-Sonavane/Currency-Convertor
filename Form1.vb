
Imports System.Text.RegularExpressions
Public Class Form1

    Dim check As Regex = New Regex("[^a-zA-Z]")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Rupees [INDIAN]")
        ComboBox1.Items.Add("Dollar [US]")
        ComboBox1.Items.Add("Pound [BRITISH]")
        ComboBox1.Items.Add("Euro [EUROPEAN]")
        ComboBox1.Items.Add("Yen [JAPANESE]")
        ComboBox1.Items.Add("Rand [SOUTH AFRICAN]")
        ComboBox2.Items.Add("Rupees [INDIAN]")
        ComboBox2.Items.Add("Dollar [US]")
        ComboBox2.Items.Add("Pound [BRITISH]")
        ComboBox2.Items.Add("Euro [EUROPEAN]")
        ComboBox2.Items.Add("Yen [JAPANESE]")
        ComboBox2.Items.Add("Rand [SOUTH AFRICAN]")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = ("Rupees [INDIAN]") And
        ComboBox2.SelectedItem = ("Dollar [US]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.0129
        ElseIf ComboBox1.SelectedItem = ("Rupees [INDIAN]") And
         ComboBox2.SelectedItem = ("Pound [BRITISH]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.010342
        ElseIf ComboBox1.SelectedItem = ("Rupees [INDIAN]") And
          ComboBox2.SelectedItem = ("Euro [EUROPEAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.01225
        ElseIf ComboBox1.SelectedItem = ("Rupees [INDIAN]") And
          ComboBox2.SelectedItem = ("Yen [JAPANESE]") Then
            TextBox2.Text = Val(TextBox1.Text) * 1.66567
        ElseIf ComboBox1.SelectedItem = ("Rupees [INDIAN]") And
          ComboBox2.SelectedItem = ("Rand [SOUTH AFRICAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.20576
        ElseIf ComboBox1.SelectedItem = ("Dollar [US]") And ComboBox2.SelectedItem =
("Rupees [INDIAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 77.5505
        ElseIf ComboBox1.SelectedItem = ("Dollar [US]") And ComboBox2.SelectedItem =
("Pound [BRITISH]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.80337
        ElseIf ComboBox1.SelectedItem = ("Dollar [US]") And ComboBox2.SelectedItem =
("Euro [EUROPEAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.9504
        ElseIf ComboBox1.SelectedItem = ("Dollar [US]") And ComboBox2.SelectedItem =
("Yen [JAPANESE]") Then
            TextBox2.Text = Val(TextBox1.Text) * 129.235
        ElseIf ComboBox1.SelectedItem = ("Dollar [US]") And ComboBox2.SelectedItem =
("Rand [SOUTH AFRICAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 15.9776
        ElseIf ComboBox1.SelectedItem = ("Pound [BRITISH]") And
ComboBox2.SelectedItem = ("Rupees [INDIAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 96.4594
        ElseIf ComboBox1.SelectedItem = ("Pound [BRITISH]") And
ComboBox2.SelectedItem = ("Dollar [US]") Then
            TextBox2.Text = Val(TextBox1.Text) * 1.2425
        ElseIf ComboBox1.SelectedItem = ("Pound [BRITISH]") And
ComboBox2.SelectedItem = ("Euro [EUROPEAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 1.18078
        ElseIf ComboBox1.SelectedItem = ("Pound [BRITISH]") And
ComboBox2.SelectedItem = ("Yen [JAPANESE]") Then
            TextBox2.Text = Val(TextBox1.Text) * 160.442
        ElseIf ComboBox1.SelectedItem = ("Pound [BRITISH]") And
ComboBox2.SelectedItem = ("Rand [SOUTH AFRICAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 19.8678
        ElseIf ComboBox1.SelectedItem = ("Euro [EUROPEAN]") And
ComboBox2.SelectedItem = ("Rupees [INDIAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 81.5923
        ElseIf ComboBox1.SelectedItem = ("Euro [EUROPEAN]") And
ComboBox2.SelectedItem = ("Dollar [US]") Then
            TextBox2.Text = Val(TextBox1.Text) * 1.0519
        ElseIf ComboBox1.SelectedItem = ("Euro [EUROPEAN]") And
ComboBox2.SelectedItem = ("Pound [BRITISH]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.8465
        ElseIf ComboBox1.SelectedItem = ("Euro [EUROPEAN]") And
ComboBox2.SelectedItem = ("Yen [JAPANESE]") Then
            TextBox2.Text = Val(TextBox1.Text) * 135.93
        ElseIf ComboBox1.SelectedItem = ("Euro [EUROPEAN]") And
ComboBox2.SelectedItem = ("Rand [SOUTH AFRICAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 16.8252
        ElseIf ComboBox1.SelectedItem = ("Yen [JAPANESE]") And
ComboBox2.SelectedItem = ("Rupees [INDIAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.60032
        ElseIf ComboBox1.SelectedItem = ("Yen [JAPANESE]") And
ComboBox2.SelectedItem = ("Dollar [US]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.00774
        ElseIf ComboBox1.SelectedItem = ("Yen [JAPANESE]") And
ComboBox2.SelectedItem = ("Pound [BRITISH]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.00624
        ElseIf ComboBox1.SelectedItem = ("Yen [JAPANESE]") And
ComboBox2.SelectedItem = ("Euro [EUROPEAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.00736
        ElseIf ComboBox1.SelectedItem = ("Yen [JAPANESE]") And
ComboBox2.SelectedItem = ("Rand [SOUTH AFRICAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.1237
        ElseIf ComboBox1.SelectedItem = ("Rand [SOUTH AFRICAN]") And
ComboBox2.SelectedItem = ("Rupees [INDIAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 4.85139
        ElseIf ComboBox1.SelectedItem = ("Rand [SOUTH AFRICAN]") And
ComboBox2.SelectedItem = ("Dollar [US]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.06255
        ElseIf ComboBox1.SelectedItem = ("Rand [SOUTH AFRICAN]") And
ComboBox2.SelectedItem = ("Pound [BRITISH]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.0504
        ElseIf ComboBox1.SelectedItem = ("Rand [SOUTH AFRICAN]") And
ComboBox2.SelectedItem = ("Euro [EUROPEAN]") Then
            TextBox2.Text = Val(TextBox1.Text) * 0.05944
        ElseIf ComboBox1.SelectedItem = ("Rand [SOUTH AFRICAN]") And
ComboBox2.SelectedItem = ("Yen [JAPANESE]") Then
            TextBox2.Text = Val(TextBox1.Text) * 8.08656
        End If
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Cannot leave textbox blank")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If
        If ComboBox1.SelectedItem = ComboBox2.SelectedItem Then
            ErrorProvider2.SetError(ComboBox2, "Values should be different")
        End If
        Dim R As New Regex("^ [a-zA-Z]")
        If R.IsMatch(TextBox1.Text) Then
            ErrorProvider3.SetError(TextBox1, "Cannot enter String")
        End If
    End Sub
End Class
