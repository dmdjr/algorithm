// 백준 14681번: 사분면 고르기
// https://www.acmicpc.net/problem/14681
// 점의 좌표 (x, y)가 주어졌을 때, 몇 사분면에 있는지 출력
//
// 입력: 첫째 줄에 x, 둘째 줄에 y (-1000 <= x, y <= 1000, x != 0, y != 0)
// 출력: 사분면 번호 (1, 2, 3, 4 중 하나)
//
// 예제 입력:
// 12
// 5
// 예제 출력: 1
//
// 참고: 1사분면(+,+) 2사분면(-,+) 3사분면(-,-) 4사분면(+,-)

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > 0 && b > 0)
{
    Console.WriteLine("1");
}
else if (a > 0 && b < 0)
{
    Console.WriteLine("4");
}
else if (a < 0 && b > 0)
{
    Console.WriteLine("2");
}
else if (a < 0 && b < 0)
{
    Console.WriteLine("3");
}