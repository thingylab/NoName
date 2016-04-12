using System;
using Dependency;
using DummyStuff;

namespace DependencyTest
{
    public class MyDummyDependency : IDependencyMap
    {
        public TimeSeries<PnlItem> Pnl { get; set; }
    }
}