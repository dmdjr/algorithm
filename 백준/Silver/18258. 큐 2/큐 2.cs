// 백준 18258번: 큐 2
// https://www.acmicpc.net/problem/18258
// 큐를 구현하는 프로그램
//
// 명령어:
// push X: 정수 X를 큐에 넣기
// pop: 맨 앞의 수를 빼고 출력 (없으면 -1)
// size: 큐의 크기 출력
// empty: 비어있으면 1, 아니면 0
// front: 맨 앞의 수 출력 (없으면 -1)
// back: 맨 뒤의 수 출력 (없으면 -1)
//
// 입력: 첫째 줄에 명령 수 N (1 <= N <= 2,000,000)
// 출력: 각 명령에 대한 결과
//

using System.Text;

int n = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>();
StringBuilder sb = new StringBuilder();
int back = 0;
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
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