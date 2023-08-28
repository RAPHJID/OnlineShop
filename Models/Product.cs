namespace Onlineshop.Models{
public class Product
{
    public int ProductId {get;set;}
    public string ProductName {get;set;}
    public decimal Price {get;set;}

    //Navigation property for Cart
    public int CartId { get; set; }
    public Cart Cart {get;set;}
}
}

