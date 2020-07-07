using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            int result = calculator.Add(5, 6);

            if (result != 11)
                throw new InvalidOperationException();

        }
    }

    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

    }

    public class CheckingAccount
    {
        private double m_balance;

        public double Balance { get { return this.m_balance; } set { m_balance = value; } }

        public CheckingAccount(string name, double currentBalance)
        {
            m_balance = currentBalance;
        }

        public void Withdraw(double amount)
        {
            if (m_balance >= amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
            }
        }
    }
    public class ArraySort
    {
        public string[] SortArray(string[] strArray)
        {
            if (strArray.Count() == 0)
                throw new ArgumentException("Array list is empty.");

            Array.Sort(strArray);
            return strArray;

        }
    }
}
