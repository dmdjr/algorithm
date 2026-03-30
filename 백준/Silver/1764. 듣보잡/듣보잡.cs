// 백준 1764번: 듣보잡
// https://www.acmicpc.net/problem/1764
// 듣도 못한 사람과 보도 못한 사람 명단이 주어질 때,
// 듣도 보도 못한 사람을 사전순으로 출력
//
// 입력:
// 첫째 줄에 듣도 못한 사람 수 N, 보도 못한 사람 수 M
// 이후 N줄에 듣도 못한 사람 이름
// 이후 M줄에 보도 못한 사람 이름
//
// 출력: 첫째 줄에 듣보잡 수, 이후 사전순으로 출력
//

string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
HashSet<string> set = new HashSet<string>();
List<string> list = new List<string>();

for (int i = 0; i < a; i++)
{
    string list_1 = Console.ReadLine();
    set.Add(list_1);
}

for (int i = 0; i < b; i++)
{
    bool isContained = false;
    string list_2 = Console.ReadLine();
    isContained = set.Contains(list_2);
    if (isContained)
    {
        list.Add(list_2);
    }
}

list.Sort();
Console.WriteLine(list.Count);
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}