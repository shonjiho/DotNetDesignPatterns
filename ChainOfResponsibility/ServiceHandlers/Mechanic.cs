namespace ChainOfResponsibility.ServiceHandlers
{
    public class Mechanic : ServiceHandler
    {
        public Mechanic() : base(ServiceRequirements.EngineTune)
        {
        }
    }
}