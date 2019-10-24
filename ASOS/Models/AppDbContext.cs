using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class AppDbContext:IdentityDbContext<ApplicationUser,RoleApplication,int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Equipament> Equipaments { get; set; }
        public DbSet<ServiceOrder> OrdensServico { get; set; }
        public DbSet<BuyOrder> OrdensCompra { get; set; }
        public DbSet<Displacement> Deslocamentos { get; set; }
        public DbSet<Equipament> Equipamentos { get; set; }


        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is ApplicationUser && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    ((ApplicationUser)entity.Entity).CreateAt = now;
                }

                ((ApplicationUser)entity.Entity).UpdateAt = now;
            }
        }

       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().Ignore(u => u.TwoFactorEnabled)
                                             .Ignore(u => u.LockoutEnabled)
                                             .Ignore(u => u.LockoutEnd);


            builder.Entity<Equipament>()
                   .HasKey(k => k.Id);
            builder.Entity<Equipament>()
                   .Property(p => p.Id).ValueGeneratedOnAdd();



            builder.Entity<ServiceOrder>()
                   .HasKey(k => k.Id);
            builder.Entity<ServiceOrder>()
                   .Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Entity<ServiceOrder>()
                   .Property(p => p.Fechamentos)
                   .HasConversion(
                                    s => string.Join(',', s),
                                    s => s.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                 );

            builder.Entity<ServiceOrder>()
                   .HasOne(e => e.Equipamento)
                   .WithMany(s => s.OrdensServico)
                   .HasForeignKey(e => e.EquipamentoID)
                   .IsRequired();


            builder.Entity<BuyOrder>()
                   .HasKey(k => k.Id);
            builder.Entity<BuyOrder>()
                   .Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Entity<BuyOrder>()
                   .Property(p => p.Pecas)
                   .HasConversion(
                                    s => string.Join(',', s),
                                    s => s.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                 );

            builder.Entity<BuyOrder>()
                   .HasOne(s => s.OrdemServico)
                   .WithMany(b => b.OrdensCompra)
                   .HasForeignKey(s => s.OrdemServicoID)
                   .IsRequired();


            builder.Entity<Displacement>()
                   .HasKey(k => k.Id);
            builder.Entity<Displacement>()
                   .Property(p => p.Id).ValueGeneratedOnAdd();


            builder.Entity<DisplacementOrder>()
                   .HasKey(pt => new { pt.DeslocamentoId, pt.OrdemServicoId });

            builder.Entity<DisplacementOrder>()
                   .HasOne(d => d.Deslocamento)
                   .WithMany(o => o.OrdensDeslocamento)
                   .HasForeignKey(d => d.DeslocamentoId);

            builder.Entity<DisplacementOrder>()
                   .HasOne(o => o.OrdemServico)
                   .WithMany(d => d.OrdensDeslocamento)
                   .HasForeignKey(o => o.OrdemServicoId);

        }
    }
}
