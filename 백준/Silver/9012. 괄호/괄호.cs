// 백준 9012번: 괄호
// https://www.acmicpc.net/problem/9012
// 괄호 문자열이 올바른지(VPS) 판별하는 프로그램
//
// 입력: 첫째 줄에 테스트 케이스 T, 이후 T줄에 괄호 문자열
// 출력: 올바르면 YES, 아니면 NO
//
// 예제 입력:
// 6
// (())())
// (((()())()
// (()())((()))
// ((()()(()))(((())))())
// ()()()()(()()())()
// (()((())()(
//
// 예제 출력:
// NO
// NO
// YES
// YES
// YES
// NO

using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
bool isTop = false;
for (int i = 0; i < n; i++)
{
    int top = 0;
    string input = Console.ReadLine();
    for (int j = 0; j < input.Length; j++)
    {
        isTop = false;
        if (top == 0 && input[j] == ')')
        {
            sb.AppendLine("NO");
            isTop = true;
            break;
        }
        if (input[j] == '(')
        {
            top++;
        }
        if (input[j] == ')')
        {
            top--;
        }
    }
    if (top == 0 && isTop == false)
    {
        sb.AppendLine("YES");
    }
    else if (top != 0 && isTop == false)
    {
        sb.AppendLine("NO");
    }
}
Console.WriteLine(sb);