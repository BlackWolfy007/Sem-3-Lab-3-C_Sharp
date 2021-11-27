using System;

namespace Sem_3_Lab_3_C_Sharp
{
    internal class Program
    {
        public static void User(ref DebitAccount dbt_acc)
        {
            int choice;
            Console.Write("Выберите действие со счетом: \n1. Пополнить счет.\n2. Снять деньги со счета.\n: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        int curr, add;
                        dbt_acc.Out();
                        Console.Write("Валюта:\n1. RUB.\n2. USD.\n3. EUR.\n: ");
                        curr = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Сумма для пополнения\n: ");
                        add = Convert.ToInt32(Console.ReadLine());
                        dbt_acc.Replemishment(add, curr-1);
                        dbt_acc.Out();
                        break;
                    }
                    case 2:
                    {
                        int curr, dec;
                        dbt_acc.Out();
                        Console.Write("Валюта:\n1. RUB.\n2. USD.\n3. EUR.\n: ");
                        curr = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Сумма для пополнения\n: ");
                        dec = Convert.ToInt32(Console.ReadLine());
                        dbt_acc.Debting(dec, curr - 1);
                        dbt_acc.Out();
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            DebitAccount Alice = new DebitAccount(1,1500);
            User(ref Alice);
        }
    }
}
