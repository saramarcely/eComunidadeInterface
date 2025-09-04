﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using eComunidade.Views;


namespace eComunidade.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? email;

        [ObservableProperty]
        private string? senha;

        [RelayCommand]
        private async Task EntrarAsync()
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Senha))
            {
               
                await Shell.Current.DisplayAlert("Erro", "Preencha email e senha", "OK");
                return;
            }

            //  aqui irá a chamada para a API de login
            await Shell.Current.DisplayAlert("Login", $"Logando com {Email}", "OK");

          
            await Shell.Current.GoToAsync("TelaHome");
        }
    }
}