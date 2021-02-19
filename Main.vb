Imports System.IO

Public Class main
    Dim arquivoEntrada As String
    Dim diretorioSaida As String
    Dim cliente As cliente
    Dim cliente6 As List(Of cliente)
    Dim cliente12 As List(Of cliente)
    Dim clienteAcima As List(Of cliente)
    Dim clienteCep As List(Of cliente)
    Dim clienteZerado As List(Of cliente)
    Dim clientesCepIncorreto As String = "cepIncorreto"
    Dim clientesZerados As String = "valorZerado"
    Dim clientes6Paginas As String = "ate6Paginas"
    Dim clientes12Paginas As String = "ate12Paginas"
    Dim clientesMaisPaginas As String = "acima12Paginas"

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cliente = New cliente()
        cliente6 = New List(Of cliente)
        cliente12 = New List(Of cliente)
        clienteAcima = New List(Of cliente)
        clienteCep = New List(Of cliente)
        clienteZerado = New List(Of cliente)
        gbDadosValidacao.Visible = False
        label6Paginas.Visible = False
        lbl6Paginas.Visible = False
        lbl6Paginas.Text = ""
        label12Paginas.Visible = False
        lbl12Paginas.Visible = False
        lbl12Paginas.Text = ""
        labelAcima.Visible = False
        lblAcima.Visible = False
        lblAcima.Text = ""
        labelZerados.Visible = False
        lblZerados.Visible = False
        lblZerados.Text = ""
        labelCep.Visible = False
        lblCep.Visible = False
        lblCep.Text = ""
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Escolher arquivo"
        fd.InitialDirectory = "C:\"
        fd.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txtArquivoEntrada.Text = fd.FileName
            arquivoEntrada = fd.FileName
        End If
    End Sub

    Private Sub txtDiretorioSaida_Click(sender As Object, e As EventArgs) Handles txtDiretorioSaida.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtSaida.Text = FolderBrowserDialog1.SelectedPath
            diretorioSaida = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub txtProcessar_Click_1(sender As Object, e As EventArgs) Handles txtProcessar.Click
        validaArquivo(arquivoEntrada)
        gbDadosValidacao.Visible = True
        MsgBox("Validação completada com sucesso!")
    End Sub

    Private Sub validaArquivo(ByRef arquivo As String)
        cliente6 = New List(Of cliente)
        cliente12 = New List(Of cliente)
        clienteAcima = New List(Of cliente)
        clienteCep = New List(Of cliente)
        clienteZerado = New List(Of cliente)
        Dim clienteIncorreto = New List(Of String)

        For Each line As String In System.IO.File.ReadAllLines(arquivo)
            cliente = New cliente()
            If line.Equals("NomeCliente;CEP;RuaComComplemento;Bairro;Cidade;Estado;ValorFatura;NumeroPaginas") Then
            Else

                Dim strings1 As String() = line.Split(";")
                If strings1.Length > 8 Then
                    clienteIncorreto.Add(line)
                Else
                    cliente.Nome1 = line.Split(";")(0).Trim()
                    cliente.Cep1 = line.Split(";")(1).Trim()
                    cliente.EnderecoComplemento1 = line.Split(";")(2).Replace("""", "").Replace(";", "").Trim()
                    cliente.Bairro1 = line.Split(";")(3).Trim()
                    cliente.Cidade1 = line.Split(";")(4).Trim()
                    cliente.Estado1 = line.Split(";")(5).Trim()
                    cliente.ValorFatura1 = Convert.ToDouble(line.Split(";")(6).Replace(".", ","))
                    cliente.NumeroPaginas1 = Convert.ToInt32(line.Split(";")(7).Trim())
                    If cliente.Cep1.Length <> 8 Then
                        clienteCep.Add(cliente)
                    ElseIf cliente.ValorFatura1 = 0 Then
                        clienteZerado.Add(cliente)
                    Else
                        If cliente.NumeroPaginas1 <= 6 Then
                            cliente6.Add(cliente)
                        ElseIf cliente.NumeroPaginas1 <= 12 Then
                            cliente12.Add(cliente)
                        Else
                            clienteAcima.Add(cliente)
                        End If
                    End If
                End If
            End If
        Next

        If cliente6.Count > 0 Then
            gravaRegistros(cliente6, clientes6Paginas)
            label6Paginas.Visible = True
            lbl6Paginas.Visible = True
            lbl6Paginas.Text = "Arquivo"
        Else
            label6Paginas.Visible = False
            lbl6Paginas.Visible = False
            lbl6Paginas.Text = ""
        End If

        If cliente12.Count > 0 Then
            gravaRegistros(cliente12, clientes12Paginas)
            label12Paginas.Visible = True
            lbl12Paginas.Visible = True
            lbl12Paginas.Text = "Arquivo"
        Else
            label12Paginas.Visible = False
            lbl12Paginas.Visible = False
            lbl12Paginas.Text = ""
        End If

        If clienteAcima.Count > 0 Then
            gravaRegistros(clienteAcima, clientesMaisPaginas)
            labelAcima.Visible = True
            lblAcima.Visible = True
            lblAcima.Text = "Arquivo"
        Else
            labelAcima.Visible = False
            lblAcima.Visible = False
            lblAcima.Text = ""
        End If

        If clienteZerado.Count > 0 Then
            gravaRegistros(clienteZerado, clientesZerados)
            labelZerados.Visible = True
            lblZerados.Visible = True
            lblZerados.Text = "Arquivo"
        Else
            labelZerados.Visible = False
            lblZerados.Visible = False
            lblZerados.Text = ""
        End If

        If clienteCep.Count > 0 Then
            gravaRegistros(clienteCep, clientesCepIncorreto)
            labelCep.Visible = True
            lblCep.Visible = True
            lblCep.Text = "Arquivo"
        Else
            labelCep.Visible = False
            lblCep.Visible = False
            lblCep.Text = ""
        End If

        If clienteIncorreto.Count > 0 Then
            gravaIncorretos(clienteIncorreto)
            MsgBox("Houve registros incorretos de clientes. Foi gerado também um arquivo com as linhas com erros.")
        End If

        gbDadosValidacao.Visible = True
    End Sub

    Private Sub gravaRegistros(ByRef clientes As List(Of cliente), ByRef nomeArquivo As String)
        If Not System.IO.File.Exists(diretorioSaida & "\" & nomeArquivo & ".csv") Then
            criaArquivo(nomeArquivo)
        End If
        Dim writer As StreamWriter = New StreamWriter(diretorioSaida & "\" & nomeArquivo & ".csv")
        For Each cliente In clientes
            writer.WriteLine(cliente.Nome1 & ";" & cliente.EnderecoComplemento1 & ", " & cliente.Cidade1 & ", " & cliente.Estado1 & " - " & cliente.Cep1 & ";" & cliente.ValorFatura1.ToString.Replace(",", ".") & ";" & cliente.NumeroPaginas1)
        Next
    End Sub

    Private Sub gravaIncorretos(ByRef registros As List(Of String))
        If Not System.IO.File.Exists(diretorioSaida & "\registrosInvalidos" & ".csv") Then
            criaArquivo("registrosInvalidos")
        End If

        Dim writer As StreamWriter = New StreamWriter(diretorioSaida & "\registrosInvalidos" & ".csv")
        For Each line As String In registros
            writer.WriteLine(line)
        Next
    End Sub

    Private Sub criaArquivo(ByRef nomeArquivo As String)
        If nomeArquivo = "registrosInvalidos" Then
            File.Create(diretorioSaida & "\" & nomeArquivo & ".csv").Dispose()
            Dim writer As StreamWriter = New StreamWriter(diretorioSaida & "\" & nomeArquivo & ".csv")
            writer.WriteLine("NomeCliente;CEP;RuaComComplemento;Bairro;Cidade;Estado;ValorFatura;NumeroPaginas")
            writer.Close()

        Else
            File.Create(diretorioSaida & "\" & nomeArquivo & ".csv").Dispose()
            Dim writer As StreamWriter = New StreamWriter(diretorioSaida & "\" & nomeArquivo & ".csv")
            writer.WriteLine("NomeCliente;EnderecoCompleto;ValorFatura;NumeroPaginas")
            writer.Close()
        End If
    End Sub

    Private Sub lbl6Paginas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl6Paginas.LinkClicked
        System.Diagnostics.Process.Start(diretorioSaida & "\" & clientes6Paginas & ".csv")
    End Sub

    Private Sub lbl12Paginas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl12Paginas.LinkClicked
        System.Diagnostics.Process.Start(diretorioSaida & "\" & clientes12Paginas & ".csv")
    End Sub

    Private Sub lblAcima_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAcima.LinkClicked
        System.Diagnostics.Process.Start(diretorioSaida & "\" & clientesMaisPaginas & ".csv")
    End Sub

    Private Sub lblCep_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCep.LinkClicked
        System.Diagnostics.Process.Start(diretorioSaida & "\" & clientesCepIncorreto & ".csv")
    End Sub

    Private Sub lblZerados_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblZerados.LinkClicked
        System.Diagnostics.Process.Start(diretorioSaida & "\" & clientesZerados & ".csv")
    End Sub
End Class
