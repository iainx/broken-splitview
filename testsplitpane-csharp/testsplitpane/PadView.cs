using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace testsplitpane {
    public partial class PadView : AppKit.NSView {
        #region Constructors

        // Called when created from unmanaged code
        public PadView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public PadView(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion
    }
}
