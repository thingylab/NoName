using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Revolver
{
  public class DataProviderRegistrationBuilder<TProvider>
  {
    private readonly IList<IRegistration> _registration;

    internal DataProviderRegistrationBuilder(IList<IRegistration> reg)
    {
      _registration = reg;
    }
    
    public DataProviderRegistrationBuilder<TProvider> WithMethod<TParam, TReturn>(Func<TProvider, Func<TParam, TReturn>> method)
    {
      _registration.Add(new Registration<TProvider, TParam, TReturn>(method));

      return this;
    }
  }
}