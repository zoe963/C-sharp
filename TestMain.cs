using System;

public class TestMain
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(37, 43, 2.5);
       
        Console.WriteLine("该圆的"+circle.ToString());
        circle.X = 20;
        circle.Y = 20;

        Console.WriteLine("该圆的" + circle.ToString());
        Console.WriteLine("-------------------------------------------------");
        
        Cylinder cylinder = new Cylinder(32, 34, 4.5, 8);
        Console.WriteLine(cylinder.ToString());
        Console.WriteLine("该圆柱体的底面积是："+ cylinder.Area());
        Console.WriteLine("该圆柱体的体积是："+ cylinder.Volume());
        Console.WriteLine("-------------------------------------------------");

        Point p1 = new Point(3, 5);
        Point p2 = new Point(7, 5);
        Point p3 = new Point(5, 0);
        Triangle triangle = new Triangle(p1, p2, p3);
        Console.WriteLine(triangle.ToString());
        Console.WriteLine("该三角形的周长是："+ triangle.Perimeter());
        Console.WriteLine("该三角形的面积是："+ triangle.Area());
        Console.WriteLine("-------------------------------------------------");
        
        Point p4 = new Point(1, 0);
        Quadrilateral quadrilateral = new Quadrilateral(p4, p1, p2, p3);
        Console.WriteLine("该四边形的" + quadrilateral.ToString());
        Console.WriteLine("该四边形的周长是："+ quadrilateral.Perimeter());
        Console.WriteLine("该四边形的面积是："+ quadrilateral.Area());
        Console.WriteLine("-------------------------------------------------");

        Point p5 = new Point(9, 0);
        Trapaezoid trapaezoid = new Trapaezoid(p4,p1,p2,p5);
        Console.WriteLine("该梯形的" + trapaezoid.ToString());
        Console.WriteLine("该梯形的周长是：" + trapaezoid.Perimeter());
        Console.WriteLine("该梯形的高是：" + trapaezoid.GetHeight());
        Console.WriteLine("该梯形的面积是："+ trapaezoid.Area());
        Console.WriteLine("-------------------------------------------------");

        Parallelogram parallelogram = new Parallelogram(p3, p1, p2, p5);
        Console.WriteLine("该平行四边形的" + parallelogram.ToString());
        Console.WriteLine("该平行四边形的周长是："+ parallelogram.Perimeter());
        Console.WriteLine("该平行四边形的高是：" + parallelogram.GetHeight());
        Console.WriteLine("该平行四边形的面积是："+ parallelogram.Area());
        Console.WriteLine("-------------------------------------------------");

        Point p6 = new Point(5, 10);
        Rhombus rhombus = new Rhombus(p1, p6, p2, p3);
        Console.WriteLine("该菱形的" + rhombus.ToString());
        Console.WriteLine("该菱形的周长是：" + rhombus.Perimeter());
        Console.WriteLine("该菱形的面积是：" + rhombus.Area());
        Console.WriteLine("-------------------------------------------------");

        Point p7 = new Point(3, 10);
        Point p8 = new Point(7, 10);
        Quadrate quadrate = new Quadrate(p1, p7, p8, p2);
        Console.WriteLine("该正方形的" + quadrate.ToString());
        Console.WriteLine("该正方形的周长是：" + quadrate.Perimeter());
        Console.WriteLine("该正方形的面积是：" + quadrate.Area());
        Console.WriteLine("-------------------------------------------------");

        Point p9 = new Point(3, 0);
        Point p10 = new Point(7, 0);
        Rectangle rectangle = new Rectangle(p9, p7, p8, p10);
        Console.WriteLine("该长方形的" + rectangle.ToString());
        Console.WriteLine("该长方形的周长是：" + rectangle.Perimeter());
        Console.WriteLine("该长方形的面积是：" + rectangle.Area());
        Console.WriteLine("-------------------------------------------------");

        Console.ReadLine();
    }
}