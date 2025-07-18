using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities
    // Expected Result:  high priority, medium priority, low priority
    // Defect(s) Found:  The defect is that the queue does not handle priority correctly.
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
    // Scenario:  Enqueue items with different priorities and dequeue them
    // Expected Result:  high priority, medium priority, low priority
    // Defect(s) Found:  The defect is that the queue does not handle priority correctly.
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
    [TestMethod]
    // Scenario: Dequeue from an empty queue
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority
    public void TestPriorityQueue_SamePriority()    
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 1);
        priorityQueue.Enqueue("item2", 1);
        priorityQueue.Enqueue("item3", 1);

        var dequeuedItem1 = priorityQueue.Dequeue();
        var dequeuedItem2 = priorityQueue.Dequeue();
        var dequeuedItem3 = priorityQueue.Dequeue();

        // The order of dequeuing should be the same as the order of enqueuing
        Assert.AreEqual("item1", dequeuedItem1);
        Assert.AreEqual("item2", dequeuedItem2);
        Assert.AreEqual("item3", dequeuedItem3);
    }
}