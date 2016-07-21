using System;

namespace Revolver
{
    public class Dependency<TProvider>
    {
        public Dependency()
        {
            
        }

        public Dependency<TProvider> ResolvedUsing<TFunc>(TFunc t)
        {
            return this;
        }

        public Dependency<TProvider> Method(Func<TProvider, Delegate> f)
        {
            return this;
        }
    }
}

