using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cylinder : Circle//圆柱体
{
    //圆柱体的高度
    private double height;

    public double Height
    {
        set { height = value; }
        get { return height; }
    }

    //构造函数，Cylinder类的初始化实例
    public Cylinder(double h) : base()
    {
        this.height = h;
    }

    //构造函数2
    public Cylinder(double x, double y, double r, double height) : base(x, y, r)
    {
        base.X = x;
        base.Y = y;
        base.R = r;
        this.height = height;
    }

    //构造函数3
    public Cylinder(Point p, double r, double height) : base(p, r)
    {
        base.X = p.X;
        base.Y = p.Y;
        base.R = r;
        this.height = height;
    }

    //计算圆柱体的表面积
    public override double Area()
    {
        return CircumFerence() * height + 2 * base.Area();
    }

    //计算圆柱体的体积
    public virtual double Volume()
    {
        return base.Area() * height;
    }

    //重写ToStirng()方法
    public override string ToString()
    {
        return "底面" + base.ToString() + "，高度 = " + height;
    }

    ~Cylinder() { }
}
