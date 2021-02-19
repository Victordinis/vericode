<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.gbArquivoEntrada = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtArquivoEntrada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtProcessar = New System.Windows.Forms.Button()
        Me.txtDiretorioSaida = New System.Windows.Forms.Button()
        Me.txtSaida = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDadosValidacao = New System.Windows.Forms.GroupBox()
        Me.lbl6Paginas = New System.Windows.Forms.LinkLabel()
        Me.lbl12Paginas = New System.Windows.Forms.LinkLabel()
        Me.lblAcima = New System.Windows.Forms.LinkLabel()
        Me.labelAcima = New System.Windows.Forms.Label()
        Me.label12Paginas = New System.Windows.Forms.Label()
        Me.label6Paginas = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.labelZerados = New System.Windows.Forms.Label()
        Me.lblZerados = New System.Windows.Forms.LinkLabel()
        Me.labelCep = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.LinkLabel()
        Me.gbArquivoEntrada.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDadosValidacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbArquivoEntrada
        '
        Me.gbArquivoEntrada.AutoSize = True
        Me.gbArquivoEntrada.Controls.Add(Me.Button1)
        Me.gbArquivoEntrada.Controls.Add(Me.txtArquivoEntrada)
        Me.gbArquivoEntrada.Controls.Add(Me.Label1)
        Me.gbArquivoEntrada.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbArquivoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbArquivoEntrada.Location = New System.Drawing.Point(0, 0)
        Me.gbArquivoEntrada.Name = "gbArquivoEntrada"
        Me.gbArquivoEntrada.Size = New System.Drawing.Size(800, 99)
        Me.gbArquivoEntrada.TabIndex = 0
        Me.gbArquivoEntrada.TabStop = False
        Me.gbArquivoEntrada.Text = "Arquivo de entrada"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(327, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtArquivoEntrada
        '
        Me.txtArquivoEntrada.Location = New System.Drawing.Point(15, 55)
        Me.txtArquivoEntrada.Name = "txtArquivoEntrada"
        Me.txtArquivoEntrada.Size = New System.Drawing.Size(306, 22)
        Me.txtArquivoEntrada.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escolher arquivo"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.txtProcessar)
        Me.GroupBox1.Controls.Add(Me.txtDiretorioSaida)
        Me.GroupBox1.Controls.Add(Me.txtSaida)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 140)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diretório de saída"
        '
        'txtProcessar
        '
        Me.txtProcessar.Location = New System.Drawing.Point(15, 96)
        Me.txtProcessar.Name = "txtProcessar"
        Me.txtProcessar.Size = New System.Drawing.Size(87, 23)
        Me.txtProcessar.TabIndex = 6
        Me.txtProcessar.Text = "Processar"
        Me.txtProcessar.UseVisualStyleBackColor = True
        '
        'txtDiretorioSaida
        '
        Me.txtDiretorioSaida.Location = New System.Drawing.Point(327, 48)
        Me.txtDiretorioSaida.Name = "txtDiretorioSaida"
        Me.txtDiretorioSaida.Size = New System.Drawing.Size(31, 23)
        Me.txtDiretorioSaida.TabIndex = 5
        Me.txtDiretorioSaida.Text = "..."
        Me.txtDiretorioSaida.UseVisualStyleBackColor = True
        '
        'txtSaida
        '
        Me.txtSaida.Location = New System.Drawing.Point(15, 48)
        Me.txtSaida.Name = "txtSaida"
        Me.txtSaida.Size = New System.Drawing.Size(306, 22)
        Me.txtSaida.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Escolher diretório"
        '
        'gbDadosValidacao
        '
        Me.gbDadosValidacao.AutoSize = True
        Me.gbDadosValidacao.Controls.Add(Me.labelZerados)
        Me.gbDadosValidacao.Controls.Add(Me.lblZerados)
        Me.gbDadosValidacao.Controls.Add(Me.labelCep)
        Me.gbDadosValidacao.Controls.Add(Me.lblCep)
        Me.gbDadosValidacao.Controls.Add(Me.lbl6Paginas)
        Me.gbDadosValidacao.Controls.Add(Me.lbl12Paginas)
        Me.gbDadosValidacao.Controls.Add(Me.lblAcima)
        Me.gbDadosValidacao.Controls.Add(Me.labelAcima)
        Me.gbDadosValidacao.Controls.Add(Me.label12Paginas)
        Me.gbDadosValidacao.Controls.Add(Me.label6Paginas)
        Me.gbDadosValidacao.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbDadosValidacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDadosValidacao.Location = New System.Drawing.Point(0, 239)
        Me.gbDadosValidacao.Name = "gbDadosValidacao"
        Me.gbDadosValidacao.Size = New System.Drawing.Size(800, 120)
        Me.gbDadosValidacao.TabIndex = 4
        Me.gbDadosValidacao.TabStop = False
        Me.gbDadosValidacao.Text = "Dados validação"
        '
        'lbl6Paginas
        '
        Me.lbl6Paginas.AutoSize = True
        Me.lbl6Paginas.Location = New System.Drawing.Point(12, 86)
        Me.lbl6Paginas.Name = "lbl6Paginas"
        Me.lbl6Paginas.Size = New System.Drawing.Size(67, 16)
        Me.lbl6Paginas.TabIndex = 7
        Me.lbl6Paginas.TabStop = True
        Me.lbl6Paginas.Text = "6 páginas"
        '
        'lbl12Paginas
        '
        Me.lbl12Paginas.AutoSize = True
        Me.lbl12Paginas.Location = New System.Drawing.Point(133, 86)
        Me.lbl12Paginas.Name = "lbl12Paginas"
        Me.lbl12Paginas.Size = New System.Drawing.Size(74, 16)
        Me.lbl12Paginas.TabIndex = 6
        Me.lbl12Paginas.TabStop = True
        Me.lbl12Paginas.Text = "12 páginas"
        '
        'lblAcima
        '
        Me.lblAcima.AutoSize = True
        Me.lblAcima.Location = New System.Drawing.Point(277, 86)
        Me.lblAcima.Name = "lblAcima"
        Me.lblAcima.Size = New System.Drawing.Size(84, 16)
        Me.lblAcima.TabIndex = 5
        Me.lblAcima.TabStop = True
        Me.lblAcima.Text = "+ 12 páginas"
        '
        'labelAcima
        '
        Me.labelAcima.AutoSize = True
        Me.labelAcima.Location = New System.Drawing.Point(277, 53)
        Me.labelAcima.Name = "labelAcima"
        Me.labelAcima.Size = New System.Drawing.Size(134, 16)
        Me.labelAcima.TabIndex = 4
        Me.labelAcima.Text = "Acima de 12 páginas"
        '
        'label12Paginas
        '
        Me.label12Paginas.AutoSize = True
        Me.label12Paginas.Location = New System.Drawing.Point(133, 53)
        Me.label12Paginas.Name = "label12Paginas"
        Me.label12Paginas.Size = New System.Drawing.Size(97, 16)
        Me.label12Paginas.TabIndex = 3
        Me.label12Paginas.Text = "Até 12 páginas"
        '
        'label6Paginas
        '
        Me.label6Paginas.AutoSize = True
        Me.label6Paginas.Location = New System.Drawing.Point(12, 50)
        Me.label6Paginas.Name = "label6Paginas"
        Me.label6Paginas.Size = New System.Drawing.Size(90, 16)
        Me.label6Paginas.TabIndex = 0
        Me.label6Paginas.Text = "Até 6 páginas"
        '
        'labelZerados
        '
        Me.labelZerados.AutoSize = True
        Me.labelZerados.Location = New System.Drawing.Point(572, 50)
        Me.labelZerados.Name = "labelZerados"
        Me.labelZerados.Size = New System.Drawing.Size(107, 16)
        Me.labelZerados.TabIndex = 7
        Me.labelZerados.Text = "Faturas Zeradas"
        '
        'lblZerados
        '
        Me.lblZerados.AutoSize = True
        Me.lblZerados.Location = New System.Drawing.Point(572, 86)
        Me.lblZerados.Name = "lblZerados"
        Me.lblZerados.Size = New System.Drawing.Size(59, 16)
        Me.lblZerados.TabIndex = 8
        Me.lblZerados.TabStop = True
        Me.lblZerados.Text = "Zerados"
        '
        'labelCep
        '
        Me.labelCep.AutoSize = True
        Me.labelCep.Location = New System.Drawing.Point(439, 53)
        Me.labelCep.Name = "labelCep"
        Me.labelCep.Size = New System.Drawing.Size(92, 16)
        Me.labelCep.TabIndex = 9
        Me.labelCep.Text = "CEP Inválidos"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(439, 86)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(92, 16)
        Me.lblCep.TabIndex = 10
        Me.lblCep.TabStop = True
        Me.lblCep.Text = "CEP inválidos"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbDadosValidacao)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbArquivoEntrada)
        Me.Name = "main"
        Me.Text = "Validação Arquivo"
        Me.gbArquivoEntrada.ResumeLayout(False)
        Me.gbArquivoEntrada.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDadosValidacao.ResumeLayout(False)
        Me.gbDadosValidacao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbArquivoEntrada As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtArquivoEntrada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDiretorioSaida As Button
    Friend WithEvents txtSaida As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbDadosValidacao As GroupBox
    Friend WithEvents lbl6Paginas As LinkLabel
    Friend WithEvents lbl12Paginas As LinkLabel
    Friend WithEvents lblAcima As LinkLabel
    Friend WithEvents labelAcima As Label
    Friend WithEvents label12Paginas As Label
    Friend WithEvents label6Paginas As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents txtProcessar As Button
    Friend WithEvents labelZerados As Label
    Friend WithEvents lblZerados As LinkLabel
    Friend WithEvents labelCep As Label
    Friend WithEvents lblCep As LinkLabel
End Class
