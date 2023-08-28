// using Onlineshop.Data;
// using Microsoft.EntityFrameworkCore;

// namespace Onlineshop
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//            on
//             var options = new DbContextOptionsBuilder<ApplicationDbContext>()
//                 .UseSqlServer("Server=localhost; Database=Assessement; User id=SA; Password=JidKim7804; Encrypt=True; TrustServerCertificate=True")
//                 .Options;

           
//             using (var context = new ApplicationDbContext(options))
//             {
//             }
//         }
//     }
// }


using Onlineshop.Data;
namespace Onlineshop{
    class Program{
        static void Main(string[] args){
       ApplicationDbContext context = new ApplicationDbContext();
    }
    }
}