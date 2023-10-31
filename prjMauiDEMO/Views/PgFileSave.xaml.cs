using System.Text;

namespace prjMAUIDEMO.Views;

public partial class PgFileSave : ContentPage
{
	public PgFileSave()
	{
		InitializeComponent();
	}
    private void btnSave_Clicked(object sender, EventArgs e)
    {
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine(folder, "hello.txt");
        File.WriteAllText(path, txtSet.Text, Encoding.UTF8);
        txtSet.Text = "";
    }

    private void btnRead_Clicked(object sender, EventArgs e)
    {
        string folder=Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine(folder, "hello.txt");
        lblGet.Text=File.ReadAllText(path,Encoding.UTF8);
    }
}