using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;


public class Trapaezoid : Quadrilateral//梯形类
{
    public Trapaezoid() { }

    public Trapaezoid(Point point1, Point point2, Point point3, Point point4) :base(point1,point2,point3,point4)
    {
        this.P1 = point1;
        this.P2 = point2;
        this.P3 = point3;
        this.P4 = point4;
        this.l1 = new Line(point1, point2);
        this.l2 = new Line(point2, point3);
        this.l3 = new Line(point3, point4);
        this.l4 = new Line(point4, point1);
    }

    public Trapaezoid(Line line1, Line line2, Line line3, Line line4) : base(line1,line2,line3,line4)
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

    //计算梯形的高
    public double GetHeight()
    {
        double a, b, c;
        if (l1.Slope()==l3.Slope())
        {
            a = l3.ACoefficient();
            b = l3.BCoefficient();
            c = l3.CCoefficient();
            return Math.Abs(a * P1.X + b * P1.Y + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        else if(l2.Slope()==l4.Slope())
        {
            a = l2.ACoefficient();
            b = l2.BCoefficient();
            c = l2.CCoefficient();
            return Math.Abs(a * P1.X + b * P1.Y + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        else
        {
            return 0.0;
        }
    }

    //计算梯形面积
    public override double Area()
    {
        if (l1.Slope() == l3.Slope())
        {
            return (l1.Length() + l3.Length()) * GetHeight() / 2;
        }
        else if (l2.Slope() == l4.Slope())
        {
            return (l2.Length() + l4.Length()) * GetHeight() / 2;
        }
        else { return 0.0; }
    }

    ~Trapaezoid() { }
}