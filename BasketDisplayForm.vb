Public Class BasketDisplayForm
    'Declare the Basket as a list of GroceryItem
    Public Basket As New List(Of GroceryItem)

    'Load event to populate the basket items
    Sub PopulateBasket()
        Basket.Add(New GroceryItem() With {.BrandName = "Coke", .Price = 4.55D,
                   .Aisle = "Drinks", .Description = "12oz 24 Pack"})
        Basket.Add(New GroceryItem() With {.BrandName = "Calrose Rice", .Price = 8.99D,
                   .Aisle = "DryGoods", .Description = "White Rice 10 lb"})
        Basket.Add(New GroceryItem() With {.BrandName = "Birds Eye Vegetables", .Price = 4.55D,
                   .Aisle = "FrozenFoods", .Description = "California Style Vegetable Mix 12oz"})
        Basket.Add(New GroceryItem() With {.BrandName = "Honeycrisp", .Price = 2.99D,
                   .Aisle = "Produce", .Description = "Apples per bag"})
    End Sub

    Private Sub viewBasket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewBasket.CellContentClick

    End Sub

    Private Sub BasketDisplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load event handle for BasketDisplayForm
        'Populate the basket before binding
        PopulateBasket()

        'Bind the basket to DataGridView
        viewBasket.DataSource = Basket

    End Sub
End Class