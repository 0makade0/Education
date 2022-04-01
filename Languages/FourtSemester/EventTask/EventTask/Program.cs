using System;
using EventTask.Events;

namespace EventTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int countEventValid = 7;
            var account = new Account(100, countEventValid);
            account.NotifyFromAction += DisplayMessage;
            account.NotifyFromCountAction += ExceedCount;
            account.NotifyFromMoreCountValidAction += MoreValidActionMessage;
            account.NotifyQueueClear += QueueCheckOperations;

            account.Put(20);
            account.Put(50);
            account.Take(100);
            account.Put(200);
            account.Put(50);
            account.Take(100);
            account.Put(20);
            account.Put(500);
            account.Take(100);
            
            account.QueueOperationClear();
            account.QueueCheckClear();
        }

        static void DisplayMessage(Account sender, AccountEventArgs sms1)
        {
            Console.WriteLine($"Сумма транзакции: {sms1.Sum}");
            Console.WriteLine(sms1.Message);
            Console.WriteLine($"Текущая сумма на счёте:{sender.Sum}");
        }

        static void ExceedCount(Account sender, AccountCountOfOperationsEvent sms2)
        {
            Console.WriteLine(sms2.Message);
            Console.WriteLine($"Произведена операция№ {sms2.CountOperation}");
        }

        static void MoreValidActionMessage(Account sender, AccountCountOfOperationMoreValidEvent sms3)
        {
            Console.WriteLine(sms3.Message);
        }

        static void QueueCheckOperations(Account sender, QueueClearEvent sms4)
        {
            Console.WriteLine(sms4.Message);
        }
    }
}