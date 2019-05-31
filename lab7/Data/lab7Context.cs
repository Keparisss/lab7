using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab7.Models;
using EFGetStarted.AspNetCore.lab7.Models;

namespace lab7.Models
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<EFGetStarted.AspNetCore.lab7.Models.Book> Book { get; set; }

        public DbSet<EFGetStarted.AspNetCore.lab7.Models.Purchase> Purchase { get; set; }

        public DbSet<EFGetStarted.AspNetCore.lab7.Models.Feedback> Feedback { get; set; }

    }
}
