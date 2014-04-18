using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prepool_k21_BookStore.Models
{
    public class Book
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImagePath { get; set; }

    }
}