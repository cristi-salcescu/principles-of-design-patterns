using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Configuration;

namespace Exports
{
    public class ReflectionExportFactory : IExportFactory
    {
        public IExportGenerator GetInstance(string exportType)
        {
            string typeFullName = ConfigurationManager.AppSettings[exportType];
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType(typeFullName);

            return (IExportGenerator)Activator.CreateInstance(type);
        }
    }
}