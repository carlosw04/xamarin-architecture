﻿using Foundation;
using System;

namespace SyncedCare.Mobile.Presentation.iOS.Extensions
{
    public static class NSObjectExtensions
    {
        public static void SetObservableProperty(this NSObject obj, string key, Action setter)
        {
            obj.WillChangeValue(key);
            setter();
            obj.DidChangeValue(key);
        }
    }
}
