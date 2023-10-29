using Android.Graphics;

namespace prjMAUIDEMO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            randomColor();


        }

        private void randomColor()
        {
            List<string> stringlist = new List<string>
            {
                "紅",
                "黃",
                "藍",
                "綠"
            };

            List<Microsoft.Maui.Graphics.Color> colors = new List<Microsoft.Maui.Graphics.Color>
            {
               Colors.Red,
               Colors.Yellow,
               Colors.Blue,
               Colors.Green
            };

            List<Microsoft.Maui.Graphics.Color> temp= new List<Microsoft.Maui.Graphics.Color>();

            Random r = new Random();
            int index;

            List<int> stringIndex = new List<int>();
            List<int> colorIndex = new List<int>();

            for (int i = 0; i <= 4; i++)
            {
                int a = r.Next(0, 4 - i);
                int b = r.Next(0, 4 - i);
                
                stringIndex.Add(a);
                colorIndex.Add(b);
                while (stringIndex.Any())
                {
                    stringIndex.Add(a);
                    colorIndex.Add(b);
                }
            }
            
            index = r.Next(0, 4);
            label1.Text = stringlist[index];
            stringlist.RemoveAt(index);

            index = r.Next(0, 3);
            label2.Text = stringlist[index];
            stringlist.RemoveAt(index);

            index = r.Next(0, 2);
            label3.Text = stringlist[index];
            stringlist.RemoveAt(index);

            index = r.Next(0, 1);
            label4.Text = stringlist[index];

            

            //index = r.Next(0, 4);
            //label1.BackgroundColor = colors[index];
            //colors.RemoveAt(index);

            //index = r.Next(0, 3);
            //label2.BackgroundColor = colors[index];
            //colors.RemoveAt(index);

            //index = r.Next(0, 2);
            //label3.BackgroundColor = colors[index];
            //colors.RemoveAt(index);

            //index = r.Next(0, 1);
            //label4.BackgroundColor = colors[index];
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            randomColor();
        }
    }
}