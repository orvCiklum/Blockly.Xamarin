using System;
using Blockly.Bindings.XamarinIOS;
using UIKit;

namespace Blockly.Sample
{
    public partial class ViewController : UIViewController//Blockly.Bindings.XamarinIOS.BKYWorkbenchViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.View.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;
            this.View.AutosizesSubviews = true;
            
            var bench = new BKYWorkbenchViewController();
            bench.View.Frame = this.View.Frame;
           
            View.AddSubview(bench.View);
            bench.DidMoveToParentViewController(this);
        }
    }
}
