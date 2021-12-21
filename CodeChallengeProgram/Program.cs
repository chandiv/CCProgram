using CodeChallengeProgram.Contract;
using CodeChallengeProgram.Core;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CodeChallengeProgram
{
    class Program
    {
        private static ServiceProvider _serviceprovider { get; set; }
        static void Main(string[] args)
        {
            RegisterServices();
            IServiceScope scope = _serviceprovider.CreateScope();
            scope.ServiceProvider.GetRequiredService<MainHandler>().Run();
            DisposeServices();
        }
        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IFizzBizzHandler, FizzBizzHandler>();
            services.AddSingleton<IFactorialHandler, FactorialHandler>();
            services.AddSingleton<MainHandler>();
            _serviceprovider = services.BuildServiceProvider(true);
        }
        private static void DisposeServices()
        {
            if (_serviceprovider == null)
                return;
            if (_serviceprovider is IDisposable)
                ((IDisposable)_serviceprovider).Dispose();
        }
    }
}
