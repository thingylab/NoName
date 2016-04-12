using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Revolver
{
  internal interface IParameter<TDep>
  {
  }
  
  internal class Parameter<TDep, TParam> : IParameter<TDep>
  {
    private readonly Expression<Func<TDep, TParam>> _accessor;

    private readonly Type _type;

    internal Parameter(Expression<Func<TDep, TParam>> accessor)
    {
      _accessor = accessor;
      _type = typeof(TParam);
    }
  }
}