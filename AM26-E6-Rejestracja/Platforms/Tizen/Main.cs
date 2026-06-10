using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace AM26_E6_Rejestracja
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
