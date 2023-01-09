using csharp;
using System.Reflection;

void SolverClasses(params Assembly[] assemblies)
{
    IEnumerable<IEulerProblem> questionSolvers = assemblies
        .SelectMany(a => a.DefinedTypes)
        .Where(IsAssignableToType<IEulerProblem>)
        .Select(Activator.CreateInstance)
        .Cast<IEulerProblem>();

    foreach (var questionSolver in questionSolvers)
        Task.Run(() => Console.WriteLine($"{questionSolver.GetType().Name} - {questionSolver.Solve()}"));
        /*Console.WriteLine($"{questionSolver.GetType().Name} - {questionSolver.Solve()}");*/

    static bool IsAssignableToType<T>(TypeInfo typeInfo) =>
        typeof(T).IsAssignableFrom(typeInfo) &&
        !typeInfo.IsInterface &&
        !typeInfo.IsAbstract;
}

SolverClasses(typeof(IEulerProblem).Assembly);
Console.ReadLine();