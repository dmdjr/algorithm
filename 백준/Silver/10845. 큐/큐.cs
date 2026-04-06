using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>();
int back = 0;
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    switch (input[0])
    {
        case "push":
            queue.Enqueue(int.Parse(input[1]));
            back = int.Parse(input[1]);
            break;
        case "pop":
            if (queue.Count == 0)
            {
                sb.AppendLine((-1).ToString());
            }
            else
            {
                sb.AppendLine(queue.Dequeue().ToString());
            }
            break;
        case "size":
            sb.AppendLine(queue.Count.ToString());
            break;
        case "empty":
            if (queue.Count == 0)
            {
                sb.AppendLine(1.ToString());
            }
            else
            {
                sb.AppendLine(0.ToString());
            }
            break;
        case "front":
            if (queue.Count == 0)
            {
                sb.AppendLine((-1).ToString());
            }
            else
            {
                sb.AppendLine(queue.Peek().ToString());
            }
            break;
        case "back":
            if (queue.Count == 0)
            {
                sb.AppendLine((-1).ToString());
            }
            else
            {
                sb.AppendLine(back.ToString());
            }
            break;


    }
}
Console.WriteLine(sb);