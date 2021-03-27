using Microsoft.Extensions.DependencyInjection;
using System;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
            .AddSingleton<IDataAccess, SQLDataAccess>()
            .AddSingleton<IService, Service>()
            .BuildServiceProvider();

            var service = serviceProvider.GetService<IService>();
            service.Remove(1);

            Console.ReadKey();
        }
    }
}
