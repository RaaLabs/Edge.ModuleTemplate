// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Serilog;
using RaaLabs.Edge.Modules.EventHandling;


namespace RaaLabs.Edge.ModuleTemplate
{
    public class ModuleTemplateHandler : IConsumeEvent<events.ModuleTemplateDatapointInput>, IProduceEvent<events.ModuleTemplateDatapointOutput>
    {
        public event EventEmitter<events.ModuleTemplateDatapointOutput> SendDatapoint;
        private readonly ILogger _logger;
        private readonly ModuleTemplateConfiguration _configuration;

        public ModuleTemplateHandler(ILogger logger, ModuleTemplateConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void Handle(events.ModuleTemplateDatapointInput @event)
        {
            var moduleTemplateDatapointOutput = new events.ModuleTemplateDatapointOutput();

            SendDatapoint(moduleTemplateDatapointOutput);
        }
    }
}
