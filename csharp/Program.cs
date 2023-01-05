using csharp;

var type = typeof(IEulerProblem);
var types = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(type.IsAssignableFrom);

Console.WriteLine(types);