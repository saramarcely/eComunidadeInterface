using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using eComunidade.Models;
using System.Collections.ObjectModel;

namespace eComunidade.ViewModels
{
    public partial class FavoritosViewModel : ObservableObject
    {
        public ObservableCollection<Favoritos> Favoritos { get; } = new ObservableCollection<Favoritos>();

        public FavoritosViewModel()
        {
            // Exemplo inicial: futuramente vem da API ou banco
            Favoritos.Add(new Favoritos { Id = 1, IdUsuario = 1, IdLocal = 101 });
            Favoritos.Add(new Favoritos { Id = 2, IdUsuario = 1, IdLocal = 102 });
        }

        [RelayCommand]
        private void RemoverFavorito(Favoritos favorito)
        {
            if (favorito != null)
                Favoritos.Remove(favorito);
        }
    }
}