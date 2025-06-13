using Astronomy.Pages;

namespace Astronomy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        // Add a route for the details page
        Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyPage));
    }
}
