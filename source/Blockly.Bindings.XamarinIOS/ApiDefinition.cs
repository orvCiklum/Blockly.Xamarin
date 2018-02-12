using System;
using CoreAnimation;
using CoreGraphics;
//using Darwin;
//using Dispatch;
using Foundation;
using ObjCRuntime;
//using ObjectiveC;
using UIKit;
using WebKit;

namespace Blockly.Bindings.XamarinIOS
{
 // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
    //
    
// @interface BKYAnglePicker : UIControl
[BaseType(typeof(UIControl))]
interface BKYAnglePicker
{
    // @property (nonatomic) double angle;
    [Export("angle")]
    double Angle { get; set; }

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
    [Export("initWithFrame:")]
    [DesignatedInitializer]
    IntPtr Constructor(CGRect frame);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)layoutSubviews;
    [Export("layoutSubviews")]
    void LayoutSubviews();
}

// @interface Blockly_Swift_209 (BKYAnglePicker)
[Category]
[BaseType(typeof(BKYAnglePicker))]
interface BKYAnglePicker_Blockly_Swift_209
{
    // -(BOOL)beginTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
    [Export("beginTrackingWithTouch:withEvent:")]
    bool BeginTrackingWithTouch(UITouch touch, [NullAllowed] UIEvent @event);

    // -(BOOL)continueTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
    [Export("continueTrackingWithTouch:withEvent:")]
    bool ContinueTrackingWithTouch(UITouch touch, [NullAllowed] UIEvent @event);

    // -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
    [Export("endTrackingWithTouch:withEvent:")]
    void EndTrackingWithTouch([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);

    // -(void)cancelTrackingWithEvent:(UIEvent * _Nullable)event;
    [Export("cancelTrackingWithEvent:")]
    void CancelTrackingWithEvent([NullAllowed] UIEvent @event);
}

// @interface BKYAnglePickerViewController : UIViewController
[BaseType(typeof(UIViewController))]
interface BKYAnglePickerViewController
{
    // @property (nonatomic) double angle;
    [Export("angle")]
    double Angle { get; set; }

    [Wrap("WeakDelegate")]
    [NullAllowed]
    BKYAnglePickerViewControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<BKYAnglePickerViewControllerDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (readonly, nonatomic, strong) BKYAnglePicker * _Nonnull anglePicker;
    [Export("anglePicker", ArgumentSemantic.Strong)]
    BKYAnglePicker AnglePicker { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)viewDidLoad;
    [Export("viewDidLoad")]
    void ViewDidLoad();
}

// @protocol BKYAnglePickerViewControllerDelegate
[Protocol, Model]
interface BKYAnglePickerViewControllerDelegate
{
    // @required -(void)anglePickerViewController:(BKYAnglePickerViewController * _Nonnull)viewController didUpdateAngle:(double)angle;
    [Abstract]
    [Export("anglePickerViewController:didUpdateAngle:")]
    void DidUpdateAngle(BKYAnglePickerViewController viewController, double angle);
}

// @interface BKYBezierPathLayer : CAShapeLayer
[BaseType(typeof(CAShapeLayer))]
interface BKYBezierPathLayer
{
    // @property (readonly, nonatomic, strong) UIBezierPath * _Nullable bezierPath;
    [NullAllowed, Export("bezierPath", ArgumentSemantic.Strong)]
    UIBezierPath BezierPath { get; }

    // @property (nonatomic) double animationDuration;
    [Export("animationDuration")]
    double AnimationDuration { get; set; }

    // -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
    [Export("initWithLayer:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSObject layer);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)setBezierPath:(UIBezierPath * _Nullable)bezierPath animated:(BOOL)animated;
    [Export("setBezierPath:animated:")]
    void SetBezierPath([NullAllowed] UIBezierPath bezierPath, bool animated);
}

// @interface BKYBlockStyle : NSObject <NSCopying>
[BaseType(typeof(NSObject))]
interface BKYBlockStyle : INSCopying
{
    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull hatNone;
    [Static]
    [Export("hatNone")]
    string HatNone { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull hatCap;
    [Static]
    [Export("hatCap")]
    string HatCap { get; }

    // @property (nonatomic, weak) BKYBlock * _Nullable block;
    [NullAllowed, Export("block", ArgumentSemantic.Weak)]
    BKYBlock Block { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable hat;
    [NullAllowed, Export("hat")]
    string Hat { get; set; }

//    // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result));
//    [Export("copyWithZone:")]
//    unsafe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
}

// @interface Blockly_Swift_426 (BKYBlock)
[Category]
[BaseType(typeof(BKYBlock))]
interface BKYBlock_Blockly_Swift_426
{
    // -(NSString * _Nullable)toXMLWithError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("toXMLWithError:")]
    [return: NullAllowed]
    string ToXMLWithError([NullAllowed] out NSError error);
}

// @interface BKYBlockBuilder : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYBlockBuilder
{
    // @property (copy, nonatomic) NSString * _Nonnull name;
    [Export("name")]
    string Name { get; set; }

    // @property (nonatomic, strong) UIColor * _Nonnull color;
    [Export("color", ArgumentSemantic.Strong)]
    UIColor Color { get; set; }

    // @property (readonly, nonatomic) BOOL outputConnectionEnabled;
    [Export("outputConnectionEnabled")]
    bool OutputConnectionEnabled { get; }

    // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable outputConnectionTypeChecks;
    [NullAllowed, Export("outputConnectionTypeChecks", ArgumentSemantic.Copy)]
    string[] OutputConnectionTypeChecks { get; }

    // @property (readonly, nonatomic) BOOL nextConnectionEnabled;
    [Export("nextConnectionEnabled")]
    bool NextConnectionEnabled { get; }

    // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable nextConnectionTypeChecks;
    [NullAllowed, Export("nextConnectionTypeChecks", ArgumentSemantic.Copy)]
    string[] NextConnectionTypeChecks { get; }

    // @property (readonly, nonatomic) BOOL previousConnectionEnabled;
    [Export("previousConnectionEnabled")]
    bool PreviousConnectionEnabled { get; }

    // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable previousConnectionTypeChecks;
    [NullAllowed, Export("previousConnectionTypeChecks", ArgumentSemantic.Copy)]
    string[] PreviousConnectionTypeChecks { get; }

    // @property (copy, nonatomic) NSArray<BKYInputBuilder *> * _Nonnull inputBuilders;
    [Export("inputBuilders", ArgumentSemantic.Copy)]
    BKYInputBuilder[] InputBuilders { get; set; }

    // @property (nonatomic) BOOL inputsInline;
    [Export("inputsInline")]
    bool InputsInline { get; set; }

    // @property (nonatomic) int position;
    [Export("position")]
    int Position { get; set; }

    // @property (copy, nonatomic) NSArray<id<BKYBlockExtension>> * _Nonnull extensions;
    [Export("extensions", ArgumentSemantic.Copy)]
    BKYBlockExtension[] Extensions { get; set; }

    // @property (nonatomic, strong) BKYBlockStyle * _Nonnull style;
    [Export("style", ArgumentSemantic.Strong)]
    BKYBlockStyle Style { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull tooltip;
    [Export("tooltip")]
    string Tooltip { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull comment;
    [Export("comment")]
    string Comment { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull helpURL;
    [Export("helpURL")]
    string HelpURL { get; set; }

    // @property (nonatomic) BOOL deletable;
    [Export("deletable")]
    bool Deletable { get; set; }

    // @property (nonatomic) BOOL movable;
    [Export("movable")]
    bool Movable { get; set; }

    // @property (nonatomic) BOOL editable;
    [Export("editable")]
    bool Editable { get; set; }

    // @property (nonatomic) BOOL disabled;
    [Export("disabled")]
    bool Disabled { get; set; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name __attribute__((objc_designated_initializer));
    [Export("initWithName:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name);

    // -(instancetype _Nonnull)initWithBlock:(BKYBlock * _Nonnull)block __attribute__((objc_designated_initializer));
    [Export("initWithBlock:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYBlock block);

    // -(BKYBlock * _Nullable)makeBlockAsShadow:(BOOL)shadow error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeBlockAsShadow:error:")]
    [return: NullAllowed]
    BKYBlock MakeBlockAsShadow(bool shadow, [NullAllowed] out NSError error);

    // -(BKYBlock * _Nullable)makeBlockAsShadow:(BOOL)shadow uuid:(NSString * _Nullable)uuid error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeBlockAsShadow:uuid:error:")]
    [return: NullAllowed]
    BKYBlock MakeBlockAsShadow(bool shadow, [NullAllowed] string uuid, [NullAllowed] out NSError error);

    // -(BOOL)setOutputConnectionWithEnabled:(BOOL)enabled typeChecks:(NSArray<NSString *> * _Nullable)typeChecks error:(NSError * _Nullable * _Nullable)error;
    [Export("setOutputConnectionWithEnabled:typeChecks:error:")]
    bool SetOutputConnectionWithEnabled(bool enabled, [NullAllowed] string[] typeChecks, [NullAllowed] out NSError error);

    // -(BOOL)setNextConnectionWithEnabled:(BOOL)enabled typeChecks:(NSArray<NSString *> * _Nullable)typeChecks error:(NSError * _Nullable * _Nullable)error;
    [Export("setNextConnectionWithEnabled:typeChecks:error:")]
    bool SetNextConnectionWithEnabled(bool enabled, [NullAllowed] string[] typeChecks, [NullAllowed] out NSError error);

    // -(BOOL)setPreviousConnectionWithEnabled:(BOOL)enabled typeChecks:(NSArray<NSString *> * _Nullable)typeChecks error:(NSError * _Nullable * _Nullable)error;
    [Export("setPreviousConnectionWithEnabled:typeChecks:error:")]
    bool SetPreviousConnectionWithEnabled(bool enabled, [NullAllowed] string[] typeChecks, [NullAllowed] out NSError error);
}

// @interface BKYBlockBumper : NSObject
[BaseType(typeof(NSObject))]
interface BKYBlockBumper
{
    // @property (nonatomic, weak) BKYWorkspaceLayoutCoordinator * _Nullable workspaceLayoutCoordinator;
    [NullAllowed, Export("workspaceLayoutCoordinator", ArgumentSemantic.Weak)]
    BKYWorkspaceLayoutCoordinator WorkspaceLayoutCoordinator { get; set; }

    // -(void)bumpBlockLayoutOfConnection:(BKYConnection * _Nonnull)impingingConnection awayFromConnection:(BKYConnection * _Nonnull)stationaryConnection;
    [Export("bumpBlockLayoutOfConnection:awayFromConnection:")]
    void BumpBlockLayoutOfConnection(BKYConnection impingingConnection, BKYConnection stationaryConnection);

    // -(void)bumpNeighborsOfBlockLayout:(BKYBlockLayout * _Nonnull)blockLayout alwaysBumpOthers:(BOOL)alwaysBumpOthers;
    [Export("bumpNeighborsOfBlockLayout:alwaysBumpOthers:")]
    void BumpNeighborsOfBlockLayout(BKYBlockLayout blockLayout, bool alwaysBumpOthers);
}



// @interface BKYBlockFactory : NSObject
[BaseType(typeof(NSObject))]
interface BKYBlockFactory
{
    // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id<BKYBlockExtension>> * _Nonnull blockExtensions;
    [Export("blockExtensions", ArgumentSemantic.Copy)]
    NSDictionary<NSString, BKYBlockExtension> BlockExtensions { get; }

    // -(void)loadFromDefaultFiles:(id)defaultFiles;
    [Export("loadFromDefaultFiles:")]
    void LoadFromDefaultFiles(NSObject defaultFiles);

    // -(BOOL)loadFromJSONPaths:(NSArray<NSString *> * _Nonnull)jsonPaths bundle:(NSBundle * _Nullable)bundle error:(NSError * _Nullable * _Nullable)error;
    [Export("loadFromJSONPaths:bundle:error:")]
    bool LoadFromJSONPaths(string[] jsonPaths, [NullAllowed] NSBundle bundle, [NullAllowed] out NSError error);

    // -(void)setBlockBuilder:(BKYBlockBuilder * _Nonnull)blockBuilder forName:(NSString * _Nonnull)name;
    [Export("setBlockBuilder:forName:")]
    void SetBlockBuilder(BKYBlockBuilder blockBuilder, string name);

    // -(BKYBlockBuilder * _Nullable)blockBuilderForName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
    [Export("blockBuilderForName:")]
    [return: NullAllowed]
    BKYBlockBuilder BlockBuilderForName(string name);

    // -(void)updateBlockExtensions:(NSDictionary<NSString *,id<BKYBlockExtension>> * _Nonnull)blockExtensions;
    [Export("updateBlockExtensions:")]
    void UpdateBlockExtensions(NSDictionary<NSString, BKYBlockExtension> blockExtensions);

    // -(BKYBlock * _Nullable)makeBlockWithName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeBlockWithName:error:")]
    [return: NullAllowed]
    BKYBlock MakeBlockWithName(string name, [NullAllowed] out NSError error);

    // -(BKYBlock * _Nullable)makeBlockWithName:(NSString * _Nonnull)name shadow:(BOOL)shadow uuid:(NSString * _Nullable)uuid error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeBlockWithName:shadow:uuid:error:")]
    [return: NullAllowed]
    BKYBlock MakeBlockWithName(string name, bool shadow, [NullAllowed] string uuid, [NullAllowed] out NSError error);
}

// @interface BKYLayout : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYLayout: INativeObject
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull uuid;
    [Export("uuid")]
    string Uuid { get; }

    // @property (readonly, nonatomic, strong) BKYLayoutEngine * _Nonnull engine;
    [Export("engine", ArgumentSemantic.Strong)]
    BKYLayoutEngine Engine { get; }

    // @property (readonly, nonatomic, strong) BKYLayoutConfig * _Nonnull config;
    [Export("config", ArgumentSemantic.Strong)]
    BKYLayoutConfig Config { get; }

    // @property (readonly, nonatomic, weak) BKYLayout * _Nullable parentLayout;
    [NullAllowed, Export("parentLayout", ArgumentSemantic.Weak)]
    BKYLayout ParentLayout { get; }

    // @property (readonly, copy, nonatomic) NSSet<BKYLayout *> * _Nonnull childLayouts;
    [Export("childLayouts", ArgumentSemantic.Copy)]
    NSSet<BKYLayout> ChildLayouts { get; }

    // @property (readonly, nonatomic) CGRect viewFrame;
    [Export("viewFrame")]
    CGRect ViewFrame { get; }

    // -(instancetype _Nonnull)initWithEngine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
    [Export("initWithEngine:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYLayoutEngine engine);

    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);

    // -(void)updateLayoutDownTree;
    [Export("updateLayoutDownTree")]
    void UpdateLayoutDownTree();

    // -(void)updateLayoutUpTree;
    [Export("updateLayoutUpTree")]
    void UpdateLayoutUpTree();

    // -(BOOL)isDescendantOf:(BKYLayout * _Nonnull)layout __attribute__((warn_unused_result));
    [Export("isDescendantOf:")]
    bool IsDescendantOf(BKYLayout layout);
}

// @interface BKYBlockGroupLayout : BKYLayout
[BaseType(typeof(BKYLayout))]
interface BKYBlockGroupLayout
{
    // @property (readonly, copy, nonatomic) NSArray<BKYBlockLayout *> * _Nonnull blockLayouts;
    [Export("blockLayouts", ArgumentSemantic.Copy)]
    BKYBlockLayout[] BlockLayouts { get; }

    // @property (nonatomic) NSUInteger zIndex;
    [Export("zIndex")]
    nuint ZIndex { get; set; }

    // @property (nonatomic) BOOL dragging;
    [Export("dragging")]
    bool Dragging { get; set; }

    // @property (readonly, nonatomic) CGFloat largestLeadingEdgeXOffset;
    [Export("largestLeadingEdgeXOffset")]
    nfloat LargestLeadingEdgeXOffset { get; }

    // -(void)appendBlockLayouts:(NSArray<BKYBlockLayout *> * _Nonnull)blockLayouts updateLayout:(BOOL)updateLayout;
    [Export("appendBlockLayouts:updateLayout:")]
    void AppendBlockLayouts(BKYBlockLayout[] blockLayouts, bool updateLayout);

    // -(BKYBlockLayout * _Nonnull)removeBlockLayoutAtIndex:(NSInteger)index updateLayout:(BOOL)updateLayout;
    [Export("removeBlockLayoutAtIndex:updateLayout:")]
    BKYBlockLayout RemoveBlockLayoutAtIndex(nint index, bool updateLayout);

    // -(void)claimWithFollowersWithBlockLayout:(BKYBlockLayout * _Nonnull)blockLayout updateLayouts:(BOOL)updateLayouts;
    [Export("claimWithFollowersWithBlockLayout:updateLayouts:")]
    void ClaimWithFollowersWithBlockLayout(BKYBlockLayout blockLayout, bool updateLayouts);

    // -(NSArray<BKYBlockLayout *> * _Nonnull)removeAllBlockLayoutsWithStartingFrom:(BKYBlockLayout * _Nonnull)blockLayout updateLayout:(BOOL)updateLayout __attribute__((warn_unused_result));
    [Export("removeAllBlockLayoutsWithStartingFrom:updateLayout:")]
    BKYBlockLayout[] RemoveAllBlockLayoutsWithStartingFrom(BKYBlockLayout blockLayout, bool updateLayout);

    // -(void)resetWithUpdateLayout:(BOOL)updateLayout;
    [Export("resetWithUpdateLayout:")]
    void ResetWithUpdateLayout(bool updateLayout);

    // -(void)moveToWorkspacePosition:(id)position updateCanvasSize:(BOOL)updateCanvasSize;
    [Export("moveToWorkspacePosition:updateCanvasSize:")]
    void MoveToWorkspacePosition(NSObject position, bool updateCanvasSize);

    // -(instancetype _Nonnull)initWithEngine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
    [Export("initWithEngine:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYLayoutEngine engine);
}

// @protocol BKYZIndexedView
[Protocol, Model]
interface BKYZIndexedView: INativeObject
{
    // @required @property (readonly, nonatomic) NSUInteger zIndex;
    [Abstract]
    [Export("zIndex")]
    nuint ZIndex { get; }
}

// @interface BKYLayoutView : UIView <BKYRecyclable>
[BaseType (typeof(UIView))]
interface BKYLayoutView : BKYRecyclable
{
    // @property (nonatomic, strong) BKYLayout * _Nullable layout;
    [NullAllowed, Export ("layout", ArgumentSemantic.Strong)]
    BKYLayout Layout { get; set; }

    [Wrap ("WeakPopoverDelegate")]
    [NullAllowed]
    BKYLayoutPopoverDelegate PopoverDelegate { get; set; }

    // @property (nonatomic, weak) id<BKYLayoutPopoverDelegate> _Nullable popoverDelegate;
    [NullAllowed, Export ("popoverDelegate", ArgumentSemantic.Weak)]
    NSObject WeakPopoverDelegate { get; set; }

    // -(void)runAnimatableCode:(BOOL)animated code:(void (^ _Nonnull)(void))code;
    [Export ("runAnimatableCode:code:")]
    void RunAnimatableCode (bool animated, Action code);

    // -(void)runAnimatableCode:(BOOL)animated code:(void (^ _Nonnull)(void))code completion:(void (^ _Nullable)(BOOL))completion;
    [Export ("runAnimatableCode:code:completion:")]
    void RunAnimatableCode (bool animated, Action code, [NullAllowed] Action<bool> completion);

    // -(void)prepareForReuse;
    [Export ("prepareForReuse")]
    void PrepareForReuse ();

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
    [Export ("initWithFrame:")]
    [DesignatedInitializer]
    IntPtr Constructor (CGRect frame);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export ("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor (NSCoder aDecoder);
}
    
// @interface BKYBlockGroupView : BKYLayoutView <BKYZIndexedView>
[BaseType(typeof(BKYLayoutView))]
interface BKYBlockGroupView : BKYZIndexedView
{
    // @property (readonly, nonatomic, strong) BKYBlockGroupLayout * _Nullable blockGroupLayout;
    [NullAllowed, Export("blockGroupLayout", ArgumentSemantic.Strong)]
    BKYBlockGroupLayout BlockGroupLayout { get; }

    [Wrap("WeakBlockGroupDelegate")]
    [NullAllowed]
    BKYBlockGroupViewDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<BKYBlockGroupViewDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakBlockGroupDelegate { get; set; }
    
    // @property (readonly, nonatomic) NSUInteger zIndex;
    [Export("zIndex")]
    nuint ZIndex { get; }

    // @property (nonatomic) BOOL dragging;
    [Export("dragging")]
    bool Dragging { get; set; }

    // -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
    [Export("hitTest:withEvent:")]
    [return: NullAllowed]
    UIView HitTest(CGPoint point, [NullAllowed] UIEvent @event);

    // -(void)prepareForReuse;
    [Export("prepareForReuse")]
    void PrepareForReuse();

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
    [Export("initWithFrame:")]
    [DesignatedInitializer]
    IntPtr Constructor(CGRect frame);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);
}

// @interface BKYBlockLayout : BKYLayout <BKYBlockListener>
[BaseType (typeof(BKYLayout))]
interface BKYBlockLayout : IBKYBlockListener
{
	// @property (readonly, nonatomic, strong) BKYBlock * _Nonnull block;
	[Export ("block", ArgumentSemantic.Strong)]
	BKYBlock Block { get; }

	// @property (readonly, copy, nonatomic) NSArray<BKYInputLayout *> * _Nonnull inputLayouts;
	[Export ("inputLayouts", ArgumentSemantic.Copy)]
	BKYInputLayout[] InputLayouts { get; }

	// @property (nonatomic, strong) BKYMutatorLayout * _Nullable mutatorLayout;
	[NullAllowed, Export ("mutatorLayout", ArgumentSemantic.Strong)]
	BKYMutatorLayout MutatorLayout { get; set; }

	// @property (readonly, copy, nonatomic) NSArray<BKYFieldLayout *> * _Nonnull fieldLayouts;
	[Export ("fieldLayouts", ArgumentSemantic.Copy)]
	BKYFieldLayout[] FieldLayouts { get; }

	// @property (readonly, nonatomic, strong) BKYBlockGroupLayout * _Nullable parentBlockGroupLayout;
	[NullAllowed, Export ("parentBlockGroupLayout", ArgumentSemantic.Strong)]
	BKYBlockGroupLayout ParentBlockGroupLayout { get; }

	// @property (readonly, nonatomic, strong) BKYBlockGroupLayout * _Nullable rootBlockGroupLayout;
	[NullAllowed, Export ("rootBlockGroupLayout", ArgumentSemantic.Strong)]
	BKYBlockGroupLayout RootBlockGroupLayout { get; }

	// @property (readonly, nonatomic, strong) BKYBlockLayout * _Nullable draggableBlockLayout;
	[NullAllowed, Export ("draggableBlockLayout", ArgumentSemantic.Strong)]
	BKYBlockLayout DraggableBlockLayout { get; }

	// @property (nonatomic) BOOL highlighted;
	[Export ("highlighted")]
	bool Highlighted { get; set; }

	// @property (nonatomic) BOOL visible;
	[Export ("visible")]
	bool Visible { get; set; }

	// @property (readonly, nonatomic) BOOL userInteractionEnabled;
	[Export ("userInteractionEnabled")]
	bool UserInteractionEnabled { get; }

	// @property (readonly, nonatomic) CGFloat leadingEdgeXOffset;
	[Export ("leadingEdgeXOffset")]
	nfloat LeadingEdgeXOffset { get; }

	// @property (nonatomic) CGFloat firstLineHeight;
	[Export ("firstLineHeight")]
	nfloat FirstLineHeight { get; set; }

	// @property (nonatomic) BOOL disabled;
	[Export ("disabled")]
	bool Disabled { get; set; }

	// @property (nonatomic) BOOL inputsInline;
	[Export ("inputsInline")]
	bool InputsInline { get; set; }

	// @property (copy, nonatomic) NSString * _Nonnull comment;
	[Export ("comment")]
	string Comment { get; set; }

	// -(instancetype _Nonnull)initWithBlock:(BKYBlock * _Nonnull)block engine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
	[Export ("initWithBlock:engine:")]
	[DesignatedInitializer]
	IntPtr Constructor (BKYBlock block, BKYLayoutEngine engine);

	// -(void)appendInputLayout:(BKYInputLayout * _Nonnull)inputLayout;
	[Export ("appendInputLayout:")]
	void AppendInputLayout (BKYInputLayout inputLayout);

	// -(BKYInputLayout * _Nonnull)removeInputLayoutAtIndex:(NSInteger)index;
	[Export ("removeInputLayoutAtIndex:")]
	BKYInputLayout RemoveInputLayoutAtIndex (nint index);

	// -(void)resetWithUpdateLayout:(BOOL)updateLayout;
	[Export ("resetWithUpdateLayout:")]
	void ResetWithUpdateLayout (bool updateLayout);

	// -(void)addHighlightSourceWithSourceUUID:(NSString * _Nonnull)sourceUUID forConnection:(BKYConnection * _Nonnull)connection;
	[Export ("addHighlightSourceWithSourceUUID:forConnection:")]
	void AddHighlightSourceWithSourceUUID (string sourceUUID, BKYConnection connection);

	// -(void)removeHighlightSourceWithSourceUUID:(NSString * _Nonnull)sourceUUID forConnection:(BKYConnection * _Nonnull)connection;
	[Export ("removeHighlightSourceWithSourceUUID:forConnection:")]
	void RemoveHighlightSourceWithSourceUUID (string sourceUUID, BKYConnection connection);

	// -(BOOL)isConnectionHighlighted:(BKYConnection * _Nonnull)connection __attribute__((warn_unused_result));
	[Export ("isConnectionHighlighted:")]
	bool IsConnectionHighlighted (BKYConnection connection);

	// -(BOOL)hasHighlightedConnections __attribute__((warn_unused_result));
	[Export ("hasHighlightedConnections")]
	[Verify (MethodToProperty)]
	bool HasHighlightedConnections { get; }

	// -(void)didUpdateBlock:(BKYBlock * _Nonnull)block;
	[Export ("didUpdateBlock:")]
	void DidUpdateBlock (BKYBlock block);
}

// @protocol BKYBlockListener
[Protocol, Model]
interface BKYBlockListener
{
    // @required -(void)didUpdateBlock:(BKYBlock * _Nonnull)block;
    [Abstract]
    [Export("didUpdateBlock:")]
    void DidUpdateBlock(BKYBlock block);
}

// @interface BKYBlockView : BKYLayoutView
[BaseType(typeof(BKYLayoutView))]
interface BKYBlockView
{
    // @property (readonly, nonatomic, strong) BKYBlockLayout * _Nullable blockLayout;
    [NullAllowed, Export("blockLayout", ArgumentSemantic.Strong)]
    BKYBlockLayout BlockLayout { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)prepareForReuse;
    [Export("prepareForReuse")]
    void PrepareForReuse();
}

// @interface BKYBlocklyError : NSError
[BaseType(typeof(NSError))]
interface BKYBlocklyError
{
    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull Domain;
    [Static]
    [Export("Domain")]
    string Domain { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);
}

// @interface BKYEvent : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYEvent
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull type;
    [Export("type")]
    string Type { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nonnull workspaceID;
    [Export("workspaceID")]
    string WorkspaceID { get; }

    // @property (copy, nonatomic) NSString * _Nullable groupID;
    [NullAllowed, Export("groupID")]
    string GroupID { get; set; }

    // @property (readonly, copy, nonatomic) NSString * _Nullable blockID;
    [NullAllowed, Export("blockID")]
    string BlockID { get; }

    // -(instancetype _Nonnull)initWithType:(NSString * _Nonnull)type workspaceID:(NSString * _Nonnull)workspaceID groupID:(NSString * _Nullable)groupID blockID:(NSString * _Nullable)blockID __attribute__((objc_designated_initializer));
    [Export("initWithType:workspaceID:groupID:blockID:")]
    [DesignatedInitializer]
    IntPtr Constructor(string type, string workspaceID, [NullAllowed] string groupID, [NullAllowed] string blockID);

    // -(instancetype _Nullable)initWithType:(NSString * _Nonnull)type json:(NSDictionary<NSString *,id> * _Nonnull)json error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithType:json:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(string type, NSDictionary<NSString, NSObject> json, [NullAllowed] out NSError error);

    // -(NSDictionary<NSString *,id> * _Nullable)toJSONAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("toJSONAndReturnError:")]
    [return: NullAllowed]
    NSDictionary<NSString, NSObject> ToJSONAndReturnError([NullAllowed] out NSError error);

    // -(NSString * _Nullable)toJSONStringAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("toJSONStringAndReturnError:")]
    [return: NullAllowed]
    string ToJSONStringAndReturnError([NullAllowed] out NSError error);

    // -(BOOL)isDiscardable __attribute__((warn_unused_result));
    [Export("isDiscardable")]
    bool IsDiscardable { get; }

    // -(BKYEvent * _Nullable)mergedWithNextChronologicalEvent:(BKYEvent * _Nonnull)event __attribute__((warn_unused_result));
    [Export("mergedWithNextChronologicalEvent:")]
    [return: NullAllowed]
    BKYEvent MergedWithNextChronologicalEvent(BKYEvent @event);
}

// @interface Blockly_Swift_1154 (BKYEvent)
[Category]
[BaseType(typeof(BKYEvent))]
interface BKYEvent_Blockly_Swift_1154
{
}

// @interface BKYEventDelete : BKYEvent
[BaseType(typeof(BKYEvent))]
interface BKYEventDelete
{
    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull EVENT_TYPE;
    [Static]
    [Export("EVENT_TYPE")]
    string EVENT_TYPE { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nonnull oldXML;
    [Export("oldXML")]
    string OldXML { get; }

    // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull blockIDs;
    [Export("blockIDs", ArgumentSemantic.Copy)]
    string[] BlockIDs { get; }

    // -(instancetype _Nullable)initWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithWorkspace:block:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYWorkspace workspace, BKYBlock block, [NullAllowed] out NSError error);

    // -(instancetype _Nullable)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithJson:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSDictionary<NSString, NSObject> json, [NullAllowed] out NSError error);

    // -(NSDictionary<NSString *,id> * _Nullable)toJSONAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("toJSONAndReturnError:")]
    [return: NullAllowed]
    NSDictionary<NSString, NSObject> ToJSONAndReturnError([NullAllowed] out NSError error);
}

// @interface Blockly_Swift_1193 (BKYEvent)
[Category]
[BaseType(typeof(BKYEvent))]
interface BKYEvent_Blockly_Swift_1193
{
}

// @interface BKYEventMove : BKYEvent
[BaseType(typeof(BKYEvent))]
interface BKYEventMove
{
    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull EVENT_TYPE;
    [Static]
    [Export("EVENT_TYPE")]
    string EVENT_TYPE { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nullable oldParentID;
    [NullAllowed, Export("oldParentID")]
    string OldParentID { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nullable oldInputName;
    [NullAllowed, Export("oldInputName")]
    string OldInputName { get; }

    // @property (copy, nonatomic) NSString * _Nullable newParentID;
    [NullAllowed, Export("newParentID")]
    string NewParentID { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable newInputName;
    [NullAllowed, Export("newInputName")]
    string NewInputName { get; set; }

    // -(instancetype _Nullable)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithJson:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSDictionary<NSString, NSObject> json, [NullAllowed] out NSError error);

    // -(instancetype _Nonnull)initWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block;
    [Export("initWithWorkspace:block:")]
    IntPtr Constructor(BKYWorkspace workspace, BKYBlock block);

    // -(NSDictionary<NSString *,id> * _Nullable)toJSONAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("toJSONAndReturnError:")]
    [return: NullAllowed]
    NSDictionary<NSString, NSObject> ToJSONAndReturnError([NullAllowed] out NSError error);

    // -(BKYEvent * _Nullable)mergedWithNextChronologicalEvent:(BKYEvent * _Nonnull)event __attribute__((warn_unused_result));
    [Export("mergedWithNextChronologicalEvent:")]
    [return: NullAllowed]
    BKYEvent MergedWithNextChronologicalEvent(BKYEvent @event);

    // -(BOOL)isDiscardable __attribute__((warn_unused_result));
    [Export("isDiscardable")]
    bool IsDiscardable { get; }

    // -(void)recordNewValuesForBlock:(BKYBlock * _Nullable)block;
    [Export("recordNewValuesForBlock:")]
    void RecordNewValuesForBlock([NullAllowed] BKYBlock block);
}

// @interface Blockly_Swift_1248 (BKYEvent)
[Category]
[BaseType(typeof(BKYEvent))]
interface BKYEvent_Blockly_Swift_1248
{
}

// @interface BKYEventUI : BKYEvent
[BaseType(typeof(BKYEvent))]
interface BKYEventUI
{
    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementCategory;
    [Static]
    [Export("elementCategory")]
    string ElementCategory { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementClick;
    [Static]
    [Export("elementClick")]
    string ElementClick { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementCommentOpen;
    [Static]
    [Export("elementCommentOpen")]
    string ElementCommentOpen { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementMutatorOpen;
    [Static]
    [Export("elementMutatorOpen")]
    string ElementMutatorOpen { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementSelected;
    [Static]
    [Export("elementSelected")]
    string ElementSelected { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementTrashOpen;
    [Static]
    [Export("elementTrashOpen")]
    string ElementTrashOpen { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementWarningOpen;
    [Static]
    [Export("elementWarningOpen")]
    string ElementWarningOpen { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull EVENT_TYPE;
    [Static]
    [Export("EVENT_TYPE")]
    string EVENT_TYPE { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nonnull element;
    [Export("element")]
    string Element { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nullable oldValue;
    [NullAllowed, Export("oldValue")]
    string OldValue { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nullable newValue;
    [NullAllowed, Export("newValue")]
    string NewValue { get; }

    // -(instancetype _Nonnull)initWithElement:(NSString * _Nonnull)element workspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nullable)block oldValue:(NSString * _Nullable)oldValue newValue:(NSString * _Nullable)newValue __attribute__((objc_designated_initializer));
    [Export("initWithElement:workspace:block:oldValue:newValue:")]
    [DesignatedInitializer]
    IntPtr Constructor(string element, BKYWorkspace workspace, [NullAllowed] BKYBlock block, [NullAllowed] string oldValue, [NullAllowed] string newValue);

    // -(instancetype _Nullable)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithJson:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSDictionary<NSString, NSObject> json, [NullAllowed] out NSError error);

    // -(NSDictionary<NSString *,id> * _Nullable)toJSONAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("toJSONAndReturnError:")]
    [return: NullAllowed]
    NSDictionary<NSString, NSObject> ToJSONAndReturnError([NullAllowed] out NSError error);

    // +(BKYEventUI * _Nonnull)blockClickedEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block __attribute__((warn_unused_result));
    [Static]
    [Export("blockClickedEventWithWorkspace:block:")]
    BKYEventUI BlockClickedEventWithWorkspace(BKYWorkspace workspace, BKYBlock block);

    // +(BKYEventUI * _Nonnull)blockSelectedEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block selectedBefore:(BOOL)selectedBefore selectedAfter:(BOOL)selectedAfter __attribute__((warn_unused_result));
    [Static]
    [Export("blockSelectedEventWithWorkspace:block:selectedBefore:selectedAfter:")]
    BKYEventUI BlockSelectedEventWithWorkspace(BKYWorkspace workspace, BKYBlock block, bool selectedBefore, bool selectedAfter);

    // +(BKYEventUI * _Nonnull)blockWarningEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block openedBefore:(BOOL)openedBefore openedAfter:(BOOL)openedAfter __attribute__((warn_unused_result));
    [Static]
    [Export("blockWarningEventWithWorkspace:block:openedBefore:openedAfter:")]
    BKYEventUI BlockWarningEventWithWorkspace(BKYWorkspace workspace, BKYBlock block, bool openedBefore, bool openedAfter);

    // +(BKYEventUI * _Nonnull)commentEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block openedBefore:(BOOL)openedBefore openedAfter:(BOOL)openedAfter __attribute__((warn_unused_result));
    [Static]
    [Export("commentEventWithWorkspace:block:openedBefore:openedAfter:")]
    BKYEventUI CommentEventWithWorkspace(BKYWorkspace workspace, BKYBlock block, bool openedBefore, bool openedAfter);

    // +(BKYEventUI * _Nonnull)mutatorPopoverEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block openedBefore:(BOOL)openedBefore openedAfter:(BOOL)openedAfter __attribute__((warn_unused_result));
    [Static]
    [Export("mutatorPopoverEventWithWorkspace:block:openedBefore:openedAfter:")]
    BKYEventUI MutatorPopoverEventWithWorkspace(BKYWorkspace workspace, BKYBlock block, bool openedBefore, bool openedAfter);

    // +(BKYEventUI * _Nonnull)toolboxCategoryEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace oldValue:(NSString * _Nullable)oldValue newValue:(NSString * _Nullable)newValue __attribute__((warn_unused_result));
    [Static]
    [Export("toolboxCategoryEventWithWorkspace:oldValue:newValue:")]
    BKYEventUI ToolboxCategoryEventWithWorkspace(BKYWorkspace workspace, [NullAllowed] string oldValue, [NullAllowed] string newValue);
}

// @interface Blockly_Swift_1395 (BKYEvent)
[Category]
[BaseType(typeof(BKYEvent))]
interface BKYEvent_Blockly_Swift_1395
{
}

// @interface BKYEventCreate : BKYEvent
[BaseType(typeof(BKYEvent))]
interface BKYEventCreate
{
    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull EVENT_TYPE;
    [Static]
    [Export("EVENT_TYPE")]
    string EVENT_TYPE { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nonnull xml;
    [Export("xml")]
    string Xml { get; }

    // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull blockIDs;
    [Export("blockIDs", ArgumentSemantic.Copy)]
    string[] BlockIDs { get; }

    // -(instancetype _Nullable)initWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithWorkspace:block:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYWorkspace workspace, BKYBlock block, [NullAllowed] out NSError error);

    // -(instancetype _Nullable)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithJson:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSDictionary<NSString, NSObject> json, [NullAllowed] out NSError error);

    // -(NSDictionary<NSString *,id> * _Nullable)toJSONAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("toJSONAndReturnError:")]
    [return: NullAllowed]
    NSDictionary<NSString, NSObject> ToJSONAndReturnError([NullAllowed] out NSError error);
}

// @interface Blockly_Swift_1434 (BKYEvent)
[Category]
[BaseType(typeof(BKYEvent))]
interface BKYEvent_Blockly_Swift_1434
{
}

// @interface BKYEventChange : BKYEvent
[BaseType(typeof(BKYEvent))]
interface BKYEventChange
{
    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementCollapsed;
    [Static]
    [Export("elementCollapsed")]
    string ElementCollapsed { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementComment;
    [Static]
    [Export("elementComment")]
    string ElementComment { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementDisabled;
    [Static]
    [Export("elementDisabled")]
    string ElementDisabled { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementField;
    [Static]
    [Export("elementField")]
    string ElementField { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementInline;
    [Static]
    [Export("elementInline")]
    string ElementInline { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull elementMutate;
    [Static]
    [Export("elementMutate")]
    string ElementMutate { get; }

    // @property (readonly, copy, nonatomic, class) NSString * _Nonnull EVENT_TYPE;
    [Static]
    [Export("EVENT_TYPE")]
    string EVENT_TYPE { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nonnull element;
    [Export("element")]
    string Element { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nullable fieldName;
    [NullAllowed, Export("fieldName")]
    string FieldName { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nullable oldValue;
    [NullAllowed, Export("oldValue")]
    string OldValue { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nullable newValue;
    [NullAllowed, Export("newValue")]
    string NewValue { get; }

    // @property (readonly, nonatomic) BOOL oldBoolValue;
    [Export("oldBoolValue")]
    bool OldBoolValue { get; }

    // @property (readonly, nonatomic) BOOL newBoolValue;
    [Export("newBoolValue")]
    bool NewBoolValue { get; }

    // -(instancetype _Nonnull)initWithElement:(NSString * _Nonnull)element workspaceID:(NSString * _Nonnull)workspaceID blockID:(NSString * _Nonnull)blockID fieldName:(NSString * _Nullable)fieldName oldValue:(NSString * _Nullable)oldValue newValue:(NSString * _Nullable)newValue __attribute__((objc_designated_initializer));
    [Export("initWithElement:workspaceID:blockID:fieldName:oldValue:newValue:")]
    [DesignatedInitializer]
    IntPtr Constructor(string element, string workspaceID, string blockID, [NullAllowed] string fieldName, [NullAllowed] string oldValue, [NullAllowed] string newValue);

    // -(instancetype _Nullable)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithJson:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSDictionary<NSString, NSObject> json, [NullAllowed] out NSError error);

    // -(NSDictionary<NSString *,id> * _Nullable)toJSONAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("toJSONAndReturnError:")]
    [return: NullAllowed]
    NSDictionary<NSString, NSObject> ToJSONAndReturnError([NullAllowed] out NSError error);

    // -(BKYEvent * _Nullable)mergedWithNextChronologicalEvent:(BKYEvent * _Nonnull)event __attribute__((warn_unused_result));
    [Export("mergedWithNextChronologicalEvent:")]
    [return: NullAllowed]
    BKYEvent MergedWithNextChronologicalEvent(BKYEvent @event);

    // -(BOOL)isDiscardable __attribute__((warn_unused_result));
    [Export("isDiscardable")]
    bool IsDiscardable { get; }

    // +(BKYEventChange * _Nonnull)commentTextEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block oldValue:(NSString * _Nonnull)oldValue newValue:(NSString * _Nonnull)newValue __attribute__((warn_unused_result));
    [Static]
    [Export("commentTextEventWithWorkspace:block:oldValue:newValue:")]
    BKYEventChange CommentTextEventWithWorkspace(BKYWorkspace workspace, BKYBlock block, string oldValue, string newValue);

    // +(BKYEventChange * _Nonnull)disabledStateEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block __attribute__((warn_unused_result));
    [Static]
    [Export("disabledStateEventWithWorkspace:block:")]
    BKYEventChange DisabledStateEventWithWorkspace(BKYWorkspace workspace, BKYBlock block);

    // +(BKYEventChange * _Nonnull)fieldValueEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block field:(BKYField * _Nonnull)field oldValue:(NSString * _Nonnull)oldValue newValue:(NSString * _Nonnull)newValue __attribute__((warn_unused_result));
    [Static]
    [Export("fieldValueEventWithWorkspace:block:field:oldValue:newValue:")]
    BKYEventChange FieldValueEventWithWorkspace(BKYWorkspace workspace, BKYBlock block, BKYField field, string oldValue, string newValue);

    // +(BKYEventChange * _Nonnull)inlineStateEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block __attribute__((warn_unused_result));
    [Static]
    [Export("inlineStateEventWithWorkspace:block:")]
    BKYEventChange InlineStateEventWithWorkspace(BKYWorkspace workspace, BKYBlock block);

    // +(BKYEventChange * _Nonnull)mutateEventWithWorkspace:(BKYWorkspace * _Nonnull)workspace block:(BKYBlock * _Nonnull)block oldValue:(NSString * _Nullable)oldValue newValue:(NSString * _Nullable)newValue __attribute__((warn_unused_result));
    [Static]
    [Export("mutateEventWithWorkspace:block:oldValue:newValue:")]
    BKYEventChange MutateEventWithWorkspace(BKYWorkspace workspace, BKYBlock block, [NullAllowed] string oldValue, [NullAllowed] string newValue);
}

// @interface BKYEventFactory : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYEventFactory
{
    // @property (nonatomic, strong, class) BKYEventFactory * _Nonnull shared;
    [Static]
    [Export("shared", ArgumentSemantic.Strong)]
    BKYEventFactory Shared { get; set; }

    // -(void)unregisterCreatorForEventType:(NSString * _Nonnull)eventType;
    [Export("unregisterCreatorForEventType:")]
    void UnregisterCreatorForEventType(string eventType);

    // -(BKYEvent * _Nullable)makeBlocklyEventFromJSON:(NSDictionary<NSString *,id> * _Nonnull)json error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeBlocklyEventFromJSON:error:")]
    [return: NullAllowed]
    BKYEvent MakeBlocklyEventFromJSON(NSDictionary<NSString, NSObject> json, [NullAllowed] out NSError error);
}

// @interface BKYBlocklyPanGestureRecognizer : UIGestureRecognizer
[BaseType(typeof(UIGestureRecognizer))]
interface BKYBlocklyPanGestureRecognizer
{
    // @property (readonly, nonatomic, strong) UITouch * _Nullable firstTouch;
    [NullAllowed, Export("firstTouch", ArgumentSemantic.Strong)]
    UITouch FirstTouch { get; }

    // @property (nonatomic) NSInteger maximumTouches;
    [Export("maximumTouches")]
    nint MaximumTouches { get; set; }

    // @property (nonatomic) float minimumPanDistance;
    [Export("minimumPanDistance")]
    float MinimumPanDistance { get; set; }

    [Wrap("WeakTargetDelegate")]
    [NullAllowed]
    BKYBlocklyPanGestureRecognizerDelegate TargetDelegate { get; set; }

    // @property (nonatomic, weak) id<BKYBlocklyPanGestureRecognizerDelegate> _Nullable targetDelegate;
    [NullAllowed, Export("targetDelegate", ArgumentSemantic.Weak)]
    NSObject WeakTargetDelegate { get; set; }

    // -(instancetype _Nonnull)initWithTargetDelegate:(id<BKYBlocklyPanGestureRecognizerDelegate> _Nullable)targetDelegate __attribute__((objc_designated_initializer));
    [Export("initWithTargetDelegate:")]
    [DesignatedInitializer]
    IntPtr Constructor([NullAllowed] BKYBlocklyPanGestureRecognizerDelegate targetDelegate);

    // -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
    [Export("touchesBegan:withEvent:")]
    void TouchesBegan(NSSet<UITouch> touches, UIEvent @event);

    // -(void)touchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
    [Export("touchesMoved:withEvent:")]
    void TouchesMoved(NSSet<UITouch> touches, UIEvent @event);

    // -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
    [Export("touchesEnded:withEvent:")]
    void TouchesEnded(NSSet<UITouch> touches, UIEvent @event);

    // -(void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
    [Export("touchesCancelled:withEvent:")]
    void TouchesCancelled(NSSet<UITouch> touches, UIEvent @event);

    // -(void)reset;
    [Export("reset")]
    void Reset();

    // -(void)cancelAllTouches;
    [Export("cancelAllTouches")]
    void CancelAllTouches();

    // -(CGPoint)firstTouchDeltaInView:(UIView * _Nullable)view __attribute__((warn_unused_result));
    [Export("firstTouchDeltaInView:")]
    CGPoint FirstTouchDeltaInView([NullAllowed] UIView view);

    // -(void)replaceBlock:(BKYBlockView * _Nonnull)block with:(BKYBlockView * _Nonnull)newBlock;
    [Export("replaceBlock:with:")]
    void ReplaceBlock(BKYBlockView block, BKYBlockView newBlock);

    // -(BOOL)isTouchingView:(UIView * _Nonnull)view __attribute__((warn_unused_result));
    [Export("isTouchingView:")]
    bool IsTouchingView(UIView view);
}

// @protocol BKYBlocklyPanGestureRecognizerDelegate
[Protocol, Model]
interface BKYBlocklyPanGestureRecognizerDelegate
{
    // @required -(void)blocklyPanGestureRecognizer:(BKYBlocklyPanGestureRecognizer * _Nonnull)gesture didTouchBlock:(BKYBlockView * _Nonnull)block touch:(UITouch * _Nonnull)touch touchState:(enum BKYBlocklyPanGestureRecognizerTouchState)touchState;
    [Abstract]
    [Export("blocklyPanGestureRecognizer:didTouchBlock:touch:touchState:")]
    void DidTouchBlock(BKYBlocklyPanGestureRecognizer gesture, BKYBlockView block, UITouch touch, BKYBlocklyPanGestureRecognizerTouchState touchState);
}

// @interface BKYCodeGenerator : NSObject <WKNavigationDelegate>
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface BKYCodeGenerator : IWKNavigationDelegate
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull jsGeneratorObject;
        [Export ("jsGeneratorObject")]
        string JsGeneratorObject { get; }

        // @property (readonly, nonatomic) enum BKYCodeGeneratorState state;
        [Export ("state")]
        BKYCodeGeneratorState State { get; }

        // -(void)webView:(WKWebView * _Nonnull)webView didFinishNavigation:(WKNavigation * _Null_unspecified)navigation;
        [Export ("webView:didFinishNavigation:")]
        void WebView (WKWebView webView, WKNavigation navigation);

        // -(void)webView:(WKWebView * _Nonnull)webView didFailNavigation:(WKNavigation * _Null_unspecified)navigation withError:(NSError * _Nonnull)error;
        [Export ("webView:didFailNavigation:withError:")]
        void WebView (WKWebView webView, WKNavigation navigation, NSError error);
    }

// @interface BKYCodeGeneratorService : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYCodeGeneratorService
{
    // -(instancetype _Nonnull)initWithJsCoreDependencies:(NSArray<NSString *> * _Nonnull)jsCoreDependencies;
    [Export("initWithJsCoreDependencies:")]
    IntPtr Constructor(string[] jsCoreDependencies);

    // -(instancetype _Nonnull)initWithJsCoreDependencies:(NSArray<NSString *> * _Nonnull)jsCoreDependencies bundle:(NSBundle * _Nonnull)bundle __attribute__((objc_designated_initializer));
    [Export("initWithJsCoreDependencies:bundle:")]
    [DesignatedInitializer]
    IntPtr Constructor(string[] jsCoreDependencies, NSBundle bundle);

    // -(void)setRequestBuilder:(BKYCodeGeneratorServiceRequestBuilder * _Nonnull)builder shouldCache:(BOOL)shouldCache;
    [Export("setRequestBuilder:shouldCache:")]
    void SetRequestBuilder(BKYCodeGeneratorServiceRequestBuilder builder, bool shouldCache);

    // -(NSString * _Nullable)generateCodeForWorkspace:(BKYWorkspace * _Nonnull)workspace error:(NSError * _Nullable * _Nullable)error onCompletion:(void (^ _Nullable)(NSString * _Nonnull, NSString * _Nonnull))onCompletion onError:(void (^ _Nullable)(NSString * _Nonnull, NSString * _Nonnull))onError __attribute__((warn_unused_result));
    [Export("generateCodeForWorkspace:error:onCompletion:onError:")]
    [return: NullAllowed]
    string GenerateCodeForWorkspace(BKYWorkspace workspace, [NullAllowed] out NSError error, [NullAllowed] Action<NSString, NSString> onCompletion, [NullAllowed] Action<NSString, NSString> onError);

    // -(NSString * _Nullable)generateCodeForWorkspaceXML:(NSString * _Nonnull)xml error:(NSError * _Nullable * _Nullable)error onCompletion:(void (^ _Nullable)(NSString * _Nonnull, NSString * _Nonnull))onCompletion onError:(void (^ _Nullable)(NSString * _Nonnull, NSString * _Nonnull))onError __attribute__((warn_unused_result));
    [Export("generateCodeForWorkspaceXML:error:onCompletion:onError:")]
    [return: NullAllowed]
    string GenerateCodeForWorkspaceXML(string xml, [NullAllowed] out NSError error, [NullAllowed] Action<NSString, NSString> onCompletion, [NullAllowed] Action<NSString, NSString> onError);

    // -(void)cancelRequestWithUuid:(NSString * _Nonnull)uuid;
    [Export("cancelRequestWithUuid:")]
    void CancelRequestWithUuid(string uuid);

    // -(void)cancelAllRequests;
    [Export("cancelAllRequests")]
    void CancelAllRequests();
}

// @interface BKYCodeGeneratorServiceRequestBuilder : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYCodeGeneratorServiceRequestBuilder
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull jsGeneratorObject;
    [Export("jsGeneratorObject")]
    string JsGeneratorObject { get; }

    // -(instancetype _Nonnull)initWithJSGeneratorObject:(NSString * _Nonnull)jsGeneratorObject __attribute__((objc_designated_initializer));
    [Export("initWithJSGeneratorObject:")]
    [DesignatedInitializer]
    IntPtr Constructor(string jsGeneratorObject);

    // -(void)addJSBlockGeneratorFiles:(NSArray<NSString *> * _Nonnull)files;
    [Export("addJSBlockGeneratorFiles:")]
    void AddJSBlockGeneratorFiles(string[] files);

    // -(void)addJSBlockGeneratorFiles:(NSArray<NSString *> * _Nonnull)files bundle:(NSBundle * _Nonnull)bundle;
    [Export("addJSBlockGeneratorFiles:bundle:")]
    void AddJSBlockGeneratorFiles(string[] files, NSBundle bundle);

    // -(void)addJSONBlockDefinitionFilesFromDefaultFiles:(id)defaultFiles;
    [Export("addJSONBlockDefinitionFilesFromDefaultFiles:")]
    void AddJSONBlockDefinitionFilesFromDefaultFiles(NSObject defaultFiles);

    // -(void)addJSONBlockDefinitionFiles:(NSArray<NSString *> * _Nonnull)files;
    [Export("addJSONBlockDefinitionFiles:")]
    void AddJSONBlockDefinitionFiles(string[] files);

    // -(void)addJSONBlockDefinitionFiles:(NSArray<NSString *> * _Nonnull)files bundle:(NSBundle * _Nonnull)bundle;
    [Export("addJSONBlockDefinitionFiles:bundle:")]
    void AddJSONBlockDefinitionFiles(string[] files, NSBundle bundle);
}

// @interface BKYColorHelper : NSObject
[BaseType(typeof(NSObject))]
interface BKYColorHelper
{
    // +(UIColor * _Nullable)makeColorWithRgb:(NSString * _Nonnull)rgb alpha:(CGFloat)alpha __attribute__((warn_unused_result));
    [Static]
    [Export("makeColorWithRgb:alpha:")]
    [return: NullAllowed]
    UIColor MakeColorWithRgb(string rgb, nfloat alpha);

    // +(UIColor * _Nonnull)makeColorWithHue:(CGFloat)hue __attribute__((warn_unused_result));
    [Static]
    [Export("makeColorWithHue:")]
    UIColor MakeColorWithHue(nfloat hue);

    // +(UIColor * _Nonnull)makeColorWithHue:(CGFloat)hue saturation:(CGFloat)saturation brightness:(CGFloat)brightness alpha:(CGFloat)alpha __attribute__((warn_unused_result));
    [Static]
    [Export("makeColorWithHue:saturation:brightness:alpha:")]
    UIColor MakeColorWithHue(nfloat hue, nfloat saturation, nfloat brightness, nfloat alpha);
}

// @interface BKYColorPalette : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYColorPalette
{
    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint50;
    [Export("tint50", ArgumentSemantic.Strong)]
    UIColor Tint50 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint100;
    [Export("tint100", ArgumentSemantic.Strong)]
    UIColor Tint100 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint200;
    [Export("tint200", ArgumentSemantic.Strong)]
    UIColor Tint200 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint300;
    [Export("tint300", ArgumentSemantic.Strong)]
    UIColor Tint300 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint400;
    [Export("tint400", ArgumentSemantic.Strong)]
    UIColor Tint400 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint500;
    [Export("tint500", ArgumentSemantic.Strong)]
    UIColor Tint500 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint600;
    [Export("tint600", ArgumentSemantic.Strong)]
    UIColor Tint600 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint700;
    [Export("tint700", ArgumentSemantic.Strong)]
    UIColor Tint700 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint800;
    [Export("tint800", ArgumentSemantic.Strong)]
    UIColor Tint800 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull tint900;
    [Export("tint900", ArgumentSemantic.Strong)]
    UIColor Tint900 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nullable accent100;
    [NullAllowed, Export("accent100", ArgumentSemantic.Strong)]
    UIColor Accent100 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nullable accent200;
    [NullAllowed, Export("accent200", ArgumentSemantic.Strong)]
    UIColor Accent200 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nullable accent400;
    [NullAllowed, Export("accent400", ArgumentSemantic.Strong)]
    UIColor Accent400 { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nullable accent700;
    [NullAllowed, Export("accent700", ArgumentSemantic.Strong)]
    UIColor Accent700 { get; }

    // -(instancetype _Nonnull)initWithTint50:(UIColor * _Nonnull)tint50 tint100:(UIColor * _Nonnull)tint100 tint200:(UIColor * _Nonnull)tint200 tint300:(UIColor * _Nonnull)tint300 tint400:(UIColor * _Nonnull)tint400 tint500:(UIColor * _Nonnull)tint500 tint600:(UIColor * _Nonnull)tint600 tint700:(UIColor * _Nonnull)tint700 tint800:(UIColor * _Nonnull)tint800 tint900:(UIColor * _Nonnull)tint900 accent100:(UIColor * _Nullable)accent100 accent200:(UIColor * _Nullable)accent200 accent400:(UIColor * _Nullable)accent400 accent700:(UIColor * _Nullable)accent700 __attribute__((objc_designated_initializer));
    [Export("initWithTint50:tint100:tint200:tint300:tint400:tint500:tint600:tint700:tint800:tint900:accent100:accent200:accent400:accent700:")]
    [DesignatedInitializer]
    IntPtr Constructor(UIColor tint50, UIColor tint100, UIColor tint200, UIColor tint300, UIColor tint400, UIColor tint500, UIColor tint600, UIColor tint700, UIColor tint800, UIColor tint900, [NullAllowed] UIColor accent100, [NullAllowed] UIColor accent200, [NullAllowed] UIColor accent400, [NullAllowed] UIColor accent700);

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull red;
    [Static]
    [Export("red", ArgumentSemantic.Strong)]
    BKYColorPalette Red { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull pink;
    [Static]
    [Export("pink", ArgumentSemantic.Strong)]
    BKYColorPalette Pink { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull purple;
    [Static]
    [Export("purple", ArgumentSemantic.Strong)]
    BKYColorPalette Purple { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull deepPurple;
    [Static]
    [Export("deepPurple", ArgumentSemantic.Strong)]
    BKYColorPalette DeepPurple { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull indigo;
    [Static]
    [Export("indigo", ArgumentSemantic.Strong)]
    BKYColorPalette Indigo { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull blue;
    [Static]
    [Export("blue", ArgumentSemantic.Strong)]
    BKYColorPalette Blue { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull lightBlue;
    [Static]
    [Export("lightBlue", ArgumentSemantic.Strong)]
    BKYColorPalette LightBlue { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull cyan;
    [Static]
    [Export("cyan", ArgumentSemantic.Strong)]
    BKYColorPalette Cyan { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull teal;
    [Static]
    [Export("teal", ArgumentSemantic.Strong)]
    BKYColorPalette Teal { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull green;
    [Static]
    [Export("green", ArgumentSemantic.Strong)]
    BKYColorPalette Green { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull lightGreen;
    [Static]
    [Export("lightGreen", ArgumentSemantic.Strong)]
    BKYColorPalette LightGreen { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull lime;
    [Static]
    [Export("lime", ArgumentSemantic.Strong)]
    BKYColorPalette Lime { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull yellow;
    [Static]
    [Export("yellow", ArgumentSemantic.Strong)]
    BKYColorPalette Yellow { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull amber;
    [Static]
    [Export("amber", ArgumentSemantic.Strong)]
    BKYColorPalette Amber { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull orange;
    [Static]
    [Export("orange", ArgumentSemantic.Strong)]
    BKYColorPalette Orange { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull deepOrange;
    [Static]
    [Export("deepOrange", ArgumentSemantic.Strong)]
    BKYColorPalette DeepOrange { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull brown;
    [Static]
    [Export("brown", ArgumentSemantic.Strong)]
    BKYColorPalette Brown { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull grey;
    [Static]
    [Export("grey", ArgumentSemantic.Strong)]
    BKYColorPalette Grey { get; }

    // @property (readonly, nonatomic, strong, class) BKYColorPalette * _Nonnull blueGrey;
    [Static]
    [Export("blueGrey", ArgumentSemantic.Strong)]
    BKYColorPalette BlueGrey { get; }
}

// @interface BKYConnection : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYConnection
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull uuid;
    [Export("uuid")]
    string Uuid { get; }

    // @property (readonly, nonatomic) enum BKYConnectionType type;
    [Export("type")]
    BKYConnectionType Type { get; }

    // @property (readonly, nonatomic, weak) BKYBlock * _Nullable sourceBlock;
    [NullAllowed, Export("sourceBlock", ArgumentSemantic.Weak)]
    BKYBlock SourceBlock { get; }

    // @property (readonly, nonatomic, weak) BKYInput * _Nullable sourceInput;
    [NullAllowed, Export("sourceInput", ArgumentSemantic.Weak)]
    BKYInput SourceInput { get; }

    // @property (readonly, nonatomic) int position;
    [Export("position")]
    int Position { get; }

    // @property (readonly, nonatomic, weak) BKYConnection * _Nullable targetConnection;
    [NullAllowed, Export("targetConnection", ArgumentSemantic.Weak)]
    BKYConnection TargetConnection { get; }

    // @property (readonly, nonatomic, weak) BKYConnection * _Nullable shadowConnection;
    [NullAllowed, Export("shadowConnection", ArgumentSemantic.Weak)]
    BKYConnection ShadowConnection { get; }

    // @property (readonly, nonatomic, strong) BKYBlock * _Nullable targetBlock;
    [NullAllowed, Export("targetBlock", ArgumentSemantic.Strong)]
    BKYBlock TargetBlock { get; }

    // @property (readonly, nonatomic, strong) BKYBlock * _Nullable shadowBlock;
    [NullAllowed, Export("shadowBlock", ArgumentSemantic.Strong)]
    BKYBlock ShadowBlock { get; }

    // @property (readonly, nonatomic) BOOL connected;
    [Export("connected")]
    bool Connected { get; }

    // @property (readonly, nonatomic) BOOL shadowConnected;
    [Export("shadowConnected")]
    bool ShadowConnected { get; }

    // @property (copy, nonatomic) NSArray<NSString *> * _Nullable typeChecks;
    [NullAllowed, Export("typeChecks", ArgumentSemantic.Copy)]
    string[] TypeChecks { get; set; }

    // @property (readonly, nonatomic) BOOL highPriority;
    [Export("highPriority")]
    bool HighPriority { get; }

    [Wrap("WeakPositionDelegate")]
    [NullAllowed]
    BKYConnectionPositionDelegate PositionDelegate { get; set; }

    // @property (nonatomic, weak) id<BKYConnectionPositionDelegate> _Nullable positionDelegate;
    [NullAllowed, Export("positionDelegate", ArgumentSemantic.Weak)]
    NSObject WeakPositionDelegate { get; set; }

    // @property (readonly, nonatomic) BOOL isInferior;
    [Export("isInferior")]
    bool IsInferior { get; }

    // -(instancetype _Nonnull)initWithType:(enum BKYConnectionType)type sourceInput:(BKYInput * _Nullable)sourceInput __attribute__((objc_designated_initializer));
    [Export("initWithType:sourceInput:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYConnectionType type, [NullAllowed] BKYInput sourceInput);

    // -(BOOL)connectTo:(BKYConnection * _Nullable)connection error:(NSError * _Nullable * _Nullable)error;
    [Export("connectTo:error:")]
    bool ConnectTo([NullAllowed] BKYConnection connection, [NullAllowed] out NSError error);

    // -(BOOL)connectShadowTo:(BKYConnection * _Nullable)connection error:(NSError * _Nullable * _Nullable)error;
    [Export("connectShadowTo:error:")]
    bool ConnectShadowTo([NullAllowed] BKYConnection connection, [NullAllowed] out NSError error);

    // -(void)disconnect;
    [Export("disconnect")]
    void Disconnect();

    // -(void)disconnectShadow;
    [Export("disconnectShadow")]
    void DisconnectShadow();

    // -(BOOL)canConnectTo:(BKYConnection * _Nonnull)target __attribute__((warn_unused_result));
    [Export("canConnectTo:")]
    bool CanConnectTo(BKYConnection target);

    // -(CGFloat)distanceFromConnection:(BKYConnection * _Nonnull)other __attribute__((warn_unused_result));
    [Export("distanceFromConnection:")]
    nfloat DistanceFromConnection(BKYConnection other);

    // -(void)moveToPosition:(id)position withOffset:(id)offset;
    [Export("moveToPosition:withOffset:")]
    void MoveToPosition(NSObject position, NSObject offset);
}

// @interface BKYConnectionManager : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYConnectionManager
{
    // @property (readonly, nonatomic, strong) BKYConnectionManagerGroup * _Nonnull mainGroup;
    [Export("mainGroup", ArgumentSemantic.Strong)]
    BKYConnectionManagerGroup MainGroup { get; }

    // -(BKYConnectionManagerGroup * _Nonnull)startGroupForBlock:(BKYBlock * _Nullable)block __attribute__((warn_unused_result));
    [Export("startGroupForBlock:")]
    BKYConnectionManagerGroup StartGroupForBlock([NullAllowed] BKYBlock block);

    // -(void)mergeGroup:(BKYConnectionManagerGroup * _Nonnull)fromGroup intoGroup:(BKYConnectionManagerGroup * _Nullable)intoGroup;
    [Export("mergeGroup:intoGroup:")]
    void MergeGroup(BKYConnectionManagerGroup fromGroup, [NullAllowed] BKYConnectionManagerGroup intoGroup);

    // -(void)trackConnection:(BKYConnection * _Nonnull)connection assignToGroup:(BKYConnectionManagerGroup * _Nullable)group;
    [Export("trackConnection:assignToGroup:")]
    void TrackConnection(BKYConnection connection, [NullAllowed] BKYConnectionManagerGroup group);

    // -(void)untrackConnection:(BKYConnection * _Nonnull)connection;
    [Export("untrackConnection:")]
    void UntrackConnection(BKYConnection connection);

    // -(void)untrackOrphanedConnections;
    [Export("untrackOrphanedConnections")]
    void UntrackOrphanedConnections();

    // -(NSArray<BKYConnection *> * _Nonnull)stationaryNeighborsForConnection:(BKYConnection * _Nonnull)connection maxRadius:(CGFloat)maxRadius __attribute__((warn_unused_result));
    [Export("stationaryNeighborsForConnection:maxRadius:")]
    BKYConnection[] StationaryNeighborsForConnection(BKYConnection connection, nfloat maxRadius);
}

// @interface Blockly_Swift_2140 (BKYConnectionManager)
[Category]
[BaseType(typeof(BKYConnectionManager))]
interface BKYConnectionManager_Blockly_Swift_2140
{
}

// @protocol BKYConnectionPositionDelegate
[Protocol, Model]
interface BKYConnectionPositionDelegate
{
    // @required -(void)willChangePositionForConnection:(BKYConnection * _Nonnull)connection;
    [Abstract]
    [Export("willChangePositionForConnection:")]
    void WillChangePositionForConnection(BKYConnection connection);

    // @required -(void)didChangePositionForConnection:(BKYConnection * _Nonnull)connection;
    [Abstract]
    [Export("didChangePositionForConnection:")]
    void DidChangePositionForConnection(BKYConnection connection);
}

// @interface BKYConnectionManagerGroup : NSObject <BKYConnectionPositionDelegate>
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYConnectionManagerGroup : BKYConnectionPositionDelegate
{
    // @property (nonatomic) BOOL dragMode;
    [Export("dragMode")]
    bool DragMode { get; set; }

    // -(void)willChangePositionForConnection:(BKYConnection * _Nonnull)connection;
    [Export("willChangePositionForConnection:")]
    void WillChangePositionForConnection(BKYConnection connection);

    // -(void)didChangePositionForConnection:(BKYConnection * _Nonnull)connection;
    [Export("didChangePositionForConnection:")]
    void DidChangePositionForConnection(BKYConnection connection);
}

// @interface BKYDefaultBlockGroupLayout : BKYBlockGroupLayout
[BaseType(typeof(BKYBlockGroupLayout))]
interface BKYDefaultBlockGroupLayout
{
    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);

    // -(instancetype _Nonnull)initWithEngine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
    [Export("initWithEngine:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYLayoutEngine engine);
}

// @interface BKYDefaultBlockLayout : BKYBlockLayout
[BaseType(typeof(BKYBlockLayout))]
interface BKYDefaultBlockLayout
{
    // @property (readonly, nonatomic, strong) BKYDefaultBlockLayoutBackground * _Nonnull background;
    [Export("background", ArgumentSemantic.Strong)]
    BKYDefaultBlockLayoutBackground Background { get; }

    // @property (readonly, nonatomic) CGFloat leadingEdgeXOffset;
    [Export("leadingEdgeXOffset")]
    nfloat LeadingEdgeXOffset { get; }

    // -(instancetype _Nonnull)initWithBlock:(BKYBlock * _Nonnull)block engine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
    [Export("initWithBlock:engine:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYBlock block, BKYLayoutEngine engine);

    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);
}

// @interface Blockly_Swift_2199 (BKYDefaultBlockLayout)
[Category]
[BaseType(typeof(BKYDefaultBlockLayout))]
interface BKYDefaultBlockLayout_Blockly_Swift_2199
{
}

// @interface BKYDefaultBlockLayoutBackground : NSObject
[BaseType(typeof(NSObject))]
interface BKYDefaultBlockLayoutBackground
{
    // @property (readonly, nonatomic) BOOL squareTopLeftCorner;
    [Export("squareTopLeftCorner")]
    bool SquareTopLeftCorner { get; }

    // @property (readonly, nonatomic) BOOL squareBottomLeftCorner;
    [Export("squareBottomLeftCorner")]
    bool SquareBottomLeftCorner { get; }

    // @property (readonly, nonatomic) BOOL previousStatementConnector;
    [Export("previousStatementConnector")]
    bool PreviousStatementConnector { get; }

    // @property (readonly, nonatomic) BOOL nextStatementConnector;
    [Export("nextStatementConnector")]
    bool NextStatementConnector { get; }

    // @property (readonly, nonatomic) BOOL outputConnector;
    [Export("outputConnector")]
    bool OutputConnector { get; }

    // @property (readonly, nonatomic) CGFloat firstLineHeight;
    [Export("firstLineHeight")]
    nfloat FirstLineHeight { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nonnull hat;
    [Export("hat")]
    string Hat { get; }

    // @property (readonly, nonatomic) CGFloat leadingEdgeXOffset;
    [Export("leadingEdgeXOffset")]
    nfloat LeadingEdgeXOffset { get; }

    // @property (readonly, nonatomic) CGFloat leadingEdgeYOffset;
    [Export("leadingEdgeYOffset")]
    nfloat LeadingEdgeYOffset { get; }

    // @property (readonly, copy, nonatomic) NSArray<BKYBlockLayoutBackgroundRow *> * _Nonnull rows;
    [Export("rows", ArgumentSemantic.Copy)]
    BKYBlockLayoutBackgroundRow[] Rows { get; }

    // -(void)updateRenderPropertiesFromBlockLayout:(BKYDefaultBlockLayout * _Nonnull)layout;
    [Export("updateRenderPropertiesFromBlockLayout:")]
    void UpdateRenderPropertiesFromBlockLayout(BKYDefaultBlockLayout layout);

    // -(void)appendRow:(BKYBlockLayoutBackgroundRow * _Nonnull)row;
    [Export("appendRow:")]
    void AppendRow(BKYBlockLayoutBackgroundRow row);

    // -(void)removeAllRows;
    [Export("removeAllRows")]
    void RemoveAllRows();
}

// @interface BKYBlockLayoutBackgroundRow : NSObject
[BaseType(typeof(NSObject))]
interface BKYBlockLayoutBackgroundRow
{
    // @property (nonatomic) BOOL outputConnector;
    [Export("outputConnector")]
    bool OutputConnector { get; set; }

    // @property (nonatomic) BOOL isStatement;
    [Export("isStatement")]
    bool IsStatement { get; set; }

    // @property (nonatomic) CGFloat rightEdge;
    [Export("rightEdge")]
    nfloat RightEdge { get; set; }

    // @property (nonatomic) CGFloat topPadding;
    [Export("topPadding")]
    nfloat TopPadding { get; set; }

    // @property (nonatomic) CGFloat bottomPadding;
    [Export("bottomPadding")]
    nfloat BottomPadding { get; set; }

    // @property (nonatomic) CGFloat middleHeight;
    [Export("middleHeight")]
    nfloat MiddleHeight { get; set; }

    // @property (nonatomic) CGFloat statementIndent;
    [Export("statementIndent")]
    nfloat StatementIndent { get; set; }

    // @property (nonatomic) CGFloat statementConnectorWidth;
    [Export("statementConnectorWidth")]
    nfloat StatementConnectorWidth { get; set; }

    // @property (copy, nonatomic) NSArray<BKYLayout *> * _Nonnull layouts;
    [Export("layouts", ArgumentSemantic.Copy)]
    BKYLayout[] Layouts { get; set; }

    // @property (readonly, nonatomic) CGFloat rowHeight;
    [Export("rowHeight")]
    nfloat RowHeight { get; }
}

// @interface BKYDefaultBlockView : BKYBlockView
[BaseType(typeof(BKYBlockView))]
interface BKYDefaultBlockView
{
    // @property (readonly, nonatomic, strong) BKYDefaultBlockLayout * _Nullable defaultBlockLayout;
    [NullAllowed, Export("defaultBlockLayout", ArgumentSemantic.Strong)]
    BKYDefaultBlockLayout DefaultBlockLayout { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
    [Export("hitTest:withEvent:")]
    [return: NullAllowed]
    UIView HitTest(CGPoint point, [NullAllowed] UIEvent @event);

    // -(void)prepareForReuse;
    [Export("prepareForReuse")]
    void PrepareForReuse();
}

// @interface BKYDefaultConnectionValidator : NSObject
[BaseType(typeof(NSObject))]
interface BKYDefaultConnectionValidator
{
    // -(BOOL)canConnect:(BKYConnection * _Nonnull)moving toConnection:(BKYConnection * _Nonnull)candidate __attribute__((warn_unused_result));
    [Export("canConnect:toConnection:")]
    bool CanConnect(BKYConnection moving, BKYConnection candidate);
}

// @interface BKYInputLayout : BKYLayout
[BaseType(typeof(BKYLayout))]
interface BKYInputLayout
{
    // @property (readonly, nonatomic, strong) BKYInput * _Nonnull input;
    [Export("input", ArgumentSemantic.Strong)]
    BKYInput Input { get; }

    // @property (readonly, nonatomic, strong) BKYBlockLayout * _Nullable parentBlockLayout;
    [NullAllowed, Export("parentBlockLayout", ArgumentSemantic.Strong)]
    BKYBlockLayout ParentBlockLayout { get; }

    // @property (readonly, nonatomic, strong) BKYBlockGroupLayout * _Null_unspecified blockGroupLayout;
    [Export("blockGroupLayout", ArgumentSemantic.Strong)]
    BKYBlockGroupLayout BlockGroupLayout { get; }

    // @property (readonly, copy, nonatomic) NSArray<BKYFieldLayout *> * _Nonnull fieldLayouts;
    [Export("fieldLayouts", ArgumentSemantic.Copy)]
    BKYFieldLayout[] FieldLayouts { get; }

    // @property (nonatomic) CGFloat firstLineHeight;
    [Export("firstLineHeight")]
    nfloat FirstLineHeight { get; set; }

    // @property (readonly, nonatomic) BOOL isFirstChild;
    [Export("isFirstChild")]
    bool IsFirstChild { get; }

    // @property (readonly, nonatomic) BOOL isLastChild;
    [Export("isLastChild")]
    bool IsLastChild { get; }

    // -(instancetype _Nullable)initWithInput:(BKYInput * _Nonnull)input engine:(BKYLayoutEngine * _Nonnull)engine factory:(BKYLayoutFactory * _Nonnull)factory error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithInput:engine:factory:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYInput input, BKYLayoutEngine engine, BKYLayoutFactory factory, [NullAllowed] out NSError error);

    // -(void)appendFieldLayout:(BKYFieldLayout * _Nonnull)fieldLayout;
    [Export("appendFieldLayout:")]
    void AppendFieldLayout(BKYFieldLayout fieldLayout);

    // -(BKYFieldLayout * _Nonnull)removeFieldLayoutAtIndex:(NSInteger)index;
    [Export("removeFieldLayoutAtIndex:")]
    BKYFieldLayout RemoveFieldLayoutAtIndex(nint index);

    // -(void)resetWithUpdateLayout:(BOOL)updateLayout;
    [Export("resetWithUpdateLayout:")]
    void ResetWithUpdateLayout(bool updateLayout);
}

// @interface BKYDefaultInputLayout : BKYInputLayout
[BaseType(typeof(BKYInputLayout))]
interface BKYDefaultInputLayout
{
    // @property (nonatomic) CGFloat rightEdge;
    [Export("rightEdge")]
    nfloat RightEdge { get; set; }

    // @property (nonatomic) int inlineConnectorPosition;
    [Export("inlineConnectorPosition")]
    int InlineConnectorPosition { get; set; }

    // @property (nonatomic) int inlineConnectorSize;
    [Export("inlineConnectorSize")]
    int InlineConnectorSize { get; set; }

    // @property (nonatomic) CGFloat statementIndent;
    [Export("statementIndent")]
    nfloat StatementIndent { get; set; }

    // @property (nonatomic) CGFloat statementConnectorWidth;
    [Export("statementConnectorWidth")]
    nfloat StatementConnectorWidth { get; set; }

    // @property (nonatomic) CGFloat statementRowTopPadding;
    [Export("statementRowTopPadding")]
    nfloat StatementRowTopPadding { get; set; }

    // @property (nonatomic) CGFloat statementRowBottomPadding;
    [Export("statementRowBottomPadding")]
    nfloat StatementRowBottomPadding { get; set; }

    // @property (nonatomic) CGFloat statementMiddleHeight;
    [Export("statementMiddleHeight")]
    nfloat StatementMiddleHeight { get; set; }

    // @property (readonly, nonatomic) CGFloat minimalFieldWidthRequired;
    [Export("minimalFieldWidthRequired")]
    nfloat MinimalFieldWidthRequired { get; }

    // @property (readonly, nonatomic) CGFloat minimalStatementWidthRequired;
    [Export("minimalStatementWidthRequired")]
    nfloat MinimalStatementWidthRequired { get; }

    // -(instancetype _Nullable)initWithInput:(BKYInput * _Nonnull)input engine:(BKYLayoutEngine * _Nonnull)engine factory:(BKYLayoutFactory * _Nonnull)factory error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
    [Export("initWithInput:engine:factory:error:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYInput input, BKYLayoutEngine engine, BKYLayoutFactory factory, [NullAllowed] out NSError error);

    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);
}

// @interface BKYLayoutConfig : NSObject
[BaseType(typeof(NSObject))]
interface BKYLayoutConfig
{
    // @property (readonly, nonatomic, class) NSInteger BlockBumpDistance;
    [Static]
    [Export("BlockBumpDistance")]
    nint BlockBumpDistance { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockSnapDistance;
    [Static]
    [Export("BlockSnapDistance")]
    nint BlockSnapDistance { get; }

    // @property (readonly, nonatomic, class) NSInteger InlineXPadding;
    [Static]
    [Export("InlineXPadding")]
    nint InlineXPadding { get; }

    // @property (readonly, nonatomic, class) NSInteger InlineYPadding;
    [Static]
    [Export("InlineYPadding")]
    nint InlineYPadding { get; }

    // @property (readonly, nonatomic, class) NSInteger WorkspaceFlowXSeparatorSpace;
    [Static]
    [Export("WorkspaceFlowXSeparatorSpace")]
    nint WorkspaceFlowXSeparatorSpace { get; }

    // @property (readonly, nonatomic, class) NSInteger WorkspaceFlowYSeparatorSpace;
    [Static]
    [Export("WorkspaceFlowYSeparatorSpace")]
    nint WorkspaceFlowYSeparatorSpace { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldMinimumHeight;
    [Static]
    [Export("FieldMinimumHeight")]
    nint FieldMinimumHeight { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldCornerRadius;
    [Static]
    [Export("FieldCornerRadius")]
    nint FieldCornerRadius { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldLineWidth;
    [Static]
    [Export("FieldLineWidth")]
    nint FieldLineWidth { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldAnglePickerOptions;
    [Static]
    [Export("FieldAnglePickerOptions")]
    nint FieldAnglePickerOptions { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldColorButtonBorderWidth;
    [Static]
    [Export("FieldColorButtonBorderWidth")]
    nint FieldColorButtonBorderWidth { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldColorButtonBorderColor;
    [Static]
    [Export("FieldColorButtonBorderColor")]
    nint FieldColorButtonBorderColor { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldColorButtonSize;
    [Static]
    [Export("FieldColorButtonSize")]
    nint FieldColorButtonSize { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldCheckboxSwitchOnTintColor;
    [Static]
    [Export("FieldCheckboxSwitchOnTintColor")]
    nint FieldCheckboxSwitchOnTintColor { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldCheckboxSwitchTintColor;
    [Static]
    [Export("FieldCheckboxSwitchTintColor")]
    nint FieldCheckboxSwitchTintColor { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldDropdownXSpacing;
    [Static]
    [Export("FieldDropdownXSpacing")]
    nint FieldDropdownXSpacing { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldDropdownYSpacing;
    [Static]
    [Export("FieldDropdownYSpacing")]
    nint FieldDropdownYSpacing { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldDropdownBackgroundColor;
    [Static]
    [Export("FieldDropdownBackgroundColor")]
    nint FieldDropdownBackgroundColor { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldDropdownBorderColor;
    [Static]
    [Export("FieldDropdownBorderColor")]
    nint FieldDropdownBorderColor { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldLabelTextColor;
    [Static]
    [Export("FieldLabelTextColor")]
    nint FieldLabelTextColor { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldEditableTextColor;
    [Static]
    [Export("FieldEditableTextColor")]
    nint FieldEditableTextColor { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldNumberPadOptions;
    [Static]
    [Export("FieldNumberPadOptions")]
    nint FieldNumberPadOptions { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldTextFieldInsetPadding;
    [Static]
    [Export("FieldTextFieldInsetPadding")]
    nint FieldTextFieldInsetPadding { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldTextFieldMinimumWidth;
    [Static]
    [Export("FieldTextFieldMinimumWidth")]
    nint FieldTextFieldMinimumWidth { get; }

    // @property (readonly, nonatomic, class) NSInteger FieldTextFieldMaximumWidth;
    [Static]
    [Export("FieldTextFieldMaximumWidth")]
    nint FieldTextFieldMaximumWidth { get; }

    // @property (readonly, nonatomic, class) NSInteger GlobalFont;
    [Static]
    [Export("GlobalFont")]
    nint GlobalFont { get; }

    // @property (readonly, nonatomic, class) NSInteger MutatorButtonSize;
    [Static]
    [Export("MutatorButtonSize")]
    nint MutatorButtonSize { get; }

    // @property (readonly, nonatomic, class) NSInteger PopoverLabelFont;
    [Static]
    [Export("PopoverLabelFont")]
    nint PopoverLabelFont { get; }

    // @property (readonly, nonatomic, class) NSInteger PopoverTitleFont;
    [Static]
    [Export("PopoverTitleFont")]
    nint PopoverTitleFont { get; }

    // @property (readonly, nonatomic, class) NSInteger PopoverSubtitleFont;
    [Static]
    [Export("PopoverSubtitleFont")]
    nint PopoverSubtitleFont { get; }

    // @property (readonly, nonatomic, class) NSInteger ViewAnimationDuration;
    [Static]
    [Export("ViewAnimationDuration")]
    nint ViewAnimationDuration { get; }

    // @property (readonly, nonatomic, class) NSInteger VariableBlocks;
    [Static]
    [Export("VariableBlocks")]
    nint VariableBlocks { get; }

    // @property (readonly, nonatomic, class) NSInteger UniqueVariableBlocks;
    [Static]
    [Export("UniqueVariableBlocks")]
    nint UniqueVariableBlocks { get; }

    // @property (readonly, copy, nonatomic) NSDictionary<NSNumber *,NSNumber *> * _Nonnull bools;
    [Export("bools", ArgumentSemantic.Copy)]
    NSDictionary<NSNumber, NSNumber> Bools { get; }

    // @property (readonly, copy, nonatomic) NSDictionary<NSNumber *,UIColor *> * _Nonnull colors;
    [Export("colors", ArgumentSemantic.Copy)]
    NSDictionary<NSNumber, UIColor> Colors { get; }

    // @property (readonly, copy, nonatomic) NSDictionary<NSNumber *,NSNumber *> * _Nonnull doubles;
    [Export("doubles", ArgumentSemantic.Copy)]
    NSDictionary<NSNumber, NSNumber> Doubles { get; }

    // @property (readonly, copy, nonatomic) NSDictionary<NSNumber *,NSNumber *> * _Nonnull floats;
    [Export("floats", ArgumentSemantic.Copy)]
    NSDictionary<NSNumber, NSNumber> Floats { get; }

    // @property (readonly, copy, nonatomic) NSDictionary<NSNumber *,NSArray<NSString *> *> * _Nonnull stringArrays;
    [Export("stringArrays", ArgumentSemantic.Copy)]
    NSDictionary<NSNumber, NSArray<NSString>> StringArrays { get; }

    // @property (readonly, copy, nonatomic) NSDictionary<NSNumber *,NSString *> * _Nonnull strings;
    [Export("strings", ArgumentSemantic.Copy)]
    NSDictionary<NSNumber, NSString> Strings { get; }

    // @property (readonly, copy, nonatomic) NSDictionary<NSNumber *,id> * _Nonnull untypedValues;
    [Export("untypedValues", ArgumentSemantic.Copy)]
    NSDictionary<NSNumber, NSObject> UntypedValues { get; }

    // +(NSInteger)newPropertyKey __attribute__((warn_unused_result));
    [Static]
    [Export("newPropertyKey")]
    nint NewPropertyKey { get; }

    // -(BOOL)setBool:(BOOL)boolValue for:(NSInteger)key;
    [Export("setBool:for:")]
    bool SetBool(bool boolValue, nint key);

    // -(BOOL)boolFor:(NSInteger)key defaultValue:(BOOL)defaultValue __attribute__((warn_unused_result));
    [Export("boolFor:defaultValue:")]
    bool BoolFor(nint key, bool defaultValue);

    // -(double)setDouble:(double)doubleValue for:(NSInteger)key;
    [Export("setDouble:for:")]
    double SetDouble(double doubleValue, nint key);

    // -(double)doubleFor:(NSInteger)key defaultValue:(double)defaultValue __attribute__((warn_unused_result));
    [Export("doubleFor:defaultValue:")]
    double DoubleFor(nint key, double defaultValue);

    // -(UIColor * _Nullable)setColor:(UIColor * _Nullable)color for:(NSInteger)key;
    [Export("setColor:for:")]
    [return: NullAllowed]
    UIColor SetColor([NullAllowed] UIColor color, nint key);

    // -(UIColor * _Nullable)colorFor:(NSInteger)key defaultValue:(UIColor * _Nullable)defaultValue __attribute__((warn_unused_result));
    [Export("colorFor:defaultValue:")]
    [return: NullAllowed]
    UIColor ColorFor(nint key, [NullAllowed] UIColor defaultValue);

    // -(id)setScaledEdgeInsets:(id)edgeInsets for:(NSInteger)key;
    [Export("setScaledEdgeInsets:for:")]
    NSObject SetScaledEdgeInsets(NSObject edgeInsets, nint key);

    // -(id)scaledEdgeInsetsFor:(NSInteger)key defaultValue:(id)defaultValue __attribute__((warn_unused_result));
    [Export("scaledEdgeInsetsFor:defaultValue:")]
    NSObject ScaledEdgeInsetsFor(nint key, NSObject defaultValue);

    // -(id)viewEdgeInsetsFor:(NSInteger)key defaultValue:(id)defaultValue __attribute__((warn_unused_result));
    [Export("viewEdgeInsetsFor:defaultValue:")]
    NSObject ViewEdgeInsetsFor(nint key, NSObject defaultValue);

    // -(id)workspaceEdgeInsetsFor:(NSInteger)key defaultValue:(id)defaultValue __attribute__((warn_unused_result));
    [Export("workspaceEdgeInsetsFor:defaultValue:")]
    NSObject WorkspaceEdgeInsetsFor(nint key, NSObject defaultValue);

    // -(CGFloat)setFloat:(CGFloat)floatValue for:(NSInteger)key;
    [Export("setFloat:for:")]
    nfloat SetFloat(nfloat floatValue, nint key);

    // -(CGFloat)floatFor:(NSInteger)key defaultValue:(CGFloat)defaultValue __attribute__((warn_unused_result));
    [Export("floatFor:defaultValue:")]
    nfloat FloatFor(nint key, nfloat defaultValue);

    // -(void)setFontCreator:(UIFont * _Nonnull (^ _Nonnull)(CGFloat))fontCreator for:(NSInteger)key;
    [Export("setFontCreator:for:")]
    void SetFontCreator(Func<nfloat, UIFont> fontCreator, nint key);

    // -(UIFont * _Nonnull (^ _Nullable)(CGFloat))fontCreatorFor:(NSInteger)key __attribute__((warn_unused_result));
    [Export("fontCreatorFor:")]
    [return: NullAllowed]
    Func<nfloat, UIFont> FontCreatorFor(nint key);

    // -(UIFont * _Nonnull)fontFor:(NSInteger)key __attribute__((warn_unused_result));
    [Export("fontFor:")]
    UIFont FontFor(nint key);

    // -(UIFont * _Nonnull)popoverFontFor:(NSInteger)key __attribute__((warn_unused_result));
    [Export("popoverFontFor:")]
    UIFont PopoverFontFor(nint key);

    // -(id)setSize:(id)size for:(NSInteger)key;
    [Export("setSize:for:")]
    NSObject SetSize(NSObject size, nint key);

    // -(id)sizeFor:(NSInteger)key defaultValue:(id)defaultValue __attribute__((warn_unused_result));
    [Export("sizeFor:defaultValue:")]
    NSObject SizeFor(nint key, NSObject defaultValue);

    // -(CGSize)viewSizeFor:(NSInteger)key defaultValue:(id)defaultValue __attribute__((warn_unused_result));
    [Export("viewSizeFor:defaultValue:")]
    CGSize ViewSizeFor(nint key, NSObject defaultValue);

    // -(id)workspaceSizeFor:(NSInteger)key defaultValue:(id)defaultValue __attribute__((warn_unused_result));
    [Export("workspaceSizeFor:defaultValue:")]
    NSObject WorkspaceSizeFor(nint key, NSObject defaultValue);

    // -(id)setUnit:(id)unit for:(NSInteger)key;
    [Export("setUnit:for:")]
    NSObject SetUnit(NSObject unit, nint key);

    // -(id)unitFor:(NSInteger)key defaultValue:(id)defaultValue __attribute__((warn_unused_result));
    [Export("unitFor:defaultValue:")]
    NSObject UnitFor(nint key, NSObject defaultValue);

    // -(CGFloat)viewUnitFor:(NSInteger)key defaultValue:(id)defaultValue __attribute__((warn_unused_result));
    [Export("viewUnitFor:defaultValue:")]
    nfloat ViewUnitFor(nint key, NSObject defaultValue);

    // -(CGFloat)workspaceUnitFor:(NSInteger)key defaultValue:(id)defaultValue __attribute__((warn_unused_result));
    [Export("workspaceUnitFor:defaultValue:")]
    nfloat WorkspaceUnitFor(nint key, NSObject defaultValue);

    // -(NSArray<NSString *> * _Nonnull)setStringArray:(NSArray<NSString *> * _Nonnull)stringArrayValue for:(NSInteger)key;
    [Export("setStringArray:for:")]
    string[] SetStringArray(string[] stringArrayValue, nint key);

    // -(NSArray<NSString *> * _Nonnull)stringArrayFor:(NSInteger)key defaultValue:(NSArray<NSString *> * _Nonnull)defaultValue __attribute__((warn_unused_result));
    [Export("stringArrayFor:defaultValue:")]
    string[] StringArrayFor(nint key, string[] defaultValue);

    // -(NSString * _Nonnull)setString:(NSString * _Nonnull)stringValue for:(NSInteger)key;
    [Export("setString:for:")]
    string SetString(string stringValue, nint key);

    // -(NSString * _Nonnull)stringFor:(NSInteger)key defaultValue:(NSString * _Nonnull)defaultValue __attribute__((warn_unused_result));
    [Export("stringFor:defaultValue:")]
    string StringFor(nint key, string defaultValue);

    // -(id _Nullable)setUntypedValue:(id _Nullable)untypedValue for:(NSInteger)key;
    [Export("setUntypedValue:for:")]
    [return: NullAllowed]
    NSObject SetUntypedValue([NullAllowed] NSObject untypedValue, nint key);

    // -(id _Nullable)untypedValueFor:(NSInteger)key defaultValue:(id _Nullable)defaultValue __attribute__((warn_unused_result));
    [Export("untypedValueFor:defaultValue:")]
    [return: NullAllowed]
    NSObject UntypedValueFor(nint key, [NullAllowed] NSObject defaultValue);

    // -(void)updateViewValuesFromEngine:(BKYLayoutEngine * _Nonnull)engine;
    [Export("updateViewValuesFromEngine:")]
    void UpdateViewValuesFromEngine(BKYLayoutEngine engine);
}

// @interface BKYDefaultLayoutConfig : BKYLayoutConfig
[BaseType(typeof(BKYLayoutConfig))]
interface BKYDefaultLayoutConfig
{
    // @property (readonly, nonatomic, class) NSInteger BlockCornerRadius;
    [Static]
    [Export("BlockCornerRadius")]
    nint BlockCornerRadius { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockLineWidthRegular;
    [Static]
    [Export("BlockLineWidthRegular")]
    nint BlockLineWidthRegular { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockLineWidthHighlight;
    [Static]
    [Export("BlockLineWidthHighlight")]
    nint BlockLineWidthHighlight { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockConnectionLineWidthHighlight;
    [Static]
    [Export("BlockConnectionLineWidthHighlight")]
    nint BlockConnectionLineWidthHighlight { get; }

    // @property (readonly, nonatomic, class) NSInteger PuzzleTabHeight;
    [Static]
    [Export("PuzzleTabHeight")]
    nint PuzzleTabHeight { get; }

    // @property (readonly, nonatomic, class) NSInteger PuzzleTabWidth;
    [Static]
    [Export("PuzzleTabWidth")]
    nint PuzzleTabWidth { get; }

    // @property (readonly, nonatomic, class) NSInteger NotchXOffset;
    [Static]
    [Export("NotchXOffset")]
    nint NotchXOffset { get; }

    // @property (readonly, nonatomic, class) NSInteger NotchWidth;
    [Static]
    [Export("NotchWidth")]
    nint NotchWidth { get; }

    // @property (readonly, nonatomic, class) NSInteger NotchHeight;
    [Static]
    [Export("NotchHeight")]
    nint NotchHeight { get; }

    // @property (readonly, nonatomic, class) NSInteger StatementSectionHeight;
    [Static]
    [Export("StatementSectionHeight")]
    nint StatementSectionHeight { get; }

    // @property (readonly, nonatomic, class) NSInteger StatementMinimumSectionWidth;
    [Static]
    [Export("StatementMinimumSectionWidth")]
    nint StatementMinimumSectionWidth { get; }

    // @property (readonly, nonatomic, class) NSInteger StatementMinimumConnectorWidth;
    [Static]
    [Export("StatementMinimumConnectorWidth")]
    nint StatementMinimumConnectorWidth { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockStrokeDefaultColor;
    [Static]
    [Export("BlockStrokeDefaultColor")]
    nint BlockStrokeDefaultColor { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockStrokeHighlightColor;
    [Static]
    [Export("BlockStrokeHighlightColor")]
    nint BlockStrokeHighlightColor { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockStrokeDisabledColor;
    [Static]
    [Export("BlockStrokeDisabledColor")]
    nint BlockStrokeDisabledColor { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockConnectionHighlightStrokeColor;
    [Static]
    [Export("BlockConnectionHighlightStrokeColor")]
    nint BlockConnectionHighlightStrokeColor { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockFillDisabledColor;
    [Static]
    [Export("BlockFillDisabledColor")]
    nint BlockFillDisabledColor { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockMaskHighlightColor;
    [Static]
    [Export("BlockMaskHighlightColor")]
    nint BlockMaskHighlightColor { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockDefaultAlpha;
    [Static]
    [Export("BlockDefaultAlpha")]
    nint BlockDefaultAlpha { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockDisabledAlpha;
    [Static]
    [Export("BlockDisabledAlpha")]
    nint BlockDisabledAlpha { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockDraggingFillColorAlpha;
    [Static]
    [Export("BlockDraggingFillColorAlpha")]
    nint BlockDraggingFillColorAlpha { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockDraggingStrokeColorAlpha;
    [Static]
    [Export("BlockDraggingStrokeColorAlpha")]
    nint BlockDraggingStrokeColorAlpha { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockShadowSaturationMultiplier;
    [Static]
    [Export("BlockShadowSaturationMultiplier")]
    nint BlockShadowSaturationMultiplier { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockShadowBrightnessMultiplier;
    [Static]
    [Export("BlockShadowBrightnessMultiplier")]
    nint BlockShadowBrightnessMultiplier { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockHat;
    [Static]
    [Export("BlockHat")]
    nint BlockHat { get; }

    // @property (readonly, nonatomic, class) NSInteger BlockHatCapSize;
    [Static]
    [Export("BlockHatCapSize")]
    nint BlockHatCapSize { get; }

    // @property (readonly, nonatomic, class) NSInteger InlineConnectorMinimumSize;
    [Static]
    [Export("InlineConnectorMinimumSize")]
    nint InlineConnectorMinimumSize { get; }

    // @property (readonly, nonatomic, class) NSInteger InlineConnectorXPadding;
    [Static]
    [Export("InlineConnectorXPadding")]
    nint InlineConnectorXPadding { get; }

    // @property (readonly, nonatomic, class) NSInteger InlineConnectorYPadding;
    [Static]
    [Export("InlineConnectorYPadding")]
    nint InlineConnectorYPadding { get; }

    // @property (readonly, nonatomic, class) NSInteger MutatorSettingsButtonColor;
    [Static]
    [Export("MutatorSettingsButtonColor")]
    nint MutatorSettingsButtonColor { get; }
}

// @interface BKYLayoutEngine : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYLayoutEngine
{
    // @property (readonly, nonatomic) CGFloat minimumScale;
    [Export("minimumScale")]
    nfloat MinimumScale { get; }

    // @property (readonly, nonatomic) CGFloat maximumScale;
    [Export("maximumScale")]
    nfloat MaximumScale { get; }

    // @property (nonatomic) CGFloat scale;
    [Export("scale")]
    nfloat Scale { get; set; }

    // @property (readonly, nonatomic) CGFloat popoverScale;
    [Export("popoverScale")]
    nfloat PopoverScale { get; }

    // @property (nonatomic) BOOL rtl;
    [Export("rtl")]
    bool Rtl { get; set; }

    // @property (nonatomic, strong) BKYLayoutConfig * _Nonnull config;
    [Export("config", ArgumentSemantic.Strong)]
    BKYLayoutConfig Config { get; set; }

    // -(id)scaledWorkspaceVectorFromViewVector:(CGPoint)point __attribute__((warn_unused_result));
    [Export("scaledWorkspaceVectorFromViewVector:")]
    NSObject ScaledWorkspaceVectorFromViewVector(CGPoint point);

    // -(id)workspaceSizeFromViewSize:(CGSize)size __attribute__((warn_unused_result));
    [Export("workspaceSizeFromViewSize:")]
    NSObject WorkspaceSizeFromViewSize(CGSize size);

    // -(CGFloat)workspaceUnitFromViewUnit:(CGFloat)unit __attribute__((warn_unused_result));
    [Export("workspaceUnitFromViewUnit:")]
    nfloat WorkspaceUnitFromViewUnit(nfloat unit);

    // -(CGFloat)viewUnitFromWorkspaceUnit:(CGFloat)unit __attribute__((warn_unused_result));
    [Export("viewUnitFromWorkspaceUnit:")]
    nfloat ViewUnitFromWorkspaceUnit(nfloat unit);

    // -(CGPoint)viewPointFromWorkspacePoint:(id)point __attribute__((warn_unused_result));
    [Export("viewPointFromWorkspacePoint:")]
    CGPoint ViewPointFromWorkspacePoint(NSObject point);

    // -(CGPoint)viewPointFromWorkspacePoint:(CGFloat)x :(CGFloat)y __attribute__((warn_unused_result));
    [Export("viewPointFromWorkspacePoint::")]
    CGPoint ViewPointFromWorkspacePoint(nfloat x, nfloat y);

    // -(CGSize)viewSizeFromWorkspaceSize:(id)size __attribute__((warn_unused_result));
    [Export("viewSizeFromWorkspaceSize:")]
    CGSize ViewSizeFromWorkspaceSize(NSObject size);
}

// @interface BKYDefaultLayoutEngine : BKYLayoutEngine
[BaseType(typeof(BKYLayoutEngine))]
interface BKYDefaultLayoutEngine
{
}

// @interface BKYDragger : NSObject
[BaseType(typeof(NSObject))]
interface BKYDragger
{
    // @property (nonatomic, strong) BKYWorkspaceLayoutCoordinator * _Nullable workspaceLayoutCoordinator;
    [NullAllowed, Export("workspaceLayoutCoordinator", ArgumentSemantic.Strong)]
    BKYWorkspaceLayoutCoordinator WorkspaceLayoutCoordinator { get; set; }

    // @property (readonly, nonatomic) NSInteger numberOfActiveDrags;
    [Export("numberOfActiveDrags")]
    nint NumberOfActiveDrags { get; }

    // -(BOOL)startDraggingBlockLayout:(BKYBlockLayout * _Nonnull)layout touchPosition:(id)touchPosition error:(NSError * _Nullable * _Nullable)error;
    [Export("startDraggingBlockLayout:touchPosition:error:")]
    bool StartDraggingBlockLayout(BKYBlockLayout layout, NSObject touchPosition, [NullAllowed] out NSError error);

    // -(void)continueDraggingBlockLayout:(BKYBlockLayout * _Nonnull)layout touchPosition:(id)touchPosition;
    [Export("continueDraggingBlockLayout:touchPosition:")]
    void ContinueDraggingBlockLayout(BKYBlockLayout layout, NSObject touchPosition);

    // -(void)finishDraggingBlockLayout:(BKYBlockLayout * _Nonnull)layout;
    [Export("finishDraggingBlockLayout:")]
    void FinishDraggingBlockLayout(BKYBlockLayout layout);

    // -(void)cancelDraggingBlockLayout:(BKYBlockLayout * _Nonnull)layout;
    [Export("cancelDraggingBlockLayout:")]
    void CancelDraggingBlockLayout(BKYBlockLayout layout);

    // -(void)cancelAllDrags;
    [Export("cancelAllDrags")]
    void CancelAllDrags();
}

// @interface BKYDropdownOptionsViewController : UITableViewController
[BaseType(typeof(UITableViewController))]
interface BKYDropdownOptionsViewController
{
    // @property (nonatomic) NSInteger selectedIndex;
    [Export("selectedIndex")]
    nint SelectedIndex { get; set; }

    [Wrap("WeakDelegate")]
    [NullAllowed]
    BKYDropdownOptionsViewControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<BKYDropdownOptionsViewControllerDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (nonatomic, strong) UIFont * _Nonnull textLabelFont;
    [Export("textLabelFont", ArgumentSemantic.Strong)]
    UIFont TextLabelFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable textLabelColor;
    [NullAllowed, Export("textLabelColor", ArgumentSemantic.Strong)]
    UIColor TextLabelColor { get; set; }

    // @property (nonatomic) CGSize maximumPopoverSize;
    [Export("maximumPopoverSize", ArgumentSemantic.Assign)]
    CGSize MaximumPopoverSize { get; set; }

    // -(void)viewDidLoad;
    [Export("viewDidLoad")]
    void ViewDidLoad();

    // -(void)viewWillAppear:(BOOL)animated;
    [Export("viewWillAppear:")]
    void ViewWillAppear(bool animated);

    // -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result));
    [Export("numberOfSectionsInTableView:")]
    nint NumberOfSectionsInTableView(UITableView tableView);

    // -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result));
    [Export("tableView:numberOfRowsInSection:")]
    nint TableView(UITableView tableView, nint section);

//    // -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
//    [Export("tableView:heightForRowAtIndexPath:")]
//    nfloat TableView(UITableView tableView, NSIndexPath indexPath);

    // -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
    [Export("tableView:cellForRowAtIndexPath:")]
    UITableViewCell TableView(UITableView tableView, NSIndexPath indexPath);

//    // -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
//    [Export("tableView:didSelectRowAtIndexPath:")]
//    void TableView(UITableView tableView, NSIndexPath indexPath);

    // -(instancetype _Nonnull)initWithStyle:(UITableViewStyle)style __attribute__((objc_designated_initializer));
    [Export("initWithStyle:")]
    [DesignatedInitializer]
    IntPtr Constructor(UITableViewStyle style);

    // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
    [Export("initWithNibName:bundle:")]
    [DesignatedInitializer]
    IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);
}

// @protocol BKYDropdownOptionsViewControllerDelegate
[Protocol, Model]
interface BKYDropdownOptionsViewControllerDelegate
{
    // @required -(void)dropdownOptionsViewController:(BKYDropdownOptionsViewController * _Nonnull)viewController didSelectOptionIndex:(NSInteger)optionIndex;
    [Abstract]
    [Export("dropdownOptionsViewController:didSelectOptionIndex:")]
    void DidSelectOptionIndex(BKYDropdownOptionsViewController viewController, nint optionIndex);
}

// @interface BKYDropdownView : UIView
[BaseType(typeof(UIView))]
interface BKYDropdownView
{
    // @property (copy, nonatomic) NSString * _Nullable text;
    [NullAllowed, Export("text")]
    string Text { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable textFont;
    [NullAllowed, Export("textFont", ArgumentSemantic.Strong)]
    UIFont TextFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable textColor;
    [NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
    UIColor TextColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable dropDownBackgroundColor;
    [NullAllowed, Export("dropDownBackgroundColor", ArgumentSemantic.Strong)]
    UIColor DropDownBackgroundColor { get; set; }

    // @property (nonatomic) CGFloat horizontalSpacing;
    [Export("horizontalSpacing")]
    nfloat HorizontalSpacing { get; set; }

    // @property (nonatomic) CGFloat verticalSpacing;
    [Export("verticalSpacing")]
    nfloat VerticalSpacing { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable borderColor;
    [NullAllowed, Export("borderColor", ArgumentSemantic.Strong)]
    UIColor BorderColor { get; set; }

    // @property (nonatomic) CGFloat borderWidth;
    [Export("borderWidth")]
    nfloat BorderWidth { get; set; }

    // @property (nonatomic) CGFloat borderCornerRadius;
    [Export("borderCornerRadius")]
    nfloat BorderCornerRadius { get; set; }

    // @property (nonatomic, strong) UIImage * _Nullable dropDownArrowImage;
    [NullAllowed, Export("dropDownArrowImage", ArgumentSemantic.Strong)]
    UIImage DropDownArrowImage { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified dropDownArrowTintColor;
    [Export("dropDownArrowTintColor", ArgumentSemantic.Strong)]
    UIColor DropDownArrowTintColor { get; set; }

    [Wrap("WeakDelegate")]
    [NullAllowed]
    BKYDropdownViewDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<BKYDropdownViewDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // -(instancetype _Nonnull)initWithDropDownArrowImage:(UIImage * _Nullable)dropDownArrowImage __attribute__((objc_designated_initializer));
    [Export("initWithDropDownArrowImage:")]
    [DesignatedInitializer]
    IntPtr Constructor([NullAllowed] UIImage dropDownArrowImage);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)layoutSubviews;
    [Export("layoutSubviews")]
    void LayoutSubviews();

    // +(CGSize)measureSizeWithText:(NSString * _Nonnull)text dropDownArrowImageSize:(CGSize)dropDownArrowImageSize textFont:(UIFont * _Nonnull)textFont borderWidth:(CGFloat)borderWidth horizontalSpacing:(CGFloat)horizontalSpacing verticalSpacing:(CGFloat)verticalSpacing __attribute__((warn_unused_result));
    [Static]
    [Export("measureSizeWithText:dropDownArrowImageSize:textFont:borderWidth:horizontalSpacing:verticalSpacing:")]
    CGSize MeasureSizeWithText(string text, CGSize dropDownArrowImageSize, UIFont textFont, nfloat borderWidth, nfloat horizontalSpacing, nfloat verticalSpacing);

    // +(UIImage * _Nullable)defaultDropDownArrowImage __attribute__((warn_unused_result));
    [Static]
    [NullAllowed, Export("defaultDropDownArrowImage")]
    UIImage DefaultDropDownArrowImage { get; }

    // +(CGSize)defaultDropDownArrowImageSize __attribute__((warn_unused_result));
    [Static]
    [Export("defaultDropDownArrowImageSize")]
    CGSize DefaultDropDownArrowImageSize { get; }
}

// @protocol BKYDropdownViewDelegate
[Protocol, Model]
interface BKYDropdownViewDelegate
{
    // @required -(void)dropDownDidReceiveTap;
    [Abstract]
    [Export("dropDownDidReceiveTap")]
    void DropDownDidReceiveTap();
}

// @interface BKYEventManager : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYEventManager
{
    // @property (readonly, nonatomic, strong, class) BKYEventManager * _Nonnull shared;
    [Static]
    [Export("shared", ArgumentSemantic.Strong)]
    BKYEventManager Shared { get; }

    // @property (readonly, copy, nonatomic) NSArray<BKYEvent *> * _Nonnull pendingEvents;
    [Export("pendingEvents", ArgumentSemantic.Copy)]
    BKYEvent[] PendingEvents { get; }

    // @property (nonatomic) BOOL isEnabled;
    [Export("isEnabled")]
    bool IsEnabled { get; set; }

    // @property (readonly, copy, nonatomic) NSString * _Nullable currentGroupID;
    [NullAllowed, Export("currentGroupID")]
    string CurrentGroupID { get; }

    // -(void)addPendingEvent:(BKYEvent * _Nonnull)event;
    [Export("addPendingEvent:")]
    void AddPendingEvent(BKYEvent @event);

    // -(void)firePendingEvents;
    [Export("firePendingEvents")]
    void FirePendingEvents();

    // -(void)pushNewGroup;
    [Export("pushNewGroup")]
    void PushNewGroup();

    // -(void)pushGroupWithGroupID:(NSString * _Nonnull)groupID;
    [Export("pushGroupWithGroupID:")]
    void PushGroupWithGroupID(string groupID);

    // -(void)popGroup;
    [Export("popGroup")]
    void PopGroup();

    // -(void)addListener:(id<BKYEventManagerListener> _Nonnull)listener;
    [Export("addListener:")]
    void AddListener(BKYEventManagerListener listener);

    // -(void)removeListener:(id<BKYEventManagerListener> _Nonnull)listener;
    [Export("removeListener:")]
    void RemoveListener(BKYEventManagerListener listener);
}

// @protocol BKYEventManagerListener
[Protocol, Model]
interface BKYEventManagerListener
{
    // @required -(void)eventManager:(BKYEventManager * _Nonnull)eventManager didFireEvent:(BKYEvent * _Nonnull)event;
    [Abstract]
    [Export("eventManager:didFireEvent:")]
    void DidFireEvent(BKYEventManager eventManager, BKYEvent @event);
}

// @interface BKYField : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYField
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
    [Export("name")]
    string Name { get; }

    // @property (nonatomic, weak) BKYInput * _Nullable sourceInput;
    [NullAllowed, Export("sourceInput", ArgumentSemantic.Weak)]
    BKYInput SourceInput { get; set; }

    // @property (nonatomic, weak) BKYFieldLayout * _Nullable layout;
    [NullAllowed, Export("layout", ArgumentSemantic.Weak)]
    BKYFieldLayout Layout { get; set; }

    // @property (nonatomic) BOOL editable;
    [Export("editable")]
    bool Editable { get; set; }

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);

    // -(void)notifyDidUpdateField;
    [Export("notifyDidUpdateField")]
    void NotifyDidUpdateField();
}

// @interface Blockly_Swift_3325 (BKYField)
[Category]
[BaseType(typeof(BKYField))]
interface BKYField_Blockly_Swift_3325
{
}

// @interface BKYFieldJSONRegistry : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYFieldJSONRegistry
{
    // @property (readonly, nonatomic, strong, class) BKYFieldJSONRegistry * _Nonnull shared;
    [Static]
    [Export("shared", ArgumentSemantic.Strong)]
    BKYFieldJSONRegistry Shared { get; }

    // -(void)unregisterType:(NSString * _Nonnull)type;
    [Export("unregisterType:")]
    void UnregisterType(string type);
}

// @interface BKYFieldAngle : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldAngle
{
    // @property (nonatomic) double angle;
    [Export("angle")]
    double Angle { get; set; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name angle:(double)angle __attribute__((objc_designated_initializer));
    [Export("initWithName:angle:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name, double angle);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);
}

// @interface BKYFieldLayout : BKYLayout
[BaseType(typeof(BKYLayout))]
interface BKYFieldLayout
{
    // @property (nonatomic) Class<BKYFieldLayoutMeasurer> _Nonnull measurer;
    [Export("measurer", ArgumentSemantic.Assign)]
    BKYFieldLayoutMeasurer Measurer { get; set; }

    // @property (readonly, nonatomic, strong) BKYField * _Nonnull field;
    [Export("field", ArgumentSemantic.Strong)]
    BKYField Field { get; }

    // @property (readonly, nonatomic) BOOL userInteractionEnabled;
    [Export("userInteractionEnabled")]
    bool UserInteractionEnabled { get; }

    // -(instancetype _Nonnull)initWithField:(BKYField * _Nonnull)field engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
    [Export("initWithField:engine:measurer:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYField field, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);

    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);
}

// @interface BKYFieldAngleLayout : BKYFieldLayout
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldAngleLayout
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull textValue;
    [Export("textValue")]
    string TextValue { get; }

    // @property (readonly, nonatomic) double angle;
    [Export("angle")]
    double Angle { get; }

    // -(instancetype _Nonnull)initWithFieldAngle:(BKYFieldAngle * _Nonnull)fieldAngle engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
    [Export("initWithFieldAngle:engine:measurer:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYFieldAngle fieldAngle, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);

    // -(void)updateAngle:(double)angle;
    [Export("updateAngle:")]
    void UpdateAngle(double angle);
}

// @interface BKYFieldView : BKYLayoutView
[BaseType(typeof(BKYLayoutView))]
interface BKYFieldView
{
    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
    [Export("initWithFrame:")]
    [DesignatedInitializer]
    IntPtr Constructor(CGRect frame);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);
}

// @interface BKYFieldAngleView : BKYFieldView <BKYAnglePickerViewControllerDelegate, BKYFieldLayoutMeasurer, UIPopoverPresentationControllerDelegate, UITextFieldDelegate>
    [BaseType (typeof(BKYFieldView))]
    interface BKYFieldAngleView : BKYAnglePickerViewControllerDelegate, BKYFieldLayoutMeasurer, IUIPopoverPresentationControllerDelegate, IUITextFieldDelegate
    {
        // @property (readonly, nonatomic, strong) BKYInsetTextField * _Nonnull textField;
        [Export ("textField", ArgumentSemantic.Strong)]
        BKYInsetTextField TextField { get; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export ("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor (NSCoder aDecoder);

        // -(void)prepareForReuse;
        [Export ("prepareForReuse")]
        void PrepareForReuse ();

        // -(BOOL)textFieldShouldBeginEditing:(UITextField * _Nonnull)textField __attribute__((warn_unused_result));
        [Export ("textFieldShouldBeginEditing:")]
        bool TextFieldShouldBeginEditing (UITextField textField);

        // +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
        [Static]
        [Export ("measureLayout:scale:")]
        CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);

        // -(void)anglePickerViewController:(BKYAnglePickerViewController * _Nonnull)viewController didUpdateAngle:(double)angle;
        [Export ("anglePickerViewController:didUpdateAngle:")]
        void AnglePickerViewController (BKYAnglePickerViewController viewController, double angle);

        // -(void)prepareForPopoverPresentation:(UIPopoverPresentationController * _Nonnull)popoverPresentationController;
        [Export ("prepareForPopoverPresentation:")]
        void PrepareForPopoverPresentation (UIPopoverPresentationController popoverPresentationController);
    }

// @protocol BKYFieldLayoutMeasurer
[Protocol, Model]
interface BKYFieldLayoutMeasurer
{
    // @required +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
    [Static, Abstract]
    [Export("measureLayout:scale:")]
    CGSize Scale(BKYFieldLayout layout, nfloat scale);
}

// @interface BKYFieldCheckbox : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldCheckbox
{
    // @property (nonatomic) BOOL checked;
    [Export("checked")]
    bool Checked { get; set; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name checked:(BOOL)checked __attribute__((objc_designated_initializer));
    [Export("initWithName:checked:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name, bool @checked);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);
}

// @interface BKYFieldCheckboxLayout : BKYFieldLayout
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldCheckboxLayout
{
    // @property (readonly, nonatomic) BOOL checked;
    [Export("checked")]
    bool Checked { get; }

    // -(instancetype _Nonnull)initWithFieldCheckbox:(BKYFieldCheckbox * _Nonnull)fieldCheckbox engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
    [Export("initWithFieldCheckbox:engine:measurer:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYFieldCheckbox fieldCheckbox, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);

    // -(void)updateCheckbox:(BOOL)checked;
    [Export("updateCheckbox:")]
    void UpdateCheckbox(bool @checked);
}

// @interface BKYFieldCheckboxView : BKYFieldView <BKYFieldLayoutMeasurer>
    [BaseType (typeof(BKYFieldView))]
    interface BKYFieldCheckboxView : BKYFieldLayoutMeasurer
    {
        // @property (readonly, nonatomic, strong) BKYFieldCheckboxLayout * _Nullable fieldCheckboxLayout;
        [NullAllowed, Export ("fieldCheckboxLayout", ArgumentSemantic.Strong)]
        BKYFieldCheckboxLayout FieldCheckboxLayout { get; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export ("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor (NSCoder aDecoder);

        // -(void)prepareForReuse;
        [Export ("prepareForReuse")]
        void PrepareForReuse ();

        // +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
        [Static]
        [Export ("measureLayout:scale:")]
        CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);
    }

// @interface BKYFieldColor : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldColor
{
    // @property (nonatomic, strong) UIColor * _Nonnull color;
    [Export("color", ArgumentSemantic.Strong)]
    UIColor Color { get; set; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name color:(UIColor * _Nonnull)color __attribute__((objc_designated_initializer));
    [Export("initWithName:color:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name, UIColor color);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);
}

// @interface BKYFieldColorLayout : BKYFieldLayout
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldColorLayout
{
    // @property (readonly, nonatomic, strong) UIColor * _Nonnull color;
    [Export("color", ArgumentSemantic.Strong)]
    UIColor Color { get; }

    // -(instancetype _Nonnull)initWithFieldColor:(BKYFieldColor * _Nonnull)fieldColor engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
    [Export("initWithFieldColor:engine:measurer:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYFieldColor fieldColor, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);

    // -(void)updateColor:(UIColor * _Nonnull)color;
    [Export("updateColor:")]
    void UpdateColor(UIColor color);
}

// @interface BKYFieldColorPickerViewController : UICollectionViewController
[BaseType(typeof(UICollectionViewController))]
interface BKYFieldColorPickerViewController
{
    // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull colors;
    [Export("colors", ArgumentSemantic.Copy)]
    string[] Colors { get; set; }

    // @property (nonatomic) NSInteger preferredColorsPerRow;
    [Export("preferredColorsPerRow")]
    nint PreferredColorsPerRow { get; set; }

    // @property (nonatomic) CGSize buttonSize;
    [Export("buttonSize", ArgumentSemantic.Assign)]
    CGSize ButtonSize { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable color;
    [NullAllowed, Export("color", ArgumentSemantic.Strong)]
    UIColor Color { get; set; }

    [Wrap("WeakDelegate")]
    [NullAllowed]
    BKYFieldColorPickerViewControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<BKYFieldColorPickerViewControllerDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)viewDidLoad;
    [Export("viewDidLoad")]
    void ViewDidLoad();

    // -(void)viewWillAppear:(BOOL)animated;
    [Export("viewWillAppear:")]
    void ViewWillAppear(bool animated);

    // -(void)viewDidAppear:(BOOL)animated;
    [Export("viewDidAppear:")]
    void ViewDidAppear(bool animated);

    // -(NSInteger)numberOfSectionsInCollectionView:(UICollectionView * _Nonnull)collectionView __attribute__((warn_unused_result));
    [Export("numberOfSectionsInCollectionView:")]
    nint NumberOfSectionsInCollectionView(UICollectionView collectionView);

    // -(NSInteger)collectionView:(UICollectionView * _Nonnull)collectionView numberOfItemsInSection:(NSInteger)section __attribute__((warn_unused_result));
    [Export("collectionView:numberOfItemsInSection:")]
    nint CollectionView(UICollectionView collectionView, nint section);

    // -(UICollectionViewCell * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView cellForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
    [Export("collectionView:cellForItemAtIndexPath:")]
    UICollectionViewCell CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

//    // -(void)collectionView:(UICollectionView * _Nonnull)collectionView didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
//    [Export("collectionView:didSelectItemAtIndexPath:")]
//    void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

    // -(void)refreshView;
    [Export("refreshView")]
    void RefreshView();
}

// @protocol BKYFieldColorPickerViewControllerDelegate
[Protocol, Model]
interface BKYFieldColorPickerViewControllerDelegate
{
    // @required -(void)fieldColorPickerViewController:(BKYFieldColorPickerViewController * _Nonnull)viewController didPickColor:(UIColor * _Nonnull)color;
    [Abstract]
    [Export("fieldColorPickerViewController:didPickColor:")]
    void DidPickColor(BKYFieldColorPickerViewController viewController, UIColor color);
}

// @interface BKYFieldColorView : BKYFieldView <BKYFieldColorPickerViewControllerDelegate, BKYFieldLayoutMeasurer>
[BaseType (typeof(BKYFieldView))]
interface BKYFieldColorView : BKYFieldColorPickerViewControllerDelegate, BKYFieldLayoutMeasurer
{
    // @property (readonly, nonatomic, strong) BKYFieldColorLayout * _Nullable fieldColorLayout;
    [NullAllowed, Export ("fieldColorLayout", ArgumentSemantic.Strong)]
    BKYFieldColorLayout FieldColorLayout { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export ("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor (NSCoder aDecoder);

    // -(void)prepareForReuse;
    [Export ("prepareForReuse")]
    void PrepareForReuse ();

    // +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
    [Static]
    [Export ("measureLayout:scale:")]
    CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);

    // -(void)fieldColorPickerViewController:(BKYFieldColorPickerViewController * _Nonnull)viewController didPickColor:(UIColor * _Nonnull)color;
    [Export ("fieldColorPickerViewController:didPickColor:")]
    void FieldColorPickerViewController (BKYFieldColorPickerViewController viewController, UIColor color);
}

// @interface BKYFieldDate : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldDate
{
    // @property (copy, nonatomic) NSDate * _Nonnull date;
    [Export("date", ArgumentSemantic.Copy)]
    NSDate Date { get; set; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name date:(NSDate * _Nonnull)date __attribute__((objc_designated_initializer));
    [Export("initWithName:date:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name, NSDate date);

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name stringDate:(NSString * _Nonnull)stringDate;
    [Export("initWithName:stringDate:")]
    IntPtr Constructor(string name, string stringDate);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);

    // -(void)setDateFromString:(NSString * _Nonnull)stringDate;
    [Export("setDateFromString:")]
    void SetDateFromString(string stringDate);
}

// @interface BKYFieldDateLayout : BKYFieldLayout
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldDateLayout
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull textValue;
    [Export("textValue")]
    string TextValue { get; }

    // @property (readonly, copy, nonatomic) NSDate * _Nonnull date;
    [Export("date", ArgumentSemantic.Copy)]
    NSDate Date { get; }

    // @property (readonly, nonatomic, strong) NSDateFormatter * _Nonnull dateFormatter;
    [Export("dateFormatter", ArgumentSemantic.Strong)]
    NSDateFormatter DateFormatter { get; }

    // -(instancetype _Nonnull)initWithFieldDate:(BKYFieldDate * _Nonnull)fieldDate engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer dateFormatter:(NSDateFormatter * _Nullable)dateFormatter __attribute__((objc_designated_initializer));
    [Export("initWithFieldDate:engine:measurer:dateFormatter:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYFieldDate fieldDate, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer, [NullAllowed] NSDateFormatter dateFormatter);

    // -(void)updateDate:(NSDate * _Nonnull)date;
    [Export("updateDate:")]
    void UpdateDate(NSDate date);
}

// @interface BKYFieldDateView : BKYFieldView <BKYFieldLayoutMeasurer, UITextFieldDelegate>
[BaseType (typeof(BKYFieldView))]
interface BKYFieldDateView : BKYFieldLayoutMeasurer, IUITextFieldDelegate
{
    // @property (readonly, nonatomic, strong) BKYFieldDateLayout * _Nullable fieldDateLayout;
    [NullAllowed, Export ("fieldDateLayout", ArgumentSemantic.Strong)]
    BKYFieldDateLayout FieldDateLayout { get; }

    // @property (readonly, nonatomic, strong) BKYInsetTextField * _Nonnull textField;
    [Export ("textField", ArgumentSemantic.Strong)]
    BKYInsetTextField TextField { get; }

    // @property (readonly, nonatomic, strong) UIDatePicker * _Nonnull datePicker;
    [Export ("datePicker", ArgumentSemantic.Strong)]
    UIDatePicker DatePicker { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export ("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor (NSCoder aDecoder);

    // -(void)prepareForReuse;
    [Export ("prepareForReuse")]
    void PrepareForReuse ();

    // -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result));
    [Export ("textField:shouldChangeCharactersInRange:replacementString:")]
    bool TextField (UITextField textField, NSRange range, string @string);

    // +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
    [Static]
    [Export ("measureLayout:scale:")]
    CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);
}

// @interface BKYFieldDropdown : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldDropdown
{
    // @property (nonatomic) NSInteger selectedIndex;
    [Export("selectedIndex")]
    nint SelectedIndex { get; set; }

    // -(instancetype _Nullable)initWithName:(NSString * _Nonnull)name displayNames:(NSArray<NSString *> * _Nonnull)displayNames values:(NSArray<NSString *> * _Nonnull)values selectedIndex:(NSInteger)selectedIndex error:(NSError * _Nullable * _Nullable)error;
    [Export("initWithName:displayNames:values:selectedIndex:error:")]
    IntPtr Constructor(string name, string[] displayNames, string[] values, nint selectedIndex, [NullAllowed] out NSError error);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);
}

// @interface BKYFieldDropdownLayout : BKYFieldLayout
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldDropdownLayout
{
    // @property (readonly, nonatomic) NSInteger selectedIndex;
    [Export("selectedIndex")]
    nint SelectedIndex { get; }

    // -(instancetype _Nonnull)initWithFieldDropdown:(BKYFieldDropdown * _Nonnull)fieldDropdown engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
    [Export("initWithFieldDropdown:engine:measurer:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYFieldDropdown fieldDropdown, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);

    // -(void)updateSelectedIndex:(NSInteger)selectedIndex;
    [Export("updateSelectedIndex:")]
    void UpdateSelectedIndex(nint selectedIndex);
}

// @interface BKYFieldDropdownView : BKYFieldView <BKYDropdownOptionsViewControllerDelegate, BKYDropdownViewDelegate, BKYFieldLayoutMeasurer, UIPopoverPresentationControllerDelegate>
[BaseType (typeof(BKYFieldView))]
interface BKYFieldDropdownView : BKYDropdownOptionsViewControllerDelegate, BKYDropdownViewDelegate, BKYFieldLayoutMeasurer, IUIPopoverPresentationControllerDelegate
{
    // @property (readonly, nonatomic, strong) BKYFieldDropdownLayout * _Nullable fieldDropdownLayout;
    [NullAllowed, Export ("fieldDropdownLayout", ArgumentSemantic.Strong)]
    BKYFieldDropdownLayout FieldDropdownLayout { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export ("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor (NSCoder aDecoder);

    // -(void)prepareForReuse;
    [Export ("prepareForReuse")]
    void PrepareForReuse ();

    // +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
    [Static]
    [Export ("measureLayout:scale:")]
    CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);

    // -(void)dropDownDidReceiveTap;
    [Export ("dropDownDidReceiveTap")]
    void DropDownDidReceiveTap ();

    // -(void)prepareForPopoverPresentation:(UIPopoverPresentationController * _Nonnull)popoverPresentationController;
    [Export ("prepareForPopoverPresentation:")]
    void PrepareForPopoverPresentation (UIPopoverPresentationController popoverPresentationController);

    // -(void)dropdownOptionsViewController:(BKYDropdownOptionsViewController * _Nonnull)viewController didSelectOptionIndex:(NSInteger)optionIndex;
    [Export ("dropdownOptionsViewController:didSelectOptionIndex:")]
    void DropdownOptionsViewController (BKYDropdownOptionsViewController viewController, nint optionIndex);
}

// @interface BKYFieldImage : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldImage
{
    // @property (nonatomic) int size;
    [Export("size")]
    int Size { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull imageLocation;
    [Export("imageLocation")]
    string ImageLocation { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull altText;
    [Export("altText")]
    string AltText { get; set; }

    // @property (nonatomic) BOOL flipRtl;
    [Export("flipRtl")]
    bool FlipRtl { get; set; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name imageLocation:(NSString * _Nonnull)imageLocation size:(id)size altText:(NSString * _Nonnull)altText flipRtl:(BOOL)flipRtl __attribute__((objc_designated_initializer));
    [Export("initWithName:imageLocation:size:altText:flipRtl:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name, string imageLocation, NSObject size, string altText, bool flipRtl);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);
}

// @interface BKYFieldImageLayout : BKYFieldLayout
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldImageLayout
{
    // @property (readonly, nonatomic) int size;
    [Export("size")]
    int Size { get; }

    // @property (readonly, nonatomic) BOOL flipRtl;
    [Export("flipRtl")]
    bool FlipRtl { get; }

    // -(instancetype _Nonnull)initWithFieldImage:(BKYFieldImage * _Nonnull)fieldImage engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
    [Export("initWithFieldImage:engine:measurer:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYFieldImage fieldImage, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);

    // -(void)loadImageWithCompletion:(void (^ _Nonnull)(UIImage * _Nullable))completion;
    [Export("loadImageWithCompletion:")]
    void LoadImageWithCompletion(Action<UIImage> completion);
}

// @interface BKYFieldImageView : BKYFieldView <BKYFieldLayoutMeasurer>
[BaseType (typeof(BKYFieldView))]
interface BKYFieldImageView : BKYFieldLayoutMeasurer
{
    // @property (readonly, nonatomic, strong) BKYFieldImageLayout * _Nullable fieldImageLayout;
    [NullAllowed, Export ("fieldImageLayout", ArgumentSemantic.Strong)]
    BKYFieldImageLayout FieldImageLayout { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export ("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor (NSCoder aDecoder);

    // -(void)prepareForReuse;
    [Export ("prepareForReuse")]
    void PrepareForReuse ();

    // +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
    [Static]
    [Export ("measureLayout:scale:")]
    CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);
}

// @interface BKYFieldInput : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldInput
{
    // @property (copy, nonatomic) NSString * _Nonnull text;
    [Export("text")]
    string Text { get; set; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name text:(NSString * _Nonnull)text __attribute__((objc_designated_initializer));
    [Export("initWithName:text:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name, string text);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);
}

// @interface BKYFieldInputLayout : BKYFieldLayout
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldInputLayout
{
    // @property (copy, nonatomic) NSString * _Nonnull currentTextValue;
    [Export("currentTextValue")]
    string CurrentTextValue { get; set; }

    // -(instancetype _Nonnull)initWithFieldInput:(BKYFieldInput * _Nonnull)fieldInput engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
    [Export("initWithFieldInput:engine:measurer:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYFieldInput fieldInput, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);

    // -(void)didUpdateField:(BKYField * _Nonnull)field;
    [Export("didUpdateField:")]
    void DidUpdateField(BKYField field);

    // -(void)updateText:(NSString * _Nonnull)text;
    [Export("updateText:")]
    void UpdateText(string text);
}

// @interface BKYFieldInputView : BKYFieldView <BKYFieldLayoutMeasurer, UITextFieldDelegate>
    [BaseType (typeof(BKYFieldView))]
    interface BKYFieldInputView : BKYFieldLayoutMeasurer, IUITextFieldDelegate
    {
        // @property (readonly, nonatomic, strong) BKYFieldInputLayout * _Nullable fieldInputLayout;
        [NullAllowed, Export ("fieldInputLayout", ArgumentSemantic.Strong)]
        BKYFieldInputLayout FieldInputLayout { get; }

        // @property (readonly, nonatomic, strong) BKYInsetTextField * _Nonnull textField;
        [Export ("textField", ArgumentSemantic.Strong)]
        BKYInsetTextField TextField { get; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export ("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor (NSCoder aDecoder);

        // -(void)prepareForReuse;
        [Export ("prepareForReuse")]
        void PrepareForReuse ();

        // -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result));
        [Export ("textFieldShouldReturn:")]
        bool TextFieldShouldReturn (UITextField textField);

        // -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField;
        [Export ("textFieldDidEndEditing:")]
        void TextFieldDidEndEditing (UITextField textField);

        // +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
        [Static]
        [Export ("measureLayout:scale:")]
        CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);
    }

// @interface BKYFieldLabel : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldLabel
{
    // @property (copy, nonatomic) NSString * _Nonnull text;
    [Export("text")]
    string Text { get; set; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name text:(NSString * _Nonnull)text __attribute__((objc_designated_initializer));
    [Export("initWithName:text:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name, string text);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);
}

// @interface BKYFieldLabelLayout : BKYFieldLayout
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldLabelLayout
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull text;
    [Export("text")]
    string Text { get; }

    // -(instancetype _Nonnull)initWithFieldLabel:(BKYFieldLabel * _Nonnull)fieldLabel engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
    [Export("initWithFieldLabel:engine:measurer:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYFieldLabel fieldLabel, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);
}

// @interface BKYFieldLabelView : BKYFieldView <BKYFieldLayoutMeasurer>
    [BaseType (typeof(BKYFieldView))]
    interface BKYFieldLabelView : BKYFieldLayoutMeasurer
    {
        // @property (readonly, nonatomic, strong) BKYFieldLabelLayout * _Nullable fieldLabelLayout;
        [NullAllowed, Export ("fieldLabelLayout", ArgumentSemantic.Strong)]
        BKYFieldLabelLayout FieldLabelLayout { get; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export ("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor (NSCoder aDecoder);

        // -(void)prepareForReuse;
        [Export ("prepareForReuse")]
        void PrepareForReuse ();

        // +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
        [Static]
        [Export ("measureLayout:scale:")]
        CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);
    }

// @protocol BKYFieldListener
[Protocol, Model]
interface BKYFieldListener
{
    // @required -(void)didUpdateField:(BKYField * _Nonnull)field;
    [Abstract]
    [Export("didUpdateField:")]
    void DidUpdateField(BKYField field);
}

// @interface Blockly_Swift_4042 (BKYFieldLayout) <BKYFieldListener>
[Category]
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldLayout_Blockly_Swift_4042 : BKYFieldListener
{
    // -(void)didUpdateField:(BKYField * _Nonnull)field;
    [Export("didUpdateField:")]
    void DidUpdateField(BKYField field);
}

// @interface BKYFieldNumber : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldNumber
{
    // @property (nonatomic) double value;
    [Export("value")]
    double Value { get; set; }

    // @property (readonly, copy, nonatomic) NSString * _Nonnull textValue;
    [Export("textValue")]
    string TextValue { get; }

    // @property (readonly, nonatomic) BOOL isInteger;
    [Export("isInteger")]
    bool IsInteger { get; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name value:(double)value __attribute__((objc_designated_initializer));
    [Export("initWithName:value:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name, double value);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);

    // -(BOOL)setValueFromLocalizedText:(NSString * _Nonnull)text;
    [Export("setValueFromLocalizedText:")]
    bool SetValueFromLocalizedText(string text);
}

// @interface BKYFieldNumberLayout : BKYFieldLayout
[BaseType(typeof(BKYFieldLayout))]
interface BKYFieldNumberLayout
{
    // @property (copy, nonatomic) NSString * _Nonnull currentTextValue;
    [Export("currentTextValue")]
    string CurrentTextValue { get; set; }

    // @property (readonly, nonatomic) BOOL isInteger;
    [Export("isInteger")]
    bool IsInteger { get; }

    // -(instancetype _Nonnull)initWithFieldNumber:(BKYFieldNumber * _Nonnull)fieldNumber engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
    [Export("initWithFieldNumber:engine:measurer:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYFieldNumber fieldNumber, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);

    // -(void)didUpdateField:(BKYField * _Nonnull)field;
    [Export("didUpdateField:")]
    void DidUpdateField(BKYField field);

    // -(void)setValueFromLocalizedText:(NSString * _Nonnull)text;
    [Export("setValueFromLocalizedText:")]
    void SetValueFromLocalizedText(string text);
}

// @interface BKYFieldNumberView : BKYFieldView <BKYFieldLayoutMeasurer, BKYNumberPadDelegate, UIPopoverPresentationControllerDelegate, UITextFieldDelegate>
[BaseType (typeof(BKYFieldView))]
interface BKYFieldNumberView : BKYFieldLayoutMeasurer, BKYNumberPadDelegate, IUIPopoverPresentationControllerDelegate, UITextFieldDelegate
{
	// @property (readonly, nonatomic, strong) BKYInsetTextField * _Nonnull textField;
	[Export ("textField", ArgumentSemantic.Strong)]
	BKYInsetTextField TextField { get; }

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)prepareForReuse;
	[Export ("prepareForReuse")]
	void PrepareForReuse ();

	// +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
	[Static]
	[Export ("measureLayout:scale:")]
	CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);

	// -(BOOL)textFieldShouldBeginEditing:(UITextField * _Nonnull)textField __attribute__((warn_unused_result));
	[Export ("textFieldShouldBeginEditing:")]
	bool TextFieldShouldBeginEditing (UITextField textField);

	// -(void)prepareForPopoverPresentation:(UIPopoverPresentationController * _Nonnull)popoverPresentationController;
	[Export ("prepareForPopoverPresentation:")]
	void PrepareForPopoverPresentation (UIPopoverPresentationController popoverPresentationController);

	// -(BOOL)popoverPresentationControllerShouldDismissPopover:(UIPopoverPresentationController * _Nonnull)popoverPresentationController __attribute__((warn_unused_result));
	[Export ("popoverPresentationControllerShouldDismissPopover:")]
	bool PopoverPresentationControllerShouldDismissPopover (UIPopoverPresentationController popoverPresentationController);

	// -(void)numberPad:(BKYNumberPad * _Nonnull)numberPad didChangeText:(NSString * _Nonnull)text;
	[Export ("numberPad:didChangeText:")]
	void NumberPad (BKYNumberPad numberPad, string text);

	// -(void)numberPadDidPressReturnKey:(BKYNumberPad * _Nonnull)numberPad;
	[Export ("numberPadDidPressReturnKey:")]
	void NumberPadDidPressReturnKey (BKYNumberPad numberPad);
}

// @protocol BKYNumberPadDelegate
[Protocol, Model]
interface BKYNumberPadDelegate
{
    // @required -(void)numberPad:(BKYNumberPad * _Nonnull)numberPad didChangeText:(NSString * _Nonnull)text;
    [Abstract]
    [Export("numberPad:didChangeText:")]
    void NumberPad(BKYNumberPad numberPad, string text);

    // @required -(void)numberPadDidPressReturnKey:(BKYNumberPad * _Nonnull)numberPad;
    [Abstract]
    [Export("numberPadDidPressReturnKey:")]
    void NumberPadDidPressReturnKey(BKYNumberPad numberPad);
}

// @interface BKYFieldVariable : BKYField
[BaseType(typeof(BKYField))]
interface BKYFieldVariable
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull variable;
    [Export("variable")]
    string Variable { get; }

    // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name variable:(NSString * _Nonnull)variable __attribute__((objc_designated_initializer));
    [Export("initWithName:variable:")]
    [DesignatedInitializer]
    IntPtr Constructor(string name, string variable);

    // -(BKYField * _Nonnull)copyField __attribute__((warn_unused_result));
    [Export("copyField")]
    BKYField CopyField { get; }

    // -(BOOL)setValueFromSerializedText:(NSString * _Nonnull)text error:(NSError * _Nullable * _Nullable)error;
    [Export("setValueFromSerializedText:error:")]
    bool SetValueFromSerializedText(string text, [NullAllowed] out NSError error);

    // +(BOOL)isValidName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
    [Static]
    [Export("isValidName:")]
    bool IsValidName(string name);

    // -(BOOL)setVariable:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
    [Export("setVariable:error:")]
    bool SetVariable(string name, [NullAllowed] out NSError error);
}

// @interface BKYFieldVariableLayout : BKYFieldLayout <BKYNameManagerListener>
[BaseType (typeof(BKYFieldLayout))]
interface BKYFieldVariableLayout : BKYNameManagerListener
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull variable;
	[Export ("variable")]
	string Variable { get; }

	// @property (nonatomic, weak) BKYNameManager * _Nullable nameManager;
	[NullAllowed, Export ("nameManager", ArgumentSemantic.Weak)]
	BKYNameManager NameManager { get; set; }

	// -(instancetype _Nonnull)initWithFieldVariable:(BKYFieldVariable * _Nonnull)fieldVariable engine:(BKYLayoutEngine * _Nonnull)engine measurer:(Class<BKYFieldLayoutMeasurer> _Nonnull)measurer __attribute__((objc_designated_initializer));
	[Export ("initWithFieldVariable:engine:measurer:")]
	[DesignatedInitializer]
	IntPtr Constructor (BKYFieldVariable fieldVariable, BKYLayoutEngine engine, BKYFieldLayoutMeasurer measurer);

	// -(void)didUpdateField:(BKYField * _Nonnull)field;
	[Export ("didUpdateField:")]
	void DidUpdateField (BKYField field);

	// -(void)changeToExistingVariable:(NSString * _Nonnull)variable;
	[Export ("changeToExistingVariable:")]
	void ChangeToExistingVariable (string variable);

	// -(void)renameVariableTo:(NSString * _Nonnull)newName;
	[Export ("renameVariableTo:")]
	void RenameVariableTo (string newName);

	// -(void)removeVariable;
	[Export ("removeVariable")]
	void RemoveVariable ();

	// -(BOOL)isValidName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
	[Export ("isValidName:")]
	bool IsValidName (string name);

	// -(NSInteger)numberOfVariableReferences __attribute__((warn_unused_result));
	[Export ("numberOfVariableReferences")]
	[Verify (MethodToProperty)]
	nint NumberOfVariableReferences { get; }

	// -(BOOL)nameManager:(BKYNameManager * _Nonnull)nameManager shouldRemoveName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
	[Export ("nameManager:shouldRemoveName:")]
	bool NameManager (BKYNameManager nameManager, string name);

	// -(void)nameManager:(BKYNameManager * _Nonnull)nameManager didRenameName:(NSString * _Nonnull)oldName toName:(NSString * _Nonnull)newName;
	[Export ("nameManager:didRenameName:toName:")]
	void NameManager (BKYNameManager nameManager, string oldName, string newName);
}

// @protocol BKYNameManagerListener
[Protocol, Model]
interface BKYNameManagerListener
{
    // @optional -(void)nameManager:(BKYNameManager * _Nonnull)nameManager didAddName:(NSString * _Nonnull)name;
    [Export("nameManager:didAddName:")]
    void NameManagerDidAddName(BKYNameManager nameManager, string name);

    // @optional -(void)nameManager:(BKYNameManager * _Nonnull)nameManager didRenameName:(NSString * _Nonnull)oldName toName:(NSString * _Nonnull)newName;
    [Export("nameManager:didRenameName:toName:")]
    void NameManagerDidRenameName(BKYNameManager nameManager, string oldName, string newName);

    // @optional -(BOOL)nameManager:(BKYNameManager * _Nonnull)nameManager shouldRemoveName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
    [Export("nameManager:shouldRemoveName:")]
    bool NameManagerShouldRemoveName(BKYNameManager nameManager, string name);

    // @optional -(void)nameManager:(BKYNameManager * _Nonnull)nameManager didRemoveName:(NSString * _Nonnull)name;
    [Export("nameManager:didRemoveName:")]
    void NameManagerDidRemoveName(BKYNameManager nameManager, string name);
}

// @interface BKYFieldVariableView : BKYFieldView <BKYDropdownOptionsViewControllerDelegate, BKYDropdownViewDelegate, BKYFieldLayoutMeasurer, UIPopoverPresentationControllerDelegate>
    [BaseType (typeof(BKYFieldView))]
    interface BKYFieldVariableView : IBKYDropdownOptionsViewControllerDelegate, IBKYDropdownViewDelegate, IBKYFieldLayoutMeasurer, IUIPopoverPresentationControllerDelegate
    {
        // @property (readonly, nonatomic, strong) BKYFieldVariableLayout * _Nullable fieldVariableLayout;
        [NullAllowed, Export ("fieldVariableLayout", ArgumentSemantic.Strong)]
        BKYFieldVariableLayout FieldVariableLayout { get; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export ("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor (NSCoder aDecoder);

        // -(void)prepareForReuse;
        [Export ("prepareForReuse")]
        void PrepareForReuse ();

        // +(CGSize)measureLayout:(BKYFieldLayout * _Nonnull)layout scale:(CGFloat)scale __attribute__((warn_unused_result));
        [Static]
        [Export ("measureLayout:scale:")]
        CGSize MeasureLayout (BKYFieldLayout layout, nfloat scale);

        // -(void)dropDownDidReceiveTap;
        [Export ("dropDownDidReceiveTap")]
        void DropDownDidReceiveTap ();

        // -(void)prepareForPopoverPresentation:(UIPopoverPresentationController * _Nonnull)popoverPresentationController;
        [Export ("prepareForPopoverPresentation:")]
        void PrepareForPopoverPresentation (UIPopoverPresentationController popoverPresentationController);

        // -(void)dropdownOptionsViewController:(BKYDropdownOptionsViewController * _Nonnull)viewController didSelectOptionIndex:(NSInteger)optionIndex;
        [Export ("dropdownOptionsViewController:didSelectOptionIndex:")]
        void DropdownOptionsViewController (BKYDropdownOptionsViewController viewController, nint optionIndex);
    }

// @interface BKYImageLoader : NSObject
[BaseType(typeof(NSObject))]
interface BKYImageLoader
{
    // +(UIImage * _Nullable)loadImageWithNamed:(NSString * _Nonnull)imageName forClass:(Class _Nonnull)anyClass __attribute__((warn_unused_result));
    [Static]
    [Export("loadImageWithNamed:forClass:")]
    [return: NullAllowed]
    UIImage LoadImageWithNamed(string imageName, Class anyClass);
}

// @interface BKYInput : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYInput
{
    // @property (readonly, nonatomic) enum BKYInputType type;
    [Export("type")]
    BKYInputType Type { get; }

    // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
    [Export("name")]
    string Name { get; }

    // @property (readonly, copy, nonatomic) NSArray<BKYField *> * _Nonnull fields;
    [Export("fields", ArgumentSemantic.Copy)]
    BKYField[] Fields { get; }

    // @property (readonly, nonatomic, weak) BKYBlock * _Nullable sourceBlock;
    [NullAllowed, Export("sourceBlock", ArgumentSemantic.Weak)]
    BKYBlock SourceBlock { get; }

    // @property (readonly, nonatomic, strong) BKYConnection * _Nullable connection;
    [NullAllowed, Export("connection", ArgumentSemantic.Strong)]
    BKYConnection Connection { get; }

    // @property (readonly, nonatomic, strong) BKYBlock * _Nullable connectedBlock;
    [NullAllowed, Export("connectedBlock", ArgumentSemantic.Strong)]
    BKYBlock ConnectedBlock { get; }

    // @property (readonly, nonatomic, strong) BKYBlock * _Nullable connectedShadowBlock;
    [NullAllowed, Export("connectedShadowBlock", ArgumentSemantic.Strong)]
    BKYBlock ConnectedShadowBlock { get; }

    // @property (nonatomic) BOOL visible;
    [Export("visible")]
    bool Visible { get; set; }

    // @property (nonatomic) enum BKYInputAlignment alignment;
    [Export("alignment", ArgumentSemantic.Assign)]
    BKYInputAlignment Alignment { get; set; }

    // @property (nonatomic, weak) BKYInputLayout * _Nullable layout;
    [NullAllowed, Export("layout", ArgumentSemantic.Weak)]
    BKYInputLayout Layout { get; set; }

    // -(void)appendField:(BKYField * _Nonnull)field;
    [Export("appendField:")]
    void AppendField(BKYField field);

    // -(void)insertField:(BKYField * _Nonnull)field at:(NSInteger)index;
    [Export("insertField:at:")]
    void InsertField(BKYField field, nint index);

    // -(void)removeField:(BKYField * _Nonnull)field;
    [Export("removeField:")]
    void RemoveField(BKYField field);
}

// @interface BKYInputBuilder : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYInputBuilder
{
    // @property (nonatomic) enum BKYInputType type;
    [Export("type", ArgumentSemantic.Assign)]
    BKYInputType Type { get; set; }

    // @property (copy, nonatomic) NSArray<NSString *> * _Nullable connectionTypeChecks;
    [NullAllowed, Export("connectionTypeChecks", ArgumentSemantic.Copy)]
    string[] ConnectionTypeChecks { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull name;
    [Export("name")]
    string Name { get; set; }

    // @property (nonatomic) BOOL visible;
    [Export("visible")]
    bool Visible { get; set; }

    // @property (nonatomic) enum BKYInputAlignment alignment;
    [Export("alignment", ArgumentSemantic.Assign)]
    BKYInputAlignment Alignment { get; set; }

    // @property (readonly, copy, nonatomic) NSArray<BKYField *> * _Nonnull fields;
    [Export("fields", ArgumentSemantic.Copy)]
    BKYField[] Fields { get; }

    // -(instancetype _Nonnull)initWithType:(enum BKYInputType)type name:(NSString * _Nonnull)name __attribute__((objc_designated_initializer));
    [Export("initWithType:name:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYInputType type, string name);

    // -(instancetype _Nonnull)initWithInput:(BKYInput * _Nonnull)input __attribute__((objc_designated_initializer));
    [Export("initWithInput:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYInput input);

    // -(BKYInput * _Nonnull)makeInput __attribute__((warn_unused_result));
    [Export("makeInput")]
    BKYInput MakeInput { get; }

    // -(void)appendField:(BKYField * _Nonnull)field;
    [Export("appendField:")]
    void AppendField(BKYField field);

    // -(void)appendFields:(NSArray<BKYField *> * _Nonnull)fields;
    [Export("appendFields:")]
    void AppendFields(BKYField[] fields);
}

// @interface BKYInputView : BKYLayoutView
[BaseType(typeof(BKYLayoutView))]
interface BKYInputView
{
    // @property (readonly, nonatomic, strong) BKYInputLayout * _Nullable inputLayout;
    [NullAllowed, Export("inputLayout", ArgumentSemantic.Strong)]
    BKYInputLayout InputLayout { get; }

    // -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
    [Export("hitTest:withEvent:")]
    [return: NullAllowed]
    UIView HitTest(CGPoint point, [NullAllowed] UIEvent @event);

    // -(void)prepareForReuse;
    [Export("prepareForReuse")]
    void PrepareForReuse();

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
    [Export("initWithFrame:")]
    [DesignatedInitializer]
    IntPtr Constructor(CGRect frame);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);
}

// @interface BKYInsetTextField : UITextField
[BaseType(typeof(UITextField))]
interface BKYInsetTextField
{
    // @property (nonatomic) int insetPadding;
    [Export("insetPadding")]
    int InsetPadding { get; set; }

    // -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
    [Export("textRectForBounds:")]
    CGRect TextRectForBounds(CGRect bounds);

    // -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
    [Export("editingRectForBounds:")]
    CGRect EditingRectForBounds(CGRect bounds);

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
    [Export("initWithFrame:")]
    [DesignatedInitializer]
    IntPtr Constructor(CGRect frame);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);
}

// @interface BKYJSONHelper : NSObject
[BaseType(typeof(NSObject))]
interface BKYJSONHelper
{
    // +(id _Nullable)makeJSONObjectWithString:(NSString * _Nonnull)string error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Static]
    [Export("makeJSONObjectWithString:error:")]
    [return: NullAllowed]
    NSObject MakeJSONObjectWithString(string @string, [NullAllowed] out NSError error);

    // +(NSDictionary<NSString *,id> * _Nullable)makeJSONDictionaryWithString:(NSString * _Nonnull)string error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Static]
    [Export("makeJSONDictionaryWithString:error:")]
    [return: NullAllowed]
    NSDictionary<NSString, NSObject> MakeJSONDictionaryWithString(string @string, [NullAllowed] out NSError error);

    // +(NSArray * _Nullable)makeJSONArrayWithString:(NSString * _Nonnull)string error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Static]
    [Export("makeJSONArrayWithString:error:")]
    [return: NullAllowed]
    NSObject[] MakeJSONArrayWithString(string @string, [NullAllowed] out NSError error);
}

// @interface Blockly_Swift_4516 (BKYLayout)
[Category]
[BaseType(typeof(BKYLayout))]
interface BKYLayout_Blockly_Swift_4516
{
    // @property (readonly, nonatomic) BOOL animateChangeEvent;
    [Export("animateChangeEvent")]
    bool AnimateChangeEvent { get; }
}

// @interface BKYLayoutBuilder : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYLayoutBuilder
{
    // @property (readonly, nonatomic, strong) BKYLayoutFactory * _Nonnull layoutFactory;
    [Export("layoutFactory", ArgumentSemantic.Strong)]
    BKYLayoutFactory LayoutFactory { get; }

    // -(instancetype _Nonnull)initWithLayoutFactory:(BKYLayoutFactory * _Nonnull)layoutFactory __attribute__((objc_designated_initializer));
    [Export("initWithLayoutFactory:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYLayoutFactory layoutFactory);

    // -(BOOL)buildLayoutTreeForWorkspaceLayout:(BKYWorkspaceLayout * _Nonnull)workspaceLayout error:(NSError * _Nullable * _Nullable)error;
    [Export("buildLayoutTreeForWorkspaceLayout:error:")]
    bool BuildLayoutTreeForWorkspaceLayout(BKYWorkspaceLayout workspaceLayout, [NullAllowed] out NSError error);

    // -(BKYBlockGroupLayout * _Nullable)buildLayoutTreeForTopLevelBlock:(BKYBlock * _Nonnull)block workspaceLayout:(BKYWorkspaceLayout * _Nonnull)workspaceLayout error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("buildLayoutTreeForTopLevelBlock:workspaceLayout:error:")]
    [return: NullAllowed]
    BKYBlockGroupLayout BuildLayoutTreeForTopLevelBlock(BKYBlock block, BKYWorkspaceLayout workspaceLayout, [NullAllowed] out NSError error);

    // -(BOOL)buildLayoutTreeForBlockGroupLayout:(BKYBlockGroupLayout * _Nonnull)blockGroupLayout block:(BKYBlock * _Nonnull)block error:(NSError * _Nullable * _Nullable)error;
    [Export("buildLayoutTreeForBlockGroupLayout:block:error:")]
    bool BuildLayoutTreeForBlockGroupLayout(BKYBlockGroupLayout blockGroupLayout, BKYBlock block, [NullAllowed] out NSError error);

    // -(BKYBlockLayout * _Nullable)buildLayoutTreeForBlock:(BKYBlock * _Nonnull)block engine:(BKYLayoutEngine * _Nonnull)engine error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("buildLayoutTreeForBlock:engine:error:")]
    [return: NullAllowed]
    BKYBlockLayout BuildLayoutTreeForBlock(BKYBlock block, BKYLayoutEngine engine, [NullAllowed] out NSError error);

    // -(BKYInputLayout * _Nullable)buildLayoutTreeForInput:(BKYInput * _Nonnull)input engine:(BKYLayoutEngine * _Nonnull)engine error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("buildLayoutTreeForInput:engine:error:")]
    [return: NullAllowed]
    BKYInputLayout BuildLayoutTreeForInput(BKYInput input, BKYLayoutEngine engine, [NullAllowed] out NSError error);

    // -(BKYFieldLayout * _Nullable)buildLayoutForField:(BKYField * _Nonnull)field engine:(BKYLayoutEngine * _Nonnull)engine error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("buildLayoutForField:engine:error:")]
    [return: NullAllowed]
    BKYFieldLayout BuildLayoutForField(BKYField field, BKYLayoutEngine engine, [NullAllowed] out NSError error);
}

// @interface BKYLayoutFactory : NSObject
[BaseType(typeof(NSObject))]
interface BKYLayoutFactory
{
    // -(BKYBlockLayout * _Nullable)makeBlockLayoutWithBlock:(BKYBlock * _Nonnull)block engine:(BKYLayoutEngine * _Nonnull)engine error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeBlockLayoutWithBlock:engine:error:")]
    [return: NullAllowed]
    BKYBlockLayout MakeBlockLayoutWithBlock(BKYBlock block, BKYLayoutEngine engine, [NullAllowed] out NSError error);

    // -(BKYBlockGroupLayout * _Nullable)makeBlockGroupLayoutWithEngine:(BKYLayoutEngine * _Nonnull)engine error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeBlockGroupLayoutWithEngine:error:")]
    [return: NullAllowed]
    BKYBlockGroupLayout MakeBlockGroupLayoutWithEngine(BKYLayoutEngine engine, [NullAllowed] out NSError error);

    // -(BKYInputLayout * _Nullable)makeInputLayoutWithInput:(BKYInput * _Nonnull)input engine:(BKYLayoutEngine * _Nonnull)engine error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeInputLayoutWithInput:engine:error:")]
    [return: NullAllowed]
    BKYInputLayout MakeInputLayoutWithInput(BKYInput input, BKYLayoutEngine engine, [NullAllowed] out NSError error);

    // -(BKYFieldLayout * _Nullable)makeFieldLayoutWithField:(BKYField * _Nonnull)field engine:(BKYLayoutEngine * _Nonnull)engine error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeFieldLayoutWithField:engine:error:")]
    [return: NullAllowed]
    BKYFieldLayout MakeFieldLayoutWithField(BKYField field, BKYLayoutEngine engine, [NullAllowed] out NSError error);
}

// @protocol BKYLayoutHierarchyListener
[Protocol, Model]
interface BKYLayoutHierarchyListener
{
    // @required -(void)layout:(BKYLayout * _Nonnull)layout didAdoptChildLayout:(BKYLayout * _Nonnull)childLayout fromOldParentLayout:(BKYLayout * _Nullable)oldParentLayout;
    [Abstract]
    [Export("layout:didAdoptChildLayout:fromOldParentLayout:")]
    void DidAdoptChildLayout(BKYLayout layout, BKYLayout childLayout, [NullAllowed] BKYLayout oldParentLayout);

    // @required -(void)layout:(BKYLayout * _Nonnull)layout didRemoveChildLayout:(BKYLayout * _Nonnull)childLayout;
    [Abstract]
    [Export("layout:didRemoveChildLayout:")]
    void DidRemoveChildLayout(BKYLayout layout, BKYLayout childLayout);
}

// @protocol BKYLayoutPopoverDelegate
[Protocol, Model]
interface BKYLayoutPopoverDelegate
{
    // @required -(void)layoutView:(BKYLayoutView * _Nonnull)layoutView requestedToPresentViewController:(UIViewController * _Nonnull)viewController;
    [Abstract]
    [Export("layoutView:requestedToPresentViewController:")]
    void LayoutView(BKYLayoutView layoutView, UIViewController viewController);

    // @required -(BOOL)layoutView:(BKYLayoutView * _Nonnull)layoutView requestedToPresentPopoverViewController:(UIViewController * _Nonnull)viewController fromView:(UIView * _Nonnull)fromView presentationDelegate:(id<UIPopoverPresentationControllerDelegate> _Nullable)presentationDelegate;
    [Abstract]
    [Export("layoutView:requestedToPresentPopoverViewController:fromView:presentationDelegate:")]
    bool LayoutView(BKYLayoutView layoutView, UIViewController viewController, UIView fromView, [NullAllowed] UIPopoverPresentationControllerDelegate presentationDelegate);

    // @required -(void)layoutView:(BKYLayoutView * _Nonnull)layoutView requestedToDismissPopoverViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
    [Abstract]
    [Export("layoutView:requestedToDismissPopoverViewController:animated:")]
    void LayoutView(BKYLayoutView layoutView, UIViewController viewController, bool animated);
}

// @protocol BKYRecyclable
[Protocol, Model]
interface BKYRecyclable
{
    // @required -(void)prepareForReuse;
    [Abstract]
    [Export("prepareForReuse")]
    void PrepareForReuse();
}

// @interface BKYMessageManager : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYMessageManager
{
    // @property (nonatomic, strong, class) BKYMessageManager * _Nonnull shared;
    [Static]
    [Export("shared", ArgumentSemantic.Strong)]
    BKYMessageManager Shared { get; set; }

    // -(BOOL)loadMessagesWithPrefix:(NSString * _Nonnull)prefix jsonPath:(NSString * _Nonnull)jsonPath bundle:(NSBundle * _Nullable)bundle error:(NSError * _Nullable * _Nullable)error;
    [Export("loadMessagesWithPrefix:jsonPath:bundle:error:")]
    bool LoadMessagesWithPrefix(string prefix, string jsonPath, [NullAllowed] NSBundle bundle, [NullAllowed] out NSError error);

    // -(void)loadMessages:(NSDictionary<NSString *,NSString *> * _Nonnull)messages;
    [Export("loadMessages:")]
    void LoadMessages(NSDictionary<NSString, NSString> messages);

    // -(BOOL)loadSynonymsWithPrefix:(NSString * _Nonnull)prefix jsonPath:(NSString * _Nonnull)jsonPath bundle:(NSBundle * _Nullable)bundle error:(NSError * _Nullable * _Nullable)error;
    [Export("loadSynonymsWithPrefix:jsonPath:bundle:error:")]
    bool LoadSynonymsWithPrefix(string prefix, string jsonPath, [NullAllowed] NSBundle bundle, [NullAllowed] out NSError error);

    // -(void)loadSynonyms:(NSDictionary<NSString *,NSString *> * _Nonnull)synonyms;
    [Export("loadSynonyms:")]
    void LoadSynonyms(NSDictionary<NSString, NSString> synonyms);

    // -(NSString * _Nullable)messageForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result));
    [Export("messageForKey:")]
    [return: NullAllowed]
    string MessageForKey(string key);

    // -(NSString * _Nonnull)decodedString:(NSString * _Nonnull)string __attribute__((warn_unused_result));
    [Export("decodedString:")]
    string DecodedString(string @string);
}

// @interface BKYMutatorHelper : NSObject
[BaseType(typeof(NSObject))]
interface BKYMutatorHelper
{
//    // @property (readonly, nonatomic, strong) NSMapTable<NSString *,BKYConnection *> * _Nonnull savedTargetConnections;
//    [Export("savedTargetConnections", ArgumentSemantic.Strong)]
//    NSMapTable<NSString, BKYConnection> SavedTargetConnections { get; }

    // -(void)clearSavedTargetConnections;
    [Export("clearSavedTargetConnections")]
    void ClearSavedTargetConnections();

    // -(void)saveTargetConnectionsFromInputs:(NSArray<BKYInput *> * _Nonnull)inputs;
    [Export("saveTargetConnectionsFromInputs:")]
    void SaveTargetConnectionsFromInputs(BKYInput[] inputs);

    // -(BOOL)disconnectConnectionsInReverseOrderFromInputs:(NSArray<BKYInput *> * _Nonnull)inputs layoutCoordinator:(BKYWorkspaceLayoutCoordinator * _Nonnull)layoutCoordinator error:(NSError * _Nullable * _Nullable)error;
    [Export("disconnectConnectionsInReverseOrderFromInputs:layoutCoordinator:error:")]
    bool DisconnectConnectionsInReverseOrderFromInputs(BKYInput[] inputs, BKYWorkspaceLayoutCoordinator layoutCoordinator, [NullAllowed] out NSError error);

    // -(BOOL)removeShadowBlocksInReverseOrderFromInputs:(NSArray<BKYInput *> * _Nonnull)inputs layoutCoordinator:(BKYWorkspaceLayoutCoordinator * _Nonnull)layoutCoordinator error:(NSError * _Nullable * _Nullable)error;
    [Export("removeShadowBlocksInReverseOrderFromInputs:layoutCoordinator:error:")]
    bool RemoveShadowBlocksInReverseOrderFromInputs(BKYInput[] inputs, BKYWorkspaceLayoutCoordinator layoutCoordinator, [NullAllowed] out NSError error);

    // -(BOOL)reconnectSavedTargetConnectionsToInputs:(NSArray<BKYInput *> * _Nonnull)inputs layoutCoordinator:(BKYWorkspaceLayoutCoordinator * _Nonnull)layoutCoordinator error:(NSError * _Nullable * _Nullable)error;
    [Export("reconnectSavedTargetConnectionsToInputs:layoutCoordinator:error:")]
    bool ReconnectSavedTargetConnectionsToInputs(BKYInput[] inputs, BKYWorkspaceLayoutCoordinator layoutCoordinator, [NullAllowed] out NSError error);
}

// @interface BKYMutatorIfElse : NSObject
[BaseType(typeof(NSObject))]
interface BKYMutatorIfElse
{
    // @property (nonatomic, weak) BKYBlock * _Nullable block;
    [NullAllowed, Export("block", ArgumentSemantic.Weak)]
    BKYBlock Block { get; set; }

    // @property (nonatomic, weak) BKYMutatorLayout * _Nullable layout;
    [NullAllowed, Export("layout", ArgumentSemantic.Weak)]
    BKYMutatorLayout Layout { get; set; }

    // @property (nonatomic) NSInteger elseIfCount;
    [Export("elseIfCount")]
    nint ElseIfCount { get; set; }

    // @property (nonatomic) BOOL elseStatement;
    [Export("elseStatement")]
    bool ElseStatement { get; set; }
}

// @interface Blockly_Swift_4990 (BKYMutatorIfElse)
[Category]
[BaseType(typeof(BKYMutatorIfElse))]
interface BKYMutatorIfElse_Blockly_Swift_4990
{
    // -(BOOL)mutateBlockAndReturnError:(NSError * _Nullable * _Nullable)error;
    [Export("mutateBlockAndReturnError:")]
    bool MutateBlockAndReturnError([NullAllowed] out NSError error);

    // -(NSArray<BKYInput *> * _Nonnull)sortedMutatorInputs __attribute__((warn_unused_result));
    [Export("sortedMutatorInputs")]
    BKYInput[] SortedMutatorInputs { get; }
}

// @interface BKYMutatorLayout : BKYLayout
[BaseType(typeof(BKYLayout))]
interface BKYMutatorLayout
{
    // @property (nonatomic, weak) BKYWorkspaceLayoutCoordinator * _Nullable layoutCoordinator;
    [NullAllowed, Export("layoutCoordinator", ArgumentSemantic.Weak)]
    BKYWorkspaceLayoutCoordinator LayoutCoordinator { get; set; }

    // @property (readonly, nonatomic) BOOL userInteractionEnabled;
    [Export("userInteractionEnabled")]
    bool UserInteractionEnabled { get; }

    // -(BOOL)performMutationAndReturnError:(NSError * _Nullable * _Nullable)error;
    [Export("performMutationAndReturnError:")]
    bool PerformMutationAndReturnError([NullAllowed] out NSError error);
}

// @interface MutatorIfElseLayout : BKYMutatorLayout
[BaseType(typeof(BKYMutatorLayout))]
interface MutatorIfElseLayout
{
    // @property (nonatomic) NSInteger elseIfCount;
    [Export("elseIfCount")]
    nint ElseIfCount { get; set; }

    // @property (nonatomic) BOOL elseStatement;
    [Export("elseStatement")]
    bool ElseStatement { get; set; }

    // -(instancetype _Nonnull)initWithMutator:(BKYMutatorIfElse * _Nonnull)mutator engine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
    [Export("initWithMutator:engine:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYMutatorIfElse mutator, BKYLayoutEngine engine);

    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);

    // -(BOOL)performMutationAndReturnError:(NSError * _Nullable * _Nullable)error;
    [Export("performMutationAndReturnError:")]
    bool PerformMutationAndReturnError([NullAllowed] out NSError error);

    // -(void)preserveCurrentInputConnections;
    [Export("preserveCurrentInputConnections")]
    void PreserveCurrentInputConnections();
}

// @interface BKYMutatorIfElseView : BKYLayoutView <UIPopoverPresentationControllerDelegate>
    [BaseType (typeof(BKYLayoutView))]
    interface BKYMutatorIfElseView : IUIPopoverPresentationControllerDelegate
    {
        // @property (readonly, nonatomic, strong) MutatorIfElseLayout * _Nullable mutatorIfElseLayout;
        [NullAllowed, Export ("mutatorIfElseLayout", ArgumentSemantic.Strong)]
        MutatorIfElseLayout MutatorIfElseLayout { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull popoverButton;
        [Export ("popoverButton", ArgumentSemantic.Strong)]
        UIButton PopoverButton { get; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export ("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor (NSCoder aDecoder);

        // -(void)prepareForReuse;
        [Export ("prepareForReuse")]
        void PrepareForReuse ();

        // -(void)prepareForPopoverPresentation:(UIPopoverPresentationController * _Nonnull)popoverPresentationController;
        [Export ("prepareForPopoverPresentation:")]
        void PrepareForPopoverPresentation (UIPopoverPresentationController popoverPresentationController);
    }

// @interface BKYMutatorProcedureCaller : NSObject
[BaseType(typeof(NSObject))]
interface BKYMutatorProcedureCaller
{
    // @property (nonatomic, weak) BKYBlock * _Nullable block;
    [NullAllowed, Export("block", ArgumentSemantic.Weak)]
    BKYBlock Block { get; set; }

    // @property (nonatomic, weak) BKYMutatorLayout * _Nullable layout;
    [NullAllowed, Export("layout", ArgumentSemantic.Weak)]
    BKYMutatorLayout Layout { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull procedureName;
    [Export("procedureName")]
    string ProcedureName { get; set; }
}

// @interface Blockly_Swift_5076 (BKYMutatorProcedureCaller)
[Category]
[BaseType(typeof(BKYMutatorProcedureCaller))]
interface BKYMutatorProcedureCaller_Blockly_Swift_5076
{
    // -(BOOL)mutateBlockAndReturnError:(NSError * _Nullable * _Nullable)error;
    [Export("mutateBlockAndReturnError:")]
    bool MutateBlockAndReturnError([NullAllowed] out NSError error);

    // -(NSArray<BKYInput *> * _Nonnull)sortedMutatorInputs __attribute__((warn_unused_result));
    [Export("sortedMutatorInputs")]
    BKYInput[] SortedMutatorInputs { get; }
}

// @interface MutatorProcedureCallerLayout : BKYMutatorLayout
[BaseType(typeof(BKYMutatorLayout))]
interface MutatorProcedureCallerLayout
{
    // @property (copy, nonatomic) NSString * _Nonnull procedureName;
    [Export("procedureName")]
    string ProcedureName { get; set; }

    // -(instancetype _Nonnull)initWithMutator:(BKYMutatorProcedureCaller * _Nonnull)mutator engine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
    [Export("initWithMutator:engine:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYMutatorProcedureCaller mutator, BKYLayoutEngine engine);

    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);

    // -(BOOL)performMutationAndReturnError:(NSError * _Nullable * _Nullable)error;
    [Export("performMutationAndReturnError:")]
    bool PerformMutationAndReturnError([NullAllowed] out NSError error);

    // -(void)preserveCurrentInputConnections;
    [Export("preserveCurrentInputConnections")]
    void PreserveCurrentInputConnections();
}

// @interface BKYMutatorProcedureDefinition : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYMutatorProcedureDefinition
{
    // @property (nonatomic, weak) BKYBlock * _Nullable block;
    [NullAllowed, Export("block", ArgumentSemantic.Weak)]
    BKYBlock Block { get; set; }

    // @property (nonatomic, weak) BKYMutatorLayout * _Nullable layout;
    [NullAllowed, Export("layout", ArgumentSemantic.Weak)]
    BKYMutatorLayout Layout { get; set; }

    // @property (readonly, nonatomic) BOOL returnsValue;
    [Export("returnsValue")]
    bool ReturnsValue { get; }

    // @property (nonatomic) BOOL allowStatements;
    [Export("allowStatements")]
    bool AllowStatements { get; set; }

    // -(instancetype _Nonnull)initWithReturnsValue:(BOOL)returnsValue __attribute__((objc_designated_initializer));
    [Export("initWithReturnsValue:")]
    [DesignatedInitializer]
    IntPtr Constructor(bool returnsValue);
}

// @interface Blockly_Swift_5120 (BKYMutatorProcedureDefinition)
[Category]
[BaseType(typeof(BKYMutatorProcedureDefinition))]
interface BKYMutatorProcedureDefinition_Blockly_Swift_5120
{
    // -(BOOL)mutateBlockAndReturnError:(NSError * _Nullable * _Nullable)error;
    [Export("mutateBlockAndReturnError:")]
    bool MutateBlockAndReturnError([NullAllowed] out NSError error);

    // -(NSArray<BKYInput *> * _Nonnull)sortedMutatorInputs __attribute__((warn_unused_result));
    [Export("sortedMutatorInputs")]
    BKYInput[] SortedMutatorInputs { get; }
}

// @interface MutatorProcedureDefinitionLayout : BKYMutatorLayout
[BaseType(typeof(BKYMutatorLayout))]
interface MutatorProcedureDefinitionLayout
{
    // @property (readonly, nonatomic, class) NSNotificationName _Nonnull NotificationDidPerformMutation;
    [Static]
    [Export("NotificationDidPerformMutation")]
    string NotificationDidPerformMutation { get; }

    // @property (readonly, nonatomic) BOOL returnsValue;
    [Export("returnsValue")]
    bool ReturnsValue { get; }

    // @property (nonatomic) BOOL allowStatements;
    [Export("allowStatements")]
    bool AllowStatements { get; set; }

    // -(instancetype _Nonnull)initWithMutator:(BKYMutatorProcedureDefinition * _Nonnull)mutator engine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
    [Export("initWithMutator:engine:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYMutatorProcedureDefinition mutator, BKYLayoutEngine engine);

    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);

    // -(BOOL)performMutationAndReturnError:(NSError * _Nullable * _Nullable)error;
    [Export("performMutationAndReturnError:")]
    bool PerformMutationAndReturnError([NullAllowed] out NSError error);

    // -(void)preserveCurrentInputConnections;
    [Export("preserveCurrentInputConnections")]
    void PreserveCurrentInputConnections();

    // -(BOOL)containsDuplicateParameters __attribute__((warn_unused_result));
    [Export("containsDuplicateParameters")]
    bool ContainsDuplicateParameters { get; }
}

// @interface MutatorProcedureDefinitionView : BKYLayoutView <UIPopoverPresentationControllerDelegate>
    [BaseType (typeof(BKYLayoutView))]
    interface MutatorProcedureDefinitionView : IUIPopoverPresentationControllerDelegate
    {
        // @property (readonly, nonatomic, strong) MutatorProcedureDefinitionLayout * _Nullable mutatorProcedureDefinitionLayout;
        [NullAllowed, Export ("mutatorProcedureDefinitionLayout", ArgumentSemantic.Strong)]
        MutatorProcedureDefinitionLayout MutatorProcedureDefinitionLayout { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull popoverButton;
        [Export ("popoverButton", ArgumentSemantic.Strong)]
        UIButton PopoverButton { get; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export ("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor (NSCoder aDecoder);

        // -(void)prepareForReuse;
        [Export ("prepareForReuse")]
        void PrepareForReuse ();

        // -(void)prepareForPopoverPresentation:(UIPopoverPresentationController * _Nonnull)popoverPresentationController;
        [Export ("prepareForPopoverPresentation:")]
        void PrepareForPopoverPresentation (UIPopoverPresentationController popoverPresentationController);
    }

// @interface BKYMutatorProcedureIfReturn : NSObject
[BaseType(typeof(NSObject))]
interface BKYMutatorProcedureIfReturn
{
    // @property (nonatomic, weak) BKYBlock * _Nullable block;
    [NullAllowed, Export("block", ArgumentSemantic.Weak)]
    BKYBlock Block { get; set; }

    // @property (nonatomic, weak) BKYMutatorLayout * _Nullable layout;
    [NullAllowed, Export("layout", ArgumentSemantic.Weak)]
    BKYMutatorLayout Layout { get; set; }

    // @property (nonatomic) BOOL hasReturnValue;
    [Export("hasReturnValue")]
    bool HasReturnValue { get; set; }
}

// @interface Blockly_Swift_5195 (BKYMutatorProcedureIfReturn)
[Category]
[BaseType(typeof(BKYMutatorProcedureIfReturn))]
interface BKYMutatorProcedureIfReturn_Blockly_Swift_5195
{
    // -(BOOL)mutateBlockAndReturnError:(NSError * _Nullable * _Nullable)error;
    [Export("mutateBlockAndReturnError:")]
    bool MutateBlockAndReturnError([NullAllowed] out NSError error);

    // -(NSArray<BKYInput *> * _Nonnull)sortedMutatorInputs __attribute__((warn_unused_result));
    [Export("sortedMutatorInputs")]
    BKYInput[] SortedMutatorInputs { get; }
}

// @interface BKYMutatorProcedureIfReturnLayout : BKYMutatorLayout <BKYEventManagerListener>
    [BaseType (typeof(BKYMutatorLayout))]
    interface BKYMutatorProcedureIfReturnLayout : IBKYEventManagerListener
    {
        // @property (nonatomic) BOOL hasReturnValue;
        [Export ("hasReturnValue")]
        bool HasReturnValue { get; set; }

        // -(instancetype _Nonnull)initWithMutator:(BKYMutatorProcedureIfReturn * _Nonnull)mutator engine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
        [Export ("initWithMutator:engine:")]
        [DesignatedInitializer]
        IntPtr Constructor (BKYMutatorProcedureIfReturn mutator, BKYLayoutEngine engine);

        // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
        [Export ("performLayoutWithIncludeChildren:")]
        void PerformLayoutWithIncludeChildren (bool includeChildren);

        // -(BOOL)performMutationAndReturnError:(NSError * _Nullable * _Nullable)error;
        [Export ("performMutationAndReturnError:")]
        bool PerformMutationAndReturnError ([NullAllowed] out NSError error);

        // -(void)preserveCurrentInputConnections;
        [Export ("preserveCurrentInputConnections")]
        void PreserveCurrentInputConnections ();

        // -(void)eventManager:(BKYEventManager * _Nonnull)eventManager didFireEvent:(BKYEvent * _Nonnull)event;
        [Export ("eventManager:didFireEvent:")]
        void EventManager (BKYEventManager eventManager, BKYEvent @event);
    }

// @interface BKYNameManager : NSObject
[BaseType(typeof(NSObject))]
interface BKYNameManager
{
    // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull names;
    [Export("names", ArgumentSemantic.Copy)]
    string[] Names { get; }

    // @property (readonly, nonatomic) NSInteger count;
    [Export("count")]
    nint Count { get; }

    // -(BOOL)addName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
    [Export("addName:error:")]
    bool AddName(string name, [NullAllowed] out NSError error);

    // -(BOOL)renameName:(NSString * _Nonnull)oldName to:(NSString * _Nonnull)newName;
    [Export("renameName:to:")]
    bool RenameName(string oldName, string newName);

    // -(BOOL)renameDisplayName:(NSString * _Nonnull)displayName;
    [Export("renameDisplayName:")]
    bool RenameDisplayName(string displayName);

    // -(BOOL)removeName:(NSString * _Nonnull)name;
    [Export("removeName:")]
    bool RemoveName(string name);

    // -(void)clearNames;
    [Export("clearNames")]
    void ClearNames();

    // -(BOOL)containsName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
    [Export("containsName:")]
    bool ContainsName(string name);

    // -(BOOL)namesAreEqual:(NSString * _Nonnull)name1 :(NSString * _Nonnull)name2 __attribute__((warn_unused_result));
    [Export("namesAreEqual::")]
    bool NamesAreEqual(string name1, string name2);

    // -(NSString * _Nonnull)generateUniqueName:(NSString * _Nonnull)name addToList:(BOOL)addToList __attribute__((warn_unused_result));
    [Export("generateUniqueName:addToList:")]
    string GenerateUniqueName(string name, bool addToList);
}

// @interface BKYNumberPad : UIView <UITextFieldDelegate>
[BaseType (typeof(UIView))]
interface BKYNumberPad : IUITextFieldDelegate
{
	// @property (nonatomic, weak) UIButton * _Nullable button0 __attribute__((iboutlet));
	[NullAllowed, Export ("button0", ArgumentSemantic.Weak)]
	UIButton Button0 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable button1 __attribute__((iboutlet));
	[NullAllowed, Export ("button1", ArgumentSemantic.Weak)]
	UIButton Button1 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable button2 __attribute__((iboutlet));
	[NullAllowed, Export ("button2", ArgumentSemantic.Weak)]
	UIButton Button2 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable button3 __attribute__((iboutlet));
	[NullAllowed, Export ("button3", ArgumentSemantic.Weak)]
	UIButton Button3 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable button4 __attribute__((iboutlet));
	[NullAllowed, Export ("button4", ArgumentSemantic.Weak)]
	UIButton Button4 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable button5 __attribute__((iboutlet));
	[NullAllowed, Export ("button5", ArgumentSemantic.Weak)]
	UIButton Button5 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable button6 __attribute__((iboutlet));
	[NullAllowed, Export ("button6", ArgumentSemantic.Weak)]
	UIButton Button6 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable button7 __attribute__((iboutlet));
	[NullAllowed, Export ("button7", ArgumentSemantic.Weak)]
	UIButton Button7 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable button8 __attribute__((iboutlet));
	[NullAllowed, Export ("button8", ArgumentSemantic.Weak)]
	UIButton Button8 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable button9 __attribute__((iboutlet));
	[NullAllowed, Export ("button9", ArgumentSemantic.Weak)]
	UIButton Button9 { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable buttonMinusSign __attribute__((iboutlet));
	[NullAllowed, Export ("buttonMinusSign", ArgumentSemantic.Weak)]
	UIButton ButtonMinusSign { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable buttonDecimal __attribute__((iboutlet));
	[NullAllowed, Export ("buttonDecimal", ArgumentSemantic.Weak)]
	UIButton ButtonDecimal { get; set; }

	// @property (nonatomic, weak) UIButton * _Nullable buttonBackspace __attribute__((iboutlet));
	[NullAllowed, Export ("buttonBackspace", ArgumentSemantic.Weak)]
	UIButton ButtonBackspace { get; set; }

	// @property (nonatomic, weak) NumberPadTextField * _Nullable textField __attribute__((iboutlet));
	[NullAllowed, Export ("textField", ArgumentSemantic.Weak)]
	NumberPadTextField TextField { get; set; }

	// @property (readonly, nonatomic) BOOL isDefault;
	[Export ("isDefault")]
	bool IsDefault { get; }

	// @property (nonatomic) BOOL allowMinusSign;
	[Export ("allowMinusSign")]
	bool AllowMinusSign { get; set; }

	// @property (nonatomic) BOOL allowDecimal;
	[Export ("allowDecimal")]
	bool AllowDecimal { get; set; }

	// @property (copy, nonatomic) NSString * _Nonnull text;
	[Export ("text")]
	string Text { get; set; }

	// @property (nonatomic, strong) UIFont * _Nullable font;
	[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
	UIFont Font { get; set; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	BKYNumberPadDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<BKYNumberPadDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)layoutSubviews;
	[Export ("layoutSubviews")]
	void LayoutSubviews ();

	// -(void)didPressButton:(UIButton * _Nonnull)button;
	[Export ("didPressButton:")]
	void DidPressButton (UIButton button);

	// -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result));
	[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
	bool TextField (UITextField textField, NSRange range, string @string);

	// -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result));
	[Export ("textFieldShouldReturn:")]
	bool TextFieldShouldReturn (UITextField textField);
}

// @interface NumberPadTextField : UITextField
[BaseType(typeof(UITextField))]
interface NumberPadTextField
{
    // -(NSArray * _Nonnull)selectionRectsForRange:(UITextRange * _Nonnull)range __attribute__((warn_unused_result));
    [Export("selectionRectsForRange:")]
    NSObject[] SelectionRectsForRange(UITextRange range);

    // -(BOOL)canPerformAction:(SEL _Nonnull)action withSender:(id _Nullable)sender __attribute__((warn_unused_result));
    [Export("canPerformAction:withSender:")]
    bool CanPerformAction(Selector action, [NullAllowed] NSObject sender);

    // -(void)copy:(id _Nullable)sender;
    [Export("copy:")]
    void Copy([NullAllowed] NSObject sender);

    // -(void)paste:(id _Nullable)sender;
    [Export("paste:")]
    void Paste([NullAllowed] NSObject sender);

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
    [Export("initWithFrame:")]
    [DesignatedInitializer]
    IntPtr Constructor(CGRect frame);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);
}

// @interface BKYNumberPadViewController : UIViewController
[BaseType(typeof(UIViewController))]
interface BKYNumberPadViewController
{
    // @property (readonly, nonatomic, strong) BKYNumberPad * _Nonnull numberPad;
    [Export("numberPad", ArgumentSemantic.Strong)]
    BKYNumberPad NumberPad { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)viewDidLoad;
    [Export("viewDidLoad")]
    void ViewDidLoad();

    // -(void)viewWillAppear:(BOOL)animated;
    [Export("viewWillAppear:")]
    void ViewWillAppear(bool animated);
}

// @interface BKYObjectPool : NSObject
[BaseType(typeof(NSObject))]
interface BKYObjectPool
{
    // -(void)recycleObject:(id<BKYRecyclable> _Nonnull)object;
    [Export("recycleObject:")]
    void RecycleObject(BKYRecyclable @object);

    // -(void)removeAllRecycledObjects;
    [Export("removeAllRecycledObjects")]
    void RemoveAllRecycledObjects();
}

// @interface BKYPathHelper : NSObject
[BaseType(typeof(NSObject))]
interface BKYPathHelper
{
    // +(void)addNotchToPath:(BKYWorkspaceBezierPath * _Nonnull)path drawLeftToRight:(BOOL)drawLeftToRight notchWidth:(CGFloat)notchWidth notchHeight:(CGFloat)notchHeight;
    [Static]
    [Export("addNotchToPath:drawLeftToRight:notchWidth:notchHeight:")]
    void AddNotchToPath(BKYWorkspaceBezierPath path, bool drawLeftToRight, nfloat notchWidth, nfloat notchHeight);

    // +(void)addJaggedTeethToPath:(BKYWorkspaceBezierPath * _Nonnull)path;
    [Static]
    [Export("addJaggedTeethToPath:")]
    void AddJaggedTeethToPath(BKYWorkspaceBezierPath path);

    // +(void)addPuzzleTabToPath:(BKYWorkspaceBezierPath * _Nonnull)path drawTopToBottom:(BOOL)drawTopToBottom puzzleTabWidth:(CGFloat)puzzleTabWidth puzzleTabHeight:(CGFloat)puzzleTabHeight;
    [Static]
    [Export("addPuzzleTabToPath:drawTopToBottom:puzzleTabWidth:puzzleTabHeight:")]
    void AddPuzzleTabToPath(BKYWorkspaceBezierPath path, bool drawTopToBottom, nfloat puzzleTabWidth, nfloat puzzleTabHeight);

    // +(void)movePathToTopLeftCornerStart:(BKYWorkspaceBezierPath * _Nonnull)path blockCornerRadius:(CGFloat)blockCornerRadius;
    [Static]
    [Export("movePathToTopLeftCornerStart:blockCornerRadius:")]
    void MovePathToTopLeftCornerStart(BKYWorkspaceBezierPath path, nfloat blockCornerRadius);

    // +(void)addHatCapToPath:(BKYWorkspaceBezierPath * _Nonnull)path hatSize:(id)hatSize;
    [Static]
    [Export("addHatCapToPath:hatSize:")]
    void AddHatCapToPath(BKYWorkspaceBezierPath path, NSObject hatSize);
}

// @interface BKYProcedureCoordinator : NSObject <BKYEventManagerListener, BKYNameManagerListener, BKYWorkspaceListener>
[BaseType (typeof(NSObject))]
interface BKYProcedureCoordinator : IBKYEventManagerListener, IBKYNameManagerListener, IBKYWorkspaceListener
{
	// @property (readonly, copy, nonatomic, class) NSString * _Nonnull BLOCK_DEFINITION_NO_RETURN;
	[Static]
	[Export ("BLOCK_DEFINITION_NO_RETURN")]
	string BLOCK_DEFINITION_NO_RETURN { get; }

	// @property (readonly, copy, nonatomic, class) NSString * _Nonnull BLOCK_DEFINITION_RETURN;
	[Static]
	[Export ("BLOCK_DEFINITION_RETURN")]
	string BLOCK_DEFINITION_RETURN { get; }

	// @property (readonly, copy, nonatomic, class) NSString * _Nonnull BLOCK_CALLER_NO_RETURN;
	[Static]
	[Export ("BLOCK_CALLER_NO_RETURN")]
	string BLOCK_CALLER_NO_RETURN { get; }

	// @property (readonly, copy, nonatomic, class) NSString * _Nonnull BLOCK_CALLER_RETURN;
	[Static]
	[Export ("BLOCK_CALLER_RETURN")]
	string BLOCK_CALLER_RETURN { get; }

	// @property (readonly, copy, nonatomic, class) NSString * _Nonnull BLOCK_IF_RETURN;
	[Static]
	[Export ("BLOCK_IF_RETURN")]
	string BLOCK_IF_RETURN { get; }

	// @property (readonly, nonatomic, weak) BKYWorkbenchViewController * _Nullable workbench;
	[NullAllowed, Export ("workbench", ArgumentSemantic.Weak)]
	BKYWorkbenchViewController Workbench { get; }

	// -(void)syncWithWorkbench:(BKYWorkbenchViewController * _Nullable)workbench;
	[Export ("syncWithWorkbench:")]
	void SyncWithWorkbench ([NullAllowed] BKYWorkbenchViewController workbench);

	// -(void)workspace:(BKYWorkspace * _Nonnull)workspace willAddBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
	[Export ("workspace:willAddBlockTrees:")]
	void Workspace (BKYWorkspace workspace, BKYBlock[] blockTrees);

	// -(void)workspace:(BKYWorkspace * _Nonnull)workspace didAddBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
	[Export ("workspace:didAddBlockTrees:")]
	void Workspace (BKYWorkspace workspace, BKYBlock[] blockTrees);

	// -(void)workspace:(BKYWorkspace * _Nonnull)workspace willRemoveBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
	[Export ("workspace:willRemoveBlockTrees:")]
	void Workspace (BKYWorkspace workspace, BKYBlock[] blockTrees);

	// -(void)workspace:(BKYWorkspace * _Nonnull)workspace didRemoveBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
	[Export ("workspace:didRemoveBlockTrees:")]
	void Workspace (BKYWorkspace workspace, BKYBlock[] blockTrees);

	// -(void)eventManager:(BKYEventManager * _Nonnull)eventManager didFireEvent:(BKYEvent * _Nonnull)event;
	[Export ("eventManager:didFireEvent:")]
	void EventManager (BKYEventManager eventManager, BKYEvent @event);

	// -(BOOL)nameManager:(BKYNameManager * _Nonnull)nameManager shouldRemoveName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
	[Export ("nameManager:shouldRemoveName:")]
	bool NameManager (BKYNameManager nameManager, string name);

	// -(void)nameManager:(BKYNameManager * _Nonnull)nameManager didRenameName:(NSString * _Nonnull)oldName toName:(NSString * _Nonnull)newName;
	[Export ("nameManager:didRenameName:toName:")]
	void NameManager (BKYNameManager nameManager, string oldName, string newName);
}

// @protocol BKYWorkspaceListener
[Protocol, Model]
interface BKYWorkspaceListener
{
    // @optional -(void)workspace:(BKYWorkspace * _Nonnull)workspace willAddBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
    [Export("workspace:willAddBlockTrees:")]
    void WillAddBlockTrees(BKYWorkspace workspace, BKYBlock[] blockTrees);

    // @optional -(void)workspace:(BKYWorkspace * _Nonnull)workspace didAddBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
    [Export("workspace:didAddBlockTrees:")]
    void DidAddBlockTrees(BKYWorkspace workspace, BKYBlock[] blockTrees);

    // @optional -(void)workspace:(BKYWorkspace * _Nonnull)workspace willRemoveBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
    [Export("workspace:willRemoveBlockTrees:")]
    void WillRemoveBlockTrees(BKYWorkspace workspace, BKYBlock[] blockTrees);

    // @optional -(void)workspace:(BKYWorkspace * _Nonnull)workspace didRemoveBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
    [Export("workspace:didRemoveBlockTrees:")]
    void DidRemoveBlockTrees(BKYWorkspace workspace, BKYBlock[] blockTrees);
}

// @interface Blockly_Swift_5590 (BKYProcedureCoordinator) <BKYWorkspaceListener>
[Category]
[BaseType(typeof(BKYProcedureCoordinator))]
interface BKYProcedureCoordinator_Blockly_Swift_5590 : BKYWorkspaceListener
{
    // -(void)workspace:(BKYWorkspace * _Nonnull)workspace willAddBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
    [Export("workspace:willAddBlockTrees:")]
    void WillAddBlockTrees(BKYWorkspace workspace, BKYBlock[] blockTrees);

    // -(void)workspace:(BKYWorkspace * _Nonnull)workspace didAddBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
    [Export("workspace:didAddBlockTrees:")]
    void DidAddBlockTrees(BKYWorkspace workspace, BKYBlock[] blockTrees);

    // -(void)workspace:(BKYWorkspace * _Nonnull)workspace willRemoveBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
    [Export("workspace:willRemoveBlockTrees:")]
    void WillRemoveBlockTrees(BKYWorkspace workspace, BKYBlock[] blockTrees);

    // -(void)workspace:(BKYWorkspace * _Nonnull)workspace didRemoveBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
    [Export("workspace:didRemoveBlockTrees:")]
    void DidRemoveBlockTrees(BKYWorkspace workspace, BKYBlock[] blockTrees);
}

// @interface Blockly_Swift_5598 (BKYProcedureCoordinator) <BKYEventManagerListener>
[Category]
[BaseType(typeof(BKYProcedureCoordinator))]
interface BKYProcedureCoordinator_Blockly_Swift_5598 : BKYEventManagerListener
{
    // -(void)eventManager:(BKYEventManager * _Nonnull)eventManager didFireEvent:(BKYEvent * _Nonnull)event;
    [Export("eventManager:didFireEvent:")]
    void EventManager(BKYEventManager eventManager, BKYEvent @event);
}

// @interface BKYToolbox : NSObject
[BaseType(typeof(NSObject))]
interface BKYToolbox
{
    // @property (readonly, copy, nonatomic) NSArray<BKYToolboxCategory *> * _Nonnull categories;
    [Export("categories", ArgumentSemantic.Copy)]
    BKYToolboxCategory[] Categories { get; }

    // @property (nonatomic) BOOL readOnly;
    [Export("readOnly")]
    bool ReadOnly { get; set; }

    // -(BKYToolboxCategory * _Nonnull)addCategoryWithName:(NSString * _Nonnull)name color:(UIColor * _Nonnull)color __attribute__((warn_unused_result));
    [Export("addCategoryWithName:color:")]
    BKYToolboxCategory AddCategoryWithName(string name, UIColor color);

    // -(BKYToolboxCategory * _Nonnull)addCategoryWithName:(NSString * _Nonnull)name color:(UIColor * _Nonnull)color icon:(UIImage * _Nullable)icon __attribute__((warn_unused_result));
    [Export("addCategoryWithName:color:icon:")]
    BKYToolboxCategory AddCategoryWithName(string name, UIColor color, [NullAllowed] UIImage icon);
}

// @interface Blockly_Swift_5637 (BKYToolbox)
[Category]
[BaseType(typeof(BKYToolbox))]
interface BKYToolbox_Blockly_Swift_5637
{
}

// @interface BKYWorkspace : NSObject
[BaseType(typeof(NSObject))]
interface BKYWorkspace
{
    // @property (readonly, copy, nonatomic) NSString * _Nonnull uuid;
    [Export("uuid")]
    string Uuid { get; }

    // @property (readonly, copy, nonatomic) NSDictionary<NSString *,BKYBlock *> * _Nonnull allBlocks;
    [Export("allBlocks", ArgumentSemantic.Copy)]
    NSDictionary<NSString, BKYBlock> AllBlocks { get; }

    // @property (nonatomic) BOOL readOnly;
    [Export("readOnly")]
    bool ReadOnly { get; set; }

    // @property (nonatomic, weak) BKYWorkspaceLayout * _Nullable layout;
    [NullAllowed, Export("layout", ArgumentSemantic.Weak)]
    BKYWorkspaceLayout Layout { get; set; }

    // -(NSArray<BKYBlock *> * _Nonnull)topLevelBlocks __attribute__((warn_unused_result));
    [Export("topLevelBlocks")]
    BKYBlock[] TopLevelBlocks { get; }

    // -(BOOL)addBlockTree:(BKYBlock * _Nonnull)rootBlock error:(NSError * _Nullable * _Nullable)error;
    [Export("addBlockTree:error:")]
    bool AddBlockTree(BKYBlock rootBlock, [NullAllowed] out NSError error);

    // -(BOOL)addBlockTrees:(NSArray<BKYBlock *> * _Nonnull)rootBlocks error:(NSError * _Nullable * _Nullable)error;
    [Export("addBlockTrees:error:")]
    bool AddBlockTrees(BKYBlock[] rootBlocks, [NullAllowed] out NSError error);

    // -(BOOL)removeBlockTree:(BKYBlock * _Nonnull)rootBlock error:(NSError * _Nullable * _Nullable)error;
    [Export("removeBlockTree:error:")]
    bool RemoveBlockTree(BKYBlock rootBlock, [NullAllowed] out NSError error);

    // -(BOOL)removeBlockTrees:(NSArray<BKYBlock *> * _Nonnull)rootBlocks error:(NSError * _Nullable * _Nullable)error;
    [Export("removeBlockTrees:error:")]
    bool RemoveBlockTrees(BKYBlock[] rootBlocks, [NullAllowed] out NSError error);

    // -(BKYBlock * _Nullable)copyBlockTree:(BKYBlock * _Nonnull)rootBlock editable:(BOOL)editable position:(id)position error:(NSError * _Nullable * _Nullable)error;
    [Export("copyBlockTree:editable:position:error:")]
    [return: NullAllowed]
    BKYBlock CopyBlockTree(BKYBlock rootBlock, bool editable, NSObject position, [NullAllowed] out NSError error);

    // -(BOOL)containsBlock:(BKYBlock * _Nonnull)block __attribute__((warn_unused_result));
    [Export("containsBlock:")]
    bool ContainsBlock(BKYBlock block);

    // -(void)deactivateBlockTreesForGroupsGreaterThan:(NSInteger)threshold;
    [Export("deactivateBlockTreesForGroupsGreaterThan:")]
    void DeactivateBlockTreesForGroupsGreaterThan(nint threshold);

    // -(NSArray<BKYBlock *> * _Nonnull)allVariableBlocksForName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
    [Export("allVariableBlocksForName:")]
    BKYBlock[] AllVariableBlocksForName(string name);
}

// @interface BKYWorkspaceFlow : BKYWorkspace
[BaseType(typeof(BKYWorkspace))]
interface BKYWorkspaceFlow
{
    // @property (readonly, copy, nonatomic) NSArray<BKYWorkspaceFlowItem *> * _Nonnull items;
    [Export("items", ArgumentSemantic.Copy)]
    BKYWorkspaceFlowItem[] Items { get; }

    // -(BOOL)addBlockTree:(BKYBlock * _Nonnull)rootBlock error:(NSError * _Nullable * _Nullable)error;
    [Export("addBlockTree:error:")]
    bool AddBlockTree(BKYBlock rootBlock, [NullAllowed] out NSError error);

    // -(BOOL)removeBlockTree:(BKYBlock * _Nonnull)rootBlock error:(NSError * _Nullable * _Nullable)error;
    [Export("removeBlockTree:error:")]
    bool RemoveBlockTree(BKYBlock rootBlock, [NullAllowed] out NSError error);

    // -(void)addGap:(CGFloat)gap;
    [Export("addGap:")]
    void AddGap(nfloat gap);
}

// @interface BKYWorkspaceFlowItem : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYWorkspaceFlowItem
{
    // @property (readonly, nonatomic, strong) BKYBlock * _Nullable rootBlock;
    [NullAllowed, Export("rootBlock", ArgumentSemantic.Strong)]
    BKYBlock RootBlock { get; }
}

// @interface BKYToolboxCategory : BKYWorkspaceFlow
[BaseType(typeof(BKYWorkspaceFlow))]
[DisableDefaultCtor]
interface BKYToolboxCategory
{
    // @property (copy, nonatomic) NSString * _Nonnull name;
    [Export("name")]
    string Name { get; set; }

    // @property (nonatomic, strong) UIColor * _Nonnull color;
    [Export("color", ArgumentSemantic.Strong)]
    UIColor Color { get; set; }

    // @property (nonatomic, strong) UIImage * _Nullable icon;
    [NullAllowed, Export("icon", ArgumentSemantic.Strong)]
    UIImage Icon { get; set; }
}

// @interface Blockly_Swift_5776 (BKYToolbox)
[Category]
[BaseType(typeof(BKYToolbox))]
interface BKYToolbox_Blockly_Swift_5776
{
    // +(BKYToolbox * _Nullable)makeToolboxWithXmlString:(NSString * _Nonnull)xmlString factory:(BKYBlockFactory * _Nonnull)factory error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Static]
    [Export("makeToolboxWithXmlString:factory:error:")]
    [return: NullAllowed]
    BKYToolbox MakeToolboxWithXmlString(string xmlString, BKYBlockFactory factory, [NullAllowed] out NSError error);
}

// @interface BKYToolboxCategoryListViewController : UICollectionViewController <UICollectionViewDelegateFlowLayout>
[BaseType (typeof(UICollectionViewController))]
interface BKYToolboxCategoryListViewController : IUICollectionViewDelegateFlowLayout
{
	// @property (readonly, nonatomic) enum BKYToolboxCategoryListViewControllerOrientation orientation;
	[Export ("orientation")]
	BKYToolboxCategoryListViewControllerOrientation Orientation { get; }

	// @property (nonatomic, strong) BKYToolboxLayout * _Nullable toolboxLayout;
	[NullAllowed, Export ("toolboxLayout", ArgumentSemantic.Strong)]
	BKYToolboxLayout ToolboxLayout { get; set; }

	// @property (nonatomic, strong) BKYToolboxCategory * _Nullable selectedCategory;
	[NullAllowed, Export ("selectedCategory", ArgumentSemantic.Strong)]
	BKYToolboxCategory SelectedCategory { get; set; }

	// @property (nonatomic, strong) UIFont * _Nonnull categoryFont;
	[Export ("categoryFont", ArgumentSemantic.Strong)]
	UIFont CategoryFont { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable selectedCategoryTextColor;
	[NullAllowed, Export ("selectedCategoryTextColor", ArgumentSemantic.Strong)]
	UIColor SelectedCategoryTextColor { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable unselectedCategoryBackgroundColor;
	[NullAllowed, Export ("unselectedCategoryBackgroundColor", ArgumentSemantic.Strong)]
	UIColor UnselectedCategoryBackgroundColor { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable unselectedCategoryTextColor;
	[NullAllowed, Export ("unselectedCategoryTextColor", ArgumentSemantic.Strong)]
	UIColor UnselectedCategoryTextColor { get; set; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	BKYToolboxCategoryListViewControllerDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<BKYToolboxCategoryListViewControllerDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(instancetype _Nonnull)initWithOrientation:(enum BKYToolboxCategoryListViewControllerOrientation)orientation __attribute__((objc_designated_initializer));
	[Export ("initWithOrientation:")]
	[DesignatedInitializer]
	IntPtr Constructor (BKYToolboxCategoryListViewControllerOrientation orientation);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSKeyValueChangeKey,id> * _Nullable)change context:(void * _Nullable)context;
	[Export ("observeValueForKeyPath:ofObject:change:context:")]
	unsafe void ObserveValueForKeyPath ([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, [NullAllowed] void* context);

	// -(void)refreshView;
	[Export ("refreshView")]
	void RefreshView ();

	// -(NSInteger)numberOfSectionsInCollectionView:(UICollectionView * _Nonnull)collectionView __attribute__((warn_unused_result));
	[Export ("numberOfSectionsInCollectionView:")]
	nint NumberOfSectionsInCollectionView (UICollectionView collectionView);

	// -(NSInteger)collectionView:(UICollectionView * _Nonnull)collectionView numberOfItemsInSection:(NSInteger)section __attribute__((warn_unused_result));
	[Export ("collectionView:numberOfItemsInSection:")]
	nint CollectionView (UICollectionView collectionView, nint section);

	// -(UICollectionViewCell * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView cellForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
	[Export ("collectionView:cellForItemAtIndexPath:")]
	UICollectionViewCell CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

//	// -(void)collectionView:(UICollectionView * _Nonnull)collectionView didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
//	[Export ("collectionView:didSelectItemAtIndexPath:")]
//	void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

	// -(CGSize)collectionView:(UICollectionView * _Nonnull)collectionView layout:(UICollectionViewLayout * _Nonnull)collectionViewLayout sizeForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
	[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
	CGSize CollectionView (UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, NSIndexPath indexPath);
}

// @protocol BKYToolboxCategoryListViewControllerDelegate
[Protocol, Model]
interface BKYToolboxCategoryListViewControllerDelegate
{
    // @required -(void)toolboxCategoryListViewController:(BKYToolboxCategoryListViewController * _Nonnull)controller didSelectCategory:(BKYToolboxCategory * _Nonnull)category;
    [Abstract]
    [Export("toolboxCategoryListViewController:didSelectCategory:")]
    void ToolboxCategoryListViewController(BKYToolboxCategoryListViewController controller, BKYToolboxCategory category);

    // @required -(void)toolboxCategoryListViewControllerDidDeselectCategory:(BKYToolboxCategoryListViewController * _Nonnull)controller;
    [Abstract]
    [Export("toolboxCategoryListViewControllerDidDeselectCategory:")]
    void ToolboxCategoryListViewControllerDidDeselectCategory(BKYToolboxCategoryListViewController controller);
}

// @interface BKYToolboxCategoryViewController : UIViewController <BKYNameManagerListener>
[BaseType (typeof(UIViewController))]
interface BKYToolboxCategoryViewController : IBKYNameManagerListener
{
	// @property (nonatomic, strong) BKYToolboxLayout * _Nullable toolboxLayout;
	[NullAllowed, Export ("toolboxLayout", ArgumentSemantic.Strong)]
	BKYToolboxLayout ToolboxLayout { get; set; }

	// @property (readonly, nonatomic, strong) BKYToolboxCategory * _Nullable category;
	[NullAllowed, Export ("category", ArgumentSemantic.Strong)]
	BKYToolboxCategory Category { get; }

	// @property (nonatomic, strong) UIView * _Nonnull headerView;
	[Export ("headerView", ArgumentSemantic.Strong)]
	UIView HeaderView { get; set; }

	// @property (nonatomic, strong) UIView * _Nonnull footerView;
	[Export ("footerView", ArgumentSemantic.Strong)]
	UIView FooterView { get; set; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	BKYWorkspaceViewControllerDelegate Delegate { get; set; }

	// @property (nonatomic, strong) id<BKYWorkspaceViewControllerDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
	NSObject WeakDelegate { get; set; }

	// @property (readonly, nonatomic, strong) BKYWorkspaceScrollView * _Nonnull workspaceScrollView;
	[Export ("workspaceScrollView", ArgumentSemantic.Strong)]
	BKYWorkspaceScrollView WorkspaceScrollView { get; }

	// -(instancetype _Nonnull)initWithViewFactory:(BKYViewFactory * _Nonnull)viewFactory orientation:(enum BKYToolboxCategoryListViewControllerOrientation)orientation variableNameManager:(BKYNameManager * _Nullable)variableNameManager __attribute__((objc_designated_initializer));
	[Export ("initWithViewFactory:orientation:variableNameManager:")]
	[DesignatedInitializer]
	IntPtr Constructor (BKYViewFactory viewFactory, BKYToolboxCategoryListViewControllerOrientation orientation, [NullAllowed] BKYNameManager variableNameManager);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)showCategory:(BKYToolboxCategory * _Nonnull)category animated:(BOOL)animated;
	[Export ("showCategory:animated:")]
	void ShowCategory (BKYToolboxCategory category, bool animated);

	// -(void)hideCategoryWithAnimated:(BOOL)animated;
	[Export ("hideCategoryWithAnimated:")]
	void HideCategoryWithAnimated (bool animated);

	// -(void)didTapAddButton:(UIButton * _Nonnull)_;
	[Export ("didTapAddButton:")]
	void DidTapAddButton (UIButton _);

	// -(void)nameManager:(BKYNameManager * _Nonnull)nameManager didAddName:(NSString * _Nonnull)name;
	[Export ("nameManager:didAddName:")]
	void NameManager (BKYNameManager nameManager, string name);

	// -(void)nameManager:(BKYNameManager * _Nonnull)nameManager didRenameName:(NSString * _Nonnull)oldName toName:(NSString * _Nonnull)newName;
	[Export ("nameManager:didRenameName:toName:")]
	void NameManager (BKYNameManager nameManager, string oldName, string newName);

	// -(void)nameManager:(BKYNameManager * _Nonnull)nameManager didRemoveName:(NSString * _Nonnull)name;
	[Export ("nameManager:didRemoveName:")]
	void NameManager (BKYNameManager nameManager, string name);
}

// @interface BKYToolboxLayout : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYToolboxLayout
{
    // @property (readonly, nonatomic, strong) BKYToolbox * _Nonnull toolbox;
    [Export("toolbox", ArgumentSemantic.Strong)]
    BKYToolbox Toolbox { get; }

    // @property (readonly, nonatomic) enum BKYWorkspaceFlowLayoutDirection layoutDirection;
    [Export("layoutDirection")]
    BKYWorkspaceFlowLayoutDirection LayoutDirection { get; }

    // @property (readonly, nonatomic, strong) BKYLayoutEngine * _Nonnull engine;
    [Export("engine", ArgumentSemantic.Strong)]
    BKYLayoutEngine Engine { get; }

    // @property (readonly, nonatomic, strong) BKYLayoutBuilder * _Nonnull layoutBuilder;
    [Export("layoutBuilder", ArgumentSemantic.Strong)]
    BKYLayoutBuilder LayoutBuilder { get; }

    // @property (copy, nonatomic) NSArray<BKYWorkspaceLayoutCoordinator *> * _Nonnull categoryLayoutCoordinators;
    [Export("categoryLayoutCoordinators", ArgumentSemantic.Copy)]
    BKYWorkspaceLayoutCoordinator[] CategoryLayoutCoordinators { get; set; }

    // -(instancetype _Nonnull)initWithToolbox:(BKYToolbox * _Nonnull)toolbox engine:(BKYLayoutEngine * _Nonnull)engine layoutDirection:(enum BKYWorkspaceFlowLayoutDirection)layoutDirection layoutBuilder:(BKYLayoutBuilder * _Nonnull)layoutBuilder __attribute__((objc_designated_initializer));
    [Export("initWithToolbox:engine:layoutDirection:layoutBuilder:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYToolbox toolbox, BKYLayoutEngine engine, BKYWorkspaceFlowLayoutDirection layoutDirection, BKYLayoutBuilder layoutBuilder);

    // -(void)setBlockFactory:(BKYBlockFactory * _Nullable)blockFactory;
    [Export("setBlockFactory:")]
    void SetBlockFactory([NullAllowed] BKYBlockFactory blockFactory);
}

// @interface BKYTrashCanView : UIView
[BaseType(typeof(UIView))]
interface BKYTrashCanView
{
    // @property (readonly, nonatomic, strong) UIButton * _Nonnull button;
    [Export("button", ArgumentSemantic.Strong)]
    UIButton Button { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)setButtonPaddingWithTop:(CGFloat)top leading:(CGFloat)leading bottom:(CGFloat)bottom trailing:(CGFloat)trailing;
    [Export("setButtonPaddingWithTop:leading:bottom:trailing:")]
    void SetButtonPaddingWithTop(nfloat top, nfloat leading, nfloat bottom, nfloat trailing);

    // -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
    [Export("setHighlighted:animated:")]
    void SetHighlighted(bool highlighted, bool animated);
}

// @interface BKYWorkspaceViewController : UIViewController
[BaseType(typeof(UIViewController))]
interface BKYWorkspaceViewController
{
    // @property (readonly, nonatomic, strong) BKYWorkspaceLayoutCoordinator * _Nullable workspaceLayoutCoordinator;
    [NullAllowed, Export("workspaceLayoutCoordinator", ArgumentSemantic.Strong)]
    BKYWorkspaceLayoutCoordinator WorkspaceLayoutCoordinator { get; }

    // @property (readonly, nonatomic, strong) BKYWorkspaceLayout * _Nullable workspaceLayout;
    [NullAllowed, Export("workspaceLayout", ArgumentSemantic.Strong)]
    BKYWorkspaceLayout WorkspaceLayout { get; }

    // @property (readonly, nonatomic, strong) BKYWorkspace * _Nullable workspace;
    [NullAllowed, Export("workspace", ArgumentSemantic.Strong)]
    BKYWorkspace Workspace { get; }

    // @property (nonatomic, strong) BKYWorkspaceView * _Nonnull workspaceView;
    [Export("workspaceView", ArgumentSemantic.Strong)]
    BKYWorkspaceView WorkspaceView { get; set; }

    [Wrap("WeakDelegate")]
    [NullAllowed]
    BKYWorkspaceViewControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<BKYWorkspaceViewControllerDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // -(instancetype _Nonnull)initWithViewFactory:(BKYViewFactory * _Nonnull)viewFactory __attribute__((objc_designated_initializer));
    [Export("initWithViewFactory:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYViewFactory viewFactory);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)loadView;
    [Export("loadView")]
    void LoadView();

    // -(void)presentViewController:(UIViewController * _Nonnull)viewControllerToPresent animated:(BOOL)flag completion:(void (^ _Nullable)(void))completion;
    [Export("presentViewController:animated:completion:")]
    void PresentViewController(UIViewController viewControllerToPresent, bool flag, [NullAllowed] Action completion);

    // -(BOOL)loadWorkspaceLayoutCoordinator:(BKYWorkspaceLayoutCoordinator * _Nullable)workspaceLayoutCoordinator error:(NSError * _Nullable * _Nullable)error;
    [Export("loadWorkspaceLayoutCoordinator:error:")]
    bool LoadWorkspaceLayoutCoordinator([NullAllowed] BKYWorkspaceLayoutCoordinator workspaceLayoutCoordinator, [NullAllowed] out NSError error);
}

// @interface BKYTrashCanViewController : BKYWorkspaceViewController
[BaseType(typeof(BKYWorkspaceViewController))]
interface BKYTrashCanViewController
{
    // @property (readonly, nonatomic, strong) BKYLayoutEngine * _Nonnull engine;
    [Export("engine", ArgumentSemantic.Strong)]
    BKYLayoutEngine Engine { get; }

    // @property (readonly, nonatomic) enum BKYWorkspaceFlowLayoutDirection layoutDirection;
    [Export("layoutDirection")]
    BKYWorkspaceFlowLayoutDirection LayoutDirection { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)viewDidLoad;
    [Export("viewDidLoad")]
    void ViewDidLoad();

    // -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSKeyValueChangeKey,id> * _Nullable)change context:(void * _Nullable)context;
    [Export("observeValueForKeyPath:ofObject:change:context:")]
    unsafe void ObserveValueForKeyPath([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, [NullAllowed] IntPtr context);

    // -(void)setWorkspaceViewHeight:(CGFloat)height animated:(BOOL)animated;
    [Export("setWorkspaceViewHeight:animated:")]
    void SetWorkspaceViewHeight(nfloat height, bool animated);

    // -(void)setWorkspaceViewWidth:(CGFloat)width animated:(BOOL)animated;
    [Export("setWorkspaceViewWidth:animated:")]
    void SetWorkspaceViewWidth(nfloat width, bool animated);
}

// @interface BKYViewBuilder : NSObject <BKYLayoutHierarchyListener>
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface BKYViewBuilder : BKYLayoutHierarchyListener
    {
        // @property (readonly, nonatomic, strong) BKYViewFactory * _Nonnull viewFactory;
        [Export ("viewFactory", ArgumentSemantic.Strong)]
        BKYViewFactory ViewFactory { get; }

        [Wrap ("WeakDelegate")]
        [NullAllowed]
        BKYViewBuilderDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<BKYViewBuilderDelegate> _Nullable delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithViewFactory:(BKYViewFactory * _Nonnull)viewFactory __attribute__((objc_designated_initializer));
        [Export ("initWithViewFactory:")]
        [DesignatedInitializer]
        IntPtr Constructor (BKYViewFactory viewFactory);

        // -(BOOL)buildViewTreeForWorkspaceView:(BKYWorkspaceView * _Nonnull)workspaceView error:(NSError * _Nullable * _Nullable)error;
        [Export ("buildViewTreeForWorkspaceView:error:")]
        bool BuildViewTreeForWorkspaceView (BKYWorkspaceView workspaceView, [NullAllowed] out NSError error);

        // -(void)layout:(BKYLayout * _Nonnull)layout didAdoptChildLayout:(BKYLayout * _Nonnull)childLayout fromOldParentLayout:(BKYLayout * _Nullable)oldParentLayout;
        [Export ("layout:didAdoptChildLayout:fromOldParentLayout:")]
        void Layout (BKYLayout layout, BKYLayout childLayout, [NullAllowed] BKYLayout oldParentLayout);

        // -(void)layout:(BKYLayout * _Nonnull)layout didRemoveChildLayout:(BKYLayout * _Nonnull)childLayout;
        [Export ("layout:didRemoveChildLayout:")]
        void Layout (BKYLayout layout, BKYLayout childLayout);
    }

// @interface Blockly_Swift_6071 (BKYViewBuilder) <BKYLayoutHierarchyListener>
[Category]
[BaseType(typeof(BKYViewBuilder))]
interface BKYViewBuilder_Blockly_Swift_6071 : BKYLayoutHierarchyListener
{
    // -(void)layout:(BKYLayout * _Nonnull)layout didAdoptChildLayout:(BKYLayout * _Nonnull)childLayout fromOldParentLayout:(BKYLayout * _Nullable)oldParentLayout;
    [Export("layout:didAdoptChildLayout:fromOldParentLayout:")]
    void Layout(BKYLayout layout, BKYLayout childLayout, [NullAllowed] BKYLayout oldParentLayout);

    // -(void)layout:(BKYLayout * _Nonnull)layout didRemoveChildLayout:(BKYLayout * _Nonnull)childLayout;
    [Export("layout:didRemoveChildLayout:")]
    void Layout(BKYLayout layout, BKYLayout childLayout);
}

// @protocol BKYViewBuilderDelegate
[Protocol, Model]
interface BKYViewBuilderDelegate
{
    // @required -(void)viewBuilder:(BKYViewBuilder * _Nonnull)viewBuilder didAddChild:(UIView * _Nonnull)childView toParent:(UIView * _Nonnull)parentView;
    [Abstract]
    [Export("viewBuilder:didAddChild:toParent:")]
    void DidAddChild(BKYViewBuilder viewBuilder, UIView childView, UIView parentView);

    // @required -(void)viewBuilder:(BKYViewBuilder * _Nonnull)viewBuilder didRemoveChild:(UIView * _Nonnull)childView fromParent:(UIView * _Nonnull)parentView;
    [Abstract]
    [Export("viewBuilder:didRemoveChild:fromParent:")]
    void DidRemoveChild(BKYViewBuilder viewBuilder, UIView childView, UIView parentView);
}

// @interface BKYViewFactory : NSObject
[BaseType(typeof(NSObject))]
interface BKYViewFactory
{
    // -(BKYLayoutView * _Nullable)makeViewWithLayout:(BKYLayout * _Nonnull)layout error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("makeViewWithLayout:error:")]
    [return: NullAllowed]
    BKYLayoutView MakeViewWithLayout(BKYLayout layout, [NullAllowed] out NSError error);

    // -(void)registerLayoutType:(Class _Nonnull)layoutType withViewType:(Class _Nonnull)viewType;
    [Export("registerLayoutType:withViewType:")]
    void RegisterLayoutType(Class layoutType, Class viewType);

    // -(void)recycleView:(UIView * _Nonnull)view;
    [Export("recycleView:")]
    void RecycleView(UIView view);

    // -(void)recycleViewTree:(UIView * _Nonnull)rootView;
    [Export("recycleViewTree:")]
    void RecycleViewTree(UIView rootView);
}

// @interface BKYViewManager : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYViewManager
{
    // @property (readonly, nonatomic, strong, class) BKYViewManager * _Nonnull shared;
    [Static]
    [Export("shared", ArgumentSemantic.Strong)]
    BKYViewManager Shared { get; }

//    // @property (readonly, nonatomic, strong) NSMapTable<NSString *,BKYLayoutView *> * _Nonnull views;
//    [Export("views", ArgumentSemantic.Strong)]
//    NSMapTable<NSString, BKYLayoutView> Views { get; }

    // -(void)cacheView:(BKYLayoutView * _Nonnull)layoutView forLayout:(BKYLayout * _Nonnull)layout;
    [Export("cacheView:forLayout:")]
    void CacheView(BKYLayoutView layoutView, BKYLayout layout);

    // -(void)uncacheViewForLayout:(BKYLayout * _Nonnull)layout;
    [Export("uncacheViewForLayout:")]
    void UncacheViewForLayout(BKYLayout layout);

    // -(BKYBlockView * _Nullable)findBlockViewForLayout:(BKYBlockLayout * _Nonnull)layout __attribute__((warn_unused_result));
    [Export("findBlockViewForLayout:")]
    [return: NullAllowed]
    BKYBlockView FindBlockViewForLayout(BKYBlockLayout layout);

    // -(BKYFieldView * _Nullable)findFieldViewForLayout:(BKYFieldLayout * _Nonnull)layout __attribute__((warn_unused_result));
    [Export("findFieldViewForLayout:")]
    [return: NullAllowed]
    BKYFieldView FindFieldViewForLayout(BKYFieldLayout layout);

    // -(BKYLayoutView * _Nullable)findViewForLayout:(BKYLayout * _Nonnull)layout __attribute__((warn_unused_result));
    [Export("findViewForLayout:")]
    [return: NullAllowed]
    BKYLayoutView FindViewForLayout(BKYLayout layout);
}

// @interface BKYWorkbenchViewController : UIViewController <BKYBlocklyPanGestureRecognizerDelegate, BKYEventManagerListener, BKYToolboxCategoryListViewControllerDelegate, BKYWorkspaceViewControllerDelegate, UIGestureRecognizerDelegate>
[BaseType (typeof(UIViewController))]
interface BKYWorkbenchViewController : BKYBlocklyPanGestureRecognizerDelegate, BKYEventManagerListener, BKYToolboxCategoryListViewControllerDelegate, BKYWorkspaceViewControllerDelegate, IUIGestureRecognizerDelegate
{
	// @property (readonly, nonatomic) NSInteger stateTrashCanOpen;
	[Export ("stateTrashCanOpen")]
	nint StateTrashCanOpen { get; }

	// @property (readonly, nonatomic) NSInteger stateTrashCanHighlighted;
	[Export ("stateTrashCanHighlighted")]
	nint StateTrashCanHighlighted { get; }

	// @property (readonly, nonatomic) NSInteger stateCategoryOpen;
	[Export ("stateCategoryOpen")]
	nint StateCategoryOpen { get; }

	// @property (readonly, nonatomic) NSInteger stateEditingTextField;
	[Export ("stateEditingTextField")]
	nint StateEditingTextField { get; }

	// @property (readonly, nonatomic) NSInteger stateDraggingBlock;
	[Export ("stateDraggingBlock")]
	nint StateDraggingBlock { get; }

	// @property (readonly, nonatomic) NSInteger statePresentingPopover;
	[Export ("statePresentingPopover")]
	nint StatePresentingPopover { get; }

	// @property (readonly, nonatomic) NSInteger stateDidPanWorkspace;
	[Export ("stateDidPanWorkspace")]
	nint StateDidPanWorkspace { get; }

	// @property (readonly, nonatomic) NSInteger stateDidTapWorkspace;
	[Export ("stateDidTapWorkspace")]
	nint StateDidTapWorkspace { get; }

	// @property (readonly, nonatomic, strong) BKYWorkspaceViewController * _Nonnull workspaceViewController;
	[Export ("workspaceViewController", ArgumentSemantic.Strong)]
	BKYWorkspaceViewController WorkspaceViewController { get; }

	// @property (readonly, nonatomic, strong) BKYTrashCanView * _Nonnull trashCanView;
	[Export ("trashCanView", ArgumentSemantic.Strong)]
	BKYTrashCanView TrashCanView { get; }

	// @property (readonly, nonatomic, strong) UIButton * _Nonnull undoButton;
	[Export ("undoButton", ArgumentSemantic.Strong)]
	UIButton UndoButton { get; }

	// @property (readonly, nonatomic, strong) UIButton * _Nonnull redoButton;
	[Export ("redoButton", ArgumentSemantic.Strong)]
	UIButton RedoButton { get; }

	// @property (readonly, nonatomic, strong) BKYToolboxCategoryViewController * _Nonnull toolboxCategoryViewController;
	[Export ("toolboxCategoryViewController", ArgumentSemantic.Strong)]
	BKYToolboxCategoryViewController ToolboxCategoryViewController { get; }

	// @property (readonly, nonatomic, strong) BKYLayoutEngine * _Nonnull engine;
	[Export ("engine", ArgumentSemantic.Strong)]
	BKYLayoutEngine Engine { get; }

	// @property (readonly, nonatomic, strong) BKYLayoutBuilder * _Nonnull layoutBuilder;
	[Export ("layoutBuilder", ArgumentSemantic.Strong)]
	BKYLayoutBuilder LayoutBuilder { get; }

	// @property (readonly, nonatomic, strong) BKYBlockFactory * _Nonnull blockFactory;
	[Export ("blockFactory", ArgumentSemantic.Strong)]
	BKYBlockFactory BlockFactory { get; }

	// @property (readonly, nonatomic, strong) BKYViewFactory * _Nonnull viewFactory;
	[Export ("viewFactory", ArgumentSemantic.Strong)]
	BKYViewFactory ViewFactory { get; }

	// @property (readonly, nonatomic) enum BKYWorkbenchViewControllerStyle style;
	[Export ("style")]
	BKYWorkbenchViewControllerStyle Style { get; }

	// @property (readonly, nonatomic, strong) BKYWorkspace * _Nullable workspace;
	[NullAllowed, Export ("workspace", ArgumentSemantic.Strong)]
	BKYWorkspace Workspace { get; }

	// @property (readonly, nonatomic, strong) BKYToolbox * _Nullable toolbox;
	[NullAllowed, Export ("toolbox", ArgumentSemantic.Strong)]
	BKYToolbox Toolbox { get; }

	// @property (readonly, nonatomic, strong) BKYNameManager * _Nonnull variableNameManager;
	[Export ("variableNameManager", ArgumentSemantic.Strong)]
	BKYNameManager VariableNameManager { get; }

	// @property (nonatomic, strong) BKYProcedureCoordinator * _Nullable procedureCoordinator;
	[NullAllowed, Export ("procedureCoordinator", ArgumentSemantic.Strong)]
	BKYProcedureCoordinator ProcedureCoordinator { get; set; }

	// @property (nonatomic) BOOL enableTrashCan;
	[Export ("enableTrashCan")]
	bool EnableTrashCan { get; set; }

	// @property (nonatomic) BOOL keepTrashedBlocks;
	[Export ("keepTrashedBlocks")]
	bool KeepTrashedBlocks { get; set; }

	// @property (nonatomic) BOOL allowZoom;
	[Export ("allowZoom")]
	bool AllowZoom { get; set; }

	// @property (nonatomic) BOOL allowUndoRedo;
	[Export ("allowUndoRedo")]
	bool AllowUndoRedo { get; set; }

	// @property (nonatomic) BOOL allowInteractivePopGestureRecognizer;
	[Export ("allowInteractivePopGestureRecognizer")]
	bool AllowInteractivePopGestureRecognizer { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable workspaceBackgroundColor;
	[NullAllowed, Export ("workspaceBackgroundColor", ArgumentSemantic.Strong)]
	UIColor WorkspaceBackgroundColor { get; set; }

	// @property (nonatomic) BOOL toolboxDrawerStaysOpen;
	[Export ("toolboxDrawerStaysOpen")]
	bool ToolboxDrawerStaysOpen { get; set; }

	// @property (readonly, copy, nonatomic) NSSet<NSNumber *> * _Nonnull state;
	[Export ("state", ArgumentSemantic.Copy)]
	NSSet<NSNumber> State { get; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	BKYWorkbenchViewControllerDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<BKYWorkbenchViewControllerDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (readonly, nonatomic, strong) BKYToolboxCategoryListViewController * _Nonnull toolboxCategoryListViewController;
	[Export ("toolboxCategoryListViewController", ArgumentSemantic.Strong)]
	BKYToolboxCategoryListViewController ToolboxCategoryListViewController { get; }

	// @property (readonly, nonatomic, strong) BKYTrashCanViewController * _Nonnull trashCanViewController;
	[Export ("trashCanViewController", ArgumentSemantic.Strong)]
	BKYTrashCanViewController TrashCanViewController { get; }

	// @property (readonly, nonatomic) BOOL shouldRecordEvents;
	[Export ("shouldRecordEvents")]
	bool ShouldRecordEvents { get; }

	// @property (copy, nonatomic) NSArray<BKYEvent *> * _Nonnull undoStack;
	[Export ("undoStack", ArgumentSemantic.Copy)]
	BKYEvent[] UndoStack { get; set; }

	// @property (copy, nonatomic) NSArray<BKYEvent *> * _Nonnull redoStack;
	[Export ("redoStack", ArgumentSemantic.Copy)]
	BKYEvent[] RedoStack { get; set; }

	// @property (readonly, nonatomic, strong) UIPanGestureRecognizer * _Null_unspecified workspacePanGesetureRecognizer;
	[Export ("workspacePanGesetureRecognizer", ArgumentSemantic.Strong)]
	UIPanGestureRecognizer WorkspacePanGesetureRecognizer { get; }

	// @property (readonly, nonatomic, strong) UITapGestureRecognizer * _Nonnull workspaceTapGestureRecognizer;
	[Export ("workspaceTapGestureRecognizer", ArgumentSemantic.Strong)]
	UITapGestureRecognizer WorkspaceTapGestureRecognizer { get; }

	// -(instancetype _Nonnull)initWithStyle:(enum BKYWorkbenchViewControllerStyle)style __attribute__((objc_designated_initializer));
	[Export ("initWithStyle:")]
	[DesignatedInitializer]
	IntPtr Constructor (BKYWorkbenchViewControllerStyle style);

	// -(instancetype _Nonnull)initWithStyle:(enum BKYWorkbenchViewControllerStyle)style engine:(BKYLayoutEngine * _Nonnull)engine layoutBuilder:(BKYLayoutBuilder * _Nonnull)layoutBuilder blockFactory:(BKYBlockFactory * _Nonnull)blockFactory viewFactory:(BKYViewFactory * _Nonnull)viewFactory variableNameManager:(BKYNameManager * _Nonnull)variableNameManager procedureCoordinator:(BKYProcedureCoordinator * _Nonnull)procedureCoordinator __attribute__((objc_designated_initializer));
	[Export ("initWithStyle:engine:layoutBuilder:blockFactory:viewFactory:variableNameManager:procedureCoordinator:")]
	[DesignatedInitializer]
	IntPtr Constructor (BKYWorkbenchViewControllerStyle style, BKYLayoutEngine engine, BKYLayoutBuilder layoutBuilder, BKYBlockFactory blockFactory, BKYViewFactory viewFactory, BKYNameManager variableNameManager, BKYProcedureCoordinator procedureCoordinator);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)loadView;
	[Export ("loadView")]
	void LoadView ();

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)viewDidAppear:(BOOL)animated;
	[Export ("viewDidAppear:")]
	void ViewDidAppear (bool animated);

	// -(void)viewWillDisappear:(BOOL)animated;
	[Export ("viewWillDisappear:")]
	void ViewWillDisappear (bool animated);

	// -(BOOL)loadWorkspace:(BKYWorkspace * _Nonnull)workspace error:(NSError * _Nullable * _Nullable)error;
	[Export ("loadWorkspace:error:")]
	bool LoadWorkspace (BKYWorkspace workspace, [NullAllowed] out NSError error);

	// -(BOOL)loadWorkspace:(BKYWorkspace * _Nonnull)workspace connectionManager:(BKYConnectionManager * _Nonnull)connectionManager error:(NSError * _Nullable * _Nullable)error;
	[Export ("loadWorkspace:connectionManager:error:")]
	bool LoadWorkspace (BKYWorkspace workspace, BKYConnectionManager connectionManager, [NullAllowed] out NSError error);

	// -(BOOL)loadToolbox:(BKYToolbox * _Nonnull)toolbox error:(NSError * _Nullable * _Nullable)error;
	[Export ("loadToolbox:error:")]
	bool LoadToolbox (BKYToolbox toolbox, [NullAllowed] out NSError error);

	// -(void)refreshView;
	[Export ("refreshView")]
	void RefreshView ();

	// -(void)workspaceViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController didAddBlockView:(BKYBlockView * _Nonnull)blockView;
	[Export ("workspaceViewController:didAddBlockView:")]
	void WorkspaceViewController (BKYWorkspaceViewController workspaceViewController, BKYBlockView blockView);

	// -(void)workspaceViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController didRemoveBlockView:(BKYBlockView * _Nonnull)blockView;
	[Export ("workspaceViewController:didRemoveBlockView:")]
	void WorkspaceViewController (BKYWorkspaceViewController workspaceViewController, BKYBlockView blockView);

	// -(void)workspaceViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController willPresentViewController:(UIViewController * _Nonnull)viewController;
	[Export ("workspaceViewController:willPresentViewController:")]
	void WorkspaceViewController (BKYWorkspaceViewController workspaceViewController, UIViewController viewController);

	// -(void)workspaceViewControllerDismissedViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController;
	[Export ("workspaceViewControllerDismissedViewController:")]
	void WorkspaceViewControllerDismissedViewController (BKYWorkspaceViewController workspaceViewController);

	// -(void)toolboxCategoryListViewController:(BKYToolboxCategoryListViewController * _Nonnull)controller didSelectCategory:(BKYToolboxCategory * _Nonnull)category;
	[Export ("toolboxCategoryListViewController:didSelectCategory:")]
	void ToolboxCategoryListViewController (BKYToolboxCategoryListViewController controller, BKYToolboxCategory category);

	// -(void)toolboxCategoryListViewControllerDidDeselectCategory:(BKYToolboxCategoryListViewController * _Nonnull)controller;
	[Export ("toolboxCategoryListViewControllerDidDeselectCategory:")]
	void ToolboxCategoryListViewControllerDidDeselectCategory (BKYToolboxCategoryListViewController controller);

	// -(void)blocklyPanGestureRecognizer:(BKYBlocklyPanGestureRecognizer * _Nonnull)gesture didTouchBlock:(BKYBlockView * _Nonnull)block touch:(UITouch * _Nonnull)touch touchState:(enum BKYBlocklyPanGestureRecognizerTouchState)touchState;
	[Export ("blocklyPanGestureRecognizer:didTouchBlock:touch:touchState:")]
	void BlocklyPanGestureRecognizer (BKYBlocklyPanGestureRecognizer gesture, BKYBlockView block, UITouch touch, BKYBlocklyPanGestureRecognizerTouchState touchState);

	// -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer __attribute__((warn_unused_result));
	[Export ("gestureRecognizerShouldBegin:")]
	bool GestureRecognizerShouldBegin (UIGestureRecognizer gestureRecognizer);

	// -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldBeRequiredToFailByGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result));
	[Export ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:")]
	bool GestureRecognizer (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);

	// -(void)eventManager:(BKYEventManager * _Nonnull)eventManager didFireEvent:(BKYEvent * _Nonnull)event;
	[Export ("eventManager:didFireEvent:")]
	void EventManager (BKYEventManager eventManager, BKYEvent @event);
}
// @interface Blockly_Swift_6384 (BKYWorkbenchViewController)
[Category]
[BaseType(typeof(BKYWorkbenchViewController))]
interface BKYWorkbenchViewController_Blockly_Swift_6384
{
    // -(void)scrollBlockIntoViewWithBlockUUID:(NSString * _Nonnull)blockUUID location:(enum BKYWorkspaceViewLocation)location animated:(BOOL)animated;
    [Export("scrollBlockIntoViewWithBlockUUID:location:animated:")]
    void ScrollBlockIntoViewWithBlockUUID(string blockUUID, BKYWorkspaceViewLocation location, bool animated);

    // -(void)setViewportTo:(enum BKYWorkspaceViewLocation)location animated:(BOOL)animated;
    [Export("setViewportTo:animated:")]
    void SetViewportTo(BKYWorkspaceViewLocation location, bool animated);
}

// @interface Blockly_Swift_6406 (BKYWorkbenchViewController)
[Category]
[BaseType(typeof(BKYWorkbenchViewController))]
interface BKYWorkbenchViewController_Blockly_Swift_6406
{
    // -(void)addGestureTrackingForBlockView:(BKYBlockView * _Nonnull)blockView;
    [Export("addGestureTrackingForBlockView:")]
    void AddGestureTrackingForBlockView(BKYBlockView blockView);

    // -(void)removeGestureTrackingForBlockView:(BKYBlockView * _Nonnull)blockView;
    [Export("removeGestureTrackingForBlockView:")]
    void RemoveGestureTrackingForBlockView(BKYBlockView blockView);
}

// @interface Blockly_Swift_6437 (BKYWorkbenchViewController)
[Category]
[BaseType(typeof(BKYWorkbenchViewController))]
interface BKYWorkbenchViewController_Blockly_Swift_6437
{
    // -(BKYBlockView * _Nullable)copyBlockToWorkspace:(BKYBlockView * _Nonnull)blockView __attribute__((warn_unused_result));
    [Export("copyBlockToWorkspace:")]
    [return: NullAllowed]
    BKYBlockView CopyBlockToWorkspace(BKYBlockView blockView);

    // -(void)addBlockToTrash:(BKYBlock * _Nonnull)block;
    [Export("addBlockToTrash:")]
    void AddBlockToTrash(BKYBlock block);

    // -(void)removeBlockFromTrash:(BKYBlockView * _Nonnull)blockView;
    [Export("removeBlockFromTrash:")]
    void RemoveBlockFromTrash(BKYBlockView blockView);
}

// @interface Blockly_Swift_6458 (BKYWorkbenchViewController)
[Category]
[BaseType(typeof(BKYWorkbenchViewController))]
interface BKYWorkbenchViewController_Blockly_Swift_6458
{
    // +(NSInteger)newUIStateValue __attribute__((warn_unused_result));
    [Static]
    [Export("newUIStateValue")]
    nint NewUIStateValue { get; }

    // -(void)addUIStateValue:(NSInteger)stateValue animated:(BOOL)animated;
    [Export("addUIStateValue:animated:")]
    void AddUIStateValue(nint stateValue, bool animated);

    // -(void)removeUIStateValue:(NSInteger)stateValue animated:(BOOL)animated;
    [Export("removeUIStateValue:animated:")]
    void RemoveUIStateValue(nint stateValue, bool animated);
}

// @interface Blockly_Swift_6488 (BKYWorkbenchViewController)
[Category]
[BaseType(typeof(BKYWorkbenchViewController))]
interface BKYWorkbenchViewController_Blockly_Swift_6488
{
    // -(void)highlightBlockWithBlockUUID:(NSString * _Nonnull)blockUUID;
    [Export("highlightBlockWithBlockUUID:")]
    void HighlightBlockWithBlockUUID(string blockUUID);

    // -(void)unhighlightBlockWithBlockUUID:(NSString * _Nonnull)blockUUID;
    [Export("unhighlightBlockWithBlockUUID:")]
    void UnhighlightBlockWithBlockUUID(string blockUUID);

    // -(void)unhighlightAllBlocks;
    [Export("unhighlightAllBlocks")]
    void UnhighlightAllBlocks();
}

// @protocol BKYWorkspaceViewControllerDelegate
[Protocol, Model]
interface BKYWorkspaceViewControllerDelegate
{
    // @required -(void)workspaceViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController didAddBlockView:(BKYBlockView * _Nonnull)blockView;
    [Abstract]
    [Export("workspaceViewController:didAddBlockView:")]
    void WorkspaceViewControllerDidAddBlockView(BKYWorkspaceViewController workspaceViewController, BKYBlockView blockView);

    // @required -(void)workspaceViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController didRemoveBlockView:(BKYBlockView * _Nonnull)blockView;
    [Abstract]
    [Export("workspaceViewController:didRemoveBlockView:")]
    void WorkspaceViewControllerDidRemoveBlockView(BKYWorkspaceViewController workspaceViewController, BKYBlockView blockView);

    // @required -(void)workspaceViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController willPresentViewController:(UIViewController * _Nonnull)viewController;
    [Abstract]
    [Export("workspaceViewController:willPresentViewController:")]
    void WorkspaceViewController(BKYWorkspaceViewController workspaceViewController, UIViewController viewController);

    // @required -(void)workspaceViewControllerDismissedViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController;
    [Abstract]
    [Export("workspaceViewControllerDismissedViewController:")]
    void WorkspaceViewControllerDismissedViewController(BKYWorkspaceViewController workspaceViewController);
}

// @interface Blockly_Swift_6534 (BKYWorkbenchViewController) <BKYWorkspaceViewControllerDelegate>
[Category]
[BaseType(typeof(BKYWorkbenchViewController))]
interface BKYWorkbenchViewController_Blockly_Swift_6534 : BKYWorkspaceViewControllerDelegate
{
    // -(void)workspaceViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController didAddBlockView:(BKYBlockView * _Nonnull)blockView;
    [Export("workspaceViewController:didAddBlockView:")]
    void WorkspaceViewControllerDidAddBlockView(BKYWorkspaceViewController workspaceViewController, BKYBlockView blockView);

    // -(void)workspaceViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController didRemoveBlockView:(BKYBlockView * _Nonnull)blockView;
    [Export("workspaceViewController:didRemoveBlockView:")]
    void WorkspaceViewControllerDidRemoveBlockView(BKYWorkspaceViewController workspaceViewController, BKYBlockView blockView);

    // -(void)workspaceViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController willPresentViewController:(UIViewController * _Nonnull)viewController;
    [Export("workspaceViewController:willPresentViewController:")]
    void WorkspaceViewController(BKYWorkspaceViewController workspaceViewController, UIViewController viewController);

    // -(void)workspaceViewControllerDismissedViewController:(BKYWorkspaceViewController * _Nonnull)workspaceViewController;
    [Export("workspaceViewControllerDismissedViewController:")]
    void WorkspaceViewControllerDismissedViewController(BKYWorkspaceViewController workspaceViewController);
}

// @interface Blockly_Swift_6544 (BKYWorkbenchViewController)
[Category]
[BaseType(typeof(BKYWorkbenchViewController))]
interface BKYWorkbenchViewController_Blockly_Swift_6544
{
    // -(void)updateFromEvent:(BKYEvent * _Nonnull)event runForward:(BOOL)runForward;
    [Export("updateFromEvent:runForward:")]
    void UpdateFromEvent(BKYEvent @event, bool runForward);

    // -(void)updateFromCreateEvent:(BKYEventCreate * _Nonnull)event runForward:(BOOL)runForward;
    [Export("updateFromCreateEvent:runForward:")]
    void UpdateFromCreateEvent(BKYEventCreate @event, bool runForward);

    // -(void)updateFromDeleteEvent:(BKYEventDelete * _Nonnull)event runForward:(BOOL)runForward;
    [Export("updateFromDeleteEvent:runForward:")]
    void UpdateFromDeleteEvent(BKYEventDelete @event, bool runForward);

    // -(void)updateFromMoveEvent:(BKYEventMove * _Nonnull)event runForward:(BOOL)runForward;
    [Export("updateFromMoveEvent:runForward:")]
    void UpdateFromMoveEvent(BKYEventMove @event, bool runForward);

    // -(void)updateFromChangeEvent:(BKYEventChange * _Nonnull)event runForward:(BOOL)runForward;
    [Export("updateFromChangeEvent:runForward:")]
    void UpdateFromChangeEvent(BKYEventChange @event, bool runForward);
}

// @protocol BKYWorkbenchViewControllerDelegate
[Protocol, Model]
interface BKYWorkbenchViewControllerDelegate
{
    // @required -(void)workbenchViewController:(BKYWorkbenchViewController * _Nonnull)workbenchViewController didUpdateState:(NSSet<NSNumber *> * _Nonnull)state;
    [Abstract]
    [Export("workbenchViewController:didUpdateState:")]
    void WorkbenchViewController(BKYWorkbenchViewController workbenchViewController, NSSet<NSNumber> state);

    // @optional -(NSSet<NSNumber *> * _Nonnull)workbenchViewController:(BKYWorkbenchViewController * _Nonnull)workbenchViewController shouldKeepStates:(NSSet<NSNumber *> * _Nonnull)keepStateValues forStateValue:(NSInteger)stateValue __attribute__((warn_unused_result));
    [Export("workbenchViewController:shouldKeepStates:forStateValue:")]
    NSSet<NSNumber> WorkbenchViewController(BKYWorkbenchViewController workbenchViewController, NSSet<NSNumber> keepStateValues, nint stateValue);
}

// @interface Blockly_Swift_6611 (BKYWorkspace)
[Category]
[BaseType(typeof(BKYWorkspace))]
interface BKYWorkspace_Blockly_Swift_6611
{
    // -(BOOL)loadBlocksFromXMLString:(NSString * _Nonnull)xmlString factory:(BKYBlockFactory * _Nonnull)factory error:(NSError * _Nullable * _Nullable)error;
    [Export("loadBlocksFromXMLString:factory:error:")]
    bool LoadBlocksFromXMLString(string xmlString, BKYBlockFactory factory, [NullAllowed] out NSError error);
}

// @interface Blockly_Swift_6626 (BKYWorkspace)
[Category]
[BaseType(typeof(BKYWorkspace))]
interface BKYWorkspace_Blockly_Swift_6626
{
    // -(NSString * _Nullable)toXMLWithError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
    [Export("toXMLWithError:")]
    [return: NullAllowed]
    string ToXMLWithError([NullAllowed] out NSError error);
}

// @interface BKYWorkspaceBezierPath : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface BKYWorkspaceBezierPath
{
    // @property (readonly, nonatomic, strong) UIBezierPath * _Nonnull viewBezierPath;
    [Export("viewBezierPath", ArgumentSemantic.Strong)]
    UIBezierPath ViewBezierPath { get; }

    // @property (readonly, nonatomic) int currentWorkspacePoint;
    [Export("currentWorkspacePoint")]
    int CurrentWorkspacePoint { get; }

    // -(instancetype _Nonnull)initWithEngine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
    [Export("initWithEngine:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYLayoutEngine engine);

    // -(void)addLineTo:(id)point relative:(BOOL)relative;
    [Export("addLineTo:relative:")]
    void AddLineTo(NSObject point, bool relative);

    // -(void)addLineToX:(CGFloat)x y:(CGFloat)y relative:(BOOL)relative;
    [Export("addLineToX:y:relative:")]
    void AddLineToX(nfloat x, nfloat y, bool relative);

    // -(void)addArcWithCenter:(id)center radius:(CGFloat)radius startAngle:(CGFloat)startAngle endAngle:(CGFloat)endAngle clockwise:(BOOL)clockwise relative:(BOOL)relative;
    [Export("addArcWithCenter:radius:startAngle:endAngle:clockwise:relative:")]
    void AddArcWithCenter(NSObject center, nfloat radius, nfloat startAngle, nfloat endAngle, bool clockwise, bool relative);

    // -(void)addCurveTo:(id)endPoint controlPoint1:(id)controlPoint1 controlPoint2:(id)controlPoint2 relative:(BOOL)relative;
    [Export("addCurveTo:controlPoint1:controlPoint2:relative:")]
    void AddCurveTo(NSObject endPoint, NSObject controlPoint1, NSObject controlPoint2, bool relative);

    // -(void)addQuadCurveTo:(id)endPoint controlPoint:(id)controlPoint relative:(BOOL)relative;
    [Export("addQuadCurveTo:controlPoint:relative:")]
    void AddQuadCurveTo(NSObject endPoint, NSObject controlPoint, bool relative);

    // -(void)addSmoothCurveTo:(id)endPoint controlPoint2:(id)controlPoint2 relative:(BOOL)relative;
    [Export("addSmoothCurveTo:controlPoint2:relative:")]
    void AddSmoothCurveTo(NSObject endPoint, NSObject controlPoint2, bool relative);

    // -(void)addSmoothQuadCurveTo:(id)endPoint relative:(BOOL)relative;
    [Export("addSmoothQuadCurveTo:relative:")]
    void AddSmoothQuadCurveTo(NSObject endPoint, bool relative);

    // -(void)append:(BKYWorkspaceBezierPath * _Nonnull)bezierPath;
    [Export("append:")]
    void Append(BKYWorkspaceBezierPath bezierPath);

    // -(void)closePath;
    [Export("closePath")]
    void ClosePath();

    // -(void)moveTo:(id)point relative:(BOOL)relative;
    [Export("moveTo:relative:")]
    void MoveTo(NSObject point, bool relative);

    // -(void)moveToX:(CGFloat)x y:(CGFloat)y relative:(BOOL)relative;
    [Export("moveToX:y:relative:")]
    void MoveToX(nfloat x, nfloat y, bool relative);

    // -(void)removeAllPoints;
    [Export("removeAllPoints")]
    void RemoveAllPoints();
}

// @interface BKYWorkspaceLayout : BKYLayout
[BaseType(typeof(BKYLayout))]
interface BKYWorkspaceLayout
{
    // @property (readonly, nonatomic, strong) BKYWorkspace * _Nonnull workspace;
    [Export("workspace", ArgumentSemantic.Strong)]
    BKYWorkspace Workspace { get; }

    // @property (copy, nonatomic) NSArray<BKYBlockGroupLayout *> * _Nonnull blockGroupLayouts;
    [Export("blockGroupLayouts", ArgumentSemantic.Copy)]
    BKYBlockGroupLayout[] BlockGroupLayouts { get; set; }

    // -(instancetype _Nonnull)initWithWorkspace:(BKYWorkspace * _Nonnull)workspace engine:(BKYLayoutEngine * _Nonnull)engine __attribute__((objc_designated_initializer));
    [Export("initWithWorkspace:engine:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYWorkspace workspace, BKYLayoutEngine engine);

    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);

    // -(void)updateLayoutDownTree;
    [Export("updateLayoutDownTree")]
    void UpdateLayoutDownTree();

    // -(NSArray<BKYBlockLayout *> * _Nonnull)allVisibleBlockLayoutsInWorkspace __attribute__((warn_unused_result));
    [Export("allVisibleBlockLayoutsInWorkspace")]
    BKYBlockLayout[] AllVisibleBlockLayoutsInWorkspace { get; }

    // -(void)appendBlockGroupLayout:(BKYBlockGroupLayout * _Nonnull)blockGroupLayout updateLayout:(BOOL)updateLayout;
    [Export("appendBlockGroupLayout:updateLayout:")]
    void AppendBlockGroupLayout(BKYBlockGroupLayout blockGroupLayout, bool updateLayout);

    // -(void)removeBlockGroupLayout:(BKYBlockGroupLayout * _Nonnull)blockGroupLayout updateLayout:(BOOL)updateLayout;
    [Export("removeBlockGroupLayout:updateLayout:")]
    void RemoveBlockGroupLayout(BKYBlockGroupLayout blockGroupLayout, bool updateLayout);

    // -(void)resetWithUpdateLayout:(BOOL)updateLayout;
    [Export("resetWithUpdateLayout:")]
    void ResetWithUpdateLayout(bool updateLayout);

    // -(void)bringBlockGroupLayoutToFront:(BKYBlockGroupLayout * _Nullable)blockGroupLayout;
    [Export("bringBlockGroupLayoutToFront:")]
    void BringBlockGroupLayoutToFront([NullAllowed] BKYBlockGroupLayout blockGroupLayout);

    // -(void)updateCanvasSize;
    [Export("updateCanvasSize")]
    void UpdateCanvasSize();
}

// @interface BKYWorkspaceFlowLayout : BKYWorkspaceLayout
[BaseType(typeof(BKYWorkspaceLayout))]
interface BKYWorkspaceFlowLayout
{
    // @property (readonly, nonatomic, strong) BKYWorkspaceFlow * _Nonnull workspaceFlow;
    [Export("workspaceFlow", ArgumentSemantic.Strong)]
    BKYWorkspaceFlow WorkspaceFlow { get; }

    // @property (nonatomic) CGFloat maximumLineBlockSize;
    [Export("maximumLineBlockSize")]
    nfloat MaximumLineBlockSize { get; set; }

    // @property (nonatomic) enum BKYWorkspaceFlowLayoutDirection layoutDirection;
    [Export("layoutDirection", ArgumentSemantic.Assign)]
    BKYWorkspaceFlowLayoutDirection LayoutDirection { get; set; }

    // -(instancetype _Nonnull)initWithWorkspace:(BKYWorkspaceFlow * _Nonnull)workspace engine:(BKYLayoutEngine * _Nonnull)engine layoutDirection:(enum BKYWorkspaceFlowLayoutDirection)layoutDirection __attribute__((objc_designated_initializer));
    [Export("initWithWorkspace:engine:layoutDirection:")]
    [DesignatedInitializer]
    IntPtr Constructor(BKYWorkspaceFlow workspace, BKYLayoutEngine engine, BKYWorkspaceFlowLayoutDirection layoutDirection);

    // -(void)performLayoutWithIncludeChildren:(BOOL)includeChildren;
    [Export("performLayoutWithIncludeChildren:")]
    void PerformLayoutWithIncludeChildren(bool includeChildren);
}

// @interface BKYWorkspaceLayoutCoordinator : NSObject <BKYNameManagerListener, BKYWorkspaceListener>
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface BKYWorkspaceLayoutCoordinator : BKYNameManagerListener, BKYWorkspaceListener
{
	// @property (readonly, nonatomic, strong) BKYWorkspaceLayout * _Nonnull workspaceLayout;
	[Export ("workspaceLayout", ArgumentSemantic.Strong)]
	BKYWorkspaceLayout WorkspaceLayout { get; }

	// @property (readonly, nonatomic, strong) BKYLayoutBuilder * _Nonnull layoutBuilder;
	[Export ("layoutBuilder", ArgumentSemantic.Strong)]
	BKYLayoutBuilder LayoutBuilder { get; }

	// @property (readonly, nonatomic, strong) BKYConnectionManager * _Nullable connectionManager;
	[NullAllowed, Export ("connectionManager", ArgumentSemantic.Strong)]
	BKYConnectionManager ConnectionManager { get; }

	// @property (readonly, nonatomic, strong) BKYBlockBumper * _Nonnull blockBumper;
	[Export ("blockBumper", ArgumentSemantic.Strong)]
	BKYBlockBumper BlockBumper { get; }

	// @property (nonatomic, weak) BKYNameManager * _Nullable variableNameManager;
	[NullAllowed, Export ("variableNameManager", ArgumentSemantic.Weak)]
	BKYNameManager VariableNameManager { get; set; }

	// @property (nonatomic, strong) BKYBlockFactory * _Nullable blockFactory;
	[NullAllowed, Export ("blockFactory", ArgumentSemantic.Strong)]
	BKYBlockFactory BlockFactory { get; set; }

	// -(instancetype _Nullable)initWithWorkspaceLayout:(BKYWorkspaceLayout * _Nonnull)workspaceLayout layoutBuilder:(BKYLayoutBuilder * _Nonnull)layoutBuilder connectionManager:(BKYConnectionManager * _Nullable)connectionManager error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
	[Export ("initWithWorkspaceLayout:layoutBuilder:connectionManager:error:")]
	[DesignatedInitializer]
	IntPtr Constructor (BKYWorkspaceLayout workspaceLayout, BKYLayoutBuilder layoutBuilder, [NullAllowed] BKYConnectionManager connectionManager, [NullAllowed] out NSError error);

	// -(BOOL)addBlockTree:(BKYBlock * _Nonnull)rootBlock error:(NSError * _Nullable * _Nullable)error;
	[Export ("addBlockTree:error:")]
	bool AddBlockTree (BKYBlock rootBlock, [NullAllowed] out NSError error);

	// -(BOOL)removeBlockTree:(BKYBlock * _Nonnull)rootBlock error:(NSError * _Nullable * _Nullable)error;
	[Export ("removeBlockTree:error:")]
	bool RemoveBlockTree (BKYBlock rootBlock, [NullAllowed] out NSError error);

	// -(BOOL)removeSingleBlock:(BKYBlock * _Nonnull)block error:(NSError * _Nullable * _Nullable)error;
	[Export ("removeSingleBlock:error:")]
	bool RemoveSingleBlock (BKYBlock block, [NullAllowed] out NSError error);

	// -(BKYBlock * _Nullable)copyBlockTree:(BKYBlock * _Nonnull)rootBlock editable:(BOOL)editable position:(BKYWorkspacePoint)position error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
	[Export ("copyBlockTree:editable:position:error:")]
	[return: NullAllowed]
	BKYBlock CopyBlockTree (BKYBlock rootBlock, bool editable, BKYWorkspacePoint position, [NullAllowed] out NSError error);

	// -(BOOL)disconnect:(BKYConnection * _Nonnull)connection error:(NSError * _Nullable * _Nullable)error;
	[Export ("disconnect:error:")]
	bool Disconnect (BKYConnection connection, [NullAllowed] out NSError error);

	// -(BOOL)disconnectShadow:(BKYConnection * _Nonnull)connection error:(NSError * _Nullable * _Nullable)error;
	[Export ("disconnectShadow:error:")]
	bool DisconnectShadow (BKYConnection connection, [NullAllowed] out NSError error);

	// -(BOOL)connect:(BKYConnection * _Nonnull)connection1 :(BKYConnection * _Nonnull)connection2 error:(NSError * _Nullable * _Nullable)error;
	[Export ("connect::error:")]
	bool Connect (BKYConnection connection1, BKYConnection connection2, [NullAllowed] out NSError error);

	// -(BOOL)rebuildLayoutTreeForBlock:(BKYBlock * _Nonnull)block error:(NSError * _Nullable * _Nullable)error;
	[Export ("rebuildLayoutTreeForBlock:error:")]
	bool RebuildLayoutTreeForBlock (BKYBlock block, [NullAllowed] out NSError error);

	// -(void)workspace:(BKYWorkspace * _Nonnull)workspace didAddBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
	[Export ("workspace:didAddBlockTrees:")]
	void Workspace (BKYWorkspace workspace, BKYBlock[] blockTrees);

	// -(void)workspace:(BKYWorkspace * _Nonnull)workspace didRemoveBlockTrees:(NSArray<BKYBlock *> * _Nonnull)blockTrees;
	[Export ("workspace:didRemoveBlockTrees:")]
	void Workspace (BKYWorkspace workspace, BKYBlock[] blockTrees);

	// -(void)nameManager:(BKYNameManager * _Nonnull)nameManager didRemoveName:(NSString * _Nonnull)name;
	[Export ("nameManager:didRemoveName:")]
	void NameManager (BKYNameManager nameManager, string name);
}

// @interface BKYWorkspaceView : BKYLayoutView
[BaseType(typeof(BKYLayoutView))]
interface BKYWorkspaceView
{
    // @property (readonly, nonatomic, strong) BKYWorkspaceLayout * _Nullable workspaceLayout;
    [NullAllowed, Export("workspaceLayout", ArgumentSemantic.Strong)]
    BKYWorkspaceLayout WorkspaceLayout { get; }

    // @property (readonly, copy, nonatomic) NSSet<BKYBlockGroupView *> * _Nonnull blockGroupViews;
    [Export("blockGroupViews", ArgumentSemantic.Copy)]
    NSSet<BKYBlockGroupView> BlockGroupViews { get; }

    // @property (nonatomic, strong) BKYWorkspaceScrollView * _Nonnull scrollView;
    [Export("scrollView", ArgumentSemantic.Strong)]
    BKYWorkspaceScrollView ScrollView { get; set; }

    // @property (nonatomic, strong) BKYZIndexedGroupView * _Null_unspecified dragLayerView;
    [Export("dragLayerView", ArgumentSemantic.Strong)]
    BKYZIndexedGroupView DragLayerView { get; set; }

    // @property (nonatomic) BOOL allowCanvasPadding;
    [Export("allowCanvasPadding")]
    bool AllowCanvasPadding { get; set; }

    // @property (nonatomic) int canvasPaddingScale;
    [Export("canvasPaddingScale")]
    int CanvasPaddingScale { get; set; }

    // @property (nonatomic) int scrollIntoViewEdgeInsets;
    [Export("scrollIntoViewEdgeInsets")]
    int ScrollIntoViewEdgeInsets { get; set; }

    // @property (nonatomic) BOOL allowZoom;
    [Export("allowZoom")]
    bool AllowZoom { get; set; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);

    // -(void)prepareForReuse;
    [Export("prepareForReuse")]
    void PrepareForReuse();

    // -(void)layoutSubviews;
    [Export("layoutSubviews")]
    void LayoutSubviews();

    // -(id)workspacePositionFromBlockView:(UIView * _Nonnull)blockView __attribute__((warn_unused_result));
    [Export("workspacePositionFromBlockView:")]
    NSObject WorkspacePositionFromBlockView(UIView blockView);

    // -(void)scrollBlockIntoView:(BKYBlock * _Nonnull)block location:(enum BKYWorkspaceViewLocation)location animated:(BOOL)animated;
    [Export("scrollBlockIntoView:location:animated:")]
    void ScrollBlockIntoView(BKYBlock block, BKYWorkspaceViewLocation location, bool animated);

    // -(void)setViewportTo:(enum BKYWorkspaceViewLocation)location animated:(BOOL)animated;
    [Export("setViewportTo:animated:")]
    void SetViewportTo(BKYWorkspaceViewLocation location, bool animated);

    // -(id)workspacePositionFromViewPoint:(CGPoint)point __attribute__((warn_unused_result));
    [Export("workspacePositionFromViewPoint:")]
    NSObject WorkspacePositionFromViewPoint(CGPoint point);
}

// @interface Blockly_Swift_7090 (BKYWorkspaceView)
[Category]
[BaseType(typeof(BKYWorkspaceView))]
interface BKYWorkspaceView_Blockly_Swift_7090
{
}

// @interface BKYWorkspaceScrollView : UIScrollView <UIGestureRecognizerDelegate>
[BaseType(typeof(UIScrollView))]
interface BKYWorkspaceScrollView : IUIGestureRecognizerDelegate
{
    // @property (readonly, nonatomic) BOOL isInMotion;
    [Export("isInMotion")]
    bool IsInMotion { get; }

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);
}

// @protocol BKYAnglePickerViewControllerDelegate
[Protocol, Model]
interface BKYBlockGroupViewDelegate
{
    // @required -(void)blockGroupViewDidUpdateDragging:(BKYBlockGroupView * _Nonnull) blockGroupView
    [Abstract]
    [Export("blockGroupViewDidUpdateDragging:")]
    void BlockGroupViewDidUpdateDragging(BKYBlockGroupView blockGroupView);
}
    
// @interface Blockly_Swift_7112 (BKYWorkspaceView)
[Category]
[BaseType(typeof(BKYWorkspaceView))]
interface BKYWorkspaceView_Blockly_Swift_7112: BKYBlockGroupViewDelegate
{
    // -(void)addBlockGroupView:(BKYBlockGroupView * _Nonnull)blockGroupView;
    [Export("addBlockGroupView:")]
    void AddBlockGroupView(BKYBlockGroupView blockGroupView);

    // -(void)removeBlockGroupView:(BKYBlockGroupView * _Nonnull)blockGroupView;
    [Export("removeBlockGroupView:")]
    void RemoveBlockGroupView(BKYBlockGroupView blockGroupView);

    // -(void)blockGroupViewDidUpdateDragging:(BKYBlockGroupView * _Nonnull)blockGroupView;
    [Export("blockGroupViewDidUpdateDragging:")]
    void BlockGroupViewDidUpdateDragging(BKYBlockGroupView blockGroupView);
}

// @interface Blockly_Swift_7125 (BKYWorkspaceView) <UIScrollViewDelegate>
[Category]
[BaseType(typeof(BKYWorkspaceView))]
interface BKYWorkspaceView_Blockly_Swift_7125 : IUIScrollViewDelegate
{
    // -(void)scrollViewDidEndDecelerating:(UIScrollView * _Nonnull)scrollView;
    [Export("scrollViewDidEndDecelerating:")]
    void ScrollViewDidEndDecelerating(UIScrollView scrollView);

    // -(void)scrollViewDidEndDragging:(UIScrollView * _Nonnull)scrollView willDecelerate:(BOOL)decelerate;
    [Export("scrollViewDidEndDragging:willDecelerate:")]
    void ScrollViewDidEndDragging(UIScrollView scrollView, bool decelerate);

    // -(UIView * _Nullable)viewForZoomingInScrollView:(UIScrollView * _Nonnull)scrollView __attribute__((warn_unused_result));
    [Export("viewForZoomingInScrollView:")]
    [return: NullAllowed]
    UIView ViewForZoomingInScrollView(UIScrollView scrollView);

    // -(void)scrollViewWillBeginZooming:(UIScrollView * _Nonnull)zoomScrollView withView:(UIView * _Nullable)view;
    [Export("scrollViewWillBeginZooming:withView:")]
    void ScrollViewWillBeginZooming(UIScrollView zoomScrollView, [NullAllowed] UIView view);

    // -(void)scrollViewDidZoom:(UIScrollView * _Nonnull)zoomScrollView;
    [Export("scrollViewDidZoom:")]
    void ScrollViewDidZoom(UIScrollView zoomScrollView);

    // -(void)scrollViewDidEndZooming:(UIScrollView * _Nonnull)scrollView withView:(UIView * _Nullable)view atScale:(CGFloat)scale;
    [Export("scrollViewDidEndZooming:withView:atScale:")]
    void ScrollViewDidEndZooming(UIScrollView scrollView, [NullAllowed] UIView view, nfloat scale);

    // -(void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
    [Export("scrollViewDidScroll:")]
    void ScrollViewDidScroll(UIScrollView scrollView);
}

// @interface Blockly_Swift_7137 (BKYWorkspaceViewController) <BKYViewBuilderDelegate>
[Category]
[BaseType(typeof(BKYWorkspaceViewController))]
interface BKYWorkspaceViewController_Blockly_Swift_7137 : BKYViewBuilderDelegate
{
    // -(void)viewBuilder:(BKYViewBuilder * _Nonnull)viewBuilder didAddChild:(UIView * _Nonnull)childView toParent:(UIView * _Nonnull)parentView;
    [Export("viewBuilder:didAddChild:toParent:")]
    void ViewBuilder(BKYViewBuilder viewBuilder, UIView childView, UIView parentView);
}

// @interface Blockly_Swift_7143 (BKYWorkspaceViewController) <BKYLayoutPopoverDelegate>
[Category]
[BaseType(typeof(BKYWorkspaceViewController))]
interface BKYWorkspaceViewController_Blockly_Swift_7143 : BKYLayoutPopoverDelegate
{
    // -(BOOL)layoutView:(BKYLayoutView * _Nonnull)layoutView requestedToPresentPopoverViewController:(UIViewController * _Nonnull)viewController fromView:(UIView * _Nonnull)fromView presentationDelegate:(id<UIPopoverPresentationControllerDelegate> _Nullable)presentationDelegate __attribute__((warn_unused_result));
    [Export("layoutView:requestedToPresentPopoverViewController:fromView:presentationDelegate:")]
    bool LayoutView(BKYLayoutView layoutView, UIViewController viewController, UIView fromView, [NullAllowed] UIPopoverPresentationControllerDelegate presentationDelegate);

    // -(void)layoutView:(BKYLayoutView * _Nonnull)layoutView requestedToPresentViewController:(UIViewController * _Nonnull)viewController;
    [Export("layoutView:requestedToPresentViewController:")]
    void LayoutView(BKYLayoutView layoutView, UIViewController viewController);

    // -(void)layoutView:(BKYLayoutView * _Nonnull)layoutView requestedToDismissPopoverViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
    [Export("layoutView:requestedToDismissPopoverViewController:animated:")]
    void LayoutView(BKYLayoutView layoutView, UIViewController viewController, bool animated);
}

// @interface Blockly_Swift_7153 (BKYWorkspaceViewController) <UIPopoverPresentationControllerDelegate>
[Category]
[BaseType(typeof(BKYWorkspaceViewController))]
interface BKYWorkspaceViewController_Blockly_Swift_7153 : IUIPopoverPresentationControllerDelegate
{
    // -(UIModalPresentationStyle)adaptivePresentationStyleForPresentationController:(UIPresentationController * _Nonnull)controller traitCollection:(UITraitCollection * _Nonnull)traitCollection __attribute__((availability(ios, introduced=8.3))) __attribute__((warn_unused_result));
    [Export("adaptivePresentationStyleForPresentationController:traitCollection:")]
    UIModalPresentationStyle AdaptivePresentationStyleForPresentationController(UIPresentationController controller, UITraitCollection traitCollection);

    // -(UIModalPresentationStyle)adaptivePresentationStyleForPresentationController:(UIPresentationController * _Nonnull)controller __attribute__((warn_unused_result));
    [Export("adaptivePresentationStyleForPresentationController:")]
    UIModalPresentationStyle AdaptivePresentationStyleForPresentationController(UIPresentationController controller);

    // -(UIViewController * _Nullable)presentationController:(UIPresentationController * _Nonnull)controller viewControllerForAdaptivePresentationStyle:(UIModalPresentationStyle)style __attribute__((warn_unused_result));
    [Export("presentationController:viewControllerForAdaptivePresentationStyle:")]
    [return: NullAllowed]
    UIViewController PresentationController(UIPresentationController controller, UIModalPresentationStyle style);

    // -(void)presentationController:(UIPresentationController * _Nonnull)presentationController willPresentWithAdaptiveStyle:(UIModalPresentationStyle)style transitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nullable)transitionCoordinator __attribute__((availability(ios, introduced=8.3)));
    [Export("presentationController:willPresentWithAdaptiveStyle:transitionCoordinator:")]
    void PresentationController(UIPresentationController presentationController, UIModalPresentationStyle style, [NullAllowed] IUIViewControllerTransitionCoordinator transitionCoordinator);

    // -(void)prepareForPopoverPresentation:(UIPopoverPresentationController * _Nonnull)popoverPresentationController;
    [Export("prepareForPopoverPresentation:")]
    void PrepareForPopoverPresentation(UIPopoverPresentationController popoverPresentationController);

    // -(BOOL)popoverPresentationControllerShouldDismissPopover:(UIPopoverPresentationController * _Nonnull)popoverPresentationController __attribute__((warn_unused_result));
    [Export("popoverPresentationControllerShouldDismissPopover:")]
    bool PopoverPresentationControllerShouldDismissPopover(UIPopoverPresentationController popoverPresentationController);

    // -(void)popoverPresentationControllerDidDismissPopover:(UIPopoverPresentationController * _Nonnull)popoverPresentationController;
    [Export("popoverPresentationControllerDidDismissPopover:")]
    void PopoverPresentationControllerDidDismissPopover(UIPopoverPresentationController popoverPresentationController);

    // -(void)popoverPresentationController:(UIPopoverPresentationController * _Nonnull)popoverPresentationController willRepositionPopoverToRect:(CGRect * _Nonnull)rect inView:(UIView * _Nonnull * _Nonnull)view;
    [Export("popoverPresentationController:willRepositionPopoverToRect:inView:")]
    unsafe void PopoverPresentationController(UIPopoverPresentationController popoverPresentationController, CGRect rect, out UIView view);

    // -(void)dismissViewControllerAnimated:(BOOL)flag completion:(void (^ _Nullable)(void))completion;
    [Export("dismissViewControllerAnimated:completion:")]
    void DismissViewControllerAnimated(bool flag, [NullAllowed] Action completion);
}

// @interface BKYZIndexedGroupView : UIView
[BaseType(typeof(UIView))]
interface BKYZIndexedGroupView
{
    // -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
    [Export("hitTest:withEvent:")]
    [return: NullAllowed]
    UIView HitTest(CGPoint point, [NullAllowed] UIEvent @event);

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
    [Export("initWithFrame:")]
    [DesignatedInitializer]
    IntPtr Constructor(CGRect frame);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor(NSCoder aDecoder);
}
    
       // @interface BKYBlock : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BKYBlock: INativeObject
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull uuid;
        [Export("uuid")]
        string Uuid { get; }
    
        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }
    
        // @property (nonatomic) BOOL inputsInline;
        [Export("inputsInline")]
        bool InputsInline { get; set; }
    
        // @property (nonatomic) int position;
        [Export("position")]
        int Position { get; set; }
    
        // @property (readonly, nonatomic) BOOL shadow;
        [Export("shadow")]
        bool Shadow { get; }
    
        // @property (readonly, nonatomic, strong) BKYConnection * _Nullable outputConnection;
        [NullAllowed, Export("outputConnection", ArgumentSemantic.Strong)]
        BKYConnection OutputConnection { get; }
    
        // @property (readonly, nonatomic, strong) BKYBlock * _Nullable outputBlock;
        [NullAllowed, Export("outputBlock", ArgumentSemantic.Strong)]
        BKYBlock OutputBlock { get; }
    
        // @property (readonly, nonatomic, strong) BKYConnection * _Nullable nextConnection;
        [NullAllowed, Export("nextConnection", ArgumentSemantic.Strong)]
        BKYConnection NextConnection { get; }
    
        // @property (readonly, nonatomic, strong) BKYBlock * _Nullable nextBlock;
        [NullAllowed, Export("nextBlock", ArgumentSemantic.Strong)]
        BKYBlock NextBlock { get; }
    
        // @property (readonly, nonatomic, strong) BKYBlock * _Nullable nextShadowBlock;
        [NullAllowed, Export("nextShadowBlock", ArgumentSemantic.Strong)]
        BKYBlock NextShadowBlock { get; }
    
        // @property (readonly, nonatomic, strong) BKYConnection * _Nullable previousConnection;
        [NullAllowed, Export("previousConnection", ArgumentSemantic.Strong)]
        BKYConnection PreviousConnection { get; }
    
        // @property (readonly, nonatomic, strong) BKYBlock * _Nullable previousBlock;
        [NullAllowed, Export("previousBlock", ArgumentSemantic.Strong)]
        BKYBlock PreviousBlock { get; }
    
        // @property (readonly, nonatomic, strong) BKYConnection * _Nullable inferiorConnection;
        [NullAllowed, Export("inferiorConnection", ArgumentSemantic.Strong)]
        BKYConnection InferiorConnection { get; }
    
        // @property (readonly, copy, nonatomic) NSArray<BKYConnection *> * _Nonnull directConnections;
        [Export("directConnections", ArgumentSemantic.Copy)]
        BKYConnection[] DirectConnections { get; }
    
        // @property (readonly, copy, nonatomic) NSArray<BKYInput *> * _Nonnull inputs;
        [Export("inputs", ArgumentSemantic.Copy)]
        BKYInput[] Inputs { get; }
    
        // @property (readonly, nonatomic, strong) UIColor * _Nonnull color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; }
    
        // @property (copy, nonatomic) NSString * _Nonnull tooltip;
        [Export("tooltip")]
        string Tooltip { get; set; }
    
        // @property (copy, nonatomic) NSString * _Nonnull comment;
        [Export("comment")]
        string Comment { get; set; }
    
        // @property (copy, nonatomic) NSString * _Nonnull helpURL;
        [Export("helpURL")]
        string HelpURL { get; set; }
    
        // @property (nonatomic) BOOL deletable;
        [Export("deletable")]
        bool Deletable { get; set; }
    
        // @property (nonatomic) BOOL movable;
        [Export("movable")]
        bool Movable { get; set; }
    
        // @property (nonatomic) BOOL disabled;
        [Export("disabled")]
        bool Disabled { get; set; }
    
        // @property (readonly, nonatomic) BOOL draggable;
        [Export("draggable")]
        bool Draggable { get; }
    
        // @property (nonatomic) BOOL editable;
        [Export("editable")]
        bool Editable { get; set; }
    
        // @property (readonly, nonatomic) BOOL topLevel;
        [Export("topLevel")]
        bool TopLevel { get; }
    
        // @property (nonatomic, strong) BKYBlockStyle * _Nonnull style;
        [Export("style", ArgumentSemantic.Strong)]
        BKYBlockStyle Style { get; set; }
    
        // @property (nonatomic, weak) BKYBlockLayout * _Nullable layout;
        [NullAllowed, Export("layout", ArgumentSemantic.Weak)]
        BKYBlockLayout Layout { get; set; }
    
        // -(NSArray<BKYConnection *> * _Nonnull)allConnectionsForTree __attribute__((warn_unused_result));
        [Export("allConnectionsForTree")]
        BKYConnection[] AllConnectionsForTree { get; }
    
        // -(BKYBlock * _Nonnull)lastBlockInChain __attribute__((warn_unused_result));
        [Export("lastBlockInChain")]
        BKYBlock LastBlockInChain { get; }
    
        // -(BKYConnection * _Nullable)lastInputValueConnectionInChain __attribute__((warn_unused_result));
        [NullAllowed, Export("lastInputValueConnectionInChain")]
        BKYConnection LastInputValueConnectionInChain { get; }
    
        // -(NSArray<BKYBlock *> * _Nonnull)allBlocksForTree __attribute__((warn_unused_result));
        [Export("allBlocksForTree")]
        BKYBlock[] AllBlocksForTree { get; }
    
        // -(BKYInput * _Nullable)firstInputWithName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
        [Export("firstInputWithName:")]
        [return: NullAllowed]
        BKYInput FirstInputWithName(string name);
    
        // -(BKYField * _Nullable)firstFieldWithName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
        [Export("firstFieldWithName:")]
        [return: NullAllowed]
        BKYField FirstFieldWithName(string name);
    
        // -(void)notifyDidUpdateBlock;
        [Export("notifyDidUpdateBlock")]
        void NotifyDidUpdateBlock();
    
        // -(void)appendInput:(BKYInput * _Nonnull)input;
        [Export("appendInput:")]
        void AppendInput(BKYInput input);
    
        // -(void)insertInput:(BKYInput * _Nonnull)input at:(NSInteger)index;
        [Export("insertInput:at:")]
        void InsertInput(BKYInput input, nint index);
    
        // -(BOOL)removeInput:(BKYInput * _Nonnull)input error:(NSError * _Nullable * _Nullable)error;
        [Export("removeInput:error:")]
        bool RemoveInput(BKYInput input, [NullAllowed] out NSError error);
    }
    
    // @protocol BKYBlockExtension
    [Protocol, Model]
    interface BKYBlockExtension: INativeObject
    {
        // @required -(BOOL)runWithBlock:(BKYBlock * _Nonnull)block error:(NSError * _Nullable * _Nullable)error;
        [Abstract]
        [Export("runWithBlock:error:")]
        bool Error(BKYBlock block, [NullAllowed] out NSError error);
    }

// @interface BKYBlockExtensionClosure : NSObject <BKYBlockExtension>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BKYBlockExtensionClosure : BKYBlockExtension
    {
        // -(instancetype _Nonnull)init:(void (^ _Nonnull)(BKYBlock * _Nonnull))closure __attribute__((objc_designated_initializer));
        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor(Action<BKYBlock> closure);

        // -(BOOL)runWithBlock:(BKYBlock * _Nonnull)block error:(NSError * _Nullable * _Nullable)error;
        [Export("runWithBlock:error:")]
        bool RunWithBlock(BKYBlock block, [NullAllowed] out NSError error);
    }
}

