﻿using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LabLife.ViewModels
{
    public partial class CollectionsPageViewModel: ViewModelBase
    {
        
        [ObservableProperty]
        private string recFill = "lightyellow";

        [ObservableProperty]
        private string? btnContent = "Hello World";

    }
}
