using System.Text;

string[] input_num = Console.ReadLine().Split(' ');
int n = int.Parse(input_num[0]);
int m = int.Parse(input_num[1]);
Dictionary<string, string> dict = new Dictionary<string, string>();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < n; i++)
{
    string[] input_info = Console.ReadLine().Split(' ');
    dict.Add(input_info[0], input_info[1]);
}

for (int i = 0; i < m; i++)
{
    string input_key = Console.ReadLine();
    if (dict.ContainsKey(input_key))
    {
        sb.AppendLine(dict[input_key]);
    }

}
Console.WriteLine(sb);
