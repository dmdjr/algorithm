// 백준 10828번: 스택
// https://www.acmicpc.net/problem/10828
// 스택을 구현하고 5가지 명령어를 처리하는 프로그램
//
// 명령어:
// push X — X를 스택에 넣기
// pop — 가장 위의 수를 빼고 출력 (없으면 -1)
// size — 스택 크기 출력
// empty — 비었으면 1, 아니면 0
// top — 가장 위의 수 출력 (없으면 -1)
//
// 입력: 첫째 줄에 명령 수 N, 이후 N줄에 명령어
// 출력: 각 명령에 대한 결과 출력
//
// 예제 입력:
// 14
// push 1
// push 2
// top
// size
// empty
// pop
// pop
// pop
// size
// empty
// pop
// push 3
// empty
// top
//
// 예제 출력:
// 2
// 2
// 0
// 2
// 1
// -1
// 0
// 1
// -1
// 0
// 3
using System.Text;


int n = int.Parse(Console.ReadLine());
int[] stack = new int[10000];
int top = -1;
StringBuilder sb = new StringBuilder();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    switch (input[0])
    {
        case "push":
            top++;
            stack[top] = int.Parse(input[1]);
            break;
        case "pop":
            if (top == -1)
            {
                sb.AppendLine((-1).ToString());
            }
            else
            {
                sb.AppendLine(stack[top].ToString());
                top--;
            }
            break;
        case "size":
            sb.AppendLine((top + 1).ToString());
            break;
        case "empty":
            if (top == -1)
            {
                sb.AppendLine(1.ToString());
            }
            else
            {
                sb.AppendLine(0.ToString());
            }
            break;
        case "top":
            if (top == -1)
            {
                sb.AppendLine((-1).ToString());
            }
            else
            {
                sb.AppendLine(stack[top].ToString());
            }
            break;
    }
}
Console.WriteLine(sb);
