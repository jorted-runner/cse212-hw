using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Test 1", 5);
        priorityQueue.Enqueue("Test 2", 1);
        var A = priorityQueue.Dequeue();
        Assert.AreEqual("Test 1", A);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Test 3", 1);
        priorityQueue.Enqueue("First Entry", 6);
        priorityQueue.Enqueue("Test 1", 1);
        priorityQueue.Enqueue("Test 2", 6);
        var A = priorityQueue.Dequeue();
        Assert.AreEqual("First Entry", A);
    }

    // Add more test cases as needed below.
}