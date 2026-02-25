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
for(var i = 1; i < n; i++)
{
    if (v[i] > m) m = v[i];
}
Console.WriteLine(m);