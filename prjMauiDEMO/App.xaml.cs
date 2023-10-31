using prjMAUIDEMO.Models;
using prjMAUIDEMO.Views;

namespace prjMAUIDEMO
{
    public partial class App : Application
    {
        public string userName {  get; set; }

        public List<CCustomer> allCustomers { get; set; }

        public int selectedCustomerIndex { get; set; }

        public string keyword {  get; set; }

        public List<CTodo> allTodos { get; set; }

        public int selectedTodosIndex { get; set; }

        public App()
        {
            InitializeComponent();
            this.selectedCustomerIndex = -1;
            this.selectedTodosIndex = -1;
            MainPage = new NavigationPage(new PgHttp());
        }
    }
}