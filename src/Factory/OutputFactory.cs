using System;
using System.Configuration;
using ConsoleZipper.Factory.Interfaces;

namespace ConsoleZipper.Factory
{
    public class OutputFactory : IOutputFactory
    {
        public IOutput GetOutput(string outputType)
        {
            Type type = null;

            if (outputType != null)
            {
                var concreteProductsNamespace = ConfigurationManager.AppSettings["concreteProducts"];

                type = Type.GetType(concreteProductsNamespace +
                                        ConfigurationManager.AppSettings[outputType.ToLowerInvariant()]);
            }

            if (type == null) return null;
            var instance = (IOutput) Activator.CreateInstance(type ?? throw new InvalidOperationException());

            return instance;

        }
    }
}
