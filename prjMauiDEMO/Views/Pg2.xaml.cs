namespace prjMAUIDEMO.Views;

public partial class Pg2 : ContentPage
{
	public Pg2()
	{
		InitializeComponent();
        App x = Application.Current as App;
        lblmember.Text = "Hi, " + x.userName;
    }

    private void btnBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}