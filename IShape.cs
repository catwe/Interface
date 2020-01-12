using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口
{
    interface IShape
    {
        double Area { get; }
        double X { get; set; }
        double Y { get; set; }
        string Color { get; set; }
        void Draw();
    }
}