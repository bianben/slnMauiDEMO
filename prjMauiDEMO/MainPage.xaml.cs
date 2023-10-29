using Android.Graphics;

namespace prjMAUIDEMO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            randomColorTest();
        }

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


        List<int> stringIndex = new List<int>();
        List<int> colorIndex = new List<int>();

        private void randomColorTest()
        {
            Random r = new Random();
            int index;

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

            stringlist = new List<string>
            {
                "紅",
                "黃",
                "藍",
                "綠"
            };

            index = r.Next(0, 4);
            label1.BackgroundColor = colors[index];
            colors.RemoveAt(index);

            index = r.Next(0, 3);
            label2.BackgroundColor = colors[index];
            colors.RemoveAt(index);

            index = r.Next(0, 2);
            label3.BackgroundColor = colors[index];
            colors.RemoveAt(index);

            index = r.Next(0, 1);
            label4.BackgroundColor = colors[index];

            colors = new List<Microsoft.Maui.Graphics.Color>
            {
               Colors.Red,
               Colors.Yellow,
               Colors.Blue,
               Colors.Green
            };
        }
        

        public int myStringIndex()
        {
            int s = stringIndex[0];
            stringIndex.RemoveAt(0);
            return s;
        }

        public int myColorIndex()
        {
            int s = colorIndex[0];
            colorIndex.RemoveAt(0);
            return s;
        }


        private void randomColor()
        {
            Random r = new Random();


            for (int i = 0; i <= 4; i++)
            {
                int a = r.Next(0, 4);
                int b = r.Next(0, 4);

                if (a != b)
                {
                    bool a重複 = stringIndex.Any(x => x == a);
                    bool b重複 = colorIndex.Any(x => x == b);

                    if (!a重複 && !b重複)
                    {
                        stringIndex.Add(a);
                        colorIndex.Add(b);
                        if (stringIndex.Count >= 4) { break; }
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }



            label1.Text = stringlist[myStringIndex()];
            label2.Text = stringlist[myStringIndex()];
            label3.Text = stringlist[myStringIndex()];
            label4.Text = stringlist[myStringIndex()];

            label1.BackgroundColor = colors[myColorIndex()];
            label2.BackgroundColor = colors[myColorIndex()];
            label3.BackgroundColor = colors[myColorIndex()];
            label4.BackgroundColor = colors[myColorIndex()];
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