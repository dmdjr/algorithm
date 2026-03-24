// 백준 2941번: 크로아티아 알파벳
// https://www.acmicpc.net/problem/2941
// 크로아티아 알파벳으로 이루어진 단어의 알파벳 개수를 출력
//
// 크로아티아 알파벳 (2글자 이상으로 이루어진 것):
// c= č, c- ć, dz= đ, d- đ, lj lj, nj nj, s= š, z= ž
//
// 입력: 최대 100글자의 단어
// 출력: 크로아티아 알파벳 개수
//
// 예제 입력: ljes=njansen=jansen=j
// 예제 출력: 16

string input = Console.ReadLine();
input = input.Replace("c=", "?");
input = input.Replace("dz=", "?");
input = input.Replace("c-", "?");
input = input.Replace("d-", "?");
input = input.Replace("lj", "?");
input = input.Replace("nj", "?");
input = input.Replace("s=", "?");
input = input.Replace("z=", "?");
Console.WriteLine(input.Length);

