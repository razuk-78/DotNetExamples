using System.Data.Entity;
namespace EF6CodeFirstDemo.TPH
{


public abstract class BillingDetail
{
    public int BillingDetailId { get; set; }
    public string Owner { get; set; }
    public string Number { get; set; }
    public string NumberA { get; set; }
    }

public class BankAccount : BillingDetail
{
    public string BankName { get; set; }
    public string Swift { get; set; }
}

public class CreditCard : BillingDetail
{
    public int CardType { get; set; }
    public string ExpiryMonth { get; set; }
    public string ExpiryYear { get; set; }
}

public class InheritanceMappingContext : DbContext
{
    public InheritanceMappingContext() : base("name=TPH")
    {
      
           
    }
        /*
         * Sometimes, especially in legacy schemas, 
         * you need to override the conventions for the discriminator
         * column so that Code First can work with the schema. 
         * The following fluent API code will change the discriminator 
         * column name to "BillingDetailType" and the values to "BA" 
         * and "CC" for BankAccount and CreditCard respectively:
         */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillingDetail>()
                        .Map<BankAccount>(m => m.Requires("BillingDetailType").HasValue("BA"))
                        .Map<CreditCard>(m => m.Requires("BillingDetailType").HasValue("CC"));
        }
        public DbSet<BillingDetail> BillingDetails { get; set; }
}
}