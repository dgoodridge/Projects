using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cstypes
{
    public class Invoice
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }


    [TestClass]
    public class ReferenceTypesandValueTypes
    {
        [TestMethod]
        public void IdentityTest()
        {
            Invoice firstInvoice = new Invoice();
            firstInvoice.ID = 1;
            firstInvoice.Description = "Test";
            firstInvoice.Amount = 0.0M;

            Invoice secondInvoice = new Invoice();
            secondInvoice.ID = 1;
            secondInvoice.Description = "Test";
            secondInvoice.Amount = 0.0M;

            Assert.IsFalse(object.ReferenceEquals(secondInvoice, firstInvoice));
            Assert.IsTrue(firstInvoice.ID == 1);

            secondInvoice.ID = 2;

            Assert.IsTrue(secondInvoice.ID == 2);
            Assert.IsTrue(firstInvoice.ID == 1);

            secondInvoice = firstInvoice;
            Assert.IsTrue(object.ReferenceEquals(secondInvoice, firstInvoice));

            secondInvoice.ID = 5;
            Assert.IsTrue(firstInvoice.ID == 5); //true because both reference the same object after second=first assignment
        }

        [TestMethod]
        public void ValueTypeTest()
        {
            int x = 5;
            int y = x;

            y = 10;

            Assert.IsTrue(x == 5);
        }

        [TestMethod]
        public void PassByValue()
        {
            Invoice invoice = new Invoice();
            invoice.ID = 1;
            int value = 1;

            DoWork(invoice, value);

            Assert.IsTrue(invoice.ID == 5);
            Assert.IsTrue(value == 1);
            //Assert.IsTrue(value == 3); For this to be True, prefix value with ref keyword in DoWork method
        }

        void DoWork(Invoice invoice, int value)
        {
            invoice.ID = 5;
            value = 3;
        }

        [TestMethod]
        public void PassByValueWithRef()
        {
            Invoice invoice = new Invoice();
            invoice.ID = 1;
            int value = 1;

            RefDoWork(invoice, ref value);

            Assert.IsTrue(invoice.ID == 5);
            Assert.IsTrue(value == 3);
        }

        void RefDoWork(Invoice invoice, ref int value)
        {
            invoice.ID = 5;
            value = 3;
        }

        [TestMethod]
        public void String() //Strings are immutable
        {
            string name = " Scott ";
            name.Trim();

            Assert.IsFalse(name.Equals("Scott", StringComparison.CurrentCulture));

            name = name.Trim();
            Assert.IsTrue(name.Equals("Scott", StringComparison.CurrentCulture));
        }
    }
}