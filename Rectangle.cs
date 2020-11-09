using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle:Parallelogram//长方形
{
    public Rectangle() { }

    public Rectangle(Point point1, Point point2, Point point3, Point point4) : base(point1, point2, point3, point4)
    {
        base.P1 = point1;
        base.P2 = point2;
        this.P3 = point3;
        this.P4 = point4;
        this.l1 = new Line(point1, point2);
        this.l2 = new Line(point2, point3);
        this.l3 = new Line(point3, point4);
        this.l4 = new Line(point4, point1);
    }

    public Rectangle(Line line1, Line line2, Line line3, Line line4) : base(line1, line2, line3, line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
        this.P1 = l1.P1;
        this.P2 = l1.P2;
        this.P3 = l2.P2;
        this.P4 = l3.P2;
    }

    //计算长方形的面积
    public override double Area()
    {
        return l1.Length() * l2.Length();
    }

    ~Rectangle() { }
}