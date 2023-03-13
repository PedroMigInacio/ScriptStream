namespace ScriptStream;

public partial class MainPage : ContentPage
{
    int count = 0;

    String html = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n\t<title>Psychedelic Fractal</title>\r\n\t<style>\r\n\t\tcanvas {\r\n\t\t\tborder: 1px solid #000;\r\n\t\t}\r\n\t</style>\r\n</head>\r\n<body>\r\n\t<h1>Psychedelic Fractal</h1>\r\n\t<canvas id=\"canvas\" width=\"800\" height=\"600\"></canvas>\r\n\t<button onclick=\"generateFractal()\">Generate Fractal</button>\r\n\r\n\t<script>\r\n\t\tfunction generateFractal() {\r\n\t\t\tvar canvas = document.getElementById(\"canvas\");\r\n\t\t\tvar ctx = canvas.getContext(\"2d\");\r\n\t\t\tvar iterations = 50000;\r\n\t\t\tvar scale = 0.005;\r\n\r\n\t\t\tctx.clearRect(0, 0, canvas.width, canvas.height);\r\n\r\n\t\t\tfor (var i = 0; i < iterations; i++) {\r\n\t\t\t\tvar x = Math.random() * canvas.width;\r\n\t\t\t\tvar y = Math.random() * canvas.height;\r\n\r\n\t\t\t\tfor (var j = 0; j < 50; j++) {\r\n\t\t\t\t\tvar r = Math.random();\r\n\t\t\t\t\tvar angle = Math.random() * Math.PI * 2;\r\n\r\n\t\t\t\t\tif (r < 0.8) {\r\n\t\t\t\t\t\tvar size = Math.random() * 10;\r\n\t\t\t\t\t\tvar red = Math.floor(Math.random() * 256);\r\n\t\t\t\t\t\tvar green = Math.floor(Math.random() * 256);\r\n\t\t\t\t\t\tvar blue = Math.floor(Math.random() * 256);\r\n\r\n\t\t\t\t\t\tctx.fillStyle = 'rgb(' + red + ',' + green + ',' + blue + ')';\r\n\t\t\t\t\t\tctx.fillRect(x, y, size, size);\r\n\r\n\t\t\t\t\t\tx += Math.sin(angle) * size * scale;\r\n\t\t\t\t\t\ty += Math.cos(angle) * size * scale;\r\n\t\t\t\t\t} else if (r < 0.95) {\r\n\t\t\t\t\t\tx = x / 2 + canvas.width / 4;\r\n\t\t\t\t\t\ty = y / 2 + canvas.height / 2;\r\n\t\t\t\t\t} else {\r\n\t\t\t\t\t\tx = x / 2 + canvas.width / 4 * 3;\r\n\t\t\t\t\t\ty = y / 2 + canvas.height / 2;\r\n\t\t\t\t\t}\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t}\r\n\t</script>\r\n</body>\r\n</html>";



    public MainPage()
    {
        InitializeComponent();

        //var source = new HtmlWebViewSource
        //{
        //    Html = html
        //};
        //shotlessnospupups.Source = source;

        for (int j = 0; j < 3; j++)
        {
            var colDefinition = new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            };
            gridSystem.ColumnDefinitions.Add(colDefinition);
        }

            for (int i = 0; i < 50; i++)
        {
            var rowDefinition = new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Star)
            };
            gridSystem.RowDefinitions.Add(rowDefinition);
            //
            for (int j = 0; j < 3; j++)
            {
                Random rnd = new Random();
                Color randomColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                var newColoredBox = new BoxView
                {
                    Color = randomColor
                };

                var newLabel = new Image
                {
                    //Text = $"({i}, {j})",
                    Source= $"https://source.unsplash.com/random/200x200?sig={j}",
                    Margin = new Thickness(20),
                    //VerticalOptions = LayoutOptions.Center,
                   // HorizontalOptions = LayoutOptions.Center,

                };
                //gridSystem.Add(newColoredBox, j, i);
                gridSystem.Add(newLabel, j, i);
            }
        }


    }

}

