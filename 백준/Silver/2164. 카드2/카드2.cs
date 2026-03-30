// 백준 2164번: 카드2
// https://www.acmicpc.net/problem/2164
// N장의 카드가 1~N까지 번호 순서대로 놓여있을 때,
// 맨 위 카드를 버리고, 그 다음 맨 위 카드를 맨 아래로 옮기는 것을 반복
// 마지막에 남는 카드 번호를 출력
//
// 입력: 첫째 줄에 N (1 <= N <= 500,000)
// 출력: 마지막에 남는 카드 번호
//
// 예제 입력: 6
// 예제 출력: 4
//
// 설명: 1버리고 2를 밑으로 → 3버리고 4를 밑으로 → 5버리고 6을 밑으로 → 2버리고 4를 밑으로 → 6버리고 4 남음

int n = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>();
for (int i = 1; i <= n; i++)
{
    queue.Enqueue(i);
}
for (int i = 0; i < n - 1; i++)
{
    queue.Dequeue();
    int a = queue.Dequeue();
    queue.Enqueue(a);
}
Console.WriteLine(queue.Peek());