using System;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using LabLife.Views;

namespace LabLife.ViewModels
{
    public partial class NewPatientPageViewModel: ViewModelBase
    {
        
        [ObservableProperty]
        private string recFill = "lightyellow";

        [ObservableProperty]
        private string? btnContent = "Hello Worlddddddd";

        public NewPatientPageViewModel()
        {
        }

    }
}
