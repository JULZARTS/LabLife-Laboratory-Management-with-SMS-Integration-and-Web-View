using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
using LabLife.ViewModels;

namespace LabLife.Views;

public partial class WebInspectPageView : UserControl
{
    
    private const string Url = "https://localhost:7296/";
    private readonly IBrowser browser;
    private readonly IEngine engine;
    

    public WebInspectPageView()
    {
        // Create and initialize the IEngine instance
        EngineOptions engineOptions = new EngineOptions.Builder
        {
            LicenseKey = "3GCNCNOELYHLTY718DIDXPYEBUTQX0YMOOJPVQOQG4IO9CG067QTWH70N49R29G9RCQOZC640IMLOZUMWJVVRL08JEA5DEEELWXYDVXP2A4EKJC35CAHRK5U4LY2B9ZQ1QV8YGVL95JQQK06"
        }.Build();
        engine = EngineFactory.Create(engineOptions);

        // Create the IBrowser instance.
        browser = engine.CreateBrowser();

        InitializeComponent();

        // Initialize the Avalonia UI BrowserView control.
        BrowserView.InitializeFrom(browser);
        browser.Navigation.LoadUrl(Url);
    }

    private void Window_Closed(object? sender, EventArgs e)
    {
        browser?.Dispose();
        engine?.Dispose();
    }
}