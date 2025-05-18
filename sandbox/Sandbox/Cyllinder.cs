class Cyllinder
{
    private Circle _circle;

    public void SetHeight(double height)
    {
        _height = height;
    }
    public void SetCircle(Circle circle)
    {
        _circle = circle;
    }

    public double GetVolume()
    {
        return Math.PI * _circle.GetRadius() * _circle.GetRadius() * height;
    }
}