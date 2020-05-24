namespace ChainOfResponsibility.ServiceHandlers
{
    public class WheelSpecialist : ServiceHandler
    {
        public WheelSpecialist() : base(ServiceRequirements.WheelAligment)
        {
        }
    }
}