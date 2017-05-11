using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCWithUnity.Domain;

namespace MVCWithUnity.Infrastructure
{
    public class ItemDb : DbContext, IMappingDataSource
    {
        public ItemDb()
            : base("DefaultConnection")
        { }

        public DbSet<ItemClass> Items { get; set; }
        public DbSet<OtherItemClass> OtherItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        IQueryable<ItemClass> IMappingDataSource.Items
        {
            get
            {
                return Items;
            }
        }

        IQueryable<OtherItemClass> IMappingDataSource.OtherItems
        {
            get
            {
                return OtherItems;
            }
        }

        void IMappingDataSource.Save()
        {
            SaveChanges();
        }
    }
}