using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_standard()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Test 1", 6);
        priorityQueue.Enqueue("Test 2", 3);
        priorityQueue.Enqueue("Test 3", 1);
        priorityQueue.Enqueue("Test 4", 0);
        priorityQueue.Enqueue("Test 5", 7);
        priorityQueue.Enqueue("Test 6", 3);

        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();

        Assert.AreEqual("Test 6", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_withNegative()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Test 3", 10);
        priorityQueue.Enqueue("First Entry", 6);
        priorityQueue.Enqueue("Test 1", -10);
        priorityQueue.Enqueue("Test 2", 6);
        var A = priorityQueue.Dequeue();
        Assert.AreEqual("Test 3", A);
    }

    // Add more test cases as needed below.
    [TestMethod]
    public void TestPriorityQueue_withAllNegative()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Test 1", -1);
        priorityQueue.Enqueue("Test 2", -6);
        priorityQueue.Enqueue("Test 3", -10);
        priorityQueue.Enqueue("Test 4", -6);
        var A = priorityQueue.Dequeue();
        Assert.AreEqual("Test 1", A);
    }
    
    [TestMethod]
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}