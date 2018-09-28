﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace testsplitpane {
    public partial class PadViewController : AppKit.NSViewController {
        #region Constructors

        // Called when created from unmanaged code
        public PadViewController(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public PadViewController(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Call to load from the XIB/NIB file
        public PadViewController() : base("PadView", NSBundle.MainBundle)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        //strongly typed view accessor
        public new PadView View {
            get {
                return (PadView)base.View;
            }
        }
    }
}
