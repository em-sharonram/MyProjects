Public Class GroceryItem
    'Private
    Private _scanNumber As Integer
    Private _brandName As String
    Private _description As String
    Private _price As Decimal
    Private _aisle As String

    'Enum for aisles
    Public Enum AisleType
        Bakery
        CannedGoods
        Drinks
        Deli
        DryGoods
        FrozenFoods
        Produce
    End Enum

    'Public properties
    'Read-only property on unique serial code for ScanNumber
    Public ReadOnly Property ScanNumber() As Integer
        Get
            Return _scanNumber
        End Get
    End Property

    'Property on item's packaging for BrandName
    Public Property BrandName() As String
        Get
            Return _brandName
        End Get
        Set(value As String)
            _brandName = value
        End Set
    End Property

    'Property for Description
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    'Property on cost to buy an item for Price
    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _price = value
            Else
                Throw New ArgumentException("Price must be a positive value.")
            End If
        End Set
    End Property

    'Property for Aisle
    Public Property Aisle() As String
        Get
            Return _aisle
        End Get
        Set(value As String)
            _aisle = value
        End Set
    End Property

    'Constructor sets for read-only ScanNumber
    Public Sub New(scanNumber As Integer)
        _scanNumber = scanNumber
    End Sub

    'Constructor sets for ScanNumber, BrandName and Price
    Public Sub New(scanNumber As Integer, brandName As String, price As Decimal)
        Me._scanNumber = scanNumber
        Me.BrandName = brandName
        Me.Price = price
    End Sub

    'Default constructor values (if necessary)
    Public Sub New()
    End Sub

End Class

