using Android.Database;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DesignPractise.Services;
using Java.Nio.FileNio.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPractise.ViewModel
{
    public partial class UserViewModel : ObservableObject
    {
        [ObservableProperty]
        string username;

        AuthService loginService;
        public UserViewModel(AuthService authService) {
            this.loginService = authService;
            this.Username = "sample";
        }

        [RelayCommand]
        async Task LoginAsync()
        {
            try
            {
                var user = await loginService.LoginAsync();
                if (user == null)
                {
                    this.username = user;
                    await Shell.Current.DisplayAlert("Hurray", "Login successful", "OK");

                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error", $"Unable to login {ex}", "OK");
            }
        }
    }
}
