Public Class Elemento
    Private NombreElemento As String
    Private MasaAtomica As Double
    Private NumeroAtomico As Integer
    Private EstadoOxidación As String
    Private Simbolo As String

    Public Property PropNombreElemento() As String
        Get
            Return NombreElemento
        End Get
        Set(value As String)
            NombreElemento = value
        End Set
    End Property

    Public Property PropMasaAtomica() As Double
        Get
            Return MasaAtomica
        End Get
        Set(value As Double)
            MasaAtomica = value
        End Set
    End Property

    Public Property PropNumeroAtomico() As Integer
        Get
            Return NumeroAtomico
        End Get
        Set(value As Integer)
            NumeroAtomico = value
        End Set
    End Property

    Public Property PropEstadoOxidacion() As String
        Get
            Return EstadoOxidación
        End Get
        Set(value As String)
            EstadoOxidación = value
        End Set
    End Property
    Public Property PropSimbolo() As String
        Get
            Return Simbolo
        End Get
        Set(value As String)
            Simbolo = value
        End Set
    End Property
End Class
