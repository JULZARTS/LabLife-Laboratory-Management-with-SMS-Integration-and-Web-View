using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LabLife.ViewModels;

namespace LabLife.Views;

public partial class NewPatientPageView : UserControl
{
    public NewPatientPageView()
    {
        InitializeComponent();
        DataContext = new NewPatientPageViewModel();

    }
}