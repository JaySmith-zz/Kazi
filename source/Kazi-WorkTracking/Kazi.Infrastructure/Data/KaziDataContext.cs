namespace Kazi.Interfaces.Data
{
    using Kazi.Core;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KaziDataContext : DbContext
    {
        // Your context has been configured to use a 'KaziDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Kazi.Interfaces.Data.KaziDataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KaziDataContext' 
        // connection string in the application configuration file.
        public KaziDataContext() : base("KaziDataContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> Roles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }

        public virtual DbSet<Bug> Bugs { get; set; }
        public virtual DbSet<Epic> Epics { get; set; }
        public virtual DbSet<UserStory> UserStories { get; set; }
        public virtual DbSet<Impediment> Impediments { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}