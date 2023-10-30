namespace prjMAUIDEMO.Views;

public partial class PgCustomerKeyword : ContentPage
{
	public PgCustomerKeyword()
	{
		InitializeComponent();
	}

    private void btnQuery_Clicked(object sender, EventArgs e)
    {
		if (string.IsNullOrEmpty(txtkeyword.Text))
			return;
		App app=Application.Current as App;
		if (app != null)
			app.keyword = txtkeyword.Text;
		Navigation.PopAsync();
    }
}