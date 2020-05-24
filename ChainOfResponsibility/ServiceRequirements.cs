using System;

namespace ChainOfResponsibility
{

    [Flags]
    public enum ServiceRequirements
    {
        None = 0,
        WheelAligment = 1,
        Dirty = 2,
        EngineTune = 4,
        TestDrive = 8
    }

}