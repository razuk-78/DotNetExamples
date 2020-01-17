using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo.TPT
{
    class TPTProvider
    {
        public static void CreateDB()
        {
            using (InheritanceMappingContext db = new InheritanceMappingContext()) {
                if (!db.Database.Exists())
                {
                    db.Database.Initialize(true);
                    db.Database.CreateIfNotExists();
                    db.Dispose();
                }

            }
        }

        public static void AddCreditCardThroughUser()
        {
            CreateDB();
            InheritanceMappingContext db = new InheritanceMappingContext();
            var Crd = new CreditCard()
            {
                CardType = 1,
                ExpiryMonth = "Feb",
                ExpiryYear = "2020",
                Number = "10",
                NumberA = 10.ToString(),
                Owner = "me"
            };
            var user = new User()
            {
                BillingInfo = Crd,
                FirstName = "me",
                LastName = "me"

            };
            db.User.Add(user);
            db.SaveChanges();
            db.Dispose();
        }
        public static void GetUserEgerLoading()
        {
            InheritanceMappingContext db = new InheritanceMappingContext();
            var user = db.User.Include("BillingInfo").FirstOrDefault();
            db.Dispose();
           foreach(var rec in user.GetType().GetProperties())
            {
                Console.WriteLine($"{rec.Name}: {rec.GetValue(user)}");
            }
            Console.WriteLine($"{ user.BillingInfo}: ->");
            foreach (var rec in user.BillingInfo.GetType().GetProperties())
            {
                Console.WriteLine($"{rec.Name}: {rec.GetValue(user.BillingInfo)}");
            }
            
            Console.ReadLine();
        }

        public static void GetUserLazyOrDefaultLoading()
        {
            InheritanceMappingContext db = new InheritanceMappingContext();
            var user = db.User.FirstOrDefault();
            db.Dispose();
            foreach (var rec in user.GetType().GetProperties())
            {

                    Console.WriteLine($"{rec.Name}: {rec.GetValue(user)}");

            }            
          
            Console.ReadLine();
        }
    }
}
