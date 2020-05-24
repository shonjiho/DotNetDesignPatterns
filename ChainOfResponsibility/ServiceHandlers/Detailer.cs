namespace ChainOfResponsibility.ServiceHandlers
{
    public class Detailer : ServiceHandler
    {
        public Detailer() : base(ServiceRequirements.Dirty)
        {
        }
    }
}