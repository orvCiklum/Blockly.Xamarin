using System;

namespace Blockly.Bindings.XamarinIOS
{
    [Native]
    public enum BKYBlocklyPanGestureRecognizerTouchState : ulong
    {
        Began = 0,
        Changed,
        Ended,
        Cancelled
    }
    
    [Native]
    public enum BKYCodeGeneratorState : ulong
    {
        Initialized = 0,
        Loading,
        ReadyForUse,
        Unusable,
        GeneratingCode
    }
    
    [Native]
    public enum BKYConnectionType : ulong
    {
        PreviousStatement = 0,
        NextStatement,
        InputValue,
        OutputValue
    }
    
}