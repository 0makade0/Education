using System;
using System.Collections.Generic;
using EventTask.Events;

namespace EventTask
{
    public class Account
    {
        public delegate void AccountHandler(Account sender, AccountEventArgs sms1);

        public delegate void AccountCountOperation(Account sender, AccountCountOfOperationsEvent sms2);

        public delegate void AccountCountOperationMoreValid(Account sender, AccountCountOfOperationMoreValidEvent sms3);

        public delegate void QueueClear(Account sender, QueueClearEvent sms4);

        public event AccountHandler? NotifyFromAction;
        public event AccountCountOperation? NotifyFromCountAction;
        public event AccountCountOperationMoreValid? NotifyFromMoreCountValidAction;
        public event QueueClear? NotifyQueueClear;
        public int Sum { get; private set; }
        public int CountEventValid { get; }

        //Account queue of operation
        private protected static List<int> OperationList { get; } = new List<int> { };
        Queue<int> operationQueue = new Queue<int>(OperationList);

        public Account(int sum, int countEventValid)
        {
            Sum = sum;
            CountEventValid = countEventValid;
        }

        public void Put(int sum)
        {
            if (CountEventValid > operationQueue.Count)
            {
                Sum += sum;
                NotifyFromAction?.Invoke(this, new AccountEventArgs($"На счёт поступило: {sum} д.е.", sum));
                operationQueue.Enqueue(sum);
                NotifyFromCountAction?.Invoke(this,
                    new AccountCountOfOperationsEvent(
                        $"Была совершена операция по счёту. Количество допустимых операция {CountEventValid - operationQueue.Count} ",
                        operationQueue.Count));
            }
            else
            {
                NotifyFromMoreCountValidAction?.Invoke(this,
                    new AccountCountOfOperationMoreValidEvent(
                        "Количество допустимых операций превышено. Попробуйте позже"));
            }
        }

        public void Take(int sum)
        {
            if (CountEventValid > operationQueue.Count)
            {
                if (Sum >= sum)
                {
                    Sum -= sum;
                    NotifyFromAction?.Invoke(this, new AccountEventArgs($"Со счёта снято: {sum} д.е.", sum));
                }
                else
                {
                    NotifyFromAction?.Invoke(this,
                        new AccountEventArgs($"На счету недостаточно средств. Текущий баланс равен {sum}", sum));
                }

                operationQueue.Enqueue(sum);
                NotifyFromCountAction?.Invoke(this,
                    new AccountCountOfOperationsEvent(
                        $"Была совершена операция по счёту. Количество допустимых операция {CountEventValid - operationQueue.Count} ",
                        operationQueue.Count));
            }
            else
            {
                NotifyFromMoreCountValidAction?.Invoke(this,
                    new AccountCountOfOperationMoreValidEvent(
                        "Количество допустимых операций превышено. Попробуйте позже"));
            }
        }

        public void QueueOperationClear() => operationQueue.Clear();

        public void QueueCheckClear()
        {
            if (operationQueue.Count == 0)
            {
                Console.WriteLine();
                NotifyQueueClear?.Invoke(this, new QueueClearEvent("Нет операций в очереди"));
            }
        }
    }
}