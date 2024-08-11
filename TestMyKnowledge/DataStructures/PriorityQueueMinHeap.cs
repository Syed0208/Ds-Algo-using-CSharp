using TestMyKnowledge.CustomClass;

namespace TestMyKnowledge.DataStructures
{
    internal class PriorityQueueMinHeap
    {
        public void MinHeapExample()
        {
            var priorityQueue = new PriorityQueue<CustomTask, int>();
            priorityQueue.Enqueue(new CustomTask { Name = "Task A", Priority = 3 }, 3);
            priorityQueue.Enqueue(new CustomTask { Name = "Task B", Priority = 2 }, 0);
            priorityQueue.Enqueue(new CustomTask { Name = "Task C", Priority = 1 }, 1);

            while (priorityQueue.Count > 0)
            {
                var task = priorityQueue.Dequeue();
                Console.WriteLine("Executing task: {0}", task.Name);
            }
        }
    }
}
