using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口
{
    class Rectangle : IShape
    {//为矩形的长和宽赋值
        public Rectangle(double length, double width)//设置了带参数的构造方法为实现类中新增加的属性赋值，
                                                     //  这样在创建实现类的实例时即可为相应的属性赋值。
        {
            this.Length = length;
            this.Width = width;
        }
        public double Length { get; set; }//定义长方形的长度
        public double Width { get; set; }//定义长方形的宽度
        public double Area
        {
            get
            {
                return Length * Width;//计算长方形面积
            }
        }
        public string Color { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public void Draw()
        {
            Console.WriteLine("绘制图形如下：");
            Console.WriteLine("在坐标 {0},{1} 的位置绘制面积为 {2} 颜色为 {3} 的矩形", X, Y, Area, Color);
        }
    }
}