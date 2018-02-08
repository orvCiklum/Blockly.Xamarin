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
    
    [Native]
    public enum BKYInputType : ulong
    {
        Value = 0,
        Statement,
        Dummy
    }
    
    [Native]
    public enum BKYInputAlignment : ulong
    {
        Left = -1,
        Center = 0,
        Right = 1
    }
}