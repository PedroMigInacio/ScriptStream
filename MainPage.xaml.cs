namespace ScriptStream;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        for (int i = 0; i < 3; i++)
        {
            var rowDefinition = new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Star)
            };
            gridSystem.RowDefinitions.Add(rowDefinition);

            var columnDefinition = new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            };
            gridSystem.ColumnDefinitions.Add(columnDefinition);

            for (int j = 0; j < 99; j++)
            {
                var newElement = new Label
                {
                    Text = $"({i}, {j})",
                    Margin = new Thickness(5),
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                };

                gridSystem.Add(newElement, i, j);
            }
        }


    }

}

