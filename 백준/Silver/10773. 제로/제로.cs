// 백준 10773번: 제로
// https://www.acmicpc.net/problem/10773
// 수를 입력받다가 0이 나오면 가장 최근 수를 지우고, 남은 수의 합을 출력
//
// 입력: 첫째 줄에 K (1 <= K <= 100000), 이후 K줄에 정수
// 출력: 남은 수의 합
//
// 예제 입력:
// 4
// 3
// 0
// 4
// 0
//
// 예제 출력: 0

int k = int.Parse(Console.ReadLine());
int[] stack = new int[100000];
int top = 0;
int sum = 0;
for (int i = 0; i < k; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n != 0)
    {
        stack[top] = n;
        top++;
    }
    else
    {
        top--;
        stack[top] = 0;
    }
}
for (int i = 0; i < top; i++)
{
    sum += stack[i];
}
Console.WriteLine(sum);