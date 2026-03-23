// 백준 5622번: 다이얼
// https://www.acmicpc.net/problem/5622
// 다이얼 전화기에서 알파벳을 누를 때 걸리는 시간을 구하는 프로그램
//
// 다이얼 매핑:
// ABC → 3, DEF → 4, GHI → 5, JKL → 6
// MNO → 7, PQRS → 8, TUV → 9, WXYZ → 10
// (숫자 = 다이얼 돌리는 시간)
//
// 입력: 알파벳 대문자로 이루어진 단어 (2~15글자)
// 출력: 총 걸리는 시간
//
// 예제 입력: WA
// 예제 출력: 13 (W=10, A=3)

int[] dial = { 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 10, 10, 10, 10 };
string input = Console.ReadLine();
int time = 0;
for (int i = 0; i < input.Length; i++)
{
    time += dial[input[i] - 'A'];
}
Console.WriteLine(time);