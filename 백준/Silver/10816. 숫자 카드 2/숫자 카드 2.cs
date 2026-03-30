// 백준 10816번: 숫자 카드 2
// https://www.acmicpc.net/problem/10816
// 숫자 카드가 몇 개인지 각각 구하는 프로그램
//
// 입력:
// 첫째 줄: 가지고 있는 카드 수 N
// 둘째 줄: N개의 카드 숫자
// 셋째 줄: 확인할 카드 수 M
// 넷째 줄: M개의 확인할 숫자
//
// 출력: 각 숫자가 카드에 몇 개 있는지 공백으로 출력
//

using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
int n_2 = int.Parse(Console.ReadLine());
string[] input_2 = Console.ReadLine().Split(' ');
Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < n; i++)
{
    int num = int.Parse(input[i]);
    if (dict.ContainsKey(num))
    {
        dict[num]++;
    }
    else
    {
        dict[num] = 1;
    }
}
for (int i = 0; i < n_2; i++)
{
    int num_2 = int.Parse(input_2[i]);
    if (dict.ContainsKey(num_2))
    {
        sb.Append(dict[num_2] + " ");
    }
    else
    {
        sb.Append(0 + " ");
    }
}
Console.WriteLine(sb);