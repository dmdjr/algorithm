// 백준 10809번: 알파벳 찾기
// https://www.acmicpc.net/problem/10809
// 알파벳 소문자로만 이루어진 단어가 주어졌을 때,
// 각 알파벳이 처음 등장하는 위치를 출력 (없으면 -1)
//
// 입력: 단어 S (소문자, 100자 이하)
// 출력: a~z 각각의 첫 등장 위치를 공백으로 구분하여 출력 (0부터 시작)
//
// 예제 입력: baekjoon
// 예제 출력: 1 0 -1 -1 2 -1 -1 -1 -1 4 3 -1 -1 5 6 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1

int[] arr = new int[26];
Array.Fill(arr, -1);
string input = Console.ReadLine();
for (int i = 0; i < input.Length; i++)
{
    if (arr[input[i] - 'a'] == -1)
    {
        arr[input[i] - 'a'] = i;
    }
}

for (int i = 0; i < 26; i++)
{
    Console.Write(arr[i] + " ");
}
