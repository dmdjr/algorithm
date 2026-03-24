// 백준 1152번: 단어의 개수
// https://www.acmicpc.net/problem/1152
// 영어 대소문자와 공백으로 이루어진 문자열이 주어졌을 때, 단어의 개수를 출력
// 단, 문자열 앞뒤에 공백이 있을 수 있음
//
// 입력: 문자열 (길이 1~1,000,000)
// 출력: 단어의 개수
//
// 예제 입력:  The Curious Case of Benjamin Button
// 예제 출력: 6

int count = 0;
string input = Console.ReadLine().Trim();
if (input == "")
{
    Console.WriteLine(0);
}
else
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }
    Console.WriteLine(count + 1);
}
