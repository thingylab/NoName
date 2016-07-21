using System;
using DummyStuff;
using Dependency;
using System.Linq.Expressions;

namespace ResolverTests
{
    class MainClass
    {
        public static string Test { get; set; } = "Bonjour";

        public static void TestFunc(Expression<Func<string>> expr)
        {
            Console.WriteLine(expr.Compile().Invoke());
        }

        public static void Assign(Expression<Func<string>> expr, string val)
        {
            var assign = Expression.Assign(
                expr.Body,
                Expression.Constant(val));

            Expression.Lambda<Action>(assign).Compile().Invoke();
        }

        public static void Main(string[] args)
        {
            TestFunc(() => Test);
            Assign(() => Test, "Blah");

            Console.WriteLine(Test);
            Console.ReadLine();
        }
    }
}