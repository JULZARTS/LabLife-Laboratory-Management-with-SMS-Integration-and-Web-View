using LabLife.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LabLife.Views;

public partial class GridPageView : UserControl
{
    public GridPageView()
    {
        InitializeComponent();
        GridPageViewModel gpvm = new GridPageViewModel();
        DataContext = gpvm;
    }
}