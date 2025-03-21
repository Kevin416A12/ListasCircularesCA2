using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LIstasCirculares;

namespace CircularListTests
{
    [TestClass]
    public class DoublyCircularLinkedListTests
    {
        private DoublyCircularLinkedList<int> doublyList;

        [TestInitialize]
        public void Setup()
        {
            doublyList = new DoublyCircularLinkedList<int>();
        }

        [TestMethod]
        public void Test_InsertAtStart()
        {
            doublyList.InsertAtStart(10);
            doublyList.InsertAtStart(5);
            Assert.AreEqual("5, 10", doublyList.ToString());
        }

        [TestMethod]
        public void Test_InsertAtEnd()
        {
            doublyList.InsertAtEnd(1);
            doublyList.InsertAtEnd(2);
            doublyList.InsertAtEnd(3);
            Assert.AreEqual("1, 2, 3", doublyList.ToString());
        }

        [TestMethod]
        public void Test_InsertAt_Middle()
        {
            doublyList.InsertAtEnd(1);
            doublyList.InsertAtEnd(3);
            doublyList.InsertAt(2, 1);
            Assert.AreEqual("1, 2, 3", doublyList.ToString());
        }

        [TestMethod]
        public void Test_RemoveAtStart()
        {
            doublyList.InsertAtEnd(1);
            doublyList.InsertAtEnd(2);
            doublyList.RemoveAtStart();
            Assert.AreEqual("2", doublyList.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_RemoveAtStart_Empty_Throws()
        {
            doublyList.RemoveAtStart();
        }

        [TestMethod]
        public void Test_RemoveAtEnd()
        {
            doublyList.InsertAtEnd(1);
            doublyList.InsertAtEnd(2);
            doublyList.RemoveAtEnd();
            Assert.AreEqual("1", doublyList.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_RemoveAtEnd_Empty_Throws()
        {
            doublyList.RemoveAtEnd();
        }

        [TestMethod]
        public void Test_RemoveAt_Middle()
        {
            doublyList.InsertAtEnd(1);
            doublyList.InsertAtEnd(2);
            doublyList.InsertAtEnd(3);
            doublyList.RemoveAt(1);
            Assert.AreEqual("1, 3", doublyList.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_RemoveAt_InvalidIndex_Throws()
        {
            doublyList.InsertAtEnd(1);
            doublyList.RemoveAt(5);
        }

        [TestMethod]
        public void Test_Size()
        {
            doublyList.InsertAtEnd(1);
            doublyList.InsertAtEnd(2);
            Assert.AreEqual(2, doublyList.Size());
        }

        [TestMethod]
        public void Test_ToString_Empty()
        {
            Assert.AreEqual("", doublyList.ToString());
        }
    }
}
