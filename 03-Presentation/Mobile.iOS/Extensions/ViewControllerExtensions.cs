﻿using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace SyncedCare.Mobile.Presentation.iOS.Extensions
{
    public static class ViewControllerExtensions
    {
        public static void OnViewLoad(this UIViewController viewController)
        {
			var g = new UITapGestureRecognizer(() => viewController.View.EndEditing(true));
			g.CancelsTouchesInView = false; //for iOS5
			viewController.View.AddGestureRecognizer(g);
            // Disable swipe to go back.
            if(viewController.NavigationController != null && viewController.NavigationController.InteractivePopGestureRecognizer != null)
            {
                viewController.NavigationController.InteractivePopGestureRecognizer.Enabled = false;
            }
        }
    }
}