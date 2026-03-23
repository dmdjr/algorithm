// 백준 25304번: 영수증
// https://www.acmicpc.net/problem/25304
// 구매한 물건의 총 금액이 영수증에 적힌 총 금액과 일치하는지 확인
//
// 입력:
// 첫째 줄: 총 금액 X
// 둘째 줄: 물건 종류 수 N
// 이후 N줄: 각 물건의 가격 a와 개수 b
//
// 출력: 일치하면 Yes, 아니면 No
//
// 예제 입력:
// 260000
// 4
// 20000 5
// 30000 2
// 10000 6
// 5000 8
//
// 예제 출력:
// Yes


int total = int.Parse(Console.ReadLine());
int kind = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= kind; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    sum = sum + a * b;
}
if (total == sum)
{
    Console.WriteLine("Yes");
    
}
else
{
    Console.WriteLine("No");
}

