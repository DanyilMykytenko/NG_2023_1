using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats_events_lambda
{
    public class Bank
    {
        public delegate void BankHandler(string message);
        public event BankHandler? Notify;
        public Bank(int sum) => Sum = sum;
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"Money was add: {sum}");
        }
        public void Take(int sum)
        {
            if(Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Money take: {sum}");
            }
            else
            {
                Notify?.Invoke($"Not enough money");
            }
        }
    }
}
