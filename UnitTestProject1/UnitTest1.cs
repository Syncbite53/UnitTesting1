using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            UnitTesting.Calculator calculator = new UnitTesting.Calculator();

            int result = calculator.Add(5, 3);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSortArray()
        {
            string[] strArray = new string[] { "d", "b", "c", "a" };
            UnitTesting.ArraySort arraySort = new UnitTesting.ArraySort();

            var result = arraySort.SortArray(strArray);

            var sortedArray = new string[] { "a", "b", "c", "d" };
            bool isEqual = Enumerable.SequenceEqual(sortedArray, result);
             
            Assert.AreEqual(isEqual, true);
        }

        [TestMethod]
        public void TestSortArrayEmptyList()
        {
            string[] strArray = new string[] {};
            UnitTesting.ArraySort arraySort = new UnitTesting.ArraySort();

            Exception ex = Assert.ThrowsException<System.ArgumentException>(() => arraySort.SortArray(strArray));
            Assert.AreEqual("Array list is empty.", ex.Message);
        }

        [TestMethod]
        public void Withdraw_ValidAmount_ChangesBalance()
        {
            // arrange
            double currentBalance = 10.0;
            double withdrawal = 1.0;
            double expected = 9.0;
            var account = new UnitTesting.CheckingAccount("JohnDoe", currentBalance);

            // act
            account.Withdraw(withdrawal);

            // assert
            Assert.AreEqual(expected, account.Balance);
        }

        [TestMethod]
        public void Withdraw_AmountMoreThanBalance_Throws()
        {
            // arrange
            var account = new UnitTesting.CheckingAccount("John Doe", 10.0);

            // act and assert
            Assert.ThrowsException<System.ArgumentException>(() => account.Withdraw(20.0));
        }
    }
}
