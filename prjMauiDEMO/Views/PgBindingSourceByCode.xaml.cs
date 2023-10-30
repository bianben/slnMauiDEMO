namespace prjMAUIDEMO.Views;

public partial class PgBindingSourceByCode : ContentPage
{
	public PgBindingSourceByCode()
	{
		InitializeComponent();
		lblBinding.BindingContext = slider;
		lblBinding.SetBinding(Label.FontSizeProperty, "Value");
	}
}