using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

public sealed class Triangle:Shape //Triangle类，包含三个Point，采用sealed,表示是继承树的根类
{
    //sealed不能被继承，只能实例化，继承树的叶子
    private Point p1;
    private Point p2;
    private Point p3;
    Line l1;//没写访问控制符，相当于默认protected，只能被其派生类使用
    Line l2;
    Line l3;

    public Point P1
    {
        get { return this.p1; }
        set { this.p1 = value; }
    }

    public Point P2
    {
        get { return this.p2; }
        set { this.p2 = value; }
    }

    public Point P3
    {
        get { return this.p3; }
        set { this.p3 = value; }
    }

    //用点初始化Triangle类的实例
    public Triangle(Point point1, Point point2, Point point3)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.l1 = new Line(point1, point2);
        this.l2 = new Line(point2, point3);
        this.l3 = new Line(point3, point1);
    }

    //用线初始化Triangle类的实例
    public Triangle(Line line1, Line line2, Line line3)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.p1 = l1.P1;
        this.p2 = l1.P2;
        this.p3 = l2.P2;
    }

    //返回三角形的周长
    public override double Perimeter()
    {
       return l1.Length() + l2.Length() + l3.Length();
    }

    //返回三角形的面积
    public override double Area() 
    {
        double a = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        double b = Math.Sqrt(Math.Pow(p3.X - p2.X, 2) + Math.Pow(p3.Y - p2.Y, 2));
        double c = Math.Sqrt(Math.Pow(p1.X - p3.X, 2) + Math.Pow(p1.Y - p3.Y, 2));
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    
    //判断是否为等腰三角形
    public bool IsEquicrural()
    {
        if(l1.Length()==l2.Length()||l1.Length()==l3.Length()||l2.Length()==l3.Length())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //判断是否为等边三角形
    public bool IsEquilateral()
    {
        if (l1.Length() == l2.Length() && l2.Length() == l3.Length()) { return true; }
        else return false;
    }

    //重写方法
    public override string ToString()
    {
        return "三角形三点坐标是：" + p1.ToString() + "，" + p2.ToString() + "，" + p3.ToString();
    }
}