// 백준 11720번: 숫자의 합
// https://www.acmicpc.net/problem/11720
// N개의 숫자가 공백 없이 주어졌을 때, 각 숫자를 더한 합을 출력
//
// 입력:
// 첫째 줄: 숫자의 개수 N (1 <= N <= 100)
// 둘째 줄: N개의 숫자가 공백 없이 붙어서 주어짐
//
// 출력: 각 숫자의 합
//
// 예제 입력:
// 11
// 10987654321
//
// 예제 출력: 46

int n = int.Parse(Console.ReadLine());
int sum = 0;
string input = Console.ReadLine();
for (int i = 0; i < n; i++)
{
    sum += input[i] - '0';
}
Console.WriteLine(sum);