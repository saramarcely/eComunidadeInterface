namespace eComunidade;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registro de todas as rotas para navegação.
        Routing.RegisterRoute(nameof(Views.TelaLogin), typeof(Views.TelaLogin));
        Routing.RegisterRoute(nameof(Views.TelaEventos), typeof(Views.TelaEventos));
        Routing.RegisterRoute(nameof(Views.TelaRanking), typeof(Views.TelaRanking));
        Routing.RegisterRoute(nameof(Views.TelaDicas), typeof(Views.TelaDicas));
        Routing.RegisterRoute(nameof(Views.TelaHome), typeof(Views.TelaHome));
    }

    private async void OnMenuItemClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(Views.TelaLogin)}");
    }
}