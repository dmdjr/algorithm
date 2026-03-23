// 백준 2908번: 상수
// https://www.acmicpc.net/problem/2908
// 세 자리 수 두 개가 주어졌을 때, 각각 뒤집어서 비교하여 큰 수를 출력
//
// 입력: 세 자리 수 A와 B (공백 구분)
// 출력: 뒤집은 수 중 큰 수
//
// 예제 입력: 734 893
// 예제 출력: 437
//
// 설명: 734 → 437, 893 → 398, 437 > 398 이므로 437 출력

string[] input = Console.ReadLine().Split(' ');
string a = input[0];
string b = input[1];
int revA = int.Parse("" + a[2] + a[1] + a[0]);
int revB = int.Parse("" + b[2] + b[1] + b[0]);

Console.WriteLine(Math.Max(revA, revB));