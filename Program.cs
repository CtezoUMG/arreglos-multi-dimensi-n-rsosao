var n = int.Parse(Console.ReadLine());
string[] t = Console.ReadLine().Split(' ');
int m = int.Parse(t[0]);
for (var i = 1; i < n; i++)
{
    int val = int.Parse(t[i]);
    if (val > m) m = val;
}
Console.WriteLine(m);