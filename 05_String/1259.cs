// 백준 1259번: 팰린드롬수
// https://www.acmicpc.net/problem/1259
// 주어진 수가 팰린드롬(앞뒤로 읽어도 같은 수)인지 판별
//
// 입력: 여러 줄에 수가 주어지며, 0이 입력되면 종료
// 출력: 팰린드롬이면 yes, 아니면 no
//
// 예제 입력:
// 121
// 1231
// 12421
// 0
//
// 예제 출력:
// yes
// no
// yes


while (true)
{
    string input = Console.ReadLine();
    string checkPalin = "";
    if (input == "0")
    {
        break;
    }
    for (int i = input.Length - 1; i >= 0; i--)
    {
        checkPalin += input[i];
    }
    if (input == checkPalin)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }

}