// 백준 2439번: 별 찍기 - 2
// https://www.acmicpc.net/problem/2439
// 오른쪽 정렬로 별을 찍는 프로그램
//
// 입력: 첫째 줄에 N (1 <= N <= 100)
// 출력: 오른쪽으로 정렬한 별 삼각형
//
// 예제 입력: 5
// 예제 출력:
//     *
//    **
//   ***
//  ****
// *****

using System.Linq.Expressions;
using System.Xml;

int n = int.Parse(Console.ReadLine());
// for (int i = 0; i < n; i++)
// {
//     for (int j = n - 1; j > i; j--)
//     {
//         Console.Write(" ");
//     }
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

for(int i = 1; i <= n; i++)
{
    Console.WriteLine(new string(' ', n - i) + new string('*', i));
}
