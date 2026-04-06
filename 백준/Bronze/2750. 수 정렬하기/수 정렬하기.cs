int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    list.Add(input);
}
list.Sort();
for(int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}