using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_App.ViewModel;

public partial class ProfileViewModel
{

    [RelayCommand]
    async Task GoToBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
}

