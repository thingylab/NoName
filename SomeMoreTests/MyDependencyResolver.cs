using Revolver;

namespace SomeMoreTests
{
    /// <summary>
    /// The description of my resolving strategy.
    /// </summary>
    public class MyDependencyResolver : DependencyResolver<MyDependencies>
    {
        public MyDependencyResolver()
        {
            Parameter(x => x.AsOfDate);

            Dependency(x => x.SomeStrings)
                .ResolvedUsing<IDataProvider<string>>()
                .Method(x => x.)
                .DependsOn(x => x.AsOfDate);
        }
    }
}