using System.ComponentModel.DataAnnotations;
namespace Onlineshop.Models{
public class Cart
{
    public int CartId {get;set;}

    //Foreign key for user
    public int UserId {get;set;}
    public User User {get;set;}

    //Navigation property for Products
    public ICollection<Product> Products {get;set;}
}
}