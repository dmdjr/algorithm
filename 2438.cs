// 백준 2438번: 별 찍기 - 1
// https://www.acmicpc.net/problem/2438
// N을 입력받은 뒤, 별을 찍는 프로그램
//
// 입력: 첫째 줄에 N (1 <= N <= 100)
// 출력: 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, ... N번째 줄에는 별 N개
//
// 예제 입력: 5
// 예제 출력:
// *
// **
// ***
// ****
// *****

int n = int.Parse(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     Console.WriteLine(new string('*', i));
// }

for(int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
