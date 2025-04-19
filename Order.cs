using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem2
{
    abstract class Order
    {
        public int OrderID { get; set; }
        public double Amount { get; set; }

        public abstract void ProcessPayment();

        public virtual void PrintReceipt()
        {
            Console.WriteLine($"Order {OrderID}, Amount Paid: {Amount}");

        }

        class OnlineOrder : Order
        {
            public override void ProcessPayment()
            {
                Console.WriteLine($"Processing online payment for Order: {OrderID}");
            }

            public override void PrintReceipt()
            {
                Console.WriteLine($"Printing receopt for Order:{OrderID}");
                base.PrintReceipt();
            }
        }

        class InPersonOrder : Order
        {
            public override void ProcessPayment()
            {
                Console.WriteLine();
            }


        }
    }
}
