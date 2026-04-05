// 백준 1302번: 베스트셀러
// https://www.acmicpc.net/problem/1302
// 하루 동안 팔린 책 제목이 주어질 때, 가장 많이 팔린 책 이름 출력
// 가장 많이 팔린 책이 여러 개면 사전순으로 앞선 것 출력
//
// 입력:
// 첫째 줄: 팔린 책 수 N
// 이후 N줄: 책 제목
//
// 출력: 가장 많이 팔린 책 이름
//

int n = int.Parse(Console.ReadLine());
Dictionary<string, int> dict = new Dictionary<string, int>();
int maxCount = 0;
string bestSeller = "";
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    if (dict.ContainsKey(input))
    {
        dict[input]++;
    }
    else
    {
        dict[input] = 1;
    }
}

foreach (var pair in dict)
{
    if (pair.Value > maxCount)
    {
        maxCount = pair.Value;
        bestSeller = pair.Key;

    }
    else if (pair.Value == maxCount)
    {
        if (pair.Key.CompareTo(bestSeller) < 0)
        {
            bestSeller = pair.Key;
        }
    }
}

Console.WriteLine(bestSeller);