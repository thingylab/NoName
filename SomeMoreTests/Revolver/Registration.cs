using System;

namespace Revolver
{
  internal interface IRegistration
  {
  }

  // Registration details for a method taking one param of type TParam
  // and returning a TReturn
  internal class Registration<TProvider, TParam, TReturn> : IRegistration
  {
    private readonly Func<TProvider, Func<TParam, TReturn>> _method;

    internal Registration(Func<TProvider, Func<TParam, TReturn>> method)
    {
      _method = method;
    }
  }
}