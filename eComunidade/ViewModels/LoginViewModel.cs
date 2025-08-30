using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using eComunidade.Views;

//sara
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
                // Usar Shell.Current é a forma recomendada no .NET MAUI
                await Shell.Current.DisplayAlert("Erro", "Preencha email e senha", "OK");
                return;
            }

            // Futuramente, aqui irá a chamada para a sua API de login.
            await Shell.Current.DisplayAlert("Login", $"Logando com {Email}", "OK");

            // Navegar para a página principal do aplicativo
            await Shell.Current.GoToAsync("TelaHome");
        }
    }
}