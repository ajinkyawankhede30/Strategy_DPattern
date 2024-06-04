using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            DebitCardPayment debitCardPayment = new DebitCardPayment();
            UPIPayment upiPayment = new UPIPayment();

            PaymentService credit_card_service = new PaymentService(creditCardPayment);
            credit_card_service.Payment(1000.25);

            PaymentService debit_card_service = new PaymentService(debitCardPayment);
            debit_card_service.Payment(5000.12);

            PaymentService upi_service = new PaymentService(upiPayment);
            upi_service.Payment(2000.26);

            Console.ReadLine();
        }
    }
}
