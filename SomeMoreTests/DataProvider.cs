using System;
using System.Collections.Generic;
using System.Linq;

namespace SomeMoreTests
{
  public interface IDataProvider<T>
  {
    IEnumerable<T> GetData(DateTime asOfDate);
  }

  public class DataProvider : IDataProvider<string>
  {
    public IEnumerable<string> GetData(DateTime asOfDate)
    {
      var rnd = new Random(asOfDate.GetHashCode());

      return Enumerable.Range(1, 10).Select(x => Guid.NewGuid().ToString());
    }
  }
}

