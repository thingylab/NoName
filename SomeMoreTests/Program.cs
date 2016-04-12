using System;
using Revolver;
using System.Collections;
using System.Collections.Generic;

namespace SomeMoreTests
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      DependencyResolver
        .RegisterDataProvider<IDataProvider<string>>()
        .WithMethod<DateTime, IEnumerable<string>>(x => x.GetData);
      //var myDependencies = MyDependencyResolver.Resolve<MyDependencies>();
    }
  }
}