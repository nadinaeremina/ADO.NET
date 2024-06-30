using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF.CodeFirst.Models
{
    public class Book_db_Context: DbContext
    {
        // передаем в кон-р наше подключение, которое в 'app.config'
        public Book_db_Context() : base("name=Book_add2") {}
        // все наши сеты - будушие таблички
        public DbSet<Author> Authors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
