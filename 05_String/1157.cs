// 백준 1157번: 단어 공부
// https://www.acmicpc.net/problem/1157
// 알파벳 대소문자로 이루어진 단어에서 가장 많이 사용된 알파벳을 대문자로 출력
// 가장 많이 사용된 알파벳이 여러 개이면 ? 출력
//
// 입력: 알파벳으로만 이루어진 단어 (길이 1~1,000,000)
// 출력: 가장 많이 사용된 알파벳 대문자 (여러 개면 ?)
//
// 예제 입력: Mississipi
// 예제 출력: ?
//

string input = Console.ReadLine();
input = input.ToUpper();
int[] arr = new int[26];
int max = 0;
int maxIndex = 0;
int count = 0;
string result;
bool isOnly = true;
for (int i = 0; i < input.Length; i++)
{
    arr[input[i] - 'A'] += 1;
}
for (int i = 0; i < 26; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
        maxIndex = i;
    }
}
result = "" + (char)('A' + maxIndex);
for (int i = 0; i < 26; i++)
{
    if (arr[i] == max)
    {
        count++;
    }
    if (count > 1)
    {
        isOnly = false;
    }
}

if (isOnly)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("?");
}
