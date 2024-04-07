using System.Diagnostics;
using System.Text;

var stopwatch = new Stopwatch();

// Concatenating strings using string concatenation
string result = "";
stopwatch.Start();
for (int i = 0; i < 100000; i++)
{
    result += i.ToString();
}
Console.WriteLine("Concatenation using string concatenation: " + stopwatch.Elapsed.TotalMilliseconds + "ms");

stopwatch = new Stopwatch();
stopwatch.Start();
// Concatenating strings using StringBuilder
StringBuilder builder = new StringBuilder();
for (int i = 0; i < 100000; i++)
{
    builder.Append(i);
}
Console.WriteLine("Concatenation using StringBuilder: " + stopwatch.Elapsed.TotalMilliseconds + "ms");
stopwatch.Stop();