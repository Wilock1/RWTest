using Microsoft.EntityFrameworkCore;
using BellTestApp.Data;

namespace BellTestApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BellTestAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BellTestAppContext>>()))
            {
                if (context == null || context.User == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any users.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        FirstName = "Test",
                        LastName = "Test",
                        Email = "test@gmail.com",
                        Phone = "555-555-5555",
                        Address = "123 Test Way, Testerville, ON A0A 0A0"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
