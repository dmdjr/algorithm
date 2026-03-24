// 백준 1316번: 그룹 단어 체커
// https://www.acmicpc.net/problem/1316

int n = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    bool[] seen = new bool[26];
    bool isGroup = true;

    seen[word[0] - 'a'] = true;

    for (int j = 1; j < word.Length; j++)
    {
        if (word[j] != word[j - 1])
        {
            if (seen[word[j] - 'a'])
            {
                isGroup = false;
                break;
            }
            seen[word[j] - 'a'] = true;
        }
    }

    if (isGroup) count++;
}

Console.WriteLine(count);
