using System;
using System.Collections.Generic;

namespace TestMyKnowledge
{
    public class Task1
    {
        public string Name { get; set; }
        public int Priority { get; set; }
# region not needed
        //public int CompareTo(Task1? other)
        //{
        //    return Priority.CompareTo(other?.Priority);
        //}
#endregion
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var priorityQueue = new PriorityQueue<Task1, int>();
            priorityQueue.Enqueue(new Task1 { Name = "Task A", Priority = 3 }, 3);
            priorityQueue.Enqueue(new Task1 { Name = "Task B", Priority = 2 }, 0);
            priorityQueue.Enqueue(new Task1 { Name = "Task C", Priority = 1 }, 1);

            while (priorityQueue.Count > 0)
            {
                var task = priorityQueue.Dequeue();
                Console.WriteLine("Executing task: {0}", task.Name);
            }
        }
    }
}
