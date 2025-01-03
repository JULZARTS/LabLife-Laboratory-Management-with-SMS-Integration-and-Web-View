using LabLife.Models;
using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using LabLife.Views;
using Avalonia.Svg.Skia;

namespace LabLife.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private int paneWidth = 190;

        [ObservableProperty]
        private string tbText = "Main Navigation";

        [ObservableProperty]
        private bool isPaneOpen = true;
        [ObservableProperty]
        private ViewModelBase _currentPage = new DashboardPageViewModel();

        [ObservableProperty]
        private ObservableCollection <MenuItems> menuItems;

        [ObservableProperty]
        private MenuItems? selectedItem;

        [ObservableProperty]
        private Brush recFill;


    [RelayCommand]
        public void ToggleSidebar()
        {
            IsPaneOpen = !IsPaneOpen;
            if(PaneWidth == 190) { PaneWidth = 55; } else { PaneWidth = 190; }
            if(TbText == "Main Navigation") { TbText = "➜"; } else { TbText = "Main Navigation"; }
        }


        [RelayCommand]
        public void GoWebInspect()
        {
            CurrentPage = new WebInspectPageViewModel();
        }

        [RelayCommand]
        public void GoCommunications()
        {
            CurrentPage = new CommunicationsPageViewModel();
        }

        [RelayCommand]
        public void GoDashboard()
        {
            CurrentPage = new DashboardPageViewModel();
        }

        [RelayCommand]
        public void GoNewPatient()
        {
            CurrentPage = new NewPatientPageViewModel();
        }

        [RelayCommand]
        public void GoRecords()
        {
            CurrentPage = new RecordsPageViewModel();
        }

        [RelayCommand]
        public void GoSettings()
        {
            CurrentPage = new SettingsPageViewModel();
        }

        partial void OnSelectedItemChanged(MenuItems? value)
        {
            if (value.Title == "Settings") { CurrentPage = new SettingsPageViewModel(); }
            else if (value.Title == "New Patient") { CurrentPage = new NewPatientPageViewModel(); }
            else if (value.Title == "Records") { CurrentPage = new RecordsPageViewModel(); }
            else if (value.Title == "Web Inspect") { CurrentPage = new WebInspectPageViewModel(); }
            else if (value.Title == "Communications") { CurrentPage = new CommunicationsPageViewModel(); }
            else if (value.Title == "Dashboard") { CurrentPage = new DashboardPageViewModel(); };
        }

        

        public MainWindowViewModel()
        {

            RecFill = new SolidColorBrush(Color.FromRgb(0, 255, 0));


            menuItems = new ObservableCollection<MenuItems>()
            {
      
                new MenuItems { Title = "Dashboard",Icon = "/Assets/Icons/Home.svg",  command = new RelayCommand(GoDashboard)},
                new MenuItems { Title = "New Patient", Icon = "/Assets/Icons/PersonAdd.svg",  command = new RelayCommand(GoNewPatient)},
                new MenuItems { Title = "Records", Icon = "/Assets/Icons/BookContacts.svg", command = new RelayCommand(GoRecords)},
                new MenuItems { Title = "Communications", Icon = "/Assets/Icons/Mail.svg",  command = new RelayCommand(GoCommunications)},
                new MenuItems { Title = "Web Inspect", Icon = "/Assets/Icons/Globe.svg" , command = new RelayCommand(GoWebInspect)},
                new MenuItems { Title = "Settings", Icon = "/Assets/Icons/Settings.svg", command = new RelayCommand(GoSettings)}
            };
        }
    }
}
