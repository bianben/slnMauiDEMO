namespace prjMAUIDEMO.Views;

public partial class PgCustomerList : ContentPage
{
	public PgCustomerList()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        App app=Application.Current as App;
        if(app != null)
        {
            lvCustomer.ItemsSource = app.allCustomers;
        }
    }

    private void lvCustomer_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        App app = Application.Current as App;
        if (app != null)
            app.selectedCustomerIndex = e.SelectedItemIndex;
        Navigation.PopAsync();
    }
}