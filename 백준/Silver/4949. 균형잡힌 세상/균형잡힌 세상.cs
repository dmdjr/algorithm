// 백준 4949번: 균형잡힌 세상
// https://www.acmicpc.net/problem/4949
// 소괄호와 대괄호가 올바르게 짝지어졌는지 판별
//
// 규칙:
// ( 와 ) 는 짝이 맞아야 함
// [ 와 ] 는 짝이 맞아야 함
// ( 와 ] 또는 [ 와 ) 처럼 섞이면 안 됨
//
// 입력: 여러 줄에 문자열이 주어지며, "."만 입력되면 종료
// 출력: 올바르면 yes, 아니면 no
//

using System.Text;

Stack<char> stack = new Stack<char>();
StringBuilder sb = new StringBuilder();
while (true)
{
    stack.Clear();
    bool isRight = true;
    string input = Console.ReadLine();
    if (input == ".") break;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == '(' || input[i] == '[')
        {
            stack.Push(input[i]);
        }
        if (input[i] == ')')
        {
            if (stack.Count > 0)
            {
                char a = stack.Pop();

                if (a == '(')
                {
                    isRight = true;
                }
                else
                {
                    isRight = false;
                    break;
                }
            }
            else
            {
                isRight = false;
                break;
            }

        }
        if (input[i] == ']')
        {
            if (stack.Count > 0)
            {
                char a = stack.Pop();
                if (a == '[')
                {
                    isRight = true;
                }
                else
                {
                    isRight = false;
                    break;
                }
            }
            else
            {
                isRight = false;
                break;
            }

        }
    }
    if (isRight && stack.Count == 0)
    {
        sb.AppendLine("yes");
    }
    else
    {
        sb.AppendLine("no");
    }
}

Console.WriteLine(sb);
