using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口
{
    class Circle : IShape
    {
        //为圆的半径赋值
        public Circle(double radius)//设置了带参数的构造方法为实现类中新增加的属性赋值，
                                    //这样在创建实现类的实例时即可为相应的属性赋值。
        {
            this.Radius = radius;
        }
        public double Radius { get; set; }
        public double Area
        {
            get
            {
                return Radius * Radius * 3.14;
            }
        }
        public string Color { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public void Draw()
        {
            Console.WriteLine("绘制图形如下：");
            Console.WriteLine("在坐标为 {0},{1} 的位置绘制面积为 {2} 颜色为 {3} 的圆形", X, Y, Area, Color);
        }
    }
}