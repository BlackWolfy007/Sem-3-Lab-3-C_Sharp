using System;
using System.Collections.Generic;

namespace Sem_3_Lab_3_C_Sharp
{
    public class DebitAccount
    {
        private int DebitAccountID;
        private int Currency;
        private double Balance;

        
            public enum CurrTypes
            {
                RUB = 0,
                USD,
                EUR
            };

            public List<double> CURRENCY_EXCHANGE_RATE = new(){1.0, 0.014, 0.012};

        
        public static int DA_account;
        public DebitAccount(){
            this.DebitAccountID = DA_account;
            this.Currency = (int)CurrTypes.RUB;
            this.Balance = 0.0;
            DA_account++;
        }

        public DebitAccount(int curr, double bal)
        {
            this.DebitAccountID = DA_account;
            this.Currency = curr;
            this.Balance = bal;
            DA_account++;
        }

        public int GetDebitAccountID()
        {
            return DebitAccountID;
        }

        public int GetCurrency()
        {
            return Currency;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void Replemishment(int add, int curr = 0)
        {
            this.Balance += add * CURRENCY_EXCHANGE_RATE[Currency] / CURRENCY_EXCHANGE_RATE[curr];
        }

        public void Debting(int dec, int curr = 0)
        {
            double k = Balance;
            this.Balance -= dec * CURRENCY_EXCHANGE_RATE[Currency] / CURRENCY_EXCHANGE_RATE[curr];
            if (Balance < 0)
            {
                Console.WriteLine("Ошибка! На балансе недостаточно средств!");
                this.Balance = k;
            }
        }

        public void Out()
        {
            Console.WriteLine($"DebitAccountID: {this.DebitAccountID}");
            Console.WriteLine($"Currency: {this.Currency}");
            Console.Write($"Balance: {this.Balance}");
            switch (Currency)
            {
                case 0:
                    {
                        Console.Write(" RUB\n");
                        break;
                    }
                case 1:
                    {
                        Console.Write(" USD\n");
                        break;
                    }
                case 2:
                    {
                        Console.Write(" EUR\n");
                        break;
                    }
            }
        }

    }
}
