using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Revolver
{
    public abstract class DependencyResolver<T>
        where T : new()
    {
        private readonly List<IParameter<T>> _parameters = new List<IParameter<T>>();

        private readonly List<Dependency> _dependencies = new List<Dependency>();

        public T Resolve()
        {
            return new T();
        }

        /// <summary>
        /// Declares a parameter, that is something that is passed to a data provider to obtain a resolved data set
        /// </summary>
        /// <param name="paramExpr">Parameter expr.</param>
        /// <typeparam name="TParam">The 1st type parameter.</typeparam>
        protected void Parameter<TParam>(Expression<Func<T, TParam>> paramExpr)
        {
            _parameters.Add(new Parameter<T, TParam>(paramExpr));
        }

        protected Dependency Dependency<TDependency>(Expression<Func<T, TDependency>> dependency)
        {
            return new Dependency();
        }
    }
}