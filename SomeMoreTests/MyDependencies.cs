using System;
using System.Collections;
using System.Collections.Generic;

namespace SomeMoreTests
{
  /// <summary>
  /// The type that will hold my resolved dependencies
  /// </summary>
  public class MyDependencies
  {
    public DateTime AsOfDate { get; set; }

    public IEnumerable<string> SomeStrings { get; set; }
  }
}

