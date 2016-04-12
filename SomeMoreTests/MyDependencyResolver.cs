using System;
using System.Linq.Expressions;
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
        .DependsOn(x => x.AsOfDate);
    }
  }
}