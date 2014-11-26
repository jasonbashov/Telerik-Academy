public class Size
{
    private double width;
    private double height;

    public Size(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Width{ get; set; };
    public double Height{ get; set; };
}
public static Size GetRotatedSize(Size oldSize, double angleOfTheFigureThatWillBeRotaed)
{
    double cosinusOfTheAngle = Math.Cos(angleOfTheFigureThatWillBeRotaed);
    double absoluteCosinus = Math.Abs(cosinusOfTheAngle);
    double sinusOfTheAngle = Math.Sin(angleOfTheFigureThatWillBeRotaed);
    double absoluteSinus = Math.Abs(sinusOfTheAngle);
    double newWidth =  absoluteCosinus * oldSize.Width +  absoluteSinus * oldSize.Height;
    double newHeight = absoluteSinus * oldSize.Width + absoluteCosinus * oldSize.Height;
    Size newSize = new Size(newWidth, newHeight);

   return newSize;
}

