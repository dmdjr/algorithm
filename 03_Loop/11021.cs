// 백준 11021번: A+B - 7
// https://www.acmicpc.net/problem/11021
// T개의 테스트 케이스마다 "Case #x: A+B" 형식으로 출력
//
// 입력: 첫째 줄에 T, 다음 T줄에 A와 B
// 출력: 각 줄마다 "Case #x: " 뒤에 A+B 출력 (x는 1부터 시작)
//
// 예제 입력:
// 5
// 1 1
// 2 3
// 3 4
// 9 8
// 5 2
//
// 예제 출력:
// Case #1: 2
// Case #2: 5
// Case #3: 7
// Case #4: 17
// Case #5: 7

var writer = new StreamWriter(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    writer.WriteLine($"Case #{i + 1}: {a + b}");
}
writer.Flush();