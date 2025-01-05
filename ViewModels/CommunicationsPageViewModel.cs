using System;
using Avalonia.Input;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LabLife.Views;

namespace LabLife.ViewModels
{
    public partial class CommunicationsPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string? defaultContent = "Please make sure the entered content is correct before sending";
        
        
        public CommunicationsPageViewModel()
        {
            
        }
    }
}