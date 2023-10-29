using prjMAUIDEMO.Models;

namespace prjMAUIDEMO.Views;

public partial class PgLotto : ContentPage
{
    public PgLotto()
    {
        InitializeComponent();

        lblLotto.FontSize = 35;

        lblLotto.Text=(new CLotto()).pull();
    }

    

    public void btnLotto_Clicked(object sender, EventArgs e)
    {
        lblLotto.Text = (new CLotto()).pull();
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {

    }
}