public class Product
{
    public int ProductId {get;set;}
    public string ProductName {get;set;}
    public decimal Price {get;set;}

    //Navigation property for Cart
    public Cart Cart {get;set;}
}
