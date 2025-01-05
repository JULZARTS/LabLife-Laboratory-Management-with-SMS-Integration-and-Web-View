using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using LabLife.ViewModels;

namespace LabLife.Views;

public partial class CommunicationsPageView : UserControl
{
    public CommunicationsPageView()
    {
        InitializeComponent();
        DataContext = new CommunicationsPageViewModel();
    }
    
    private void Tb_OnGotFocus(object? sender, GotFocusEventArgs e)
    {
        Tb.Text = String.Empty;
    }
}