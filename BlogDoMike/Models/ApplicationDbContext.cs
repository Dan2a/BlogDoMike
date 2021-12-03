using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogDoMike.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base ("DefaultConnection")
        { }

        public static ApplicationDbContext Create() => new ApplicationDbContext();

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<CadastroUser> Cadastros { get; set; }
    }
}