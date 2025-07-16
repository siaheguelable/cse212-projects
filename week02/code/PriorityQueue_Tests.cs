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
    // Create a priority queue and enqueue items with different priorities
    // The item with the highest priority should be dequeued first.
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low priority", 1);
        priorityQueue.Enqueue("medium priority", 2);
        priorityQueue.Enqueue("high priority", 3);
        // Dequeue items and verify the order of priorities
        // The expected order is: high priority, medium priority, low priority

        var dequeuedItem1 = priorityQueue.Dequeue();
        var dequeuedItem2 = priorityQueue.Dequeue();
        var dequeuedItem3 = priorityQueue.Dequeue();
        // Assert that the dequeued items are in the expected order

        Assert.AreEqual("high priority", dequeuedItem1);
        Assert.AreEqual("medium priority", dequeuedItem2);
        Assert.AreEqual("low priority", dequeuedItem3);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low priority", 1);
        priorityQueue.Enqueue("medium priority", 2);
        priorityQueue.Enqueue("high priority", 3);

        var dequeuedItem1 = priorityQueue.Dequeue();
        var dequeuedItem2 = priorityQueue.Dequeue();
        var dequeuedItem3 = priorityQueue.Dequeue();

        Assert.AreEqual("high priority", dequeuedItem1);
        Assert.AreEqual("medium priority", dequeuedItem2);
        Assert.AreEqual("low priority", dequeuedItem3);
    }

    // Add more test cases as needed below.
}