// 백준 2739번: 구구단
// https://www.acmicpc.net/problem/2739
// N을 입력받은 뒤, N의 구구단을 출력하는 프로그램
//
// 입력: 첫째 줄에 N (2 <= N <= 9)
// 출력: N*1부터 N*9까지 한 줄씩 출력
//
// 예제 입력: 2
// 예제 출력:
// 2 * 1 = 2
// 2 * 2 = 4
// ...
// 2 * 9 = 18

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < 9; i++)
{
    Console.WriteLine($"{n} * {i + 1} = {n * (i + 1)}");
}