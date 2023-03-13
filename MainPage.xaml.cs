namespace ScriptStream;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Random rnd = new Random();
                Color randomColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                var newColoredBox = new BoxView
                {
                    Color = randomColor
                };

                var newLabel = new Label
                {
                    Text = $"({i}, {j})",
                    Margin = new Thickness(5),
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
 
                };
                gridSystem.Add(newColoredBox, j, i);
                gridSystem.Add(newLabel, j, i);
            }
        }


    }

}

