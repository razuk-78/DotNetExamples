using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo.TPH
{
    class TPHProvider
    {
        public static void CreateDB()
        {
            using (InheritanceMappingContext db = new InheritanceMappingContext()) { 
                if (!db.Database.Exists())
                {
            db.Database.Initialize(true);
            db.Database.CreateIfNotExists();
            db.Dispose() ;
                }
   
            }
        }
        public static void AddCreditCard()
        {
            CreateDB();
            InheritanceMappingContext db = new InheritanceMappingContext();
            db.BillingDetails.Add(new CreditCard()
            {
                CardType = 1,
                ExpiryMonth = "Feb",
                ExpiryYear = "2020",
                Number="10",
                NumberA=10.ToString(),
                Owner="me"
            });
            db.SaveChanges();
            db.Dispose();
        }
        public static void AddBankAccount()
        {
            CreateDB();
            InheritanceMappingContext db = new InheritanceMappingContext();
            db.BillingDetails.Add(new BankAccount()
            {
                Number = "10",
                NumberA = 10.ToString(),
                Owner = "me",
                BankName="Nordea",
                Swift="3333"
            });
            db.SaveChanges();
            db.Dispose();
        }
        public static void GetAllBankAccount()
        {
            InheritanceMappingContext db = new InheritanceMappingContext();
           foreach(var rec in db.BillingDetails.OfType<BankAccount>())
            {
              foreach(var pro in rec.GetType().GetProperties())
                {
                  Console.WriteLine($"{pro.Name}: {pro.GetValue(rec)}");
                }
            }
            Console.ReadLine();
        }
        public static void GetAllCreditCard()
        {
            InheritanceMappingContext db = new InheritanceMappingContext();
            foreach (var rec in db.BillingDetails.OfType<CreditCard>())
            {
                foreach (var pro in rec.GetType().GetProperties())
                {
                    Console.WriteLine($"{pro.Name}: {pro.GetValue(rec)}");
                }
            }
            Console.ReadLine();
        }
    }
}
