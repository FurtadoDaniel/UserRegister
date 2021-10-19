using UserRegister.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UserRegister.DAL
{
    public class UserContext : DbContext
    {
    
        //No método de criação apenas extende o base
        public UserContext() : base("UserContext")
        {
        }
        
        //base de usuários
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<UserContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}