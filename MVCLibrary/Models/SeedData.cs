using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if( context.Book.Any())
                {
                    return;
                }
                else
                {
                    context.Book.AddRange(new Book { Title = "Tiny C# Projects", Author = "Bob", CallNumber = "AXD 2029" },
                        new Book { Title = "Tiny Drons Now", Author = "Dave", CallNumber = "HJG 7389" });
                    context.SaveChanges();
                }
            }
        }
    }
}
