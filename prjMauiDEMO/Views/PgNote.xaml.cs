using System.Diagnostics.Metrics;
using prjMAUIDEMO.Models;

namespace prjMAUIDEMO.Views;

public partial class PgNote : ContentPage
{
    private CTodo _current = null; 
	public PgNote()
	{
		InitializeComponent();
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        int count = Convert.ToInt32(Preferences.Default.Get("COUNT", 0));
        count++;
        Preferences.Default.Set("COUNT", count);
        Preferences.Default.Set("T"+count.ToString(),txtTitle.Text);
        Preferences.Default.Set("D"+count.ToString(),txtDate.Text);

        txtTitle.Text = "";
        txtDate.Text = "";
    }

    private void btnRead_Clicked(object sender, EventArgs e)
    {
        if (Preferences.Default.Get("COUNT", 0) == 0)
            return;

        List<CTodo> datas= new List<CTodo>();
        for (int i = 1; i <= Convert.ToInt32(Preferences.Default.Get("COUNT", 0)); i++)
        {
            if (Preferences.Default.ContainsKey("T" + i))
            {
                CTodo todo = new CTodo();
                todo.id = i;
                todo.title = Preferences.Default.Get("T" + i, "");
                todo.date = Preferences.Default.Get("D" + i, "");

                datas.Add(todo);
                //(Application.Current as App).allTodos.Add(todo);
                //System.NullReferenceException：“物件引用未設置為對象的實例。
                //solution 因為沒有new
            }
        }
        App app = Application.Current as App;
            app.allTodos = datas;
        

        Navigation.PushAsync(new PgNoteList());
    }

    private void btnCo_Clicked(object sender, EventArgs e)
    {

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        App app = Application.Current as App;
        if (app != null && app.selectedTodosIndex >= 0)
        {
            _current = app.allTodos[app.selectedTodosIndex];
            txtDate.Text = _current.date;
            txtTitle.Text = _current.title;
        }


    }
}