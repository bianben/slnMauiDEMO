namespace prjMAUIDEMO.Views;

public partial class Pg1 : ContentPage
{
	public Pg1()
	{
		InitializeComponent();
    }

    private void btnGo_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Pg2());
    }

    private void btnSend_Clicked_1(object sender, EventArgs e)
    {
        App x = Application.Current as App;
        x.userName = "Marco";
        Navigation.PushAsync(new Pg2());
    }
}