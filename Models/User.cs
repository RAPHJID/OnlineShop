public class User 
{
    public int UserId {get;set;}
    public string UserName {get;set;}
    public string Email {get;set;}

    //Navigate property for Cart
    public Cart Cart {get;set;}

    //Navigate property for Orders
    public ICollection<Order> Orders {get;set;}
}
