using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            var books = new []
            {
                new Book{ Name = "Breath: The New Science of a Lost Art" , Author = "James Nestor" },
                new Book{ Name = "Why We Sleep: Unlocking the Power of Sleep and Dreams" , Author = "Matthew Walker" },
                new Book{ Name = "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones" , Author = "James Clear" },
                new Book{ Name = "The Power of Habit: Why We Do What We Do in Life and Business" , Author = "Charles Duhigg" }
            };
            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
}
