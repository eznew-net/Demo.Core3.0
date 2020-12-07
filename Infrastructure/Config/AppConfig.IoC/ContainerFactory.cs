using System;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using EZNEW.Web.DependencyInjection;
using EZNEW.VerificationCode.SkiaSharp;
using EZNEW.Drawing.VerificationCode;
using EZNEW.DependencyInjection;
using EZNEW.Logging;
using EZNEW.Diagnostics;

namespace AppConfig.IoC
{
    public class ContainerFactory : IServiceProviderFactory<IDIContainer>
    {
        /// <summary>
        /// �Զ��������������
        /// </summary>
        /// <param name="container">Dependency injection container</param>
        static void ConfigureServices(IDIContainer container)
        {
            WebDependencyInjectionManager.ConfigureDefaultWebService();
            container.Register(typeof(VerificationCodeProvider), typeof(SkiaSharpVerificationCode));
        }

        public IDIContainer CreateBuilder(IServiceCollection services)
        {
            //�򿪿�ܸ�����־
            SwitchManager.EnableFrameworkTrace();
            services.AddLogging(cfg =>
            {
                cfg.AddTraceSource("", new DefaultTraceListener());
            }).Configure<LoggerFilterOptions>(option =>
            {
            });

            ContainerManager.Init(services, configureServiceAction: ConfigureServices);
            return ContainerManager.Container;
        }

        public IServiceProvider CreateServiceProvider(IDIContainer containerBuilder)
        {
            return containerBuilder.BuildServiceProvider();
        }
    }
}
