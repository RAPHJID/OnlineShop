public class Shipment
{
    public int ShipmentId {get;set;}
    public Order Order {get;set;}

    //Foreign Key for Order
    public int OrderId {get;set;}
    public Order Order {get;set;}
}
