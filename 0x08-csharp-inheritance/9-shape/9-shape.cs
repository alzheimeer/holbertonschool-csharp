using System;

///<summary>class Shape</summary>
class Shape
{
    ///<summary>Throws an NotImplementedException</summary>
    public virtual int Area()
    {
       throw new NotImplementedException("Area() is not implemented");
    }
}
///<summary>class Rectangle</summary>
class Rectangle : Shape
{
    private int width;
    private int height;    ///<summary> public property Width / get: retrieve width / set: set width or exception</summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary> public property Height / get: retrieve height / set: set height or exception</summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary> public override Area </summary>
    public override int Area()
    {
        return height*width;
    }
    /// <summary> public property ToString()</summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }


}
///<summary>class Square</summary>
class Square : Rectangle
{
    private int size;

    /// <summary> public property size</summary>
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Width = size;
            Height = size;
        }
    }

    /// <summary> public property ToString()</summary>
    public override string ToString()
    {
        return string.Format("[Square] {0} / {1}", size, size);
    }



}