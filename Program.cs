// See https://aka.ms/new-console-template for more information
using System.Management.Automation.Language;

var script = File.ReadAllText(Path.Combine(System.AppContext.BaseDirectory, "script.txt"));

Parallel.ForEach(Enumerable.Range(0, 40), cur =>
{
    var parsed = Parser.ParseInput(script, out var tokens, out var errors);
});

