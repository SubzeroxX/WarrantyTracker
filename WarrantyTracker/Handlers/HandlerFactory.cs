using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace WarrantyTracker.Handlers
{
    internal class EntryNoUnderlineHandler
    {
        public static void RemoveUnderlineHandler()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
#if ANDROID
            handler.PlatformView.Background = null;
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#elif IOS
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
            handler.PlatformView.BorderBrush = null;
            handler.PlatformView.Background = null;
#endif
            });
        }
    }
}
