namespace lab6;

public class QuequeLab: ILab8QueuePartBasicLevel
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    
    public QuequeLab(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }
    
    public List<int> GetSequence(int N)
    {
        List<int> sequence = new List<int>();
        Queue<int> queueA = new Queue<int>();
        Queue<int> queueB = new Queue<int>();
        Queue<int> queueC = new Queue<int>();

        

        queueA.Enqueue(2);
        queueB.Enqueue(3);
        queueC.Enqueue(5);

        while (sequence.Count < N)
        {
            int nextNumber = Math.Min(queueA.Peek(), Math.Min(queueB.Peek(), queueC.Peek()));

            if (nextNumber == queueA.Peek())
            {
                queueA.Dequeue();
            }

            if (nextNumber == queueB.Peek())
            {
                queueB.Dequeue();
            }

            if (nextNumber == queueC.Peek())
            {
                queueC.Dequeue();
            }

            sequence.Add(nextNumber);

            queueA.Enqueue(nextNumber * A);
            queueB.Enqueue(nextNumber * B);
            queueC.Enqueue(nextNumber * C);
        }

        return sequence;
    }

    static void Main()
    {
        QuequeLab _sequence = new QuequeLab(2, 3, 5);
        List<int> sequence = _sequence.GetSequence(10);
        Console.WriteLine(string.Join(", ", sequence));
    }
     
}