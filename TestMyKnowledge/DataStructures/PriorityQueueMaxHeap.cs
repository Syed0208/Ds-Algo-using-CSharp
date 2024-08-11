using TestMyKnowledge.CustomClass;

namespace TestMyKnowledge.DataStructures
{
    internal class PriorityQueueMaxHeap
    {
        public void MaxHeapExample()
        {
            var priorityQueue = new PriorityQueue<CustomTask, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            priorityQueue.Enqueue(new CustomTask { Name = "Task A", Priority = 3 }, 3);
            priorityQueue.Enqueue(new CustomTask { Name = "Task B", Priority = 2 }, 4);
            priorityQueue.Enqueue(new CustomTask { Name = "Task C", Priority = 1 }, 5);

            Console.WriteLine();

            while (priorityQueue.Count > 0)
            {
                var task = priorityQueue.Dequeue();
                Console.WriteLine("Executing task: {0}", task.Name);
            }
        }
    }
}
