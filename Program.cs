int n = int.Parse(Console.ReadLine());
string[] v = Console.ReadLine().Split(' ');
int m = int.Parse(v[0]);
for (int i = 1; i < n; i++)
{
    int a = int.Parse(v[i]);
    if (a > m) m = a;
}
Console.Write(m);