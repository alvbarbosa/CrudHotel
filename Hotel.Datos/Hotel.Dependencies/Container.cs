using Ninject;
using System.Reflection;

namespace Hotel.Dependencies
{
    public static class Container
    {
        private static readonly StandardKernel Kernel;

        static Container()
        {
            Kernel = new StandardKernel();
            Kernel.Load(Assembly.GetExecutingAssembly());
        }

        public static T Resolver<T>()
        {
            return Kernel.Get<T>();
        }

    }
}
