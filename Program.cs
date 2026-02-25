string? l = Console.ReadLine();
int n = int.Parse(l);
string[]? t = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(t[i]);
}
// Máximo
int m = 0;
foreach (var a in v)
{
    if (a > m) m = a;
}
Console.WriteLine(m);