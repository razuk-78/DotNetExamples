using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace EF6CodeFirstDemo.LazyEagerExplicit
{


    public  class BillingDetail
    {
        public int BillingDetailId { get; set; }
        public string Owner { get; set; }
        public string Number { get; set; }
        public string NumberA { get; set; }
    }
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BillingDetailId { get; set; }

        public virtual BillingDetail BillingInfo { get; set; }
    }
    public class InheritanceMappingContext : DbContext
    {
        public InheritanceMappingContext() : base("name=LoadingMethods")
        {


        }
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
        public DbSet<BillingDetail> BillingDetails { get; set; }
        public DbSet<User> User { get; set; }
    }
}