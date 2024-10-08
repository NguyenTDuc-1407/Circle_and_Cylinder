public class Circle
{
    private double radius = 1.0;
    private string color = "green";
    private bool filled = true;

    public Circle()
    {
    }

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double getRadius()
    {
        return radius;
    }

    public void setRadius(double radius, string color, bool filled)
    {
        this.radius = radius;
        this.color = color;
        this.filled = filled;
    }

    public double getArea()
    {
        return radius * radius * Math.PI;
    }

    public double getPerimeter()
    {
        return 2 * radius * Math.PI;
    }

    public string getColor()
    {
        return color;
    }

    public void setColor(string color)
    {
        this.color = color;
    }

    public bool isFilled()
    {
        return filled;
    }

    public void setFilled(bool filled)
    {
        this.filled = filled;
    }

    public override string ToString()
    {
        return "A Circle with radius="
                + getRadius()
                + ", which is a subclass of "
                + base.ToString();
    }
}