#region Using Statements
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#endregion

namespace BubbleBreaker
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program2
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //App app = new App();
            /*App.Start(a =>
            //{
                
            });*/
           // global::Windows.UI.Xaml.Application.LoadComponent(new App(), new global::System.Uri("ms-appx:///App.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
            global::Windows.UI.Xaml.Application.Start((p) => new App()); 
            //Windows.ApplicationModel.Core.CoreApplication;
        }
    }
  
}
