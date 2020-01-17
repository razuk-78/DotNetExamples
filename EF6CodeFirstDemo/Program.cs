using EF6CodeFirstDemo.School;
using EF6CodeFirstDemo.TPH;
using System;

namespace EF6CodeFirstDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //TPHProvider.AddBankAccount();
            // TPHProvider.AddCreditCard();
            //TPH.TPHProvider.GetAllBankAccount();
            //TPH.TPHProvider.GetAllCreditCard();
            // TPT.TPTProvider.CreateDB();
            // TPT.TPTProvider.AddCreditCardThroughUser();
            TPT.TPTProvider.GetUserEgerLoading();
        }
    }
}