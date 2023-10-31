namespace prjMAUIDEMO.Views;

public partial class PgPreference : ContentPage
{
	public PgPreference()
	{
		InitializeComponent();
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        Preferences.Default.Set("kk",txtSet.Text);
    }

    private void btnRead_Clicked(object sender, EventArgs e)
    {
        txtGet.Text=Preferences.Default.Get("kk", "---");
    }
}