using DocumentsAPI.Entities;
using DocumentsAPI.Seed;
using Microsoft.EntityFrameworkCore;

namespace DocumentsAPI.Data
{
    public class DbCtx : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<User> Users { get; set; }

        public DbCtx(DbContextOptions<DbCtx> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seedHelper = new SeedDataHelper();

            var departments = seedHelper.GetDepartments();
            modelBuilder.Entity<Department>().HasData(departments);

            var offices = seedHelper.GetOffices();
            modelBuilder.Entity<Office>().HasData(offices);

            var divisions = seedHelper.GetDivisions();
            modelBuilder.Entity<Division>().HasData(divisions);

            var folders = seedHelper.GetFolders();
            modelBuilder.Entity<Folder>().HasData(folders);

            var users = seedHelper.GetUsers();
            modelBuilder.Entity<User>().HasData(users);

            var documents = seedHelper.GetDocuments();
            modelBuilder.Entity<Document>().HasData(documents);

            base.OnModelCreating(modelBuilder);
        }
    }
}
