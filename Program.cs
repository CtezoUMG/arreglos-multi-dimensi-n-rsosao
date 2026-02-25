var l = Console.Read();
string[] t = Console.ReadLine().Split(' ');
var n = int.Parse(l);
int[] v = new int[n];
for (var i = 0; i < n; i++)
    v[i] = int.Parse(t[i]);
var m = v[0];
for(var i = 1; i < n; i++)
    if (v[i] > m) m = v[i];
Console.WriteLine(m);
l = null;
t = null;
