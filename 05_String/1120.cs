// 백준 1120번: 문자열
// https://www.acmicpc.net/problem/1120
// 길이가 다른 두 문자열 A, B가 주어질 때 (A가 B보다 짧거나 같음)
// A의 앞뒤에 아무 문자나 붙여서 B와 길이를 같게 만든 후
// 두 문자열의 차이(다른 문자 개수)의 최솟값을 출력
//
// 입력: 문자열 A와 B (공백 구분)
// 출력: 차이의 최솟값
//
// 예제 입력: adaabc aababbc
// 예제 출력: 3

string[] input = Console.ReadLine().Split(' ');
string a = input[0];
string b = input[1];
int min = int.MaxValue;
for (int i = 0; i < b.Length - a.Length + 1; i++)
{
    int count = 0;
    for (int j = 0; j < a.Length; j++)
    {
        if (a[j] != b[i + j])
        {
            count++;
        }
    }
    if (count < min)
    {
        min = count;
    }
}
Console.WriteLine(min);