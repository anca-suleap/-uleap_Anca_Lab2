using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Șuleap_Anca_Lab2.Models;

namespace Șuleap_Anca_Lab2.Data
{
    public class Șuleap_Anca_Lab2Context : DbContext
    {
        public Șuleap_Anca_Lab2Context (DbContextOptions<Șuleap_Anca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Șuleap_Anca_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Șuleap_Anca_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Șuleap_Anca_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
