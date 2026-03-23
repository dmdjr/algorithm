// 백준 10871번: X보다 작은 수
// https://www.acmicpc.net/problem/10871
// 정수 N개로 이루어진 수열에서 X보다 작은 수를 모두 출력하는 프로그램
//
// 입력: 첫째 줄에 N과 X (1 <= N <= 10000, 1 <= X <= 10000)
//       둘째 줄에 N개의 정수 (1 이상 10000 이하)
// 출력: X보다 작은 수를 공백으로 구분하여 출력
//
// 예제 입력:
// 10 5
// 1 10 4 9 2 3 8 5 7 6
//
// 예제 출력:
// 1 4 2 3

string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
string[] nums = Console.ReadLine().Split(' ');
for (int i = 0; i < a; i++)
{
    if (int.Parse(nums[i]) < b)
    {
        Console.Write(nums[i] + ' ');
    }
}



