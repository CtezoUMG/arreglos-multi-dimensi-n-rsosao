// Leemos línea
string l = Console.ReadLine() ?? String.Empty;
if (l.Length == 0) return;
int n = int.Parse(l);
// Obtenemos entrada
string[]? t = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(t[i]);
}
// Máximo
int m = v[0];
for(int i = 1; i < n; i++)
{
    if(v[i] > m) m = v[i];
}
Console.WriteLine(m);