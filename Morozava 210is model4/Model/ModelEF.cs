using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Morozava_210is_model4.Model
{
    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<chek> chek { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<lekarstva> lekarstva { get; set; }
        public virtual DbSet<postavsiki> postavsiki { get; set; }
        public virtual DbSet<prixodTovara> prixodTovara { get; set; }
        public virtual DbSet<prodazi> prodazi { get; set; }
        public virtual DbSet<recepti> recepti { get; set; }
        public virtual DbSet<sotrydniki> sotrydniki { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<SostavProdazi> SostavProdazi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>()
                .HasMany(e => e.chek)
                .WithRequired(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lekarstva>()
                .Property(e => e.cost_price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lekarstva>()
                .Property(e => e.selling_price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lekarstva>()
                .HasMany(e => e.prixodTovara)
                .WithRequired(e => e.lekarstva)
                .HasForeignKey(e => e.medicine_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lekarstva>()
                .HasMany(e => e.recepti)
                .WithOptional(e => e.lekarstva)
                .HasForeignKey(e => e.medicine_id);

            modelBuilder.Entity<lekarstva>()
                .HasMany(e => e.SostavProdazi)
                .WithRequired(e => e.lekarstva)
                .HasForeignKey(e => e.medicine_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<postavsiki>()
                .HasMany(e => e.prixodTovara)
                .WithRequired(e => e.postavsiki)
                .HasForeignKey(e => e.supplier_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<prodazi>()
                .HasMany(e => e.SostavProdazi)
                .WithRequired(e => e.prodazi)
                .HasForeignKey(e => e.sale_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sotrydniki>()
                .HasMany(e => e.chek)
                .WithRequired(e => e.sotrydniki)
                .HasForeignKey(e => e.idRabotnika)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sotrydniki>()
                .HasMany(e => e.prixodTovara)
                .WithRequired(e => e.sotrydniki)
                .HasForeignKey(e => e.employee_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sotrydniki>()
                .HasMany(e => e.prodazi)
                .WithRequired(e => e.sotrydniki)
                .HasForeignKey(e => e.cashier_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SostavProdazi>()
                .Property(e => e.price_at_sale)
                .HasPrecision(19, 4);
        }
    }
}
