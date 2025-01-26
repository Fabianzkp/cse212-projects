using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue a single item with high priority.
    // Expected Result: Dequeue should return that item.
    // Defect(s) Found:
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Item1", result);
    }

    [TestMethod]
    // Scenario: Enqueue items with different priorities.
    // Expected Result: Dequeue should return items in priority order (highest first).
    // Defect(s) Found:
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 10);
        priorityQueue.Enqueue("Item2", 5);
        priorityQueue.Enqueue("Item3", 15);

        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with the same high priority.
    // Expected Result: Dequeue should return items in the order they were enqueued (FIFO).
    // Defect(s) Found:
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 10);
        priorityQueue.Enqueue("Item2", 10);
        priorityQueue.Enqueue("Item3", 10);

        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Dequeue should throw an InvalidOperationException.
    // Defect(s) Found:
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    // I could add more test methods here. But I stopped here.
}