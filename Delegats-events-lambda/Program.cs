using System;

namespace Delegats_events_lambda
{
    internal class Program
    {
        delegate void Message(string name);
        delegate int Operation(int x, int y);
        delegate T Operation<T, K>(K val);
        static void Main(string[] args)
        {
            Message mes;
            mes = Hello;
            mes += HowAreYou;
            mes("Vadim");

            Operation oper = Add;
            oper += Multiply;
            int result = oper.Invoke(5, 10);
            Console.WriteLine(result);
            DoSomeThings(5, 10, Add);
            /////////
            void Hello(string name) => Console.WriteLine($"Hello {name} ");
            void HowAreYou(string name) => Console.WriteLine($"How are you {name}");
            int Add(int a, int y) => a + y;
            int Multiply(int a, int b) => a * b;
            ///////
            void DoSomeThings(int a, int b, Operation op)
            {
                Console.WriteLine(op(a, b));
            }
            ////////
            Bank bank = new Bank(300);
            bank.Notify += displayMessage;
            bank.Notify += displayRedMessage;

            bank.Put(100);
            bank.Take(1000);


            void displayMessage(string message) => Console.WriteLine(message);
            void displayRedMessage(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }

        }
    }
}
