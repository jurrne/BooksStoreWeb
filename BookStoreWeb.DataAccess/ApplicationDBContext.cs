using BooksStoreWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace BooksStoreWeb.DataAccess
{
    public class ApplicationDBContext : DbContext
    {
    public DbSet<Category> Categories { get; set; }
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
    {

    }
       
    }

}
