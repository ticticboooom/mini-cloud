using System;
using System.Threading;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Handlers;
using MiniCloud.Messages;
using MiniCloud.System.ContainerService.DataAccess;

namespace MiniCloud.System.ContainerService
{
    class Program
    {

        static async Task Main(string[] args)
        {

            var host = new HostBuilder().ConfigureServices(services =>
            {
                services.AddScoped<DbService>();
                services.AddMassTransit(x => x.AddBus(y => Bus.Factory.CreateUsingRabbitMq(sbc =>
                {
                    sbc.Host("rabbitmq://minicloud-mq");

                    sbc.ReceiveEndpoint("container_system_queue",
                        ep =>
                        {
                        });
                })));
                services.AddScoped<LaunchTaskDefinitionGroupHandler>();

            });
            await host.RunConsoleAsync();
        }
    }
}
