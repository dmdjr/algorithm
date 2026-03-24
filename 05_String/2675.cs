// 백준 2675번: 문자열 반복
// https://www.acmicpc.net/problem/2675
// 문자열 S의 각 문자를 R번 반복한 새 문자열을 출력
//
// 입력: 첫째 줄에 테스트 케이스 T
//       이후 T줄에 R(반복 횟수)과 S(문자열)가 공백 구분으로 주어짐
// 출력: 각 테스트 케이스마다 반복된 문자열 출력
//
// 예제 입력:
// 2
// 3 ABC
// 5 /HTP
//
// 예제 출력:
// AAABBBCCC
// /////HHHHHTTTTTTPPPPP

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int a = int.Parse(input[0]);
    string b = input[1];
    for (int j = 0; j < b.Length; j++)
    {
        Console.Write(new string(b[j], a));
    }
    Console.WriteLine();
}

