using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Git
{
    class Purse
    {
        static void Main(string[] args)
        {
            Money m = new Money(134);
            m.GetInformation();

            CreditCard myCard = new CreditCard("1234 5678 4567 4231", new DateTime(2017, 8, 21), 521, "USD");
            myCard.ChangePin(5626);

            BusinessCard bs = new BusinessCard();
           
        }
    }
}
