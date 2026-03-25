// 백준 1427번: 소트인사이드
// https://www.acmicpc.net/problem/1427
// 수의 각 자리수를 내림차순으로 정렬하여 출력
//
// 입력: 첫째 줄에 정수 N (1 <= N <= 1,000,000,000)
// 출력: 각 자리수를 내림차순 정렬한 수
//
// 예제 입력: 2143
// 예제 출력: 4321

string input = Console.ReadLine();
char[] arr = input.ToCharArray();
Array.Sort(arr);
for (int i = arr.Length - 1; i >= 0; i--)
{
    Console.Write(arr[i]);
}