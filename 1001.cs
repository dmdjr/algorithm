// 백준 1001번: A-B
// https://www.acmicpc.net/problem/1001
// 두 정수 A와 B를 입력받은 다음, A-B를 출력하는 프로그램
//
// 입력: 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
// 출력: 첫째 줄에 A-B를 출력한다.
//
// 예제 입력: 3 2
// 예제 출력: 1


string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

Console.WriteLine(a - b);