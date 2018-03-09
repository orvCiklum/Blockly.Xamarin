using System;
using System.IO;
using Blockly.Bindings.XamarinIOS;
using Blockly.Extensions;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Blockly.Sample
{
    public partial class ViewController : UIViewController//Blockly.Bindings.XamarinIOS.BKYWorkbenchViewController
    {
        private BKYWorkbenchViewController _bench;
        private BKYCodeGeneratorService _codeService;

        private string[] blocksJson = { "simple.json" };//{ "simple.json" };//{ "actions_blocks.json", "logic_blocks.json",
                //"loop_blocks.json", "math_blocks.json", "senses_blocks.json" };
        private const string toolboxXml = "toolbox_simple.xml";

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

            SetupBench();

            var button = new UIButton(new CGRect(new CGPoint(10, 150), new CGSize(80, 80))) { BackgroundColor = UIColor.Cyan };
            button.TouchUpInside += (sender, e) =>
            {
                _codeService.GenerateCodeForWorkspace(_bench.Workspace, out var error, (id, code) => {
                    Console.WriteLine(code.ToString());
                }, (id, ex) => {
                    Console.WriteLine(ex.ToString());
                });
            };
            _bench.Add(button);
        }

        private void SetupBench()
        {
            _bench = new BKYWorkbenchViewController(BKYWorkbenchViewControllerStyle.Alternate)
            {
                ToolboxDrawerStaysOpen = true,
                WorkspaceBackgroundColor = UIColor.Brown
            };
            _bench.View.Frame = this.View.Frame;

            View.AddSubview(_bench.View);
            _bench.DidMoveToParentViewController(this);

            _bench.SetupToolBox(toolboxXml, blocksJson);

            _codeService = _bench.SetupCodeGeneratorService(blocksJson, "simple.js");
        }
    }
}
