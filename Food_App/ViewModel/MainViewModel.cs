using CommunityToolkit.Mvvm.Input;
using Food_App.View;

namespace Food_App.ViewModel;

public partial class MainViewModel
{
    [RelayCommand]
    public async Task GoToHomeAsync()
    {
        await Shell.Current.GoToAsync(nameof(HomePage));
    }
}
