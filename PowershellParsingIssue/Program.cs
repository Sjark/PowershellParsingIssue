using System.Management.Automation.Language;

var script = File.ReadAllText(Path.Combine(System.AppContext.BaseDirectory, "ordered.ps1"));
// var script = File.ReadAllText(Path.Combine(System.AppContext.BaseDirectory, "noordered.ps1"));

Parallel.ForEach(Enumerable.Range(0, 20), cur =>
{
    var parsed = Parser.ParseInput(script, out var tokens, out var errors);
});

