using CA2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircularSinglyLinkedListTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Node_NodeCreation_NodeWithValue3()
    {
        Node Nodo3 = new Node(3);
        Assert.AreEqual(3, Nodo3.data);
    }

    [TestMethod]
    public void CircularSinglyLinkedList_CircularListCreation_ListWithNoElements()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList(); //Al estar vacía, tail debe de ser null y size 0
        Assert.AreEqual(0, list.getSize());
    }

    [TestMethod]
    public void elementsList_PrintsElementsOfList_StringWithElementsOfList()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(3);
        list.add(2);
        list.add(1);
        
        string elements = list.elementsList();
        
        Assert.AreEqual("3, 2, 1", elements);
        
    }

    [TestMethod]
    public void elementsList_PrintsElementsOfList_StringWithElementsOfEmptyList()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        string elements = list.elementsList();
        Assert.AreEqual("This list is empty", elements);
    }

    [TestMethod]
    public void elementsList_PrintsElementsOfList_StringWithElementsOfListWithOneElement()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(5);
        string elements = list.elementsList();
        Assert.AreEqual("5", elements);
        
    }

    [TestMethod]
    public void remove_DeletionOfElementsInEmptyList_ReturnsFalse()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        bool value = list.remove(5);
        Assert.IsFalse(value);
    }

    [TestMethod]
    public void remove_DeletionOfElements_ListWithOneElementLess()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(5);
        list.add(10);
        list.add(15);
        
        bool value = list.remove(15);
        
        Assert.IsTrue(value);
        Assert.AreEqual("5, 10", list.elementsList());
        
    }
    
    [TestMethod]
    public void remove_DeletionOfElements_ListWithOneElementLess_2()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(5);
        list.add(10);
        list.add(15);
        
        bool value = list.remove(10);
        
        Assert.IsTrue(value);
        Assert.AreEqual("5, 15", list.elementsList());
        
    }

    [TestMethod]
    public void remove_DeletionOfTheOnlyElementInList_ReturnsTrue()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(5);
        
        bool value = list.remove(5);
        Assert.IsTrue(value);
        Assert.AreEqual(0, list.getSize());
        Assert.AreEqual("This list is empty", list.elementsList());
    }

    [TestMethod]
    public void remove_DeletionOfElementThatIsNotInList_ReturnsFalse()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(5);
        list.add(10);

        bool value = list.remove(3);
        Assert.IsFalse(value);
        Assert.AreEqual("5, 10", list.elementsList());
        Assert.AreEqual(2,list.getSize() );
        
        
    }
    

    [TestMethod]
    public void clear_DeletionOfElementsInListWithClear_EmptyList()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(2);
        list.add(4);
        list.add(6);
        
        list.clear();
        Assert.AreEqual("This list is empty", list.elementsList());
        
    }

    [TestMethod]
    public void getSize_ObtainingTheSizeOfTheList_ReturnsCorrectSize()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(1);
        list.add(3);
        list.add(5);
        int size = list.getSize();
        Assert.AreEqual(3, size);
    }
    
    [TestMethod]
    public void getTail_ObtainingTheVaueOfTheTailOfTheList_ReturnsCorrectValueOfTail()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(1);
        list.add(3);
        list.add(5);
        int size = list.getTailValue();
        Assert.AreEqual(5, size);
    }

    [TestMethod]
    public void isEmpty_VerificationOfEmptyList_ReturnsTrue()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        bool value = list.isEmpty();
        Assert.IsTrue(value);
    }

    [TestMethod]
    public void isEmpty_VerificationOfEmptyList_ReturnsFalse()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(5);
        bool value = list.isEmpty();
        Assert.IsFalse(value);
    }

    [TestMethod]
    public void contains_VerificationThatListContainsElement_ReturnsTrue()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(5);
        list.add(3);
        list.add(2);
        
        bool value = list.contains(3);
        Assert.IsTrue(value);
    }
    
    
    [TestMethod]
    public void contains_VerificationThatListContainsElement_ReturnsFalse()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        list.add(5);
        bool value = list.contains(3);
        Assert.IsFalse(value);
    }
    
    [TestMethod]
    public void contains_VerificationThatEmptyListContainsElement_ReturnsFalse()
    {
        CircularSinlglyLinkedList list = new CircularSinlglyLinkedList();
        bool value = list.contains(5);
        Assert.IsFalse(value);
    }
    
    


}