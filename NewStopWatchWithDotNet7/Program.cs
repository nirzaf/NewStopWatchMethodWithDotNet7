// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("Stop watch new method in .NET 7");

var startTimer = Stopwatch.GetTimestamp();
// Do some work
for(int i = 0; i < 3; i++)
{
    await Task.Delay(1000);
}


var diff = Stopwatch.GetElapsedTime(startTimer);
Console.WriteLine($"Elapsed time: {diff.TotalMilliseconds} ms");
Console.WriteLine($"Elapsed time: {diff.TotalNanoseconds} ns");
Console.ReadLine();