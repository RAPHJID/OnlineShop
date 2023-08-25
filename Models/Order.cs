public class Order
{
    public int OrderId {get;set;}
    public DateTime OrderDate {get;set;}

    //Foreign Key for User
    public int UserId {get;set;}
    public User User {get;set;}

    //Navigation property for Shipment
    public Shipment Shipment {get;set;}

    //Navigation property for Payment
    public Payment Payment {get;set;}
}
