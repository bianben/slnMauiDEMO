namespace prjMAUIDEMO.Views;

public partial class PgNoteList : ContentPage
{
	public PgNoteList()
	{
		InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        App app = Application.Current as App;

        if (app != null)
        {
            lvTodo.ItemsSource = app.allTodos;
        }
    }

    private void lvTodo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        App app = Application.Current as App;
        if (app != null)
            app.selectedTodosIndex = e.SelectedItemIndex;
        Navigation.PopAsync();
    }
}