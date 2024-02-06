using Food_App.View;
using Food_App.ViewModel;

namespace Food_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

            Routing.RegisterRoute(nameof(DetailPage),typeof(DetailPage));

            
        }
    }
}
