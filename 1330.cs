// 백준 1330번: 두 수 비교하기
// https://www.acmicpc.net/problem/1330
// 두 정수 A와 B가 주어졌을 때, 비교 결과를 출력하는 프로그램
//
// 입력: 첫째 줄에 A와 B가 주어진다. (-10000 <= A, B <= 10000)
// 출력: A가 B보다 크면 >, 작으면 <, 같으면 == 출력
//
// 예제 입력: 1 2
// 예제 출력: <

string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

if (a > b)
{
    Console.WriteLine(">");
}
else if (a < b)
{

    Console.WriteLine("<");
}
else
{
    Console.WriteLine("==");
}