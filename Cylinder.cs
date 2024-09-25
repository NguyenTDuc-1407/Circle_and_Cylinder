class Cylinder : Circle
{
    double height;
    public double getHeight()
    {
        return height;
    }

    public void setHeight(double height)
    {
        this.height = height;
    }
    public Cylinder()
    {

    }
    public Cylinder(double radius, double height) : base(radius){
        this.height = height;
    }
        public override string ToString()
    {
        return "A Cylinder with height="
                + getHeight()
                + ", which is a subclass of "
                + base.ToString();
    }
}