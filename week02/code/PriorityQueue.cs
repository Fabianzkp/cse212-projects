public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority. 
    /// The node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public string Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority (and earliest enqueue order)
        int highestPriorityIndex = 0;
        for (int index = 1; index < _queue.Count; index++)
        {
            if (_queue[index].Priority > _queue[highestPriorityIndex].Priority)
            {
                highestPriorityIndex = index;
            }
            else if (_queue[index].Priority == _queue[highestPriorityIndex].Priority &&
                    _queue[index].EnqueueOrder < _queue[highestPriorityIndex].EnqueueOrder)
            {
                highestPriorityIndex = index;
            }
        }

        // Remove and return the item with the highest priority
        var value = _queue[highestPriorityIndex].Value;
        _queue.RemoveAt(highestPriorityIndex);
        return value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }
    internal int EnqueueOrder { get; set; } // Track the order of enqueue

    private static int _enqueueCounter = 0;

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
        EnqueueOrder = _enqueueCounter++;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}