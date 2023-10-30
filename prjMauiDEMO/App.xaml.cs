using prjMAUIDEMO.Views;

namespace prjMAUIDEMO
{
    public partial class App : Application
    {
        public string userName {  get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PgCustomerEditor());
        }
    }
}