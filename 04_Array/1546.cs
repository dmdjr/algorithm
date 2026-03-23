// 백준 1546번: 평균
// https://www.acmicpc.net/problem/1546
// 시험 점수 중 최댓값을 M이라 할 때,
// 모든 점수를 (점수/M)*100으로 바꾼 후 새로운 평균을 출력
//
// 입력:
// 첫째 줄: 시험 본 과목 수 N (1 <= N <= 1000)
// 둘째 줄: 각 과목의 점수 (0 이상 100 이하, 공백 구분)
//
// 출력: 새로운 평균 (소수점 출력 가능)
//
// 예제 입력:
// 3
// 40 80 60
//
// 예제 출력: 75.0

float maxScore = 0f;
float newAver = 0f;
float[] arr = new float[1000];
int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split();
for (int i = 0; i < n; i++)
{
    arr[i] = float.Parse(input[i]);
}
for (int i = 0; i < n; i++)
{
    if (maxScore < arr[i])
    {
        maxScore = arr[i];
    }
}
for (int i = 0; i < n; i++)
{
    arr[i] = arr[i] / maxScore * 100;
    newAver += arr[i];
}
newAver = newAver / n;
Console.WriteLine(newAver);


