using LabLife.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LabLife.Views;

public partial class SettingsPageView : UserControl
{
    public SettingsPageView()
    {
        InitializeComponent();
        SettingsPageViewModel spvm = new SettingsPageViewModel();
        DataContext = spvm;
    }
}