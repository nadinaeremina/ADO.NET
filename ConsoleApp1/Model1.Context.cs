﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> AuthorSet { get; set; }
        public virtual DbSet<Book> BookSet { get; set; }
        public virtual DbSet<Country> CountrySet { get; set; }
        public virtual DbSet<Publisher> PublisherSet { get; set; }
        public virtual DbSet<Cities> CitiesSet { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
