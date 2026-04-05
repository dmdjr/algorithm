// 백준 11866번: 요세푸스 문제 0
// https://www.acmicpc. net/problem/11866
// 1~N명이 원형으로 앉아있고, K번째 사람을 차례로 제거
// 제거된 순서를 출력
//
// 입력: N K (공백 구분)
// 출력: <제거순서> 형식으로 출력
//
// 예제 입력: 7 3
// 예제 출력: <3, 6, 2, 7, 5, 1, 4>

string[] input = Console.ReadLine().Split(' ');
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);
Queue<int> queue = new Queue<int>();
List<int> list = new List<int>();
int count = 1;

for (int i = 1; i <= n; i++)
{
    queue.Enqueue(i);
}

while (queue.Count != 0)
{
    if (count != k)
    {
        int temp = queue.Dequeue();
        queue.Enqueue(temp);
        count++;
    }
    else
    {
        list.Add(queue.Dequeue());
        count = 1;
    }
}

Console.WriteLine("<" + string.Join(", ", list) + ">");


