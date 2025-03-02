<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        ErrorProvider3 = New ErrorProvider(components)
        TextBox2 = New TextBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(399, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(574, 81)
        Label1.TabIndex = 0
        Label1.Text = "Currency Converter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(53, 246)
        Label2.Name = "Label2"
        Label2.Size = New Size(307, 38)
        Label2.TabIndex = 1
        Label2.Text = "Converting Amount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(533, 246)
        Label3.Name = "Label3"
        Label3.Size = New Size(306, 38)
        Label3.TabIndex = 2
        Label3.Text = "From this Currency"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(986, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(262, 38)
        Label4.TabIndex = 3
        Label4.Text = "To this Currency"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Mongolian Baiti", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(618, 429)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 40)
        Label5.TabIndex = 4
        Label5.Text = "Result"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(524, 329)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(289, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(986, 329)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(262, 28)
        ComboBox2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaption
        Button1.Location = New Point(603, 582)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 49)
        Button1.TabIndex = 7
        Button1.Text = "CONVERT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(62, 329)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(273, 27)
        TextBox1.TabIndex = 8
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' ErrorProvider3
        ' 
        ErrorProvider3.ContainerControl = Me
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(533, 506)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(280, 27)
        TextBox2.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1407, 762)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
End Class
