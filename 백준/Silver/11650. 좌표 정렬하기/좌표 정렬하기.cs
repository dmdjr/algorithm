int n = int.Parse(Console.ReadLine());
List<(int x, int y)> list = new List<(int x, int y)>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);

    list.Add((x, y));
}
list.Sort();

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i].x + " " + list[i].y);
}