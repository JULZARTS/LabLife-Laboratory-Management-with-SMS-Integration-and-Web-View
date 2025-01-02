using LabLife.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LabLife.Views;

public partial class RecordsPageView : UserControl
{
    public RecordsPageView()
    {
        InitializeComponent();
        RecordsPageViewModel gpvm = new RecordsPageViewModel();
        DataContext = gpvm;
    }
}