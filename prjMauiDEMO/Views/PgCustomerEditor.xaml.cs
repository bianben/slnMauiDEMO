using prjMAUIDEMO.ViewModels;

namespace prjMAUIDEMO.Views;

public partial class PgCustomerEditor : ContentPage
{
    CCustomerViewModel _vModel = null;

    public PgCustomerEditor()
	{
		InitializeComponent();
        _vModel = this.BindingContext as CCustomerViewModel;
	}


    private void btnFirst_Clicked(object sender, EventArgs e)
    {
        _vModel.moveFirst();
    }

    private void showCustomerInfo()
    {
        this.txtId.Text = _vModel.current.id.ToString();
        this.txtName.Text = _vModel.current.name;
        this.txtEmail.Text = _vModel.current.email;
        this.txtAddress.Text = _vModel.current.address;
        this.txtPhone.Text = _vModel.current.phone;
    }

    private void btnPrevious_Clicked(object sender, EventArgs e)
    {
        _vModel.movePrevious();
    }

    private void btnNext_Clicked(object sender, EventArgs e)
    {
        _vModel.moveNext();
    }

    private void btnLast_Clicked(object sender, EventArgs e)
    {
        _vModel.moveLast();
    }

    private void btnQuery_Clicked(object sender, EventArgs e)
    {
        clearCache();
        Navigation.PushAsync(new PgCustomerKeyword());
    }

    private void clearCache()
    {
        App app = Application.Current as App;
        app.keyword = "";
        app.selectedCustomerIndex = -1;
    }

    private void btnList_Clicked(object sender, EventArgs e)
    {
        App app = Application.Current as App;
        app.allCustomers = _vModel.all;
        clearCache();
        Navigation.PushAsync(new PgCustomerList());
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        App app = Application.Current as App;
        if (app != null && !string.IsNullOrEmpty(app.keyword))
        {
            _vModel.queryByKeyword(app.keyword);
        }
        if (app != null && app.selectedCustomerIndex >= 0)
            _vModel.moveTo(app.selectedCustomerIndex);
    }
}
