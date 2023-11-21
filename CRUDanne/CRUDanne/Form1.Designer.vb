<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.mtbCPF = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCEP = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCelular = New System.Windows.Forms.MaskedTextBox()
        Me.dtNascimento = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(168, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(278, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(379, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Data de Nascimento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(36, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Código"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(36, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nome"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(27, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Endereço"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(177, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Bairro"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(322, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "CEP"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(573, 211)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Cidade"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(436, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "UF"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(177, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Celular"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCodigo.Location = New System.Drawing.Point(12, 44)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 23)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNome.Location = New System.Drawing.Point(12, 150)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 23)
        Me.txtNome.TabIndex = 1
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEndereco.Location = New System.Drawing.Point(12, 231)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(100, 23)
        Me.txtEndereco.TabIndex = 1
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBairro.Location = New System.Drawing.Point(155, 231)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(100, 23)
        Me.txtBairro.TabIndex = 1
        '
        'txtCidade
        '
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCidade.Location = New System.Drawing.Point(549, 233)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(100, 23)
        Me.txtCidade.TabIndex = 1
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"F", "M"})
        Me.cbSexo.Location = New System.Drawing.Point(251, 44)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(106, 21)
        Me.cbSexo.TabIndex = 2
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cbEstado.Location = New System.Drawing.Point(409, 233)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(106, 21)
        Me.cbEstado.TabIndex = 2
        '
        'mtbCPF
        '
        Me.mtbCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.mtbCPF.Location = New System.Drawing.Point(133, 44)
        Me.mtbCPF.Mask = "000,000,000-00"
        Me.mtbCPF.Name = "mtbCPF"
        Me.mtbCPF.Size = New System.Drawing.Size(100, 23)
        Me.mtbCPF.TabIndex = 3
        '
        'mtbCEP
        '
        Me.mtbCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.mtbCEP.Location = New System.Drawing.Point(281, 231)
        Me.mtbCEP.Mask = "00,000-999"
        Me.mtbCEP.Name = "mtbCEP"
        Me.mtbCEP.Size = New System.Drawing.Size(100, 23)
        Me.mtbCEP.TabIndex = 3
        '
        'mtbCelular
        '
        Me.mtbCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.mtbCelular.Location = New System.Drawing.Point(155, 150)
        Me.mtbCelular.Mask = "(00) 00000-0000"
        Me.mtbCelular.Name = "mtbCelular"
        Me.mtbCelular.Size = New System.Drawing.Size(100, 23)
        Me.mtbCelular.TabIndex = 3
        '
        'dtNascimento
        '
        Me.dtNascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtNascimento.Location = New System.Drawing.Point(376, 47)
        Me.dtNascimento.Name = "dtNascimento"
        Me.dtNascimento.Size = New System.Drawing.Size(200, 23)
        Me.dtNascimento.TabIndex = 4
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(15, 323)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView.TabIndex = 5
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(701, 98)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(701, 130)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 6
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(701, 175)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 6
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(701, 211)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(75, 23)
        Me.btnExibir.TabIndex = 6
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(701, 240)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 547)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.dtNascimento)
        Me.Controls.Add(Me.mtbCelular)
        Me.Controls.Add(Me.mtbCEP)
        Me.Controls.Add(Me.mtbCPF)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Cadastro de Pessoas"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents mtbCPF As MaskedTextBox
    Friend WithEvents mtbCEP As MaskedTextBox
    Friend WithEvents mtbCelular As MaskedTextBox
    Friend WithEvents dtNascimento As DateTimePicker
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnExibir As Button
    Friend WithEvents btnCancelar As Button
End Class
