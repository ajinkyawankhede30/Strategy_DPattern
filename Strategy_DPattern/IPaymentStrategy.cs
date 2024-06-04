using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DPattern
{
    /// <summary>
    /// 1. Create Strategy interface
    /// </summary>
    public interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }

    /// <summary>
    /// Define Credit card payment algorithm
    /// </summary>
    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing payment of $" + amount + " via credit card...");
        }
    }

    /// <summary>
    /// Define debit card payment algorithm
    /// </summary>
    public class DebitCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing payment of $" + amount + " via debit card...");
        }
    }

    /// <summary>
    /// Define UPI payment algorithm
    /// </summary>
    public class UPIPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing payment of $" + amount + " via upi...");
        }
    }

    /// <summary>
    /// Class to call the respective algorithm using iterface
    /// </summary>
    public class PaymentService
    {
        IPaymentStrategy iPaymentStrategy;
        public PaymentService(IPaymentStrategy _PaymentStrategy)
        {
            iPaymentStrategy = _PaymentStrategy;
        }

        //Implement the respective algorithm
        public void Payment(double amount)
        {
            Console.WriteLine("\nPayment service pre logic");
            iPaymentStrategy.ProcessPayment(amount);
            Console.WriteLine("Payment service post logic\n");
        }
    }
}
