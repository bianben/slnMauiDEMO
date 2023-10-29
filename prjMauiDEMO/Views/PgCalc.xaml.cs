namespace prjMAUIDEMO.Views;

public partial class PgCalc : ContentPage
{
	public PgCalc()
	{
		InitializeComponent();
	}

    double n1 = 0;
    string op = "";

    private void Btneql_Clicked(object sender, EventArgs e)
    {
        double n2 = Convert.ToDouble(Ans.Text);

        if (op == "+")
        {
            Ans.Text = (n1 + n2).ToString();
        }
        else if(op == "-")
        {
            Ans.Text = (n1 - n2).ToString();
        }
        else if (op == "X")
        {
            Ans.Text = (n1 * n2).ToString();
        }
        else if (op == "/")
        {
            Ans.Text = (n1 / n2).ToString();
        }
    }

    private void BtnAC_Clicked(object sender, EventArgs e)
    {
        n1 = 0;
        op = "";
        Ans.Text = "0";
    }

    private void BtnCommon_Clicked(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        double temp = Convert.ToDouble(Ans.Text);
        if (temp == 0)
            Ans.Text = btn.Text;
        else
            Ans.Text += btn.Text;
    }

    private void btnOperator_Clicked(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        n1 = Convert.ToDouble(Ans.Text);
        Ans.Text = "0";
        op = btn.Text;

        //if (op == "")
        //{
        //    Button btn = sender as Button;
        //    n1 = Convert.ToDouble(Ans.Text);
        //    Ans.Text = "0";
        //    op = btn.Text;
        //}
        //else
        //{
        //    double n2 = Convert.ToDouble(Ans.Text);

        //    if (op == "+")
        //    {
        //        Ans.Text = (n1 + n2).ToString();
        //    }
        //    else if (op == "-")
        //    {
        //        Ans.Text = (n1 - n2).ToString();
        //    }
        //    else if (op == "X")
        //    {
        //        Ans.Text = (n1 * n2).ToString();
        //    }
        //    else if (op == "/")
        //    {
        //        Ans.Text = (n1 / n2).ToString();
        //    }
        //}
    }

    private void Btn正負_Clicked(object sender, EventArgs e)
    {

    }

    private void Btn百分_Clicked(object sender, EventArgs e)
    {

    }

    private void Btn點_Clicked(object sender, EventArgs e)
    {

    }

   

   

}