using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LabLife.ViewModels;

namespace LabLife.Views;

public partial class WebInspectPageView : UserControl
{
    public WebInspectPageView()
    {
        InitializeComponent();
        DataContext = new WebInspectPageViewModel();
    }

    private void Window_Closed(object? sender, EventArgs e)
    {
        if (DataContext is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}