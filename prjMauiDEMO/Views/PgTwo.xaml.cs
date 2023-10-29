namespace prjMAUIDEMO.Views;

public partial class PgTwo : ContentPage
{
	public PgTwo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		double a = double.Parse(etya.Text);
		double b = double.Parse(etyb.Text);
		double c = double.Parse(etyc.Text);

		double fff = (b * b) - (4 * a * c);
        double d = Math.Sqrt(fff);
		
		double f = (-b + d) / (2 * a);
		double ff = (-b - d) / (2 * a);

		this.result.Text = "X=" + f + "\r©Î" + ff;
    }
}