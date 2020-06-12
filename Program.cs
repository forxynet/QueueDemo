using System.Collections;

namespace QueueDemo {
    class Program {
        static void Main(string[] args) {

            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue("Fello");
            q.Enqueue(3.14f);
            q.Enqueue(true);
            q.Enqueue(67.8);
            q.Enqueue('A');

            //printing the enque items using foreach Enqueue method

            foreach (var item in q) {
                System.Console.WriteLine(item + " ");
            }
            System.Console.WriteLine();

            System.Console.WriteLine(q.Dequeue());
            System.Console.WriteLine();

            foreach (var item in q) {
                System.Console.WriteLine(item + " ");
            }
            System.Console.WriteLine();

            System.Console.WriteLine(q.Peek());
            System.Console.WriteLine();

            foreach (var item in q) {
                System.Console.WriteLine(item + " ");
            }

            System.Console.ReadLine();
        }
    }
}
