// 백준 12789번: 도키도키 간식드리미
// https://www.acmicpc.net/problem/12789
// 번호표 순서대로(1,2,3,...) 간식을 받아야 하는데,
// 줄에 서있는 순서가 뒤죽박죽일 때
// 한 줄짜리 대기 공간(스택)을 활용해서 순서대로 받을 수 있는지 판별
//
// 입력:
// 첫째 줄: 학생 수 N
// 둘째 줄: 줄에 서있는 순서
//
// 출력: 순서대로 받을 수 있으면 Nice, 아니면 Sad
//
// 예제 입력:
// 5
// 5 4 1 3 2
//
// 예제 출력: Nice

int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
Stack<int> stack = new Stack<int>();
int nextNum = 1;

for (int i = 0; i < input.Length; i++)
{
    int a = int.Parse(input[i]);
    if (a == nextNum)
    {
        nextNum++;
        while (stack.Count > 0 && stack.Peek() == nextNum)
        {
            nextNum++;
            stack.Pop();
        }
    }
    else
    {
        stack.Push(a);
    }
}

if (stack.Count == 0)
{
    Console.WriteLine("Nice");
}
else
{
    Console.WriteLine("Sad");
}
