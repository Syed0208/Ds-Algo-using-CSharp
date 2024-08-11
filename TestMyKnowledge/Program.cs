using TestMyKnowledge.DataStructures;

namespace TestMyKnowledge
{
    public class Program
    {
        static void Main(string[] args)
        {
            var minHeap = new PriorityQueueMinHeap();
            minHeap.MinHeapExample();

            var maxHeap = new PriorityQueueMaxHeap();
            maxHeap.MaxHeapExample();

        }
    }
}
