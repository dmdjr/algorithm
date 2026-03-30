// 백준 10866번: 덱
// https://www.acmicpc.net/problem/10866
// 덱(Deque)을 구현하는 프로그램
//
// 명령어:
// push_front X: 앞에 X를 넣기
// push_back X: 뒤에 X를 넣기
// pop_front: 맨 앞 수를 빼고 출력 (없으면 -1)
// pop_back: 맨 뒤 수를 빼고 출력 (없으면 -1)
// size: 크기 출력
// empty: 비어있으면 1, 아니면 0
// front: 맨 앞 수 출력 (없으면 -1)
// back: 맨 뒤 수 출력 (없으면 -1)
//
// 입력: 첫째 줄에 명령 수 N (1 <= N <= 10,000)
// 출력: 각 명령에 대한 결과
//
using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
LinkedList<int> deque = new LinkedList<int>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    switch (input[0])
    {
        case "push_front":
            deque.AddFirst(int.Parse(input[1]));
            break;
        case "push_back":
            deque.AddLast(int.Parse(input[1]));
            break;
        case "pop_front":
            if (deque.Count == 0)
            {
                sb.AppendLine((-1).ToString());
            }
            else
            {
                sb.AppendLine(deque.First.Value.ToString());
                deque.RemoveFirst();
            }
            break;
        case "pop_back":
            if (deque.Count == 0)
            {
                sb.AppendLine((-1).ToString());
            }
            else
            {
                sb.AppendLine(deque.Last.Value.ToString());
                deque.RemoveLast();
            }
            break;
        case "size":
            sb.AppendLine(deque.Count.ToString());
            break;
        case "empty":
            if (deque.Count == 0)
            {
                sb.AppendLine(1.ToString());
            }
            else
            {
                sb.AppendLine(0.ToString());
            }
            break;
        case "front":
            if (deque.Count == 0)
            {
                sb.AppendLine((-1).ToString());
            }
            else
            {
                sb.AppendLine(deque.First.Value.ToString());
            }
            break;
        case "back":
            if (deque.Count == 0)
            {
                sb.AppendLine((-1).ToString());
            }
            else
            {
                sb.AppendLine(deque.Last.Value.ToString());
            }
            break;
    }
}
Console.WriteLine(sb);
