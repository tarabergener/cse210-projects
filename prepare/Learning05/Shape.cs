using System;
using System.Drawing;

public class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color; 
    }

    public double GetArea()
    {
        return -1;
    }
}