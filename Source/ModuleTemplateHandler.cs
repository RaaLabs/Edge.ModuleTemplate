using RaaLabs.Edge.Modules.EventHandling;


namespace RaaLabs.Edge.ModuleTemplate
{
    public class ModuleTemplateHandler : IConsumeEvent<events.ModuleTemplateDatapointInput>, IProduceEvent<events.ModuleTemplateDatapointOutput>
    {
        public event EventEmitter<events.ModuleTemplateDatapointOutput> SendDatapoint;
        public void Handle(events.ModuleTemplateDatapointInput @event)
        {
            var moduleTemplateDatapointOutput = new events.ModuleTemplateDatapointOutput();

            SendDatapoint(moduleTemplateDatapointOutput);
        }
    }
}
