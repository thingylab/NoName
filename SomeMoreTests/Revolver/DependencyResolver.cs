using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Revolver
{
  public static class DependencyResolver
  {
    internal static Dictionary<Type, List<IRegistration>> _registrations = new Dictionary<Type, List<IRegistration>>();
    
    public static DataProviderRegistrationBuilder<TProvider> RegisterDataProvider<TProvider>()
    {
      if (!_registrations.ContainsKey(typeof(TProvider)))
      {
        _registrations.Add(typeof(TProvider), new List<IRegistration>());
      }

      return new DataProviderRegistrationBuilder<TProvider>(_registrations[typeof(TProvider)]);
    }
  }
}