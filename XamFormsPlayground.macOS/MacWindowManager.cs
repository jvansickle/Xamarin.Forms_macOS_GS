using System;
using System.Linq;
using AppKit;
using CoreFoundation;
using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;
using XamFormsPlayground.Services;

namespace XamFormsPlayground.macOS
{
    public class MacWindowManager : IWindowManager
    {
        public MacWindowManager()
        {
        }

        public void CloseWindow(string identifier)
        {
            DispatchQueue.MainQueue.DispatchAsync(() => NSApplication.SharedApplication.Windows.FirstOrDefault((window) => window.Identifier == identifier)?.Close());
        }

        public string OpenWindow(Page page)
        {
            var identifier = Guid.NewGuid();

            var nsWindow = new NSWindow
            {
                Title = page.Title ?? string.Empty,
                BackingType = NSBackingStore.Buffered,
                StyleMask = NSWindowStyle.Miniaturizable | NSWindowStyle.Titled | NSWindowStyle.Resizable,
                Level = NSWindowLevel.Normal,
                Identifier = identifier.ToString()
            };
            nsWindow.SetFrame(new CGRect(200, 1000, 1024, 768), true, true);
            NSViewController controller = page.CreateViewController();
            nsWindow.ContentView = controller.View;

            NSWindowController windowController = new NSWindowController(nsWindow);
            windowController.ShowWindow(null);

            return identifier.ToString();
        }
    }
}
