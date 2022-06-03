using ContactWebEFCore6_New.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContactWebEFCore6_New.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        private static IConfigurationRoot _configuration;

        public DbSet<State> States { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var builder = new ConfigurationBuilder();
        //    builder.SetBasePath(Directory.GetCurrentDirectory());
        //    builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        //    _configuration = builder.Build();
        //    var constr = _configuration.GetConnectionString("DefaultConnection");
        //    optionsBuilder.UseSqlServer(constr);


        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<State>(x => {
                x.HasData(

                new State() { Id = 1, Name = "Attica", Abbreviation = "AT" },
                new State() { Id = 2, Name = "Achaia", Abbreviation = "AC" },
                new State() { Id = 3, Name = "Thessaloniki", Abbreviation = "TH" },
                new State() { Id = 4, Name = "Irakleio", Abbreviation = "IR" });

            });


        }


    }
}