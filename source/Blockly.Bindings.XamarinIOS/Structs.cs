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
}