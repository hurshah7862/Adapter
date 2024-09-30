using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Database> Databases { get; set; }
        public DbSet<DatabaseType> DatabaseTypes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Logging> Loggings { get; set; }
        public DbSet<Lookup> Lookups { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                     .Where(e => e.State == EntityState.Deleted && e.Entity is BaseEntity))
            {
                var entity = (BaseEntity)entry.Entity;

                // Mark the entity as not deleted
                entry.State = EntityState.Modified;

                // Set the soft delete properties
                entity.IsActive = false;
                entity.ModifiedOn = DateTime.Now;
            }
            foreach (var entry in ChangeTracker.Entries()
                     .Where(e => e.State == EntityState.Modified && e.Entity is BaseEntity))
            {
                var entity = (BaseEntity)entry.Entity;
                entity.ModifiedOn = DateTime.Now;
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Model creation

            #region Database entity region
            modelBuilder.Entity<Database>().HasKey(entity => entity.Id);
            modelBuilder.Entity<Database>().HasIndex(entity => entity.Name).IsUnique();
            modelBuilder.Entity<Database>().Property(entity => entity.Id).UseIdentityColumn().IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Database>().Property(entity => entity.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Database>().Property(entity => entity.DatabaseTypeId).IsRequired();
            modelBuilder.Entity<Database>().Property(entity => entity.ConnectionString).IsRequired();
            modelBuilder.Entity<Database>().Property(entity => entity.CreatedBy).IsRequired();
            modelBuilder.Entity<Database>().Property(entity => entity.CreatedOn).HasDefaultValueSql("GETDATE()").IsRequired();
            modelBuilder.Entity<Database>().Property(entity => entity.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Database>().Property(entity => entity.UserId).IsRequired();
            modelBuilder.Entity<Database>()
                                .HasOne(x => x.DatabaseType)
                                .WithMany(y => y.Databases)
                                .HasForeignKey(x => x.DatabaseTypeId);
            modelBuilder.Entity<Database>()
                                .HasOne(x => x.User)
                                .WithMany(y => y.Databases)
                                .HasForeignKey(x => x.UserId);
            #endregion

            #region DatabaseType entity region
            modelBuilder.Entity<DatabaseType>().HasKey(entity => entity.Id);
            modelBuilder.Entity<DatabaseType>().HasIndex(entity => entity.Name).IsUnique();
            modelBuilder.Entity<DatabaseType>().Property(entity => entity.Id).UseIdentityColumn().IsRequired().ValueGeneratedOnAdd().ValueGeneratedOnAdd();
            modelBuilder.Entity<DatabaseType>().Property(entity => entity.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<DatabaseType>().Property(entity => entity.TypeId).IsRequired();
            modelBuilder.Entity<DatabaseType>().Property(entity => entity.CreatedBy).IsRequired();
            modelBuilder.Entity<DatabaseType>().Property(entity => entity.CreatedOn).HasDefaultValueSql("GETDATE()").IsRequired();
            modelBuilder.Entity<DatabaseType>().Property(entity => entity.Name).IsRequired().HasMaxLength(100);
            #endregion

            #region Transaction entity region
            modelBuilder.Entity<Transaction>().HasKey(entity => entity.Id);
            modelBuilder.Entity<Transaction>().Property(entity => entity.Id).UseIdentityColumn().IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Transaction>().Property(entity => entity.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Transaction>().Property(entity => entity.CreatedBy).IsRequired();
            modelBuilder.Entity<Transaction>().Property(entity => entity.UserId).IsRequired();
            modelBuilder.Entity<Transaction>().Property(entity => entity.SourceDatabaseId).IsRequired();
            modelBuilder.Entity<Transaction>().Property(entity => entity.CreatedOn).HasDefaultValueSql("GETDATE()").IsRequired();


            modelBuilder.Entity<Transaction>()
                                .HasOne(x => x.User)
                                .WithMany(y => y.Transactions)
                                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Transaction>()
                                .HasOne(x => x.SourceDatabase)
                                .WithMany(y => y.TransactionsAsSource)
                                .HasForeignKey(x => x.SourceDatabaseId)
                                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Transaction>()
                                .HasOne(x => x.TargetDatabase)
                                .WithMany(y => y.TransactionsAsTarget)
                                .HasForeignKey(x => x.TargetDatabaseId)
                                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region User entity region
            modelBuilder.Entity<User>().HasKey(entity => entity.Id);
            modelBuilder.Entity<User>().HasIndex(entity => entity.Email).IsUnique();
            modelBuilder.Entity<User>().HasIndex(entity => entity.Mobile).IsUnique();
            modelBuilder.Entity<User>().HasIndex(entity => entity.UserName).IsUnique();
            modelBuilder.Entity<User>().Property(entity => entity.Id).UseIdentityColumn().IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(entity => entity.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<User>().Property(entity => entity.CreatedBy).IsRequired();
            modelBuilder.Entity<User>().Property(entity => entity.CreatedOn).HasDefaultValueSql("GETDATE()").IsRequired();
            modelBuilder.Entity<User>().Property(entity => entity.Email).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<User>().Property(entity => entity.UserName).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<User>().Property(entity => entity.FullName).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<User>().Property(entity => entity.Mobile).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<User>().Property(entity => entity.IsSuperAdmin).HasDefaultValue(false);
            #endregion

            #region Logging entity region
            modelBuilder.Entity<Logging>().HasKey(entity => entity.Id);
            modelBuilder.Entity<Logging>().Property(entity => entity.Id).UseIdentityColumn().IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Logging>().Property(entity => entity.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Logging>().Property(entity => entity.CreatedBy).IsRequired();
            modelBuilder.Entity<Logging>().Property(entity => entity.CreatedOn).HasDefaultValueSql("GETDATE()").IsRequired();
            modelBuilder.Entity<Logging>().Property(entity => entity.Request).IsRequired();
            modelBuilder.Entity<Logging>().Property(entity => entity.Response).IsRequired();
            modelBuilder.Entity<Logging>().Property(entity => entity.Route).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Logging>()
                                .HasOne(x => x.User)
                                .WithMany(y => y.Loggings)
                                .HasForeignKey(x => x.UserId);
            #endregion

            #region Lookup entity region
            modelBuilder.Entity<Lookup>().HasKey(entity => entity.Id);
            modelBuilder.Entity<Lookup>().Property(entity => entity.Id).UseIdentityColumn().IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Lookup>().Property(entity => entity.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Lookup>().Property(entity => entity.CreatedBy).IsRequired();
            modelBuilder.Entity<Lookup>().Property(entity => entity.CreatedOn).HasDefaultValueSql("GETDATE()").IsRequired();
            modelBuilder.Entity<Lookup>().Property(entity => entity.GroupId).IsRequired();
            modelBuilder.Entity<Lookup>().Property(entity => entity.Key).IsRequired();
            modelBuilder.Entity<Lookup>().Property(entity => entity.Value).IsRequired();
            modelBuilder.Entity<Lookup>()
                                .HasOne(x => x.ParentLookup)
                                .WithMany(y => y.ChildLookups)
                                .HasForeignKey(x => x.ParentId);
            #endregion

            #endregion

            #region Data Seeding

            #region User seeding
            modelBuilder.Entity<User>().HasData(new List<User>()
            {
                new User(){ Id = 1, CreatedBy = 1, CreatedOn = DateTime.MinValue, Email = "hurshah7862@gmail.com", IsActive = true, UserName = "hurshah7862", FullName = "Hur Abbas Shah", Mobile = "+92 (305) 6252620", IsSuperAdmin = true }
            });
            #endregion

            #region Lookup seeding
            modelBuilder.Entity<Lookup>().HasData(new List<Lookup>()
            {
                new Lookup(){ Id = 1, CreatedBy = 1, CreatedOn = DateTime.MinValue, GroupId = 1, IsActive = true, Key = "SQL Relational DB", Value = "SRD" },
                new Lookup(){ Id = 2, CreatedBy = 1, CreatedOn = DateTime.MinValue, GroupId = 1, IsActive = true, Key = "SQL Non-Relational DB", Value = "SNRD" },
                new Lookup(){ Id = 3, CreatedBy = 1, CreatedOn = DateTime.MinValue, GroupId = 1, IsActive = true, Key = "NoSQL Non-Relational DB", Value = "NSNRD" }
            });
            #endregion

            #region DatabaseType seeding
            modelBuilder.Entity<DatabaseType>().HasData(new List<DatabaseType>() {
            new DatabaseType(){ Id = 1, CreatedBy = 1, CreatedOn = DateTime.MinValue, IsActive = true, Name = "Microsoft SQL Server", TypeId = 1},
            new DatabaseType(){ Id = 2, CreatedBy = 1, CreatedOn = DateTime.MinValue, IsActive = true, Name = "PostgreSQL", TypeId = 1},
            new DatabaseType(){ Id = 3, CreatedBy = 1, CreatedOn = DateTime.MinValue, IsActive = true, Name = "MySQL", TypeId = 1},
            new DatabaseType(){ Id = 4, CreatedBy = 1, CreatedOn = DateTime.MinValue, IsActive = true, Name = "Cosmos DB", TypeId = 2},
            new DatabaseType(){ Id = 5, CreatedBy = 1, CreatedOn = DateTime.MinValue, IsActive = true, Name = "Mongo DB", TypeId = 3},
            new DatabaseType(){ Id = 6, CreatedBy = 1, CreatedOn = DateTime.MinValue, IsActive = true, Name = "Dynamo DB", TypeId = 3},
            new DatabaseType(){ Id = 7, CreatedBy = 1, CreatedOn = DateTime.MinValue, IsActive = true, Name = "Azure Storage Table", TypeId = 2}
            });
            #endregion

            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
