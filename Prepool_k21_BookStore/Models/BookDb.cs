using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Prepool_k21_BookStore.Models
{
    public class BookDb : DbContext
    {
        private static string _defaultConnection = "DefaultConnection";
        public BookDb():base(_defaultConnection)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}