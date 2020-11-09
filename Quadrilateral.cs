using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

public class Quadrilateral: Shape//四边形类
{
    private Point p1;
    private Point p2;
    private Point p3;
    private Point p4;
    protected Line l1;
    protected Line l2;
    protected Line l3;
    protected Line l4;

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

    public Point P4
    {
        get { return this.p4; }
        set { this.p4 = value; }
    }

    public Quadrilateral() { }

    //用点初始化Quadrilateral类的实例，默认按照顺时针给的点
    public Quadrilateral(Point point1, Point point2, Point point3, Point point4)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.p4 = point4;
        this.l1 = new Line(point1, point2);
        this.l2 = new Line(point2, point3);
        this.l3 = new Line(point3, point4);
        this.l4 = new Line(point4, point1);
    }

    //用线初始化Quadrilateral类的实例，默认按照顺时针给的线
    public Quadrilateral(Line line1, Line line2, Line line3, Line line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
        this.p1 = l1.P1;
        this.p2 = l1.P2;
        this.p3 = l2.P2;
        this.p4 = l3.P2;
    }

    //返回四边形的周长
    public override double Perimeter()
    {
        return l1.Length() + l2.Length() + l3.Length() + l4.Length();
    }

    //返回四边形的面积，默认为凸四边形
    public override double Area()
    {
        Triangle t1 = new Triangle(P1, P2, P3);
        Triangle t2 = new Triangle(P3, P4, P1);
        return t1.Area()+t2.Area();
    }

    //tostring()
    public override string ToString()
    {
        return "四点坐标是" +
            p1.ToString() + "，" +
            p2.ToString() + "，" +
            p3.ToString() + "，" +
            p4.ToString();
    }

    ~Quadrilateral() { }
}