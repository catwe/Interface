using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{

    /*
     接口的定义:
     接口中的成员不允许使用 public、private、protected、internal 访问修饰符。
     接口中的成员不允许使用 static、virtual、abstract、sealed 修饰符。
     在接口中不能定义字段。
     在接口中定义的方法不能包含方法体。
      */
    interface ICompute
    {
        int Id { get; set; }
        string Name { get; set; }
        void Total();
        void Avg();
    }



    class Program : ICompute
    {
        public int Id { get; set; }//隐式的实现接口中的属性
        public string Name { get; set; }//隐式的实现接口中的属性
        public double English { get; set; }//添加的科目
        public double Programming { get; set; }
        public double Database { get; set; }
        public void Total()//隐式的实现接口中的方法
        {
            double sum = English + Programming + Database;
            Console.WriteLine("总分为：" + sum);
        }
        public void Avg()
        {
            double avg = (English + Programming + Database) / 3;
            Console.WriteLine("平均分：" + avg);
        }


        static void Main(string[] args)
        {
            Program computerMajor = new Program();
            computerMajor.Id = 1;
            computerMajor.Name = "李明";
            computerMajor.English = 80;
            computerMajor.Programming = 90;
            computerMajor.Database = 85;
            Console.WriteLine("学号：" + computerMajor.Id);
            Console.WriteLine("姓名：" + computerMajor.Name);
            Console.WriteLine("成绩信息如下：");
            computerMajor.Total();
            computerMajor.Avg();


            /*
             测试画图形的接口
             */
            IShape shape1 = new Rectangle(10, 20);
            shape1.X = 100;
            shape1.Y = 200;
            shape1.Color = "红色";
            shape1.Draw();
            IShape shape2 = new Circle(10);
            shape2.X = 300;
            shape2.Y = 500;
            shape2.Color = "蓝色";
            shape2.Draw();

            Console.ReadLine();
        }
    }
}

