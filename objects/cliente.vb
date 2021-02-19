Public Class cliente

    Private nome As String

    Private cep As String

    Private enderecoComplemento As String

    Private bairro As String

    Private cidade As String

    Private estado As String

    Private valorFatura As Double

    Private numeroPaginas As Integer

    Public Property Nome1 As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

    Public Property Cep1 As String
        Get
            Return cep
        End Get
        Set(value As String)
            cep = value
        End Set
    End Property

    Public Property EnderecoComplemento1 As String
        Get
            Return enderecoComplemento
        End Get
        Set(value As String)
            enderecoComplemento = value
        End Set
    End Property

    Public Property Bairro1 As String
        Get
            Return bairro
        End Get
        Set(value As String)
            bairro = value
        End Set
    End Property

    Public Property Cidade1 As String
        Get
            Return cidade
        End Get
        Set(value As String)
            cidade = value
        End Set
    End Property

    Public Property Estado1 As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Property ValorFatura1 As Double
        Get
            Return valorFatura
        End Get
        Set(value As Double)
            valorFatura = value
        End Set
    End Property

    Public Property NumeroPaginas1 As Integer
        Get
            Return numeroPaginas
        End Get
        Set(value As Integer)
            numeroPaginas = value
        End Set
    End Property
End Class
