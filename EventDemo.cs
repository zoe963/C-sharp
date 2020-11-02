using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public delegate void EventHandler();
    public class TrafficLight
    {
        //交通灯类，发布器类，发布事件
        private int _Color;//1表示绿灯，0表示红灯，2表示黄灯
        public event EventHandler ChangeColor;
        //构造器，默认
        public void OnChange()
        {
            //事件触发方法
            ChangeColor?.Invoke();//C#6语法，?.空值传播运算符
        }
        public void ClearChange()
        {
            //清空事件方法链
            ChangeColor = null;
        }
        public int Color
        {
            //本来只是可读的，应该可通过时间延迟进行变灯
            get { return _Color; }
            set { _Color = value; }
        }
    }
    public class Car
    {
        //订阅器类
        static void Main(string[] args)
        {
            TrafficLight t = new TrafficLight();//发布器对象
            Car c = new Car();//订阅器对象
            while(true)
            {
                Console.WriteLine("请输入一个数字，代表交通灯的颜色（0=红灯 1=绿灯 2=黄灯 -1=退出程序）：");
                t.Color = Convert.ToInt32(Console.ReadLine());//获取数字（灯的颜色）
                switch(t.Color)
                {
                    case 0:
                        t.ClearChange();//清空方法链
                        t.ChangeColor += T_ChangeColor_Stop;
                        t.OnChange();
                        break;
                    case 1:
                        t.ClearChange();
                        t.ChangeColor += T_ChangeColor_Go;
                        t.OnChange();
                        break;
                    case 2:
                        t.ClearChange();
                        t.ChangeColor += T_ChangeColor_Wait;
                        t.OnChange();
                        break;
                    case -1:
                        return;//退出程序
                    default:
                        Console.WriteLine("输入错误，请重新输入！");
                        break;
                }
            }
        }
        //事件处理函数，只能内部调用
        private static void T_ChangeColor_Wait()
        {
            Console.WriteLine("黄灯等待");
        }

        private static void T_ChangeColor_Go()
        {
            Console.WriteLine("绿灯行");
        }

        private static void T_ChangeColor_Stop()
        {
            Console.WriteLine("红灯停");
        }
    }
}
