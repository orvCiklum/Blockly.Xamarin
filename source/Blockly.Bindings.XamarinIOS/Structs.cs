using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

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
    public enum BKYInputAlignment : long
    {
        Left = -1,
        Center = 0,
        Right = 1
    }
    
    [Native]
    public enum BKYToolboxCategoryListViewControllerOrientation : ulong
    {
        Horizontal = 0,
        Vertical
    }
    
    [Native]
    public enum BKYWorkspaceFlowLayoutDirection : ulong
    {
        Horizontal,
        Vertical
    }
    
    [Native]
    public enum BKYWorkbenchViewControllerStyle : ulong
    {
        DefaultStyle,
        Alternate
    }
    
    [Native]
    public enum BKYWorkspaceViewLocation : ulong
    {
        Anywhere = 0,
        TopLeading,
        TopCenter,
        TopTrailing,
        MiddleLeading,
        Center,
        MiddleTrailing,
        BottomLeading,
        BottomCenter,
        BottomTrailing
    }
    
    [StructLayout (LayoutKind.Sequential)]
    public struct BKYWorkspacePoint
    {
        public nfloat x;

        public nfloat y;
    }
    
    [StructLayout (LayoutKind.Sequential)]
    public struct BKYEdgeInsets
    {
        public nfloat top;

        public nfloat leading;

        public nfloat bottom;

        public nfloat trailing;
    }

    [Native]
    public enum BKYBlockJSONFile : ulong
    {
        ColorDefault = 1 << 0,
        ListDefault = 1 << 1,
        LogicDefault = 1 << 2,
        LoopDefault = 1 << 3,
        MathDefault = 1 << 4,
        ProcedureDefault = 1 << 5,
        TextDefault = 1 << 6,
        VariableDefault = 1 << 7,
        AllDefault = ColorDefault | ListDefault | LogicDefault | LoopDefault | MathDefault | TextDefault | VariableDefault | ProcedureDefault
    }
}