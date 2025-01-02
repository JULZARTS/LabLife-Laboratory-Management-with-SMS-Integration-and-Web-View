﻿using LabLife.Models;
using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace LabLife.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isPaneOpen = true;
        [ObservableProperty]
        private ViewModelBase _currentPage = new DashboardPageViewModel();

        [ObservableProperty]
        private ObservableCollection <MenuItems> menuItems;

        [ObservableProperty]
        private MenuItems? selectedItem;

        [RelayCommand]
        public void ToggleSidebar()
        {
            IsPaneOpen = !IsPaneOpen;
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



        public static string geo3 = "M14 9.50006C11.5147 9.50006 9.5 11.5148 9.5 14.0001C9.5 16.4853 11.5147 18.5001 14 18.5001C15.3488 18.5001 16.559 17.9066 17.3838 16.9666C18.0787 16.1746 18.5 15.1365 18.5 14.0001C18.5 13.5401 18.431 13.0963 18.3028 12.6784C17.7382 10.8381 16.0253 9.50006 14 9.50006ZM11 14.0001C11 12.3432 12.3431 11.0001 14 11.0001C15.6569 11.0001 17 12.3432 17 14.0001C17 15.6569 15.6569 17.0001 14 17.0001C12.3431 17.0001 11 15.6569 11 14.0001Z M21.7093 22.3948L19.9818 21.6364C19.4876 21.4197 18.9071 21.4515 18.44 21.7219C17.9729 21.9924 17.675 22.4693 17.6157 23.0066L17.408 24.8855C17.3651 25.273 17.084 25.5917 16.7055 25.682C14.9263 26.1061 13.0725 26.1061 11.2933 25.682C10.9148 25.5917 10.6336 25.273 10.5908 24.8855L10.3834 23.0093C10.3225 22.4731 10.0112 21.9976 9.54452 21.7281C9.07783 21.4586 8.51117 21.4269 8.01859 21.6424L6.29071 22.4009C5.93281 22.558 5.51493 22.4718 5.24806 22.1859C4.00474 20.8536 3.07924 19.2561 2.54122 17.5137C2.42533 17.1384 2.55922 16.7307 2.8749 16.4977L4.40219 15.3703C4.83721 15.0501 5.09414 14.5415 5.09414 14.0007C5.09414 13.4598 4.83721 12.9512 4.40162 12.6306L2.87529 11.5051C2.55914 11.272 2.42513 10.8638 2.54142 10.4882C3.08038 8.74734 4.00637 7.15163 5.24971 5.82114C5.51684 5.53528 5.93492 5.44941 6.29276 5.60691L8.01296 6.36404C8.50793 6.58168 9.07696 6.54881 9.54617 6.27415C10.0133 6.00264 10.3244 5.52527 10.3844 4.98794L10.5933 3.11017C10.637 2.71803 10.9245 2.39704 11.3089 2.31138C12.19 2.11504 13.0891 2.01071 14.0131 2.00006C14.9147 2.01047 15.8128 2.11485 16.6928 2.31149C17.077 2.39734 17.3643 2.71823 17.4079 3.11017L17.617 4.98937C17.7116 5.85221 18.4387 6.50572 19.3055 6.50663C19.5385 6.507 19.769 6.45838 19.9843 6.36294L21.7048 5.60568C22.0626 5.44818 22.4807 5.53405 22.7478 5.81991C23.9912 7.1504 24.9172 8.74611 25.4561 10.487C25.5723 10.8623 25.4386 11.2703 25.1228 11.5035L23.5978 12.6297C23.1628 12.95 22.9 13.4586 22.9 13.9994C22.9 14.5403 23.1628 15.0489 23.5988 15.3698L25.1251 16.4965C25.441 16.7296 25.5748 17.1376 25.4586 17.5131C24.9198 19.2536 23.9944 20.8492 22.7517 22.1799C22.4849 22.4657 22.0671 22.5518 21.7093 22.3948ZM16.263 22.1966C16.4982 21.4685 16.9889 20.8288 17.6884 20.4238C18.5702 19.9132 19.6536 19.8547 20.5841 20.2627L21.9281 20.8526C22.791 19.8538 23.4593 18.7013 23.8981 17.4552L22.7095 16.5778L22.7086 16.5771C21.898 15.98 21.4 15.0277 21.4 13.9994C21.4 12.9719 21.8974 12.0195 22.7073 11.4227L22.7085 11.4218L23.8957 10.545C23.4567 9.2988 22.7881 8.14636 21.9248 7.1477L20.5922 7.73425L20.5899 7.73527C20.1844 7.91463 19.7472 8.00722 19.3039 8.00663C17.6715 8.00453 16.3046 6.77431 16.1261 5.15465L16.1259 5.15291L15.9635 3.69304C15.3202 3.57328 14.6677 3.50872 14.013 3.50017C13.3389 3.50891 12.6821 3.57367 12.0377 3.69328L11.8751 5.15452C11.7625 6.16272 11.1793 7.05909 10.3019 7.56986C9.41937 8.0856 8.34453 8.14844 7.40869 7.73694L6.07273 7.14893C5.20949 8.14751 4.54092 9.29983 4.10196 10.5459L5.29181 11.4233C6.11115 12.0269 6.59414 12.9837 6.59414 14.0007C6.59414 15.0173 6.11142 15.9742 5.29237 16.5776L4.10161 17.4566C4.54002 18.7044 5.2085 19.8585 6.07205 20.8587L7.41742 20.2682C8.34745 19.8613 9.41573 19.9215 10.2947 20.4292C11.174 20.937 11.7593 21.832 11.8738 22.84L11.8744 22.8445L12.0362 24.3088C13.3326 24.5638 14.6662 24.5638 15.9626 24.3088L16.1247 22.8418C16.1491 22.6217 16.1955 22.4055 16.263 22.1966Z";
        public static string geo2 = "M17.75,3 C19.5449254,3 21,4.45507456 21,6.25 L21,13.1286797 C21,13.7254168 20.7629471,14.2977131 20.3409903,14.7196699 L14.7196699,20.3409903 C14.2977131,20.7629471 13.7254168,21 13.1286797,21 L6.25,21 C4.45507456,21 3,19.5449254 3,17.75 L3,6.25 C3,4.45507456 4.45507456,3 6.25,3 L17.75,3 Z M17.75,4.5 L6.25,4.5 C5.28350169,4.5 4.5,5.28350169 4.5,6.25 L4.5,17.75 C4.5,18.7164983 5.28350169,19.5 6.25,19.5 L13,19.5 L13,16.25 C13,14.5169685 14.3564548,13.1007541 16.0655761,13.0051448 L16.25,13 L19.5,13 L19.5,6.25 C19.5,5.28350169 18.7164983,4.5 17.75,4.5 Z M18.439,14.5 L16.25,14.5 C15.3318266,14.5 14.5788077,15.2071103 14.5058012,16.1064728 L14.5,16.25 L14.5,18.439 L18.439,14.5 Z";
        public static string geo1 = "M21.6062 5.85517C23.0048 4.71494 24.9952 4.71494 26.3938 5.85517L39.5688 16.5966C40.4736 17.3342 41 18.4492 41 19.628V39.1134C41 41.2599 39.2875 43 37.175 43H32.075C29.9625 43 28.25 41.2599 28.25 39.1134V29.7492C28.25 29.0337 27.6792 28.4536 26.975 28.4536H21.025C20.3208 28.4536 19.75 29.0337 19.75 29.7492V39.1134C19.75 41.2599 18.0375 43 15.925 43H10.825C8.71251 43 7 41.2599 7 39.1134V19.628C7 18.4493 7.52645 17.3342 8.43124 16.5966L21.6062 5.85517ZM24.7979 7.87612C24.3317 7.49604 23.6683 7.49604 23.2021 7.87612L10.0271 18.6175C9.72548 18.8634 9.55 19.2351 9.55 19.628V39.1134C9.55 39.8289 10.1208 40.4089 10.825 40.4089H15.925C16.6292 40.4089 17.2 39.8289 17.2 39.1134V29.7492C17.2 27.6027 18.9125 25.8626 21.025 25.8626H26.975C29.0875 25.8626 30.8 27.6027 30.8 29.7492V39.1134C30.8 39.8289 31.3708 40.4089 32.075 40.4089H37.175C37.8792 40.4089 38.45 39.8289 38.45 39.1134V19.628C38.45 19.2351 38.2745 18.8634 37.9729 18.6175L24.7979 7.87612Z";


        public MainWindowViewModel()
        {
         
            menuItems = new ObservableCollection<MenuItems>()
            {
                new MenuItems { Title = "Dashboard", Icon = Geometry.Parse(geo1), command = new RelayCommand(GoDashboard)},
                new MenuItems { Title = "New Patient", Icon = Geometry.Parse(geo2), command = new RelayCommand(GoNewPatient)},
                new MenuItems { Title = "Records", Icon = Geometry.Parse(geo2), command = new RelayCommand(GoRecords)},
                new MenuItems { Title = "Communications", Icon = Geometry.Parse(geo2), command = new RelayCommand(GoCommunications)},
                new MenuItems { Title = "Web Inspect", Icon = Geometry.Parse(geo2), command = new RelayCommand(GoWebInspect)},
                new MenuItems { Title = "Settings", Icon = Geometry.Parse(geo3), command = new RelayCommand(GoSettings)}
            };
        }
    }
}
