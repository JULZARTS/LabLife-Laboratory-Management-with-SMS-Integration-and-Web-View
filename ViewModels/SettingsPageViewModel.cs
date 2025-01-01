using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLife.ViewModels
{
    public partial class SettingsPageViewModel: ViewModelBase
    {
        [ObservableProperty]
        public string? bgBackground;

        [ObservableProperty]
        public string? sliderValue;

        [RelayCommand]
        public void TriggerBG()
        {
           BgBackground = "violet";
        }


    }
}
