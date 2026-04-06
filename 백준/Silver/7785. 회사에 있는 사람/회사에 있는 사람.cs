int n = int.Parse(Console.ReadLine());
HashSet<string> set = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    if (input[1] == "enter")
    {
        set.Add(input[0]);
    }
    else if (set.Count > 0 && input[1] == "leave")
    {
        set.Remove(input[0]);
    }
}
List<string> list = new List<string>(set);
list.Sort();
list.Reverse();
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
