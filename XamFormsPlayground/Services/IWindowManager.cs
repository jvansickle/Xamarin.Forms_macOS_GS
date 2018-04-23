using System;
using Xamarin.Forms;

namespace XamFormsPlayground.Services
{
    public interface IWindowManager
    {
        /// <summary>
        /// Opens a new window, returning an identifier for the new window.
        /// </summary>
        /// <returns>The window identifier.</returns>
        /// <param name="page">Page.</param>
        string OpenWindow(Page page);

        /// <summary>
        /// Closes the window matching the identifier.
        /// </summary>
        /// <param name="identifier">Window identifier.</param>
        void CloseWindow(string identifier);
    }
}
