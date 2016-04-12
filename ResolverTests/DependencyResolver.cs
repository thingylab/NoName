using System;
using Dependency;

namespace ResolverTests
{
  public class DependencyResolver
  {
    public DependencyResolver()
    {
    }

    public T Resolve<T>(T dependencyMap) where T : IDependencyMap
    {
      return default(T);
    }
  }
}