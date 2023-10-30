using prjMAUIDEMO.Models;

namespace prjMAUIDEMO.Views;

public partial class PgCustomerEditor : ContentPage
{
    
    public PgCustomerEditor()
	{
		InitializeComponent();
        _manager.LoadData();
	}

    CCustomerManager _manager = new CCustomerManager();

    private void btnFirst_Clicked(object sender, EventArgs e)
    {
        _manager.moveFirst();
        showCustomerInfo();
    }

    private void showCustomerInfo()
    {
        this.txtId.Text = _manager.current.id.ToString();
        this.txtName.Text = _manager.current.name;
        this.txtEmail.Text = _manager.current.email;
        this.txtAddress.Text = _manager.current.address;
        this.txtPhone.Text = _manager.current.phone;
    }

    private void btnPrevious_Clicked(object sender, EventArgs e)
    {
        _manager.movePrevious();
        showCustomerInfo();
    }

    private void btnNext_Clicked(object sender, EventArgs e)
    {
        _manager.moveNext();
        showCustomerInfo();
    }

    private void btnLast_Clicked(object sender, EventArgs e)
    {
        _manager.moveLast();
        showCustomerInfo();
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
        app.allCustomers = _manager.all;
        clearCache();
        Navigation.PushAsync(new PgCustomerList());
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        App app = Application.Current as App;
        if (app != null && !string.IsNullOrEmpty(app.keyword))
        {
            if (_manager.queryByKeyword(app.keyword) != null)
                showCustomerInfo();
        }
        if (app != null && app.selectedCustomerIndex >= 0)
        {
            _manager.moveTo(app.selectedCustomerIndex);
            showCustomerInfo();
        }
    }
}