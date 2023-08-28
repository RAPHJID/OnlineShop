namespace Onlineshop.Models{
public class Payment
{
    public int PaymentId {get;set;}
    public decimal Amount {get;set;}

    //Foreign Key for Order
    public int OrderId {get;set;}
    public Order Order {get;set;}
}
}
