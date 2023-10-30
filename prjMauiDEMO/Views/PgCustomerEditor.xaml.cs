using prjMAUIDEMO.Models;

namespace prjMAUIDEMO.Views;

public partial class PgCustomerEditor : ContentPage
{
	public PgCustomerEditor()
	{
		InitializeComponent();
        LoadData();
	}
    List<CCustomer> _list = new List<CCustomer>();

    private void LoadData()
    {
        _list.Add(new CCustomer() { id = 1, address = "Taipei", email = "john@gmail.com", name = "John", phone = "0955312654" });
        _list.Add(new CCustomer() { id = 2, address = "Taoyuan", email = "peggy@gmail.com", name = "Peggy", phone = "0934212336" });
        _list.Add(new CCustomer() { id = 5, address = "Taipei", email = "wman@gmail.com", name = "Wman", phone = "0980556221" });
    }

    private void btnFirst_Clicked(object sender, EventArgs e)
    {

    }

    private void btnPrevious_Clicked(object sender, EventArgs e)
    {

    }

    private void btnNext_Clicked(object sender, EventArgs e)
    {

    }

    private void btnLast_Clicked(object sender, EventArgs e)
    {

    }

    private void btnQuery_Clicked(object sender, EventArgs e)
    {

    }

    private void btnList_Clicked(object sender, EventArgs e)
    {

    }
}