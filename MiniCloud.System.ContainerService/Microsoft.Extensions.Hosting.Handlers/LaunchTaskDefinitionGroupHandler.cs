using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using MiniCloud.Messages;

namespace Microsoft.Extensions.Hosting.Handlers
{
    public class LaunchTaskDefinitionGroupHandler
    {
        public LaunchTaskDefinitionGroupHandler()
        {
        }

        public async Task HandleTaskDefinitionGroupLaunchMessage(ConsumeContext<ContainerSystemTaskDefinitionGroupLaunchMessage> context)
        {

        }
    }
}
