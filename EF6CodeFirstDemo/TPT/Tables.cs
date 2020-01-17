using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace EF6CodeFirstDemo.TPT
{


public abstract class BillingDetail
{
    public int BillingDetailId { get; set; }
    public string Owner { get; set; }
    public string Number { get; set; }
    public string NumberA { get; set; }
    }
    /*
     * We can create a TPT mapping simply by placing
     * Table attribute on the subclasses to
     * specify the mapped table name
     */
    [Table("BankAccount")]
    public class BankAccount : BillingDetail
{
    public string BankName { get; set; }
    public string Swift { get; set; }
}
    [Table("CreditCard")]
    public class CreditCard : BillingDetail
{
    public int CardType { get; set; }
    public string ExpiryMonth { get; set; }
    public string ExpiryYear { get; set; }
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
    public InheritanceMappingContext() : base("name=TPT")
    {
      
           
    }
        /*
        If you prefer fluent API, 
        then you can create a TPT mapping by using ToTable() method:
         */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            // uncomment this if want to map using Fluent API:
            /*
            modelBuilder.Entity<BankAccount>().ToTable("BankAccounts");
            modelBuilder.Entity<CreditCard>().ToTable("CreditCards");
            */
        }
        public DbSet<BillingDetail> BillingDetails { get; set; }
        public DbSet<User> User { get; set; }
    }
}